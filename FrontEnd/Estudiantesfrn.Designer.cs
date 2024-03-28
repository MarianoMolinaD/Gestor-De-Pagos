namespace FrontEnd
{
    partial class Estudiantesfrn
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.buscarEstudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregarEstudiante = new System.Windows.Forms.Button();
            this.btnBuscarEstudiante = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.buscarEstudianteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(169, 590);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // buscarEstudianteToolStripMenuItem
            // 
            this.buscarEstudianteToolStripMenuItem.Enabled = false;
            this.buscarEstudianteToolStripMenuItem.Name = "buscarEstudianteToolStripMenuItem";
            this.buscarEstudianteToolStripMenuItem.Size = new System.Drawing.Size(156, 24);
            this.buscarEstudianteToolStripMenuItem.Text = "MENU ESTUDIANTES";
            this.buscarEstudianteToolStripMenuItem.Click += new System.EventHandler(this.buscarEstudianteToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Agregar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 497);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Salir";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::FrontEnd.Properties.Resources.iconosalir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(12, 388);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(133, 106);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregarEstudiante
            // 
            this.btnAgregarEstudiante.BackgroundImage = global::FrontEnd.Properties.Resources.agregaruser;
            this.btnAgregarEstudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarEstudiante.Location = new System.Drawing.Point(12, 210);
            this.btnAgregarEstudiante.Name = "btnAgregarEstudiante";
            this.btnAgregarEstudiante.Size = new System.Drawing.Size(133, 106);
            this.btnAgregarEstudiante.TabIndex = 3;
            this.btnAgregarEstudiante.UseVisualStyleBackColor = true;
            this.btnAgregarEstudiante.Click += new System.EventHandler(this.btnAgregarEstudiante_Click);
            // 
            // btnBuscarEstudiante
            // 
            this.btnBuscarEstudiante.BackgroundImage = global::FrontEnd.Properties.Resources.buscar_user;
            this.btnBuscarEstudiante.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarEstudiante.Location = new System.Drawing.Point(12, 43);
            this.btnBuscarEstudiante.Name = "btnBuscarEstudiante";
            this.btnBuscarEstudiante.Size = new System.Drawing.Size(133, 111);
            this.btnBuscarEstudiante.TabIndex = 2;
            this.btnBuscarEstudiante.UseVisualStyleBackColor = true;
            this.btnBuscarEstudiante.Click += new System.EventHandler(this.btnBuscarEstudiante_Click);
            // 
            // Estudiantesfrn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 590);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarEstudiante);
            this.Controls.Add(this.btnBuscarEstudiante);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Estudiantesfrn";
            this.Text = "Estudiantes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buscarEstudianteToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnBuscarEstudiante;
        private System.Windows.Forms.Button btnAgregarEstudiante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label3;
    }
}