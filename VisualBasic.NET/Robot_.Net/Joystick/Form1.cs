using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Controls;

namespace Joystick1
{
    enum Lado { derecha, izquierda };
    enum PartesBrazo { Codo, HombroBrazo, HombroCuerpo };
    enum MovimientoCabeza { Alabeo, Cabeceo };
    enum MovimientoBrazo { Subir, Bajar, Adelante, Atras, Parar };
    enum MovimientoMano { Derecha, Izquierda, Abrir, Cerrar };
    enum MovimientoBase { Derecha, Izquierda, Adelante, Atrás };
    enum Posicion { Arriba, Abajo, Centro };

    public partial class Form1 : Form
    {
        List<Joystick.DeviceInfo> devices = Joystick.GetAvailableDevices();
        Joystick joystick;
        enum Control { Base, Brazos, Cabeza, Manos };
        MovimientosRASPER RASPER;
        LecturaJoystick Joy1 = new LecturaJoystick();

        Control ControlActivo;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            joystick = new Joystick(cmbControles.SelectedIndex);
            cmbControles.Enabled = false;
            tmrGamePad.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Joystick.Status status = joystick.GetCurrentStatus();

            Joy1.Boton1 = false;
            Joy1.Boton2 = false;
            Joy1.Boton3 = false;
            Joy1.Boton4 = false;
            Joy1.Boton5 = false;
            Joy1.Boton6 = false;
            Joy1.Boton7 = false;
            Joy1.Boton8 = false;
            Joy1.Boton9 = false;
            Joy1.Boton10 = false;
            Joy1.Boton11 = false;
            Joy1.Boton12 = false;

            if (status.IsButtonPressed(Joystick.Buttons.Button1))
            {
                lblBoton1.BackColor = Color.Lime;
                ControlActivo = Control.Brazos;
                lblControl.Text = "Brazos";
                Joy1.Boton1 = true;
            }
            else
                lblBoton1.BackColor = Color.Red;

            if (status.IsButtonPressed(Joystick.Buttons.Button2))
            {
                lblBoton2.BackColor = Color.Lime;
                ControlActivo = Control.Cabeza;
                lblControl.Text = "Cabeza";
                Joy1.Boton2 = true;
            }
            else
                lblBoton2.BackColor = Color.Red;

            if (status.IsButtonPressed(Joystick.Buttons.Button3))
            {
                lblBoton3.BackColor = Color.Lime;
                ControlActivo = Control.Base;
                lblControl.Text = "Base";
                Joy1.Boton3 = true;
            }
            else
                lblBoton3.BackColor = Color.Red;

            if (status.IsButtonPressed(Joystick.Buttons.Button4))
            {
                lblBoton4.BackColor = Color.Lime;
                ControlActivo = Control.Manos;
                lblControl.Text = "Manos";
                Joy1.Boton4 = true;
            }
            else
                lblBoton4.BackColor = Color.Red;

            if (status.IsButtonPressed(Joystick.Buttons.Button5))
            {
                Joy1.Boton5 = true;
                lblBoton5.BackColor = Color.Lime;
            }
            else
                lblBoton5.BackColor = Color.Red;

            if (status.IsButtonPressed(Joystick.Buttons.Button6))
            {
                Joy1.Boton6 = true;
                lblBoton6.BackColor = Color.Lime;
            }
            else
                lblBoton6.BackColor = Color.Red;

            if (status.IsButtonPressed(Joystick.Buttons.Button7))
            {
                Joy1.Boton7 = true;
                lblBoton7.BackColor = Color.Lime;
            }
            else
                lblBoton7.BackColor = Color.Red;

            if (status.IsButtonPressed(Joystick.Buttons.Button8))
            {
                Joy1.Boton8 = true;
                lblBoton8.BackColor = Color.Lime;
            }
            else
                lblBoton8.BackColor = Color.Red;

            if (status.IsButtonPressed(Joystick.Buttons.Button9))
            {
                Joy1.Boton9 = true;
                lblBoton9.BackColor = Color.Lime;
            }
            else
                lblBoton9.BackColor = Color.Red;

            if (status.IsButtonPressed(Joystick.Buttons.Button10))
            {
                Joy1.Boton10 = true;
                lblBoton10.BackColor = Color.Lime;
            }
            else
                lblBoton10.BackColor = Color.Red;

            if (status.IsButtonPressed(Joystick.Buttons.Button11))
            {
                Joy1.Boton11 = true;
                lblBoton11.BackColor = Color.Lime;
            }
            else
                lblBoton11.BackColor = Color.Red;

            if (status.IsButtonPressed(Joystick.Buttons.Button12))
            {
                Joy1.Boton12 = true;
                lblBoton12.BackColor = Color.Lime;
            }
            else
                lblBoton12.BackColor = Color.Red;

            lblAxis1X.Text = status.XAxis.ToString();
            lblAxis1Y.Text = status.YAxis.ToString();

            lblAxis1R.Text = status.RAxis.ToString();
            lblAxis1Z.Text = status.ZAxis.ToString();

            Joy1.X = RecuperarValorEje(status.XAxis);
            Joy1.Y = RecuperarValorEje(status.XAxis);
            Joy1.R = RecuperarValorEje(status.XAxis);
            Joy1.Z = RecuperarValorEje(status.XAxis);

            Lado l;
            Posicion p;

            //RecuperarPosicion(Joy1.X, Joy1.Y, l, p);

        }

        private int RecuperarValorEje(float v)
        {
            return (int)(1 / v * 255);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            foreach (Joystick.DeviceInfo di in devices)
            {

                cmbControles.Items.Add(string.Format("{0} : {1} ({2} axes, {3} buttons)",
                    di.ID, di.Name, di.Axes, di.Buttons));
                System.Diagnostics.Debug.WriteLine(
                    string.Format("{0} : {1} ({2} axes, {3} buttons)",
                        di.ID, di.Name, di.Axes, di.Buttons));

            }
        }
    }
    public class MovimientosRASPER
    {
        void MoverBrazo(Lado Brazo, PartesBrazo ParteBrazo, MovimientoBrazo Mov)
        { }

        void MoverCabeza(MovimientoCabeza Mov, int Angulo)
        { }

        void MoverMano(Lado Mano, MovimientoMano Mov)
        { }
        void MoverBase(MovimientoBase Mov, int Velocidad)
        { }
    }

    public struct LecturaJoystick
    {
        public int X, Y, Z, R;
        public bool Boton1;
        public bool Boton2;
        public bool Boton3;
        public bool Boton4;
        public bool Boton5;
        public bool Boton6;
        public bool Boton7;
        public bool Boton8;
        public bool Boton9;
        public bool Boton10;
        public bool Boton11;
        public bool Boton12;
    }
}
