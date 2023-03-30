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
using Microsoft.Kinect;
using System.Windows.Media.Imaging;


using MyoSharp.Communication;
using MyoSharp.Device;
using MyoSharp.Exceptions;
using MyoSharp.Poses;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;
using System.Runtime.InteropServices;
using System.Web.UI.WebControls.Expressions;


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
        [DllImport("user32.dll", EntryPoint = "SetWindowPos")]
        public static extern IntPtr SetWindowPos(IntPtr hWnd, int hWndInsertAfter, int x, int Y, int cx, int cy, int wFlags);
        [DllImport("user32.dll")]
        private static extern bool ShowWindow(IntPtr hWnd, WindowShowStyle nCmdShow);

        //----Kinect-----------------------------------------
        private WriteableBitmap colorBitmap, DepthBitmap;
        private DepthImagePixel[] depthPixels;
        private byte[] colorPixels;
        public delegate void LeerBitmap(Bitmap img);
        public LeerBitmap dLeerBitmapKinectColor;
        public LeerBitmap dLeerBitmapKinectProfundidad;
        public LeerBitmap dLeerBitmapKinectXNA;
        //----Kinect-----------------------------------------
        //----XNA--------------------------------------------
        private const float RenderWidth = 640.0f;
        private const float RenderHeight = 480.0f;
        private const double JointThickness = 3;
        private const double BodyCenterThickness = 10;
        private const double ClipBoundsThickness = 10;
        private readonly System.Windows.Media.Brush centerPointBrush = System.Windows.Media.Brushes.Blue;
        private readonly System.Windows.Media.Brush trackedJointBrush = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(255, 68, 192, 68));
        private readonly System.Windows.Media.Brush inferredJointBrush = System.Windows.Media.Brushes.Yellow;
        private readonly System.Windows.Media.Pen trackedBonePen = new System.Windows.Media.Pen(System.Windows.Media.Brushes.Green, 6);
        private readonly System.Windows.Media.Pen inferredBonePen = new System.Windows.Media.Pen(System.Windows.Media.Brushes.Gray, 1);
        private KinectSensor sensor;
        private System.Windows.Media.DrawingGroup drawingGroup;
        private System.Windows.Media.DrawingImage imageSource;
        //----XNA--------------------------------------------
        private bool una_ejec_xna = false;
        private bool una_ejec_deph = false;
        private bool una_ejec_rgb = false;
        private long ms_ult_ejec_xna = 0;
        private long ms_ult_ejec_deph = 0;
        private long ms_ult_ejec_rgb = 0;
        private const int ESPERA_XNA_MS = 1000;
        private const int ESPERA_DEPH_MS = 1000;
        private const int ESPERA_RGB_MS = 500;
        //-----KINECT----------------------------------------
        /// <summary>Enumeration of the different ways of showing a window using 
        /// ShowWindow</summary>
        private enum WindowShowStyle : uint
        {
            Hide = 0,
            ShowNormal = 1,
            ShowMinimized = 2,
            ShowMaximized = 3,
            Maximize = 3,
            ShowNormalNoActivate = 4,
            Show = 5,
            Minimize = 6,
            ShowMinNoActivate = 7,
            ShowNoActivate = 8,
            Restore = 9,
            ShowDefault = 10,
            ForceMinimized = 11
        }
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
        public static bool VozActiva = false;
        static string static_frase = "";
        int ControlX, ControlY;
#if VOZ_UWP_SAPI_11
        private static SpeechRecognizer speechRecognizer;
        public SpeechRecognitionEngine recognizer;
        static public SpeechRecognitionEngine srecognizer;
#else
        public SpeechRecognitionEngine recognizer;
