#define VOZ_UWP_SAPI_11

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using SpeechLib;
using AIMLbot;
using System.Speech;
using System.Speech.Synthesis;
using System.Configuration;

using MyoSharp.Communication;
using MyoSharp.Device;
using MyoSharp.Exceptions;
using MyoSharp.Poses;
#if VOZ_UWP_SAPI_11
    using Windows.Media.SpeechRecognition;
    using Windows.ApplicationModel.Resources.Core;
    using System.Threading.Tasks;
    using Microsoft.Speech.Recognition;
#else
    using System.Speech.Recognition;
#endif
using System.Threading;

namespace AIMLGUI
{
    public partial class aimlForm : Form
    {
        MyoSharp.Communication.IChannel channel; //Canal Myo
        static float PRECISION_MINIMA = 0.7F;

        public static int roll = 0;
        public static int pitch = 0;
        public static int yaw = 0;

        static int sroll = 0;
        static int spitch = 0;
        static int syaw = 0;
        private static string sPosicionMyo;

        private Bot myBot;
        private User myUser;
        private Request lastRequest = null;
        private Result lastResult = null;
        static System.Speech.Synthesis.SpeechSynthesizer static_voz;
        static string static_frase = "";
        int ControlX, ControlY;
#if VOZ_UWP_SAPI_11
        private static SpeechRecognizer speechRecognizer;
        public SpeechRecognitionEngine recognizer;
        static public SpeechRecognitionEngine srecognizer;
        static bool Salida = false;
        static string texto = "";
        static bool ActivarCabeza = false;
        public static bool SeguirSonido = true;
#else
        public SpeechRecognitionEngine recognizer;
#endif
        static aimlForm saimlForm;
        static String[] comandos;
        public delegate int DelegadoEjecutarComando(String comando, float precision, int iServo, int iPos);
        public delegate void DelegadoprocessInputFromUser();
        public DelegadoEjecutarComando dEjecutarComando;
        public DelegadoprocessInputFromUser dprocessInputFromUser;
        public delegate void EjecutarMyo(String Comando, int roll, int pitch, int yaw);
        public static EjecutarMyo dEjecutarMyo;
        static bool tmr_rec_uwp_activo = true;
        static MODO MODO_ACTIVO = MODO.Comando;
        static bool ComandosSoloRecUWP = false;
        bool PresentacionPorVoz = false;
        static bool ComandoAutorizado = false;
        static bool RecVozUWPACtivado = false;
        static Stopwatch timeMeasure = new Stopwatch();
        const int SEGUNDOS_REC_COMANDO_DANI = 4;

        enum eModos
        { 
            Conversacion, Comando
        };
        enum MODO { Comando, Conversacion};
        public aimlForm()
        {
            InitializeComponent();
            saimlForm = this;
            this.toolStripMenuItemSpeech.Checked = true;
            this.richTextBoxInput.Focus();
            myBot = new Bot();
            myBot.loadSettings();
            myUser = new User("DefaultUser",this.myBot);
            myBot.WrittenToLog += new Bot.LogMessageDelegate(myBot_WrittenToLog);
            dprocessInputFromUser = processInputFromUser;
        }

        public void InicializarPosControl(int x, int y)
        {
            ControlX = x;
            ControlY = y;
            this.Top = x-this.Height ;
            this.Left = y;
        }
        void myBot_WrittenToLog()
        {
            this.richTextBoxOutput.Text += this.myBot.LastLogMessage+Environment.NewLine+Environment.NewLine;
            this.richTextBoxOutput.ScrollToCaret();
        }

#region Menu Item Events
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitQuery = MessageBox.Show("Are you sure?", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (exitQuery == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void saveBotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fi = new FileInfo(Application.ExecutablePath);
                saveFileDialogDump.InitialDirectory = fi.DirectoryName;
                saveFileDialogDump.AddExtension = true;
                saveFileDialogDump.DefaultExt = "dat";
                saveFileDialogDump.FileName = "Graphmaster.dat";
                DialogResult dr = saveFileDialogDump.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    if (this.myBot.Size > 0)
                    {
                        this.myBot.isAcceptingUserInput = false;
                        this.myBot.saveToBinaryFile(saveFileDialogDump.FileName);
                        this.myBot.isAcceptingUserInput = true;
                    }
                }
            }
            catch (Exception ex)
            {
                this.richTextBoxOutput.Text += ex.Message + Environment.NewLine;
            }
        }

