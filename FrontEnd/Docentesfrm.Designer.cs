namespace FrontEnd
{
    partial class Docentesfrm
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarDocente = new System.Windows.Forms.Button();
            this.btnBuscarDocente = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(149, 590);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // buscarEstudianteToolStripMenuItem
            // 
            this.buscarEstudianteToolStripMenuItem.Enabled = false;
            this.buscarEstudianteToolStripMenuItem.Name = "buscarEstudianteToolStripMenuItem";
            this.buscarEstudianteToolStripMenuItem.Size = new System.Drawing.Size(136, 24);
            this.buscarEstudianteToolStripMenuItem.Text = "MENU DOCENTES";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 502);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Salir";
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::FrontEnd.Properties.Resources.iconosalir;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSalir.Location = new System.Drawing.Point(12, 393);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(133, 106);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Agregar";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Buscar";
            // 
            // btnAgregarDocente
            // 
            this.btnAgregarDocente.BackgroundImage = global::FrontEnd.Properties.Resources.agregaruser;
            this.btnAgregarDocente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAgregarDocente.Location = new System.Drawing.Point(12, 215);
            this.btnAgregarDocente.Name = "btnAgregarDocente";
            this.btnAgregarDocente.Size = new System.Drawing.Size(133, 106);
            this.btnAgregarDocente.TabIndex = 12;
            this.btnAgregarDocente.UseVisualStyleBackColor = true;
            this.btnAgregarDocente.Click += new System.EventHandler(this.btnAgregarDocente_Click);
            // 
            // btnBuscarDocente
            // 
            this.btnBuscarDocente.BackgroundImage = global::FrontEnd.Properties.Resources.buscar_user;
            this.btnBuscarDocente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBuscarDocente.Location = new System.Drawing.Point(12, 48);
            this.btnBuscarDocente.Name = "btnBuscarDocente";
            this.btnBuscarDocente.Size = new System.Drawing.Size(133, 111);
            this.btnBuscarDocente.TabIndex = 11;
            this.btnBuscarDocente.UseVisualStyleBackColor = true;
            this.btnBuscarDocente.Click += new System.EventHandler(this.btnBuscarDocente_Click);
            // 
            // Docentesfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1537, 590);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarDocente);
            this.Controls.Add(this.btnBuscarDocente);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Docentesfrm";
            this.Text = "Docentes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem buscarEstudianteToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarDocente;
        private System.Windows.Forms.Button btnBuscarDocente;
    }
}