#endif
        static bool Salida = false;
        static string texto = "";
        static bool ActivarCabeza = false;
        public static bool SeguirSonido = true;
        public string PyPath = "";
        public string PyExec = "";
        public string Modelo = "AIML";
        public string RecVozActivado = "S";
        static bool tmr_rec_uwp_activo = true;
        static MODO MODO_ACTIVO = MODO.Comando;
        bool PresentacionPorVoz = false; //Mensaje de activación y presentación
        static bool ComandoAutorizado = false; //Comando autorizado con la palabra DANI
        static bool RecVozUWPACtivado = false;
        static bool ComandosSoloRecUWP = false;
        bool RecordarConversacionGPT = true;
        static Stopwatch timeMeasure = new Stopwatch();
        const int SEGUNDOS_REC_COMANDO_DANI = 4;

        public static aimlForm saimlForm;
        static String[] comandos;
        public delegate int DelegadoEjecutarComando(String comando, float precision, int iServo, int iPos);
        public delegate void DelegadoprocessInputFromUser();
        public DelegadoEjecutarComando dEjecutarComando;
        public DelegadoprocessInputFromUser dprocessInputFromUser;
        public delegate void EjecutarMyo(String Comando, int roll, int pitch, int yaw);
        public static EjecutarMyo dEjecutarMyo;
        Process processPython = new Process();
        StreamReader StdIn;
        StreamWriter StdOut;
        public DateTime TimeModoConversacion = System.DateTime.Now;
        public int TimeOutModoConversacion = 60;
        public bool SistemaOperativo = false;
        public bool RepetirComandoPorVoz = false;
        const int DPI_X = 96;
        const int DPI_Y = 96;

        enum eModos
        {
            Conversacion, Comando
        };
        enum MODO { Comando, Conversacion };
        public aimlForm()
        {
            InitializeComponent();
            saimlForm = this;
            this.toolStripMenuItemSpeech.Checked = true;
            this.richTextBoxInput.Focus();
            myBot = new Bot();
            myBot.loadSettings();
            myUser = new User("DefaultUser", this.myBot);
            myBot.WrittenToLog += new Bot.LogMessageDelegate(myBot_WrittenToLog);
            dprocessInputFromUser = processInputFromUser;
        }

        private void aimlForm_Load(object sender, EventArgs e)
        {
            CargarConfiguracion();

            InicializarPython();
            cbModelo.Text = Modelo;

            AIMLbot.Utils.AIMLLoader loader = new AIMLbot.Utils.AIMLLoader(this.myBot);
            loader.loadAIML(System.Windows.Forms.Application.StartupPath + "\\Xulia");

            InicializarRecVoz();
            //Copiamos el texto de configuración del charbot GPT3
            ResetearRecuerdosConversacion();

            if (PresentacionPorVoz)
            {
                System.Speech.Synthesis.SpeechSynthesizer voz = new System.Speech.Synthesis.SpeechSynthesizer();
                voz.Speak("sistema operativo");
                voz.Dispose();
            }
            SistemaOperativo = true;
        }
        public void InicializarPython()
        {
            EjecutarPython(false);
            String Salida = "";

            // Esperar a que se inicialize Python
            while (true)
            {
                Salida = LeerSalidaPython();
                if (Salida == ":INIT:")
                    break;
                Thread.Sleep(100);
            }
            //ShowWindow(processPython.MainWindowHandle, WindowShowStyle.Minimize);
            EjecutarComandoPython("dir_defecto(\"" + Directory.GetCurrentDirectory().Replace(@"\", @"\\") + "\")", false);
            EjecutarComandoPython("cargar_rostros()", false);

            #region prueba_python
            //String ret = "";
            //ret = EjecutarComandoPython("reconocer_rostros(\"images"+ @"\\" + "faces2"+ @"\\" + "1674226062130.jpg\", True)", false);
            //if (ret != "")
            //    MessageBox.Show(ret);
            #endregion

        }
        public void InicializarPosControl(int x, int y)
        {
            ControlX = x;
            ControlY = y;
            this.Top = x - this.Height;
            this.Left = y;
        }
        void myBot_WrittenToLog()
        {
            this.richTextBoxOutput.Text += this.myBot.LastLogMessage + Environment.NewLine + Environment.NewLine;
            this.richTextBoxOutput.ScrollToCaret();
        }

        #region Menu Item Events
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult exitQuery = MessageBox.Show("Are you sure?", "Are you sure?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (exitQuery == DialogResult.OK)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void saveBotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fi = new FileInfo(System.Windows.Forms.Application.ExecutablePath);
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
                FileInfo fi = new FileInfo(System.Windows.Forms.Application.ExecutablePath);
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
                result.Append(setting + ": " + this.myBot.GlobalSettings.grabSetting(setting) + Environment.NewLine);
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
                result.Append(setting + ": " + this.myUser.Predicates.grabSetting(setting) + Environment.NewLine);
            }
            this.showInformation(result);
        }

        private void lastRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!object.Equals(null, this.lastRequest))
            {
                StringBuilder result = new StringBuilder();

                result.Append("Last Request:" + Environment.NewLine + Environment.NewLine);

                result.Append("Raw Input: " + this.lastRequest.rawInput.Replace(Environment.NewLine, "") + Environment.NewLine);
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
                result.Append("Duration: " + this.lastResult.Duration.ToString() + Environment.NewLine + Environment.NewLine);
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
                Result myResult = new Result(this.myUser, this.myBot, myRequest);
                bool Comando = false;
                List<String> Comandos = new List<String>();
                bool AIML = false;
                int pos_coma = 0;
                String modelo = "";

                buttonGo.BackColor = Color.Red;
                buttonGo.Text = "...";

                if (rawInput.Length > 4)
                    if (rawInput.Substring(0, 4) == "com:")
                        Comando = true;

                if (Comando)
                    saimlForm.dEjecutarComando(rawInput.Substring(4), 0, 0, 0);
                else
                {
                    AIML = cbModelo.Text.Substring(0, 3) == "AIM";
                    if (AIML)
                    {
                        myResult = this.myBot.Chat(myRequest);
                        Salida = myResult.Output;
                        Comandos = RecuperarComandos(ref Salida);
                        // AIML y modelo si no sabe la respuesta
                        if (Comandos.Exists(x => x == "[NOSE]") || (Salida.IndexOf("UNKNOW") >= 0))
                        {
                            pos_coma = cbModelo.Text.IndexOf(',');
                            if (pos_coma >= 0)
                                modelo = cbModelo.Text.Substring(pos_coma + 1);
                        }
                        else if (RecordarConversacionGPT)
                            GuardarConversacion(rawInput, Salida);
                    }
                    else
                        modelo = cbModelo.Text;

                    if (modelo != "")
                    {
                        //Salida = EjecutarGPT3(cbModelo.Text, rawInput);
                        //gpt(entrada,modelo,recordar)
                        String myString = "";
                        if (modelo == "chatgpt")
                        {
                            String comando = "gpt(\"" + rawInput + "\",\"" + modelo + "\"," + (RecordarConversacionGPT ? "True" : "False") + ")";
                            Salida = EjecutarComandoPython(comando, false);
                            myString = Salida;
                        }
                        else 
                        {
                            String comando = "chat_GPT(\"" + rawInput + "\"," + (RecordarConversacionGPT ? "True" : "False") + ")";
                            Salida = EjecutarComandoPython(comando, false);
                            myString = Salida;
                        }

                        //Salida = ConvertirUTF8(Salida); //No funcionó

                        byte[] myByteArray = new byte[myString.Length];
                        for (int ix = 0; ix < myString.Length; ++ix)
                        {
                            char ch = myString[ix];
                            myByteArray[ix] = (byte)ch;
                        }

                        Salida = Encoding.UTF8.GetString(myByteArray, 0, myString.Length);
                    }
                    this.lastRequest = myRequest;
                    this.lastResult = myResult;
                    this.richTextBoxOutput.AppendText("Bot: " + Salida + Environment.NewLine + Environment.NewLine);
                    this.richTextBoxOutput.ScrollToCaret();
                    if (this.toolStripMenuItemSpeech.Checked)
                    {
                        Hablar(Salida);
                    }
                }
            }
            else
            {
                this.richTextBoxInput.Text = string.Empty;
                this.richTextBoxOutput.AppendText("Bot not accepting user input." + Environment.NewLine);
            }
        }
        public void Hablar(String Salida, bool Async = true)
        {
            while (VozActiva)
            {
                System.Windows.Forms.Application.DoEvents();
                Thread.Sleep(200);
            }
            //Desactivamos reconocimiento para que no detecte su propia voz
            try
            {
#if !VOZ_UWP_SAPI_11
                        if (chkReconocimientoActivo.Checked) recognizer.RecognizeAsyncCancel();
#else
                if (speechRecognizer != null)
                    if (chkReconocimientoActivo.Checked) speechRecognizer.ContinuousRecognitionSession.StopAsync();
#endif
            }
            catch (Exception e) { /*MessageBox.Show(e.Message);*/ }
            VozActiva = true;
            System.Speech.Synthesis.SpeechSynthesizer voz = new System.Speech.Synthesis.SpeechSynthesizer();
            static_voz = voz;
            voz.SpeakProgress += new EventHandler<SpeakProgressEventArgs>(synth_SpeakProgress);
            voz.SpeakCompleted += new EventHandler<SpeakCompletedEventArgs>(synth_SpeakCompleted);
            //voz.SelectVoice(ControlVoz.voz);
            static_frase = Salida;
            if (chkMoverBoca.Checked)
            {
                tmrMoverBoca.Enabled = true;
                InicializarMoverBoca();
            }
            tmr_rec_uwp_activo = false;
            voz.SpeakAsync(Salida);
            if (speechRecognizer != null)
                if (chkReconocimientoActivo.Checked) 
                     speechRecognizer.ContinuousRecognitionSession.StartAsync();
            //try
            //{
            //    if (chkReconocimientoActivo.Checked) recognizer.RecognizeAsync(RecognizeMode.Multiple);
            //}
            //catch (Exception e) { }
            if (!Async)
                while (VozActiva)
                {
                    System.Windows.Forms.Application.DoEvents();
                    Thread.Sleep(50);
                }
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
            aimlForm.VozActiva = false;
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

        private void singleFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FileInfo fi = new FileInfo(Path.Combine(System.Windows.Forms.Application.ExecutablePath, "aiml"));
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
                FileInfo fi = new FileInfo(System.Windows.Forms.Application.ExecutablePath);
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
                FileInfo fi = new FileInfo(System.Windows.Forms.Application.ExecutablePath);
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
                FileInfo fi = new FileInfo(System.Windows.Forms.Application.ExecutablePath);
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

#if VOZ_UWP_SAPI_11
        private async Task<bool> CompilarGramaticaUWP()
        {
            speechRecognizer = new SpeechRecognizer(SpeechRecognizer.SystemSpeechLanguage);
            speechRecognizer.Timeouts.BabbleTimeout = new TimeSpan(1, 59, 59);
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
                    MessageBox.Show("Error activando reconocimiento UWP: " + ex.Message);
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
                (args.Status == SpeechRecognitionResultStatus.Success))
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

            TimeModoConversacion = System.DateTime.Now;

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
            comandos = new String[] {"profundidad imagen", "jugar a piedra papel tijera","reconocer rostros", "reconocer objetos", "movimiento adelante","movimiento atras","parar base","griro derecha","giro izquierda","activar base","desactivar base","activar cuerpo",
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
                recognizer.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error inicializando sistema de reconocimiento, compruebe si tiene un micro conectado, error:" + e.Message.ToString());
                System.Windows.Forms.Application.Exit();
            }

        }
        static void recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (!saimlForm.chkReconocimientoActivo.Checked) return;

            saimlForm.richTextBoxInput.Text = ProcesarEntrada(e.Result.Text);

            if (e.Result.Confidence < PRECISION_MINIMA) return;

            if (!saimlForm.chkReconocimientoActivo.Checked) return;

            ReconocerTexto(e.Result.Text, e.Result.Confidence);

        }
        public void ActivarModoConversacion()
        {
            if (MODO_ACTIVO != MODO.Conversacion)
            {
                TimeModoConversacion = System.DateTime.Now;
                TimeOutConversacion.Enabled = true;

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
            }
            return;
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
                                voz.Speak("Hola, me llamo dani. Soy un robot de servicio con capacidades de interacción y navegación autónoma. Mi version es " + System.Windows.Forms.Application.ProductVersion);
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
                                saimlForm.ResetearRecuerdosConversacion();
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
                        if (saimlForm.RepetirComandoPorVoz)
                        {
                            srecognizer.RecognizeAsyncCancel();
                            System.Speech.Synthesis.SpeechSynthesizer voz = new System.Speech.Synthesis.SpeechSynthesizer();
                            voz.Speak(texto);
                            voz.Dispose();
                        }
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

        public bool PythonActivo = true;

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
            tmrProcesarVozUWP.Enabled = chkReconocimientoActivo.Checked;
        }

        private void tmrPRocesarVozUWP_Tick(object sender, EventArgs e)
        {
            if (!saimlForm.chkReconocimientoActivo.Checked) return;

            try
            {
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
            if (processPython != null)
            {
                EjecutarComandoPython("quit()", true);
            }
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
            PyPath = ConfigurationSettings.AppSettings["py_path"].ToString();
            PyExec = ConfigurationSettings.AppSettings["py_exec"].ToString();
            if (!System.IO.File.Exists(PyExec))
                PyExec = ConfigurationSettings.AppSettings["py_exec_robot"].ToString();
            Modelo = ConfigurationSettings.AppSettings["modelo"].ToString();
            RecVozActivado = ConfigurationSettings.AppSettings["rec_voz_activado"].ToString();
            chkReconocimientoActivo.Checked = (RecVozActivado == "S" ? true : false);
            RecordarConversacionGPT = (ConfigurationSettings.AppSettings["recordar_conversacion_gpt"].ToString() == "S" ? true : false);
            TimeOutModoConversacion= Convert.ToInt16(ConfigurationSettings.AppSettings["timeout_modo_conversacion"]);
            RepetirComandoPorVoz = (ConfigurationSettings.AppSettings["repetir_comando_por_voz"].ToString() == "S" ? true : false);
        }
        static void EjecutarComando(String comando, float precision)
        {
            saimlForm.dEjecutarComando(comando, 1, 0, 0);
        }

        public void EjecutarPython(bool log)
        {
            string s = PyPath;
            var DirActual = Directory.GetCurrentDirectory();
            processPython.StartInfo.FileName = s;
            processPython.StartInfo.Arguments = PyExec;
            processPython.StartInfo.RedirectStandardOutput = true;
            processPython.StartInfo.RedirectStandardInput = true;
            processPython.StartInfo.UseShellExecute = false;
            processPython.StartInfo.WorkingDirectory = DirActual;
            if (log)
            {
                processPython.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
                processPython.StartInfo.CreateNoWindow = false;
            }
            else
            {
                processPython.StartInfo.WindowStyle = ProcessWindowStyle.Minimized;
                processPython.StartInfo.CreateNoWindow = true;
            }

            processPython.Start();

            StdIn = processPython.StandardOutput;
            StdOut = processPython.StandardInput;
        }

        public String EjecutarComandoPython(String comando, bool asyncrono)
        {
            String Salida = "";
            String Retorno = "";
            StdOut.WriteLine(comando);

            cmdPython.BackColor = Color.Red;
            cmdPython.Refresh();
            if (!asyncrono)
            {
                PythonActivo = true;
                while (PythonActivo)
                {
                    Thread.Yield();
                    Thread.Sleep(50);
                    System.Windows.Forms.Application.DoEvents();
                    Salida = LeerSalidaPython();
                    if (Salida != null)
                    {
                        String Sal = Salida.Substring(0, 5);
                        if ((Sal == ":ERR:") || (Sal == ":LOG:"))
                            MessageBox.Show(Salida);
                        else if (Sal == ":VAL:")
                            Retorno = (Retorno == "" ? "" : Retorno + ";") + Salida.Substring(5);
                        else if ((Sal == ":RET:") || (Salida.Substring(0, 5) == ":ASY:"))
                        {
                            PythonActivo = false;
                            break;
                        }
                    }
                }
            }
            cmdPython.BackColor = Color.LightGray;
            cmdPython.Refresh();
            return Retorno;
        }
        public String LeerSalidaPython()
        {
            return StdIn.ReadLine();
        }
        public String ConvertirUTF8(String entrada)
        {
            String myString = entrada;

            byte[] myByteArray = new byte[myString.Length];
            for (int ix = 0; ix < myString.Length; ++ix)
            {
                char ch = myString[ix];
                myByteArray[ix] = (byte)ch;
            }

            myString = Encoding.UTF8.GetString(myByteArray, 0, myString.Length);
            return myString;
        }
        public List<String> RecuperarComandos(ref String entrada)
        {
            int ini, fin;
            List<String> Comandos = new List<String>();

            do
            {
                ini = entrada.IndexOf('[');
                fin = entrada.IndexOf(']');

                if (ini >= 0)
                {
                    Comandos.Add(entrada.Substring(ini,  fin - ini+1));
                    entrada = entrada.Substring(0, ini)+ entrada.Substring(fin+1);
                }
            }
            while (ini > 0);

            return Comandos;
        }
        void GuardarConversacion(String entrada, String Salida)
        {
            String DirActual = Environment.CurrentDirectory;
            System.IO.File.AppendAllText(DirActual + "\\GPT3\\entrada.txt", "Humano:" + entrada + "\nIA:" + Salida + "\n");
        }

        private void TimeOutConversacion_Tick(object sender, EventArgs e)
        {
            if ( (System.DateTime.Now - TimeModoConversacion).TotalSeconds > TimeOutModoConversacion)
            {
                TimeOutConversacion.Enabled = false;
                ReconocerTexto("salir de conversacion", 1);
            }
        }

        void ResetearRecuerdosConversacion()
        {
            String DirActual = Environment.CurrentDirectory;
            System.IO.File.Copy(DirActual + "\\GPT3\\configuracion.txt", DirActual + "\\GPT3\\entrada.txt", true);
        }
        //----------KINECT----------------------------------------------
        private System.Drawing.Bitmap BitmapFromWriteableBitmap(WriteableBitmap writeBmp)
        {
            System.Drawing.Bitmap bmp;
            using (MemoryStream outStream = new MemoryStream())
            {
                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create((BitmapSource)writeBmp));
                enc.Save(outStream);
                bmp = new System.Drawing.Bitmap(outStream);
            }
            return bmp;
        }
        public void DesactivarKinect(KinectSensor sensor)
        {
            if (sensor != null) sensor.Stop();
        }
        public void DesactivarAudioSource(KinectSensor sensor)
        {
            if (sensor != null)
                sensor.AudioSource.Stop();
        }
        public void DesactivarCamaras(KinectSensor sensor)
        {
            if (sensor != null)
            {
                sensor.ColorStream.Disable();
                sensor.DepthStream.Disable();
            }
        }

        public void ActivarCamaras(KinectSensor sensor, bool ActivarCamaraColor , LeerBitmap LeerBmpColor, bool ActivarCamaraProfundidad , LeerBitmap LeerBmpProfundidad, bool ActivarXNA, LeerBitmap LeerBmpXNA)
        {
            dLeerBitmapKinectColor = LeerBmpColor;
            dLeerBitmapKinectProfundidad = LeerBmpProfundidad;
            dLeerBitmapKinectXNA = LeerBmpXNA;

            if (null != sensor)
            {
                this.sensor = sensor;
                if (ActivarCamaraColor)
                {
                    sensor.ColorStream.Enable(ColorImageFormat.RgbResolution1280x960Fps12);
                    colorPixels = new byte[sensor.ColorStream.FramePixelDataLength];
                    colorBitmap = new WriteableBitmap(sensor.ColorStream.FrameWidth, sensor.ColorStream.FrameHeight, DPI_X, DPI_Y, System.Windows.Media.PixelFormats.Bgr32, null);
                    sensor.ColorFrameReady += this.SensorColorFrameReady;
                }
                else sensor.ColorStream.Disable();

                //XNA y Depth comparten picturebox, solo puede activarse uno
                if (ActivarXNA)
                {
                    this.drawingGroup = new System.Windows.Media.DrawingGroup();
                    this.imageSource = new System.Windows.Media.DrawingImage(this.drawingGroup);
                    sensor.SkeletonStream.TrackingMode = SkeletonTrackingMode.Default;
                    sensor.SkeletonStream.Enable();
                    sensor.SkeletonFrameReady += this.SensorSkeletonFrameReady;
                }
                else
                {
                    sensor.SkeletonStream.Disable();
                    if (ActivarCamaraProfundidad)
                    {
                        sensor.DepthStream.Enable(DepthImageFormat.Resolution640x480Fps30);
                        depthPixels = new DepthImagePixel[sensor.DepthStream.FramePixelDataLength];
                        this.colorPixels = new byte[sensor.ColorStream.FramePixelDataLength];
                        this.DepthBitmap = new WriteableBitmap(sensor.DepthStream.FrameWidth, sensor.DepthStream.FrameHeight, DPI_X, DPI_Y, System.Windows.Media.PixelFormats.Bgr32, null);
                        DepthBitmap = new WriteableBitmap(sensor.DepthStream.FrameWidth, sensor.DepthStream.FrameHeight, DPI_X, DPI_Y, System.Windows.Media.PixelFormats.Bgr32, null);
                        sensor.DepthFrameReady += this.SensorDepthFrameReady;
                    }
                    else sensor.DepthStream.Disable();
                }
            }
        }
        private void SensorDepthFrameReady(object sender, DepthImageFrameReadyEventArgs e)
        {
            if (!una_ejec_deph)
            {
                if (!TiempoEspera(ref ms_ult_ejec_deph, ref una_ejec_deph, ESPERA_DEPH_MS)) return;
            }
            else una_ejec_deph = false;

            using (DepthImageFrame depthFrame = e.OpenDepthImageFrame())
            {
                if (depthFrame != null)
                {
                    // Copy the pixel data from the image to a temporary array
                    depthFrame.CopyDepthImagePixelDataTo(this.depthPixels);

                    // Get the min and max reliable depth for the current frame
                    int minDepth = depthFrame.MinDepth;
                    int maxDepth = depthFrame.MaxDepth;

                    // Convert the depth to RGB
                    int colorPixelIndex = 0;
                    for (int i = 0; i < this.depthPixels.Length; ++i)
                    {
                        // Get the depth for this pixel
                        short depth = depthPixels[i].Depth;

                        byte intensity = (byte)(depth >= minDepth && depth <= maxDepth ? depth : 0);

                        this.colorPixels[colorPixelIndex++] = intensity;
                        this.colorPixels[colorPixelIndex++] = intensity;
                        this.colorPixels[colorPixelIndex++] = intensity;

                        ++colorPixelIndex;
                    }

                    // Write the pixel data into our bitmap
                    this.DepthBitmap.WritePixels(
                        new System.Windows.Int32Rect(0, 0, this.DepthBitmap.PixelWidth, this.DepthBitmap.PixelHeight),
                        this.colorPixels,
                        this.DepthBitmap.PixelWidth * sizeof(int),
                        0);
                    dLeerBitmapKinectProfundidad(BitmapFromWriteableBitmap(this.DepthBitmap));
                }
            }
        }

        public BitmapSource ToBitmapSource(System.Windows.Media.DrawingImage source)
        {
            System.Windows.Media.DrawingVisual drawingVisual = new System.Windows.Media.DrawingVisual();
            System.Windows.Media.DrawingContext drawingContext = drawingVisual.RenderOpen();
            drawingContext.DrawImage(source, new System.Windows.Rect(new System.Windows.Point(0, 0), new System.Windows.Size(source.Width, source.Height)));
            drawingContext.Close();

            RenderTargetBitmap bmp = new RenderTargetBitmap((int)source.Width, (int)source.Height, 96, 96, System.Windows.Media.PixelFormats.Pbgra32);
            bmp.Render(drawingVisual);
            return bmp;
        }

        System.Drawing.Bitmap MakeNet2BitmapFromWPFBitmapSource(BitmapSource src)
        {
            try
            {
                MemoryStream TransportStream = new MemoryStream();
                BitmapEncoder enc = new BmpBitmapEncoder();
                enc.Frames.Add(BitmapFrame.Create(src));
                enc.Save(TransportStream);
                return new System.Drawing.Bitmap(TransportStream);
            }
            catch { System.Windows.Forms.MessageBox.Show("failed"); return null; }
        }

        private void SensorColorFrameReady(object sender, ColorImageFrameReadyEventArgs e)
        {
            if (!una_ejec_rgb)
            {
                if (!TiempoEspera(ref ms_ult_ejec_rgb, ref una_ejec_rgb, ESPERA_RGB_MS)) return;
            }
            else una_ejec_rgb = false;

            using (ColorImageFrame colorFrame = e.OpenColorImageFrame())
            {
                if (colorFrame != null)
                {
                    // Copy the pixel data from the image to a temporary array
                    colorFrame.CopyPixelDataTo(this.colorPixels);

                    // Write the pixel data into our bitmap
                    this.colorBitmap.WritePixels(
                        new System.Windows.Int32Rect(0, 0, this.colorBitmap.PixelWidth, this.colorBitmap.PixelHeight),
                        this.colorPixels,
                        this.colorBitmap.PixelWidth * sizeof(int),
                        0);
                    dLeerBitmapKinectColor(BitmapFromWriteableBitmap(this.colorBitmap));
                }
            }
        }

        private void SensorSkeletonFrameReady(object sender, SkeletonFrameReadyEventArgs e)
        {
            if (!una_ejec_xna)
            {
                if (!TiempoEspera(ref ms_ult_ejec_xna, ref una_ejec_xna, ESPERA_XNA_MS)) return;
            }
            else una_ejec_xna = false;

            Skeleton[] skeletons = new Skeleton[0];

            using (SkeletonFrame skeletonFrame = e.OpenSkeletonFrame())
            {
                if (skeletonFrame != null)
                {
                    skeletons = new Skeleton[skeletonFrame.SkeletonArrayLength];
                    skeletonFrame.CopySkeletonDataTo(skeletons);
                }
            }

            using (System.Windows.Media.DrawingContext dc = this.drawingGroup.Open())
            {
                // Draw a transparent background to set the render size
                dc.DrawRectangle(System.Windows.Media.Brushes.Black, null, new System.Windows.Rect(0.0, 0.0, RenderWidth, RenderHeight));

                if (skeletons.Length != 0)
                {
                    foreach (Skeleton skel in skeletons)
                    {
                        RenderClippedEdges(skel, dc);

                        if (skel.TrackingState == SkeletonTrackingState.Tracked)
                        {
                            this.DrawBonesAndJoints(skel, dc);
                        }
                        else if (skel.TrackingState == SkeletonTrackingState.PositionOnly)
                        {
                            dc.DrawEllipse(
                            this.centerPointBrush,
                            null,
                            this.SkeletonPointToScreen(skel.Position),
                            BodyCenterThickness,
                            BodyCenterThickness);
                        }
                    }
                    if (imageSource.Width > 0)
                    {
                        // prevent drawing outside of our render area
                        this.drawingGroup.ClipGeometry = new System.Windows.Media.RectangleGeometry(new System.Windows.Rect(0.0, 0.0, RenderWidth, RenderHeight));
                        Bitmap bmp = MakeNet2BitmapFromWPFBitmapSource(ToBitmapSource(imageSource));
                        dLeerBitmapKinectXNA(bmp);
                    }
                }
            }
        }

        /// <summary>
        /// Draws a skeleton's bones and joints
        /// </summary>
        /// <param name="skeleton">skeleton to draw</param>
        /// <param name="drawingContext">drawing context to draw to</param>
        private void DrawBonesAndJoints(Skeleton skeleton, System.Windows.Media.DrawingContext drawingContext)
        {
            // Render Torso
            this.DrawBone(skeleton, drawingContext, JointType.Head, JointType.ShoulderCenter);
            this.DrawBone(skeleton, drawingContext, JointType.ShoulderCenter, JointType.ShoulderLeft);
            this.DrawBone(skeleton, drawingContext, JointType.ShoulderCenter, JointType.ShoulderRight);
            this.DrawBone(skeleton, drawingContext, JointType.ShoulderCenter, JointType.Spine);
            this.DrawBone(skeleton, drawingContext, JointType.Spine, JointType.HipCenter);
            this.DrawBone(skeleton, drawingContext, JointType.HipCenter, JointType.HipLeft);
            this.DrawBone(skeleton, drawingContext, JointType.HipCenter, JointType.HipRight);

            // Left Arm
            this.DrawBone(skeleton, drawingContext, JointType.ShoulderLeft, JointType.ElbowLeft);
            this.DrawBone(skeleton, drawingContext, JointType.ElbowLeft, JointType.WristLeft);
            this.DrawBone(skeleton, drawingContext, JointType.WristLeft, JointType.HandLeft);

            // Right Arm
            this.DrawBone(skeleton, drawingContext, JointType.ShoulderRight, JointType.ElbowRight);
            this.DrawBone(skeleton, drawingContext, JointType.ElbowRight, JointType.WristRight);
            this.DrawBone(skeleton, drawingContext, JointType.WristRight, JointType.HandRight);

            // Left Leg
            this.DrawBone(skeleton, drawingContext, JointType.HipLeft, JointType.KneeLeft);
            this.DrawBone(skeleton, drawingContext, JointType.KneeLeft, JointType.AnkleLeft);
            this.DrawBone(skeleton, drawingContext, JointType.AnkleLeft, JointType.FootLeft);

            // Right Leg
            this.DrawBone(skeleton, drawingContext, JointType.HipRight, JointType.KneeRight);
            this.DrawBone(skeleton, drawingContext, JointType.KneeRight, JointType.AnkleRight);
            this.DrawBone(skeleton, drawingContext, JointType.AnkleRight, JointType.FootRight);

            // Render Joints
            foreach (Joint joint in skeleton.Joints)
            {
                System.Windows.Media.Brush drawBrush = null;

                if (joint.TrackingState == JointTrackingState.Tracked)
                {
                    drawBrush = this.trackedJointBrush;
                }
                else if (joint.TrackingState == JointTrackingState.Inferred)
                {
                    drawBrush = this.inferredJointBrush;
                }

                if (drawBrush != null)
                {
                    drawingContext.DrawEllipse(drawBrush, null, this.SkeletonPointToScreen(joint.Position), JointThickness, JointThickness);
                }
            }
        }

        /// <summary>
        /// Maps a SkeletonPoint to lie within our render space and converts to Point
        /// </summary>
        /// <param name="skelpoint">point to map</param>
        /// <returns>mapped point</returns>
        private System.Windows.Point SkeletonPointToScreen(SkeletonPoint skelpoint)
        {
            // Convert point to depth space.  
            // We are not using depth directly, but we do want the points in our 640x480 output resolution.
            DepthImagePoint depthPoint = sensor.CoordinateMapper.MapSkeletonPointToDepthPoint(skelpoint, DepthImageFormat.Resolution640x480Fps30);
            return new System.Windows.Point(depthPoint.X, depthPoint.Y);
        }

        /// <summary>
        /// Draws a bone line between two joints
        /// </summary>
        /// <param name="skeleton">skeleton to draw bones from</param>
        /// <param name="drawingContext">drawing context to draw to</param>
        /// <param name="jointType0">joint to start drawing from</param>
        /// <param name="jointType1">joint to end drawing at</param>
        private void DrawBone(Skeleton skeleton, System.Windows.Media.DrawingContext drawingContext, JointType jointType0, JointType jointType1)
        {
            Joint joint0 = skeleton.Joints[jointType0];
            Joint joint1 = skeleton.Joints[jointType1];

            // If we can't find either of these joints, exit
            if (joint0.TrackingState == JointTrackingState.NotTracked ||
                joint1.TrackingState == JointTrackingState.NotTracked)
            {
                return;
            }

            // Don't draw if both points are inferred
            if (joint0.TrackingState == JointTrackingState.Inferred &&
                joint1.TrackingState == JointTrackingState.Inferred)
            {
                return;
            }

            // We assume all drawn bones are inferred unless BOTH joints are tracked
            System.Windows.Media.Pen drawPen = this.inferredBonePen;
            if (joint0.TrackingState == JointTrackingState.Tracked && joint1.TrackingState == JointTrackingState.Tracked)
            {
                drawPen = this.trackedBonePen;
            }

            drawingContext.DrawLine(drawPen, this.SkeletonPointToScreen(joint0.Position), this.SkeletonPointToScreen(joint1.Position));
        }
        private static void RenderClippedEdges(Skeleton skeleton, System.Windows.Media.DrawingContext drawingContext)
        {
            if (skeleton.ClippedEdges.HasFlag(FrameEdges.Bottom))
            {
                drawingContext.DrawRectangle(
                    System.Windows.Media.Brushes.Red,
                    null,
                    new System.Windows.Rect(0, RenderHeight - ClipBoundsThickness, RenderWidth, ClipBoundsThickness));
            }

            if (skeleton.ClippedEdges.HasFlag(FrameEdges.Top))
            {
                drawingContext.DrawRectangle(
                    System.Windows.Media.Brushes.Red,
                    null,
                    new System.Windows.Rect(0, 0, RenderWidth, ClipBoundsThickness));
            }

            if (skeleton.ClippedEdges.HasFlag(FrameEdges.Left))
            {
                drawingContext.DrawRectangle(
                    System.Windows.Media.Brushes.Red,
                    null,
                    new System.Windows.Rect(0, 0, ClipBoundsThickness, RenderHeight));
            }

            if (skeleton.ClippedEdges.HasFlag(FrameEdges.Right))
            {
                drawingContext.DrawRectangle(
                    System.Windows.Media.Brushes.Red,
                    null,
                    new System.Windows.Rect(RenderWidth - ClipBoundsThickness, 0, ClipBoundsThickness, RenderHeight));
            }
        }

        public void CerrarDANI()
        {
            PythonActivo = false;
            System.Windows.Forms.Application.Exit();
        }
        public void Aviso()
        {
            Console.Beep();
            System.Windows.Forms.Application.DoEvents();
        }
        private bool TiempoEspera(ref long ms, ref bool una_ejec,  int espera)
        {
            DateTimeOffset now = DateTimeOffset.UtcNow;
            long ms_actual = now.ToUnixTimeMilliseconds();

            if (Math.Abs(ms_actual - ms) < espera)
                return false;

            ms = ms_actual;
            una_ejec = true;
            return true;
        }
    }
}