        private void fromAIMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                folderBrowserDialogAIML.RootFolder = Environment.SpecialFolder.MyComputer;
                folderBrowserDialogAIML.SelectedPath = this.myBot.PathToAIML;
                DialogResult dr = folderBrowserDialogAIML.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    AIMLbot.Utils.AIMLLoader loader = new AIMLbot.Utils.AIMLLoader(this.myBot);
                    this.myBot.isAcceptingUserInput = false;
                    if (folderBrowserDialogAIML.SelectedPath.Length > 0)
                    {
                        loader.loadAIML(folderBrowserDialogAIML.SelectedPath);
                    }
                    else
                    {
                        loader.loadAIML(this.myBot.PathToAIML);
                    }
                    this.myBot.isAcceptingUserInput = true;
                }
            }
            catch (Exception ex)
            {
                this.richTextBoxOutput.Text += ex.Message + Environment.NewLine;
            }
        }

        private void fromDatFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fi = new FileInfo(Application.ExecutablePath);
                openFileDialogDump.InitialDirectory = fi.DirectoryName;
                openFileDialogDump.AddExtension = true;
                openFileDialogDump.DefaultExt = "dat";
                openFileDialogDump.FileName = "Graphmaster.dat";
                DialogResult dr = openFileDialogDump.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    this.myBot.isAcceptingUserInput = false;
                    this.myBot.loadFromBinaryFile(openFileDialogDump.FileName);
                    this.myBot.isAcceptingUserInput = true;
                }
            }
            catch (Exception ex)
            {
                this.richTextBoxOutput.Text += ex.Message + Environment.NewLine;
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();

            result.Append("Bot Settings:" + Environment.NewLine + Environment.NewLine);
            foreach (string setting in this.myBot.GlobalSettings.SettingNames)
            {
                result.Append(setting + ": " + this.myBot.GlobalSettings.grabSetting(setting)+Environment.NewLine);
            }

            this.showInformation(result);
        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();

            result.Append("User Information:" + Environment.NewLine + Environment.NewLine);

            result.Append("UserID: " + this.myUser.UserID + Environment.NewLine);
            result.Append("Topic: " + this.myUser.Topic + Environment.NewLine + Environment.NewLine);

            result.Append("User Predicate List:" + Environment.NewLine);
            foreach (string setting in this.myUser.Predicates.SettingNames)
            {
                result.Append(setting + ": " + this.myUser.Predicates.grabSetting(setting)+Environment.NewLine);
            }
            this.showInformation(result);
        }

        private void lastRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!object.Equals(null, this.lastRequest))
            {
                StringBuilder result = new StringBuilder();

                result.Append("Last Request:" + Environment.NewLine + Environment.NewLine);

                result.Append("Raw Input: " + this.lastRequest.rawInput.Replace(Environment.NewLine,"") + Environment.NewLine);
                result.Append("Started On: " + this.lastRequest.StartedOn + Environment.NewLine);
                result.Append("Has Timed Out: " + Convert.ToString(this.lastRequest.hasTimedOut) + Environment.NewLine + Environment.NewLine);
                this.showInformation(result);
            }
        }

        private void lastResultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!object.Equals(null, this.lastResult))
            {
                StringBuilder result = new StringBuilder();

                result.Append("Last Result:" + Environment.NewLine + Environment.NewLine);

                result.Append("Raw Input: " + this.lastResult.RawInput + Environment.NewLine);
                result.Append("Output: " + this.lastResult.Output + Environment.NewLine);
                result.Append("Raw Output: " + this.lastResult.RawOutput + Environment.NewLine);
                result.Append("Duration: "+this.lastResult.Duration.ToString() + Environment.NewLine + Environment.NewLine);
                result.Append("Sentences: " + Environment.NewLine);
                foreach (string sentence in this.lastResult.InputSentences)
                {
                    result.Append(sentence + Environment.NewLine);
                }
                result.Append(Environment.NewLine);
                
                result.Append(Environment.NewLine);
                result.Append("Sub Queries: " + Environment.NewLine);
                result.Append(Environment.NewLine);
                foreach (AIMLbot.Utils.SubQuery query in this.lastResult.SubQueries)
                {
                    result.Append("Path: " + query.FullPath + Environment.NewLine);
                    result.Append("Template: " + Environment.NewLine + query.Template + Environment.NewLine);
                    result.Append(Environment.NewLine);
                    result.Append("Input Stars:" + Environment.NewLine);
                    foreach (string star in query.InputStar)
                    {
                        result.Append(star + Environment.NewLine);
                    }
                    result.Append(Environment.NewLine);
                    result.Append("That Stars:" + Environment.NewLine);
                    foreach (string that in query.ThatStar)
                    {
                        result.Append(that + Environment.NewLine);
                    }
                    result.Append(Environment.NewLine);
                    result.Append("Topic Stars:" + Environment.NewLine);
                    foreach (string topic in query.TopicStar)
                    {
                        result.Append(topic + Environment.NewLine);
                    }
                    result.Append(Environment.NewLine);
                }
                result.Append(Environment.NewLine);
                result.Append("Output Sentences: " + Environment.NewLine);
                foreach (string outputSentence in this.lastResult.OutputSentences)
                {
                    result.Append(outputSentence + Environment.NewLine);
                }
                this.showInformation(result);
            }
        }

        private void showInformation(StringBuilder result)
        {
            ViewInformation vi = new ViewInformation();
            vi.OutputMessage = result.ToString();
            vi.ShowDialog(this);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string about = @"AIMLGui, Program# / AIMLBot (c) 2006 Nicholas H.Tollervey.
http://ntoll.org

This is a .NET implementation of the ALICE chatterbot using the AIML specification. Put simply, this software will allow you to chat (by entering text) with your computer using natural language.

Program# is a complete re-write of an earlier C# AIML implementation called AIMLBot. It is available under the Gnu LGPL. This means that you are free to download, modify and share it. Links to download Program# can be found at the bottom of the page.

";
            MessageBox.Show(about, "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void licenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string content = @"
Program# / AIMLBot - a .Net implementation of the AIML standard.
Copyright (C) 2006  Nicholas H.Tollervey (http://ntoll.org)

This library is free software; you can redistribute it and/or
modify it under the terms of the GNU Lesser General Public
License as published by the Free Software Foundation; either
version 2.1 of the License, or (at your option) any later version.

This library is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU
Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public
License along with this library; if not, write to the Free Software
Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301  USA
";
            MessageBox.Show(content, "License", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
#endregion

        private void buttonGo_Click(object sender, EventArgs e)
        {
                this.processInputFromUser();
        }

        private void processInputFromUser()
        {
            if (!tmr_rec_uwp_activo) return;

            if (this.myBot.isAcceptingUserInput)
            {
                string Salida = "";
                string rawInput = this.richTextBoxInput.Text;
                this.richTextBoxInput.Text = string.Empty;
                this.richTextBoxOutput.AppendText("You: " + rawInput + Environment.NewLine);
                Request myRequest = new Request(rawInput, this.myUser, this.myBot);
                Result myResult = new Result(this.myUser,this.myBot,myRequest);
                buttonGo.BackColor = Color.Red;
                buttonGo.Text = "...";

                if (cbModelo.Text == "AIML")
                {
                    myResult = this.myBot.Chat(myRequest);
                    Salida = myResult.Output;
                }
                else
                {
                    Salida = EjecutarGPT3(cbModelo.Text, rawInput);
                }
                this.lastRequest = myRequest;
                this.lastResult = myResult;
                this.richTextBoxOutput.AppendText("Bot: " + Salida + Environment.NewLine + Environment.NewLine);
                if (this.toolStripMenuItemSpeech.Checked)
                {
                    //Desactivamos reconocimiento para que no detecte su propia voz
                    try
                    {
#if !VOZ_UWP_SAPI_11
                        if (chkReconocimientoActivo.Checked) recognizer.RecognizeAsyncCancel();
#else
                        speechRecognizer.ContinuousRecognitionSession.StopAsync();
#endif
                    }
                    catch (Exception e) { MessageBox.Show(e.Message); }
                    System.Speech.Synthesis.SpeechSynthesizer voz= new System.Speech.Synthesis.SpeechSynthesizer();
                    static_voz = voz;
                    voz.SpeakProgress += new EventHandler<SpeakProgressEventArgs>(synth_SpeakProgress);
                    voz.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(synth_SpeakCompleted);
                    //voz.SelectVoice(ControlVoz.voz);
                    static_frase = myResult.Output;
                    if (chkMoverBoca.Checked)
                    {
                        tmrMoverBoca.Enabled = true;
                        InicializarMoverBoca();
                    }
                    tmr_rec_uwp_activo = false;
                    voz.SpeakAsync(Salida);
                    speechRecognizer.ContinuousRecognitionSession.StartAsync();
                    //try
                    //{
                    //    if (chkReconocimientoActivo.Checked) recognizer.RecognizeAsync(RecognizeMode.Multiple);
                    //}
                    //catch (Exception e) { }
                    return;
#region codigo_antiguo
               if (chkMoverBoca.Checked)
                    {
                        //Desactivamos reconocimiento para que no detecte su propia voz
                        try 
                        {
                            if (chkReconocimientoActivo.Checked) recognizer.RecognizeAsyncCancel();
                        } catch (Exception e) { }
                        voz = new System.Speech.Synthesis.SpeechSynthesizer();
                        static_voz = voz;
                        voz.SpeakProgress += new EventHandler<SpeakProgressEventArgs>(synth_SpeakProgress);
                        voz.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(synth_SpeakCompleted);
                        //voz.SelectVoice(ControlVoz.voz);
                        //voz.SpeakAsync(myResult.Output);
                        voz.Speak(myResult.Output);
                        try 
                        {
                            if (chkReconocimientoActivo.Checked) recognizer.RecognizeAsync(RecognizeMode.Multiple);
                        } catch (Exception e) { }
                    }
                    else
                    {
                        try
                        {
                            if (chkReconocimientoActivo.Checked) recognizer.RecognizeAsyncCancel();
                        }
                        catch (Exception e) { }
                        SpVoice objSpeech = new SpVoice();
                        objSpeech.Speak(myResult.Output, SpeechVoiceSpeakFlags.SVSFlagsAsync);
                        objSpeech.SynchronousSpeakTimeout = 20;
                        objSpeech.Rate = 1;
                        try
                        {
                            if (chkReconocimientoActivo.Checked) recognizer.RecognizeAsync(RecognizeMode.Multiple);
                        }
                        catch (Exception e) { }
                    }
#endregion
                }
            }
            else
            {
                this.richTextBoxInput.Text = string.Empty;
                this.richTextBoxOutput.AppendText("Bot not accepting user input." + Environment.NewLine);
            }
        }
        static void synth_SpeakCompleted(object sender, SpeakCompletedEventArgs e)
        {
            if (saimlForm.chkMoverBoca.Checked)
            {
                saimlForm.tmrMoverBoca.Enabled = false;
                EjecutarComando("cerrar boca", 1);
            }
#if !VOZ_UWP_SAPI_11
            srecognizer.RecognizeAsync(RecognizeMode.Multiple);
#endif
            saimlForm.buttonGo.BackColor = Color.LightGray;
            saimlForm.buttonGo.Text = "PROCESAR";
            texto = "";

            //static_ControlVoz.ActivarReconocimiento();
            static_voz.Dispose();
            Thread.Yield(); //Procesamos mensajes, alguno de reconocimiento de voz
            Thread.Yield();
            Thread.Yield();
            Thread.Sleep(1500);
            Thread.Yield(); //Procesamos mensajes, alguno de reconocimiento de voz
            Thread.Yield();
            Thread.Yield();
            texto = ""; //Borramos los posibles reconocimientos de voz mientras hablaba
            tmr_rec_uwp_activo = true;
        }
        static void synth_SpeakProgress(object sender, SpeakProgressEventArgs e)
        {
            try
            {
                //Localizamos si segue un signo de puntuación
                for (int i = e.CharacterPosition + e.CharacterCount; i < static_frase.Length; i++)
                {
                    char car = static_frase.Substring(i, 1).ToLower().ToCharArray()[0];
                    if ((car == '.') || (car == ',') || (car == ';') || (car == '?') || (car == '!'))
                    {
                        //Paramos el movimiento de la boca temporalmente
                        if (saimlForm.chkMoverBoca.Checked)
                            EjecutarComando("cerrar boca", 1);

                    }
                    else if ((car >= 'a') && (car <= 'z'))
                    {
                        //Comienza una nueva palabra
                        break;
                    }
                }
                if (e.CharacterPosition + e.CharacterCount + 1 >= static_frase.Length)
                {
                    //Hemos llegado al final de la frase
                    //Paramos el movimiento de la boca definitivo
                    if (saimlForm.chkMoverBoca.Checked)
                    {
                        saimlForm.tmrMoverBoca.Enabled = false;
                        EjecutarComando("cerrar boca", 1);
                    }
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void singleFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fi = new FileInfo(Path.Combine(Application.ExecutablePath, "aiml"));
                openFileDialogDump.InitialDirectory = fi.DirectoryName;
                openFileDialogDump.AddExtension = true;
                openFileDialogDump.DefaultExt = "aiml";
                openFileDialogDump.FileName = "Reduce.aiml";
                DialogResult dr = openFileDialogDump.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    AIMLbot.Utils.AIMLLoader loader = new AIMLbot.Utils.AIMLLoader(this.myBot);
                    this.myBot.isAcceptingUserInput = false;
                    loader.loadAIMLFile(openFileDialogDump.FileName);
                    this.myBot.isAcceptingUserInput = true;
                }
            }
            catch (Exception ex)
            {
                this.richTextBoxOutput.Text += ex.Message + Environment.NewLine;
            }
        }

        private void richTextBoxInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                this.processInputFromUser();
            }
        }

        private void richTextBoxOutput_TextChanged(object sender, EventArgs e)
        {
            this.richTextBoxOutput.ScrollToCaret();
        }

        private void toolStripMenuItemCustomLib_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fi = new FileInfo(Application.ExecutablePath);
                openFileDialogDump.InitialDirectory = fi.DirectoryName;
                openFileDialogDump.AddExtension = true;
                openFileDialogDump.DefaultExt = "dll";
                DialogResult dr = openFileDialogDump.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    if (openFileDialogDump.FileName.Length > 0)
                    {
                        this.myBot.isAcceptingUserInput = false;
                        this.myBot.loadCustomTagHandlers(openFileDialogDump.FileName);
                        this.myBot.isAcceptingUserInput = true;
                    }
                }
            }
            catch (Exception ex)
            {
                this.richTextBoxOutput.Text += ex.Message + Environment.NewLine;
            }
        }

        private void toolStripMenuItemSpeech_Click(object sender, EventArgs e)
        {
            this.toolStripMenuItemSpeech.Checked = !this.toolStripMenuItemSpeech.Checked;
        }

        private void fromDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                AIMLbot.Utils.AIMLLoader loader = new AIMLbot.Utils.AIMLLoader(this.myBot);
                this.myBot.isAcceptingUserInput = false;
                loader.loadAIML(this.myBot.PathToAIML);
                this.myBot.isAcceptingUserInput = true;
            }
            catch (Exception ex)
            {
                this.richTextBoxOutput.Text += ex.Message + Environment.NewLine;
            }
        }

        private void toolStripMenuItemLoadSession_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fi = new FileInfo(Application.ExecutablePath);
                openFileDialogDump.InitialDirectory = fi.DirectoryName;
                openFileDialogDump.AddExtension = true;
                openFileDialogDump.DefaultExt = "xml";
                openFileDialogDump.FileName = "UserSession.xml";
                DialogResult dr = openFileDialogDump.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    this.myUser.Predicates.loadSettings(openFileDialogDump.FileName);
                }
            }
            catch (Exception ex)
            {
                this.richTextBoxOutput.Text += ex.Message + Environment.NewLine;
            }
        }

        private void toolStripMenuItemSaveSession_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fi = new FileInfo(Application.ExecutablePath);
                saveFileDialogDump.InitialDirectory = fi.DirectoryName;
                saveFileDialogDump.AddExtension = true;
                saveFileDialogDump.DefaultExt = "xml";
                saveFileDialogDump.FileName = "UserSession.xml";
                DialogResult dr = saveFileDialogDump.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    this.myUser.Predicates.DictionaryAsXML.Save(saveFileDialogDump.FileName);
                }
            }
            catch (Exception ex)
            {
                this.richTextBoxOutput.Text += ex.Message + Environment.NewLine;
            }
        }

        private void aimlForm_Load(object sender, EventArgs e)
        {
            CargarConfiguracion();

            AIMLbot.Utils.AIMLLoader loader = new AIMLbot.Utils.AIMLLoader(this.myBot);
            loader.loadAIML(Application.StartupPath+ "\\Xulia");

            InicializarRecVoz();
            //Copiamos el texto de configuración del charbot GPT3
            String DirActual = Environment.CurrentDirectory;
            File.Copy(DirActual + "\\configuracion.txt", DirActual + "\\entrada.txt", true);

            if (PresentacionPorVoz)
            {
                System.Speech.Synthesis.SpeechSynthesizer voz = new System.Speech.Synthesis.SpeechSynthesizer();
                voz.Speak("sistema operativo");
                voz.Dispose();
            }
        }

