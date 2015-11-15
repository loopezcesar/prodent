﻿namespace presentacion
{
    partial class frm_principal
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
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemPaciente = new System.Windows.Forms.ToolStripMenuItem();
            this.medicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asistenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCitaMedica = new System.Windows.Forms.ToolStripMenuItem();
            this.tratamientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.menuPaciente,
            this.menuCitaMedica,
            this.tratamientoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuracionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // configuracionToolStripMenuItem
            // 
            this.configuracionToolStripMenuItem.Name = "configuracionToolStripMenuItem";
            this.configuracionToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.configuracionToolStripMenuItem.Text = "Configuracion";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(150, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            // 
            // menuPaciente
            // 
            this.menuPaciente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemPaciente,
            this.medicoToolStripMenuItem,
            this.asistenteToolStripMenuItem});
            this.menuPaciente.Name = "menuPaciente";
            this.menuPaciente.Size = new System.Drawing.Size(69, 20);
            this.menuPaciente.Text = "Gestionar";
            // 
            // menuItemPaciente
            // 
            this.menuItemPaciente.Name = "menuItemPaciente";
            this.menuItemPaciente.Size = new System.Drawing.Size(122, 22);
            this.menuItemPaciente.Text = "Paciente";
            this.menuItemPaciente.Click += new System.EventHandler(this.menuItemPaciente_Click);
            // 
            // medicoToolStripMenuItem
            // 
            this.medicoToolStripMenuItem.Name = "medicoToolStripMenuItem";
            this.medicoToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.medicoToolStripMenuItem.Text = "Medico";
            // 
            // asistenteToolStripMenuItem
            // 
            this.asistenteToolStripMenuItem.Name = "asistenteToolStripMenuItem";
            this.asistenteToolStripMenuItem.Size = new System.Drawing.Size(122, 22);
            this.asistenteToolStripMenuItem.Text = "Asistente";
            // 
            // menuCitaMedica
            // 
            this.menuCitaMedica.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.modificarToolStripMenuItem});
            this.menuCitaMedica.Name = "menuCitaMedica";
            this.menuCitaMedica.Size = new System.Drawing.Size(82, 20);
            this.menuCitaMedica.Text = "Cita Medica";
            // 
            // tratamientoToolStripMenuItem
            // 
            this.tratamientoToolStripMenuItem.Name = "tratamientoToolStripMenuItem";
            this.tratamientoToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.tratamientoToolStripMenuItem.Text = "Tratamiento";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.registrarToolStripMenuItem.Text = "Registrar";
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modificarToolStripMenuItem.Text = "Modificar";
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 409);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_principal";
            this.Text = "frm_principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuPaciente;
        private System.Windows.Forms.ToolStripMenuItem menuItemPaciente;
        private System.Windows.Forms.ToolStripMenuItem medicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asistenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCitaMedica;
        private System.Windows.Forms.ToolStripMenuItem tratamientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
    }
}