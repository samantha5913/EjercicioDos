namespace APSICO_ADUANAL
{
    partial class Operadores
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
            this.registrarTransferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarAgenciaAduanalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarPrevioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalDeDependenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarTransferenciaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarTransferenciaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(358, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registrarTransferenciaToolStripMenuItem
            // 
            this.registrarTransferenciaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarAgenciaAduanalToolStripMenuItem,
            this.registrarPrevioToolStripMenuItem,
            this.personalDeDependenciasToolStripMenuItem,
            this.registrarTransferenciaToolStripMenuItem1});
            this.registrarTransferenciaToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarTransferenciaToolStripMenuItem.Name = "registrarTransferenciaToolStripMenuItem";
            this.registrarTransferenciaToolStripMenuItem.Size = new System.Drawing.Size(175, 25);
            this.registrarTransferenciaToolStripMenuItem.Text = "Registro de Tramies.";
            // 
            // registrarAgenciaAduanalToolStripMenuItem
            // 
            this.registrarAgenciaAduanalToolStripMenuItem.Name = "registrarAgenciaAduanalToolStripMenuItem";
            this.registrarAgenciaAduanalToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.registrarAgenciaAduanalToolStripMenuItem.Text = "Registrar Agencia  Aduanal.";
            this.registrarAgenciaAduanalToolStripMenuItem.Click += new System.EventHandler(this.registrarAgenciaAduanalToolStripMenuItem_Click);
            // 
            // registrarPrevioToolStripMenuItem
            // 
            this.registrarPrevioToolStripMenuItem.Name = "registrarPrevioToolStripMenuItem";
            this.registrarPrevioToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.registrarPrevioToolStripMenuItem.Text = "Registrar Previo.";
            this.registrarPrevioToolStripMenuItem.Click += new System.EventHandler(this.registrarPrevioToolStripMenuItem_Click);
            // 
            // personalDeDependenciasToolStripMenuItem
            // 
            this.personalDeDependenciasToolStripMenuItem.Name = "personalDeDependenciasToolStripMenuItem";
            this.personalDeDependenciasToolStripMenuItem.Size = new System.Drawing.Size(290, 26);
            this.personalDeDependenciasToolStripMenuItem.Text = "Personal de Dependencias.";
            this.personalDeDependenciasToolStripMenuItem.Click += new System.EventHandler(this.personalDeDependenciasToolStripMenuItem_Click);
            // 
            // registrarTransferenciaToolStripMenuItem1
            // 
            this.registrarTransferenciaToolStripMenuItem1.Name = "registrarTransferenciaToolStripMenuItem1";
            this.registrarTransferenciaToolStripMenuItem1.Size = new System.Drawing.Size(290, 26);
            this.registrarTransferenciaToolStripMenuItem1.Text = "Registrar Transferencia.";
            this.registrarTransferenciaToolStripMenuItem1.Click += new System.EventHandler(this.registrarTransferenciaToolStripMenuItem1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::APSICO_ADUANAL.Properties.Resources.ruedas1;
            this.pictureBox1.Location = new System.Drawing.Point(79, 54);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Operadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(358, 261);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Operadores";
            this.Text = "Operadores";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registrarTransferenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarAgenciaAduanalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarPrevioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalDeDependenciasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarTransferenciaToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}