namespace Joystick1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbControles = new System.Windows.Forms.ComboBox();
            this.lblAxis1X = new System.Windows.Forms.TextBox();
            this.lblAxis1R = new System.Windows.Forms.TextBox();
            this.lblAxis1Z = new System.Windows.Forms.TextBox();
            this.lblAxis1Y = new System.Windows.Forms.TextBox();
            this.lblBoton1 = new System.Windows.Forms.Label();
            this.lblBoton2 = new System.Windows.Forms.Label();
            this.lblBoton3 = new System.Windows.Forms.Label();
            this.lblBoton4 = new System.Windows.Forms.Label();
            this.lblBoton8 = new System.Windows.Forms.Label();
            this.lblBoton7 = new System.Windows.Forms.Label();
            this.lblBoton6 = new System.Windows.Forms.Label();
            this.lblBoton5 = new System.Windows.Forms.Label();
            this.lblBoton12 = new System.Windows.Forms.Label();
            this.lblBoton11 = new System.Windows.Forms.Label();
            this.lblBoton10 = new System.Windows.Forms.Label();
            this.lblBoton9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tmrGamePad = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblControl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbControles
            // 
            this.cmbControles.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbControles.FormattingEnabled = true;
            this.cmbControles.Location = new System.Drawing.Point(26, 36);
            this.cmbControles.Name = "cmbControles";
            this.cmbControles.Size = new System.Drawing.Size(571, 32);
            this.cmbControles.TabIndex = 0;
            // 
            // lblAxis1X
            // 
            this.lblAxis1X.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAxis1X.Location = new System.Drawing.Point(94, 144);
            this.lblAxis1X.Name = "lblAxis1X";
            this.lblAxis1X.Size = new System.Drawing.Size(100, 29);
            this.lblAxis1X.TabIndex = 1;
            // 
            // lblAxis1R
            // 
            this.lblAxis1R.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAxis1R.Location = new System.Drawing.Point(220, 144);
            this.lblAxis1R.Name = "lblAxis1R";
            this.lblAxis1R.Size = new System.Drawing.Size(100, 29);
            this.lblAxis1R.TabIndex = 2;
            // 
            // lblAxis1Z
            // 
            this.lblAxis1Z.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAxis1Z.Location = new System.Drawing.Point(220, 193);
            this.lblAxis1Z.Name = "lblAxis1Z";
            this.lblAxis1Z.Size = new System.Drawing.Size(100, 29);
            this.lblAxis1Z.TabIndex = 4;
            // 
            // lblAxis1Y
            // 
            this.lblAxis1Y.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAxis1Y.Location = new System.Drawing.Point(94, 193);
            this.lblAxis1Y.Name = "lblAxis1Y";
            this.lblAxis1Y.Size = new System.Drawing.Size(100, 29);
            this.lblAxis1Y.TabIndex = 3;
            // 
            // lblBoton1
            // 
            this.lblBoton1.AutoSize = true;
            this.lblBoton1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBoton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoton1.Location = new System.Drawing.Point(85, 262);
            this.lblBoton1.Name = "lblBoton1";
            this.lblBoton1.Size = new System.Drawing.Size(88, 27);
            this.lblBoton1.TabIndex = 5;
            this.lblBoton1.Text = "Boton 1";
            // 
            // lblBoton2
            // 
            this.lblBoton2.AutoSize = true;
            this.lblBoton2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBoton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoton2.Location = new System.Drawing.Point(193, 262);
            this.lblBoton2.Name = "lblBoton2";
            this.lblBoton2.Size = new System.Drawing.Size(88, 27);
            this.lblBoton2.TabIndex = 6;
            this.lblBoton2.Text = "Boton 2";
            // 
            // lblBoton3
            // 
            this.lblBoton3.AutoSize = true;
            this.lblBoton3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBoton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoton3.Location = new System.Drawing.Point(300, 262);
            this.lblBoton3.Name = "lblBoton3";
            this.lblBoton3.Size = new System.Drawing.Size(88, 27);
            this.lblBoton3.TabIndex = 7;
            this.lblBoton3.Text = "Boton 3";
            // 
            // lblBoton4
            // 
            this.lblBoton4.AutoSize = true;
            this.lblBoton4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBoton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoton4.Location = new System.Drawing.Point(405, 262);
            this.lblBoton4.Name = "lblBoton4";
            this.lblBoton4.Size = new System.Drawing.Size(88, 27);
            this.lblBoton4.TabIndex = 8;
            this.lblBoton4.Text = "Boton 4";
            // 
            // lblBoton8
            // 
            this.lblBoton8.AutoSize = true;
            this.lblBoton8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBoton8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoton8.Location = new System.Drawing.Point(405, 311);
            this.lblBoton8.Name = "lblBoton8";
            this.lblBoton8.Size = new System.Drawing.Size(88, 27);
            this.lblBoton8.TabIndex = 12;
            this.lblBoton8.Text = "Boton 8";
            // 
            // lblBoton7
            // 
            this.lblBoton7.AutoSize = true;
            this.lblBoton7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBoton7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoton7.Location = new System.Drawing.Point(300, 311);
            this.lblBoton7.Name = "lblBoton7";
            this.lblBoton7.Size = new System.Drawing.Size(88, 27);
            this.lblBoton7.TabIndex = 11;
            this.lblBoton7.Text = "Boton 7";
            // 
            // lblBoton6
            // 
            this.lblBoton6.AutoSize = true;
            this.lblBoton6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBoton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoton6.Location = new System.Drawing.Point(193, 311);
            this.lblBoton6.Name = "lblBoton6";
            this.lblBoton6.Size = new System.Drawing.Size(88, 27);
            this.lblBoton6.TabIndex = 10;
            this.lblBoton6.Text = "Boton 6";
            // 
            // lblBoton5
            // 
            this.lblBoton5.AutoSize = true;
            this.lblBoton5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBoton5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoton5.Location = new System.Drawing.Point(85, 311);
            this.lblBoton5.Name = "lblBoton5";
            this.lblBoton5.Size = new System.Drawing.Size(88, 27);
            this.lblBoton5.TabIndex = 9;
            this.lblBoton5.Text = "Boton 5";
            // 
            // lblBoton12
            // 
            this.lblBoton12.AutoSize = true;
            this.lblBoton12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBoton12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoton12.Location = new System.Drawing.Point(405, 357);
            this.lblBoton12.Name = "lblBoton12";
            this.lblBoton12.Size = new System.Drawing.Size(100, 27);
            this.lblBoton12.TabIndex = 16;
            this.lblBoton12.Text = "Boton 12";
            // 
            // lblBoton11
            // 
            this.lblBoton11.AutoSize = true;
            this.lblBoton11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBoton11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoton11.Location = new System.Drawing.Point(300, 357);
            this.lblBoton11.Name = "lblBoton11";
            this.lblBoton11.Size = new System.Drawing.Size(100, 27);
            this.lblBoton11.TabIndex = 15;
            this.lblBoton11.Text = "Boton 11";
            // 
            // lblBoton10
            // 
            this.lblBoton10.AutoSize = true;
            this.lblBoton10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBoton10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoton10.Location = new System.Drawing.Point(193, 357);
            this.lblBoton10.Name = "lblBoton10";
            this.lblBoton10.Size = new System.Drawing.Size(100, 27);
            this.lblBoton10.TabIndex = 14;
            this.lblBoton10.Text = "Boton 10";
            // 
            // lblBoton9
            // 
            this.lblBoton9.AutoSize = true;
            this.lblBoton9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBoton9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoton9.Location = new System.Drawing.Point(85, 357);
            this.lblBoton9.Name = "lblBoton9";
            this.lblBoton9.Size = new System.Drawing.Size(88, 27);
            this.lblBoton9.TabIndex = 13;
            this.lblBoton9.Text = "Boton 9";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(617, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 54);
            this.button1.TabIndex = 21;
            this.button1.Text = "Explorar Controles";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tmrGamePad
            // 
            this.tmrGamePad.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 25);
            this.label1.TabIndex = 22;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(200, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 25);
            this.label3.TabIndex = 24;
            this.label3.Text = "R";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(201, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Z";
            // 
            // lblControl
            // 
            this.lblControl.AutoSize = true;
            this.lblControl.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblControl.Location = new System.Drawing.Point(523, 142);
            this.lblControl.Name = "lblControl";
            this.lblControl.Size = new System.Drawing.Size(137, 41);
            this.lblControl.TabIndex = 26;
            this.lblControl.Text = "Boton 4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 423);
            this.Controls.Add(this.lblControl);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblBoton12);
            this.Controls.Add(this.lblBoton11);
            this.Controls.Add(this.lblBoton10);
            this.Controls.Add(this.lblBoton9);
            this.Controls.Add(this.lblBoton8);
            this.Controls.Add(this.lblBoton7);
            this.Controls.Add(this.lblBoton6);
            this.Controls.Add(this.lblBoton5);
            this.Controls.Add(this.lblBoton4);
            this.Controls.Add(this.lblBoton3);
            this.Controls.Add(this.lblBoton2);
            this.Controls.Add(this.lblBoton1);
            this.Controls.Add(this.lblAxis1Z);
            this.Controls.Add(this.lblAxis1Y);
            this.Controls.Add(this.lblAxis1R);
            this.Controls.Add(this.lblAxis1X);
            this.Controls.Add(this.cmbControles);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbControles;
        private System.Windows.Forms.TextBox lblAxis1X;
        private System.Windows.Forms.TextBox lblAxis1R;
        private System.Windows.Forms.TextBox lblAxis1Z;
        private System.Windows.Forms.TextBox lblAxis1Y;
        private System.Windows.Forms.Label lblBoton1;
        private System.Windows.Forms.Label lblBoton2;
        private System.Windows.Forms.Label lblBoton3;
        private System.Windows.Forms.Label lblBoton4;
        private System.Windows.Forms.Label lblBoton8;
        private System.Windows.Forms.Label lblBoton7;
        private System.Windows.Forms.Label lblBoton6;
        private System.Windows.Forms.Label lblBoton5;
        private System.Windows.Forms.Label lblBoton12;
        private System.Windows.Forms.Label lblBoton11;
        private System.Windows.Forms.Label lblBoton10;
        private System.Windows.Forms.Label lblBoton9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer tmrGamePad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblControl;
    }
}