#if VOZ_UWP_SAPI_11
        private async Task<bool> CompilarGramaticaUWP()
        {
            speechRecognizer = new SpeechRecognizer(SpeechRecognizer.SystemSpeechLanguage);
            speechRecognizer.Timeouts.BabbleTimeout = new TimeSpan(1,59,59);
            speechRecognizer.Timeouts.InitialSilenceTimeout = new TimeSpan(1, 59, 59);
            speechRecognizer.Timeouts.EndSilenceTimeout = new TimeSpan(1, 59, 59);
            speechRecognizer.ContinuousRecognitionSession.AutoStopSilenceTimeout = new TimeSpan(1, 59, 59);

            // Provide feedback to the user about the state of the recognizer. This can be used to provide visual feedback in the form
            // of an audio indicator to help the user understand whether they're being heard.
            speechRecognizer.StateChanged += SpeechRecognizer_StateChanged;

            // Build a command-list grammar. Commands should ideally be drawn from a resource file for localization, and 
            // be grouped into tags for alternate forms of the same command.
            var dictationConstraint = new SpeechRecognitionTopicConstraint(SpeechRecognitionScenario.Dictation, "dictation");
            speechRecognizer.Constraints.Add(dictationConstraint);

            Object result = speechRecognizer.CompileConstraintsAsync();

            return true;
        }
        public void ActivarReconocimientoUWP()
        {
            try
            {
                CompilarGramaticaUWP();
                Thread.Sleep(2000);
                ActivarReconocedorUWP();
                tmrProcesarVozUWP.Enabled = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        private void ActivarReconocedorUWP()
        {
            speechRecognizer.ContinuousRecognitionSession.Completed += ContinuousRecognitionSession_Completed;
            speechRecognizer.ContinuousRecognitionSession.ResultGenerated += ContinuousRecognitionSession_ResultGenerated;
            speechRecognizer.StateChanged += SpeechRecognizer_StateChanged;

            if (speechRecognizer.State == Windows.Media.SpeechRecognition.SpeechRecognizerState.Idle)
            {
                try
                {
                    speechRecognizer.ContinuousRecognitionSession.StartAsync();
                }
                catch (Exception ex)
                {
                }
            }
        }
        private void DesactivarReconocedorUWP()
        {
            tmrProcesarVozUWP.Enabled = false;
            speechRecognizer.ContinuousRecognitionSession.Completed -= ContinuousRecognitionSession_Completed;
            speechRecognizer.ContinuousRecognitionSession.ResultGenerated -= ContinuousRecognitionSession_ResultGenerated;
            speechRecognizer.StateChanged -= SpeechRecognizer_StateChanged;

            if (speechRecognizer.State == Windows.Media.SpeechRecognition.SpeechRecognizerState.Idle)
            {
                try
                {
                    speechRecognizer.ContinuousRecognitionSession.StopAsync();

                    //speechRecognizer.RecognizeWithUIAsync();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            speechRecognizer.Dispose();
            RecVozUWPACtivado = false;
        }
        private async void ContinuousRecognitionSession_ResultGenerated(SpeechContinuousRecognitionSession sender, SpeechContinuousRecognitionResultGeneratedEventArgs args)
        {
            // The garbage rule will not have a tag associated with it, the other rules will return a string matching the tag provided
            // when generating the grammar.
            string tag = "unknown";
            if (args.Result.Constraint != null)
            {
                tag = args.Result.Constraint.Tag;
            }

            // Developers may decide to use per-phrase confidence levels in order to tune the behavior of their 
            // grammar based on testing.
            if (args.Result.Confidence == SpeechRecognitionConfidence.Medium ||
                args.Result.Confidence == SpeechRecognitionConfidence.High)
            {
                texto = args.Result.Text;
            }
        }
        private async void ContinuousRecognitionSession_Completed(SpeechContinuousRecognitionSession sender, SpeechContinuousRecognitionCompletedEventArgs args)
        {
            if ((args.Status == SpeechRecognitionResultStatus.TimeoutExceeded) || 
                (args.Status == SpeechRecognitionResultStatus.Success ))
            {
                //Cuando finalice el reconocedor lo iniciamos de nuevo
                if (!Salida)
                {
                    try
                    {
                        speechRecognizer.ContinuousRecognitionSession.StartAsync();
                    }
                    catch (Exception e) { }
                }
            }
        }

        private async void SpeechRecognizer_StateChanged(SpeechRecognizer sender, SpeechRecognizerStateChangedEventArgs args)
        {
        }
#endif
        string ProcesarTextoReconocido(string texto)
        {
            String salida = "";
            texto = texto.ToLower();
            for (int i = 0; i < texto.Length; i++)
            {
                switch (texto[i])
                {
                    case 'á':
                        salida += "a";
                        break;
                    case 'é':
                        salida += "e";
                        break;
                    case 'í':
                        salida += "i";
                        break;
                    case 'ó':
                        salida += "o";
                        break;
                    case 'ú':
                        salida += "u";
                        break;
                    case 'ü':
                        salida += "u";
                        break;
                    case 'ñ':
                        salida += "nh";
                        break;
                    default:
                        salida += texto[i];
                        break;
                }
            }
            return salida;
        }
        private void InicializarRecVoz()
        {
            recognizer = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("es-ES"));
            srecognizer = recognizer;
            comandos = new String[] {"movimiento adelante","movimiento atras","parar base","griro derecha","giro izquierda","activar base","desactivar base","activar cuerpo",
                                        "desactivar cuerpo","apagar todo","parar movimientos","subir brazo derecho","subir brazo izquierdo","bajar brazo derecho","bajar brazo izquierdo",
                                        "adelante brazo derecho","adelante brazo izquierdo","atras brazo derecho","atras brazo izquierdo","abrir mano derecha","abrir mano izquierda","cerrar mano derecha",
                                        "cerrar mano izquerda","abrir boca","cerrar boca", "abrir boca","cerrar boca dos","girar muñeca derecha","ladear muñeca derecha", "tirar pelota",
                                        "modo conversacion", "salir de conversacion", "dani", "modelo avanzado", "modelo básico", "version"
                                    };

            recognizer.LoadGrammar(CargarGramaticaReconocedor(comandos, "es-ES", new GrammarBuilder()));
            //recognizer.LoadGrammar(new DictationGrammar());

            recognizer.SpeechRecognized +=
              new EventHandler<SpeechRecognizedEventArgs>(recognizer_SpeechRecognized);
            try
            {
                // Configure input to the speech recognizer.
                recognizer.SetInputToDefaultAudioDevice();

                // Start asynchronous, continuous speech recognition.
                recognizer.RecognizeAsync(RecognizeMode.Multiple );
            }
            catch (Exception e)
            {
                MessageBox.Show("Error inicializando sistema de reconocimiento, compruebe si tiene un micro conectado, error:" + e.Message.ToString());
                Application.Exit();
            }

        }
        static void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            saimlForm.richTextBoxInput.Text = ProcesarEntrada(e.Result.Text);

            if (e.Result.Confidence < PRECISION_MINIMA) return;

            if (!saimlForm.chkReconocimientoActivo.Checked) return;

            ReconocerTexto(e.Result.Text, e.Result.Confidence);

        }
        static void ReconocerTexto(String texto, float Precision)
        {
            if (SeguirSonido)
            {
                saimlForm.dEjecutarComando("pos_cabeza_ang_sonido", 0, 0, 0);
            }

            if ((texto == "dani") && !ComandoAutorizado)
            {
                ComandoAutorizado = true;
                saimlForm.richTextBoxInput.BackColor = Color.Green;
                timeMeasure.Reset();
                timeMeasure.Start();
                return;
            }
            else
                saimlForm.richTextBoxInput.BackColor = Color.White;

            if (ComandoAutorizado)
            {
                timeMeasure.Stop();
                if (timeMeasure.Elapsed.TotalSeconds < SEGUNDOS_REC_COMANDO_DANI)
                {
                    switch (texto)
                    {
                        case "version":
                            {
                                System.Speech.Synthesis.SpeechSynthesizer voz = new System.Speech.Synthesis.SpeechSynthesizer();
                                voz.Speak("Hola, me llamo dani. Soy un robot de servicio con capacidades de interacción y navegación autónoma. Mi version es " + Application.ProductVersion);
                                break;
                            }
                        case "modelo básico":
                            {
                                saimlForm.cbModelo.Text = "curie";
                                break;
                            }
                        case "modelo avanzado":
                            {
                                saimlForm.cbModelo.Text = "davinci";
                                break;
                            }
                        case "modo conversacion":
                        case "modo conversación":
                            {
#if VOZ_UWP_SAPI_11
                                saimlForm.recognizer.RecognizeAsyncStop();
                                if (RecVozUWPACtivado)
                                    speechRecognizer.ContinuousRecognitionSession.StartAsync();
                                else
                                {
                                    saimlForm.ActivarReconocimientoUWP();
                                    RecVozUWPACtivado = true;
                                }
#else
                        saimlForm.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                        saimlForm.recognizer.UnloadAllGrammars();
                        saimlForm.recognizer.LoadGrammar(new DictationGrammar());
#endif
                                saimlForm.Cursor = System.Windows.Forms.Cursors.Default;
                                saimlForm.richTextBoxInput.BackColor = Color.Red;
                                MODO_ACTIVO = MODO.Conversacion;
                                if (ActivarCabeza) EjecutarComando("activar cabeza", 1);
                                return;
                            }
                        case "salir conversacion":
                        case "salir de conversacion":
                        case "salir de conversación":
                            {
                                ComandoAutorizado = false;

                                if (ActivarCabeza) EjecutarComando("desactivar cabeza", 1);
                                try
                                {
#if VOZ_UWP_SAPI_11
                                    //saimlForm.speechRecognizer.ContinuousRecognitionSession.CancelAsync();
                                    saimlForm.DesactivarReconocedorUWP();
                                    saimlForm.recognizer.RecognizeAsync(RecognizeMode.Multiple);
#else
                        saimlForm.Cursor = System.Windows.Forms.Cursors.WaitCursor;
                        saimlForm.recognizer.UnloadAllGrammars();
                        saimlForm.recognizer.LoadGrammar(CargarGramaticaReconocedor(comandos, "es-ES", new GrammarBuilder()));
#endif
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show(e.Message);
                                }
                                finally
                                {
                                    saimlForm.Cursor = System.Windows.Forms.Cursors.Default;
                                    saimlForm.richTextBoxInput.BackColor = Color.White;
                                    MODO_ACTIVO = MODO.Comando;
                                }

                                return;
                            }
                    }
                }
                if (MODO_ACTIVO == MODO.Comando)
                {
                    ComandoAutorizado = false;

                    if (!ComandosSoloRecUWP)
                    {
                        srecognizer.RecognizeAsyncCancel();
                        System.Speech.Synthesis.SpeechSynthesizer voz = new System.Speech.Synthesis.SpeechSynthesizer();
                        voz.Speak(texto);
                        voz.Dispose();
                        EjecutarComando(texto, Precision);
                        try
                        {
                            srecognizer.RecognizeAsync(RecognizeMode.Multiple);
                        }
                        catch { }
                    }
                }
                else //Modo conversación
                {
#if !VOZ_UWP_SAPI_11
                saimlForm.processInputFromUser();
#endif
                    ComandoAutorizado = true;
                }
            } //if comandoautorizado
        }
        static Grammar CargarGramaticaReconocedor(string[] palabras, string cultura, GrammarBuilder grammar)
        {
            Grammar g;
            grammar.Culture = new System.Globalization.CultureInfo(cultura);
            grammar.Append(new Choices(palabras));
            g = new Grammar(grammar);

            return g;
        }
        static String ProcesarEntrada(String cad)
        {
            String tmp = "";
            cad = cad.ToLower();

            for (int i = 0; i < cad.Length; i++)
            {
                switch (cad[i])
                {
                    case 'á':
                        tmp += 'a';
                        break;
                    case 'é':
                        tmp += 'e';
                        break;
                    case 'í':
                        tmp += 'i';
                        break;
                    case 'ó':
                        tmp += 'o';
                        break;
                    case 'ú':
                        tmp += 'u';
                        break;
                    default:
                        tmp += cad[i];
                        break;
                }
            }
            return tmp;
        }

        private void chkReconocimientoActivo_CheckStateChanged(object sender, EventArgs e)
        {
#if !VOZ_UWP_SAPI_11
            if (chkReconocimientoActivo.Checked )
                recognizer.RecognizeAsync(RecognizeMode.Multiple);
            else
                recognizer.RecognizeAsyncCancel();
#endif
        }

        private void chkMoverBoca_CheckedChanged(object sender, EventArgs e)
        {
        }
        static int contador = 0;
        private void InicializarMoverBoca()
        {
            contador = 0;
            EjecutarComando("abrir boca", 1);
        }

        private void tmrMoverBoca_Tick(object sender, EventArgs e)
        {
            contador++;
            Random rnd = new Random();
            int numero = contador % 2;
            int a = rnd.Next(10);
            if (numero == 0)
            {
                if (a >= 5)
                    EjecutarComando("cerrar boca", 1);
                else
                    EjecutarComando("cerrar boca1", 1);
            }
            if (numero == 1)
            {
                if (a >= 5)
                    EjecutarComando("abrir boca", 1);
                else
                    EjecutarComando("abrir boca1", 1);
            }
        }

        private void richTextBoxInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmdMyo_Click(object sender1, EventArgs e1)
        {
            if (cmdMyo.BackColor == Color.Green)
            {
                cmdMyo.BackColor = Color.Gray;
                channel.StopListening();
                return;
            }
            // create a hub that will manage Myo devices for us
            channel = Channel.Create(
                ChannelDriver.Create(ChannelBridge.Create(),
                MyoErrorHandlerDriver.Create(MyoErrorHandlerBridge.Create())));

            var hub = Hub.Create(channel);
            // listen for when the Myo connects
            hub.MyoConnected += (sender, e) =>
            {
                //Información de conexión
                Console.WriteLine("Myo {0} has connected!", e.Myo.Handle);
                e.Myo.Vibrate(VibrationType.Short);

                //Lectura de movimientos
                e.Myo.OrientationDataAcquired += Myo_OrientationDataAcquired;
                cmdMyo.BackColor = Color.Green;

                //Lectura de posiciones
                e.Myo.Unlock(UnlockType.Hold);

                // setup for the pose we want to watch for
                var pose = HeldPose.Create(e.Myo, Pose.Fist, Pose.FingersSpread, Pose.DoubleTap, Pose.WaveIn, Pose.WaveOut);

                // set the interval for the event to be fired as long as 
                // the pose is held by the user
                pose.Interval = TimeSpan.FromSeconds(0.5);

                pose.Start();
                pose.Triggered += Pose_Triggered;

            };

            // listen for when the Myo disconnects
            hub.MyoDisconnected += (sender, e) =>
            {
                Console.WriteLine("Oh no! It looks like {0} arm Myo has disconnected!", e.Myo.Arm);
                e.Myo.OrientationDataAcquired -= Myo_OrientationDataAcquired;
                cmdMyo.BackColor = Color.Red;
            };

            // start listening for Myo data
            channel.StartListening();
            tmrMyo.Enabled = true;
            cmdMyo.Enabled = false;
        }
        private static void Myo_OrientationDataAcquired(object sender, OrientationDataEventArgs e)
        {
            const float PI = (float)System.Math.PI;

            // convert the values to a 0-9 scale (for easier digestion/understanding)
            roll = (int)((e.Roll + PI) / (PI * 2.0f) * 10);
            pitch = (int)((e.Pitch + PI) / (PI * 2.0f) * 10);
            yaw = (int)((e.Yaw + PI) / (PI * 2.0f) * 10);

        }
        private static void Pose_Triggered(object sender, PoseEventArgs e)
        {
            if (sPosicionMyo != e.Pose.ToString())
            { //Detectado cambio de figura de la mano
                sPosicionMyo = e.Pose.ToString();
                dEjecutarMyo(sPosicionMyo, roll, pitch, yaw);
                Console.WriteLine("{0} arm Myo is holding pose {1}!", e.Myo.Arm, e.Pose);
            }

        }
        private void tmrMyo_Tick(object sender, EventArgs e)
        {
            if (spitch + sroll + syaw != pitch + roll + yaw)
            {
                spitch = pitch;
                sroll = roll;
                syaw = yaw;
                tbMyo.Text = "Myo: " + aimlForm.roll + ", " + aimlForm.pitch + ", " + aimlForm.yaw;
                dEjecutarMyo("CambioPosicion", roll, pitch, yaw);
            }
        }

        private void chkReconocimientoActivo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tmrPRocesarVozUWP_Tick(object sender, EventArgs e)
        {
            try {
                if (tmr_rec_uwp_activo)
                {
                    if (texto != "")
                    {
                        string tmpTexto = texto;
                        texto = "";
                        tmpTexto = ProcesarTextoReconocido(tmpTexto); //quitamos acentos y ñ
                        richTextBoxInput.Text = tmpTexto;

                        //Si es un comando lo ejecutamos
                        if ((tmpTexto == "salir conversacion") || (tmpTexto == "salir de conversacion") ||
                            (tmpTexto == "salir conversación") || (tmpTexto == "salir de conversación"))
                            ReconocerTexto(tmpTexto, (float)0.9);
                        else if (EsUnComando(tmpTexto))
                            EjecutarComando(tmpTexto, (float)0.9);
                        else
                        {
                            saimlForm.processInputFromUser();
                        }
                    }
                }
                else
                    texto = "";
            }
            catch (Exception ex)
            {
                Console.WriteLine("aimlForm.cs - tmrPRocesarVozUWP_Tick: " + ex.Message);
                tmr_rec_uwp_activo = false;
            }
        }

        bool EsUnComando(string texto)
        {
            foreach (string s in comandos)
                if (s == texto)
                    return true;

            return false;
        }
        private void tmrMoverCabeza_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int a = rnd.Next(4);
            switch (a)
            {
                case 0:
                    EjecutarComando("cabeza cabeceo arriba1", 1);
                    break;
                case 1:
                    EjecutarComando("cabeza cabeceo arriba2", 1);
                    break;
                case 2:
                    EjecutarComando("cabeza cabeceo abajo1", 1);
                    break;
                case 3:
                    EjecutarComando("cabeza cabeceo abajo2", 1);
                    break;
            }
            a = rnd.Next(4);
            switch (a)
            {
                case 0:
                    EjecutarComando("cabeza guinada izquierda1", 1);
                    break;
                case 1:
                    EjecutarComando("cabeza guinada izquierda2", 1);
                    break;
                case 2:
                    EjecutarComando("cabeza guinada derecha1", 1);
                    break;
                case 3:
                    EjecutarComando("cabeza guinada derecha2", 1);
                    break;
            }
        }

        private void chkMoverCabeza_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMoverCabeza.Checked) 
                tmrMoverCabeza.Enabled = true;
            else
                tmrMoverCabeza.Enabled = false;
        }

        private void aimlForm_FormClosing(object sender, FormClosingEventArgs e)
        {
#if !VOZ_UWP_SAPI_11
            recognizer.RecognizeAsyncCancel();
#endif
        }

        private String EjecutarGPT3(String Modelo, String conversacion)
        {
            String s = "D:\\PROGRAMAS\\PYTHON\\python.exe";
            Process p = new Process();
            String fileReader = "";
            String DirActual = Environment.CurrentDirectory;
            StreamWriter escritor;

            escritor = File.AppendText(DirActual + "\\entrada.txt");
            escritor.Write("Humano:" + conversacion+ Environment.NewLine);
            escritor.Flush();
            escritor.Close();

            p.StartInfo.FileName = s;
            p.StartInfo.Arguments = "D:\\PROGRAMAS\\PYTHON\\Proy\\chatbot.py "+Modelo+" " + DirActual + "\\entrada.txt " + DirActual + "\\salida.txt";
            p.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            p.Start();
            p.WaitForExit();

            fileReader = File.ReadAllText(DirActual + "\\salida.txt", System.Text.Encoding.UTF8);

            escritor = File.AppendText(DirActual + "\\entrada.txt");
            escritor.Write("Dani:" + fileReader+Environment.NewLine);
            escritor.Flush();
            escritor.Close();

            return fileReader;
        }
        private void CargarConfiguracion()
        {
            String prec_min = ConfigurationSettings.AppSettings["precision_reconocimiento"].ToString();
            ComandosSoloRecUWP = (ConfigurationSettings.AppSettings["SoloComandosRecVozUWP"].ToString() == "S" ? true : false);
            chkMoverBoca.Checked = (ConfigurationSettings.AppSettings["mover_boca"].ToString() == "S" ? true : false);
            chkMoverCabeza.Checked = (ConfigurationSettings.AppSettings["mover_cabeza"].ToString() == "S" ? true : false);
            ActivarCabeza = (ConfigurationSettings.AppSettings["cabeza_activada_modo_conversacion"].ToString() == "S" ? true : false);
            PresentacionPorVoz = (ConfigurationSettings.AppSettings["presentacion_por_voz"].ToString() == "S" ? true : false);
            PRECISION_MINIMA = Convert.ToInt16(prec_min) / 100;
            SeguirSonido = (ConfigurationSettings.AppSettings["seguir_sonido_con_cabeza"].ToString() == "S" ? true : false);
        }
        static void EjecutarComando(String comando, float precision)
        {
             saimlForm.dEjecutarComando("cerrar boca", 1, 0, 0);
        }

    }
}