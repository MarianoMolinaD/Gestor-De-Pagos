namespace FrontEnd
{
    partial class BuscarEstudiantefrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbCarnet = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarEstudiante = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbDocente = new System.Windows.Forms.TextBox();
            this.cbSemestre = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tbSaldo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbJornada = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tbFacultad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDireccion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.tbNombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCui = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbCarnet
            // 
            this.tbCarnet.Location = new System.Drawing.Point(117, 36);
            this.tbCarnet.Name = "tbCarnet";
            this.tbCarnet.Size = new System.Drawing.Size(568, 26);
            this.tbCarnet.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Carnet";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbCarnet);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnBuscarEstudiante);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 105);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar";
            // 
            // btnBuscarEstudiante
            // 
            this.btnBuscarEstudiante.BackgroundImage = global::FrontEnd.Properties.Resources.Buscar;
            this.btnBuscarEstudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarEstudiante.Location = new System.Drawing.Point(691, 30);
            this.btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.Size = new System.Drawing.Size(47, 39);
            this.btnBuscarEstudiante.TabIndex = 3;
            this.btnBuscarEstudiante.UseVisualStyleBackColor = true;
            this.btnBuscarEstudiante.Click += new System.EventHandler(this.btnBuscarEstudiante_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDocente);
            this.groupBox2.Controls.Add(this.cbSemestre);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.tbSaldo);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tbJornada);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.tbFacultad);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.tbDireccion);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbEmail);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbTelefono);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbApellidos);
            this.groupBox2.Controls.Add(this.tbNombres);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.tbCui);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1061, 250);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado";
            // 
            // tbDocente
            // 
            this.tbDocente.Location = new System.Drawing.Point(599, 153);
            this.tbDocente.Name = "tbDocente";
            this.tbDocente.Size = new System.Drawing.Size(439, 26);
            this.tbDocente.TabIndex = 40;
            // 
            // cbSemestre
            // 
            this.cbSemestre.Location = new System.Drawing.Point(599, 121);
            this.cbSemestre.Name = "cbSemestre";
            this.cbSemestre.Size = new System.Drawing.Size(439, 26);
            this.cbSemestre.TabIndex = 39;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(465, 153);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 20);
            this.label14.TabIndex = 37;
            this.label14.Text = "Docente";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(465, 125);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(81, 20);
            this.label18.TabIndex = 35;
            this.label18.Text = "Semestre";
            // 
            // tbSaldo
            // 
            this.tbSaldo.Location = new System.Drawing.Point(599, 187);
            this.tbSaldo.Name = "tbSaldo";
            this.tbSaldo.Size = new System.Drawing.Size(96, 26);
            this.tbSaldo.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(465, 190);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 20);
            this.label15.TabIndex = 33;
            this.label15.Text = "Saldo";
            // 
            // tbJornada
            // 
            this.tbJornada.Location = new System.Drawing.Point(599, 87);
            this.tbJornada.Name = "tbJornada";
            this.tbJornada.Size = new System.Drawing.Size(439, 26);
            this.tbJornada.TabIndex = 32;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(465, 93);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(69, 20);
            this.label16.TabIndex = 31;
            this.label16.Text = "Jornada";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(465, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(73, 20);
            this.label17.TabIndex = 30;
            this.label17.Text = "Facultad";
            // 
            // tbFacultad
            // 
            this.tbFacultad.Location = new System.Drawing.Point(599, 55);
            this.tbFacultad.Name = "tbFacultad";
            this.tbFacultad.Size = new System.Drawing.Size(439, 26);
            this.tbFacultad.TabIndex = 29;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(32, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 28;
            this.label9.Text = "Direccion";
            // 
            // tbDireccion
            // 
            this.tbDireccion.Location = new System.Drawing.Point(166, 213);
            this.tbDireccion.Name = "tbDireccion";
            this.tbDireccion.Size = new System.Drawing.Size(244, 26);
            this.tbDireccion.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(79, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 20);
            this.label13.TabIndex = 26;
            this.label13.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 25;
            this.label6.Text = "Email";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(166, 175);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(244, 26);
            this.tbEmail.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 20);
            this.label5.TabIndex = 23;
            this.label5.Text = " ";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(166, 143);
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.Size = new System.Drawing.Size(244, 26);
            this.tbTelefono.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Telefono";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(166, 113);
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.Size = new System.Drawing.Size(244, 26);
            this.tbApellidos.TabIndex = 20;
            // 
            // tbNombres
            // 
            this.tbNombres.Location = new System.Drawing.Point(166, 80);
            this.tbNombres.Name = "tbNombres";
            this.tbNombres.Size = new System.Drawing.Size(244, 26);
            this.tbNombres.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Apellidos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(32, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Nombre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(32, 46);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Cui";
            // 
            // tbCui
            // 
            this.tbCui.Location = new System.Drawing.Point(166, 46);
            this.tbCui.Name = "tbCui";
            this.tbCui.Size = new System.Drawing.Size(244, 26);
            this.tbCui.TabIndex = 15;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FrontEnd.Properties.Resources.estudiantesIcon;
            this.pictureBox1.Location = new System.Drawing.Point(813, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 105);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // BuscarEstudiantefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1096, 416);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BuscarEstudiantefrm";
            this.Text = "Buscar Estudiante";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbCarnet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscarEstudiante;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDireccion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.TextBox tbNombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCui;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbSaldo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tbJornada;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbFacultad;
        private System.Windows.Forms.TextBox cbSemestre;
        private System.Windows.Forms.TextBox tbDocente;
    }
}