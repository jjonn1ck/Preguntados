﻿namespace Preguntados
{
    partial class MDItest
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.iniciarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jUGARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vERTOPSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearPreguntaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iniciarSesionToolStripMenuItem,
            this.jUGARToolStripMenuItem,
            this.vERTOPSToolStripMenuItem,
            this.crearPreguntaToolStripMenuItem,
            this.cerrarSesionToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // iniciarSesionToolStripMenuItem
            // 
            this.iniciarSesionToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.iniciarSesionToolStripMenuItem.Name = "iniciarSesionToolStripMenuItem";
            this.iniciarSesionToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.iniciarSesionToolStripMenuItem.Text = "Iniciar Sesion";
            this.iniciarSesionToolStripMenuItem.Click += new System.EventHandler(this.iniciarSesionToolStripMenuItem_Click);
            // 
            // jUGARToolStripMenuItem
            // 
            this.jUGARToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.jUGARToolStripMenuItem.Name = "jUGARToolStripMenuItem";
            this.jUGARToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.jUGARToolStripMenuItem.Text = "JUGAR";
            this.jUGARToolStripMenuItem.Click += new System.EventHandler(this.jUGARToolStripMenuItem_Click);
            // 
            // vERTOPSToolStripMenuItem
            // 
            this.vERTOPSToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.vERTOPSToolStripMenuItem.Name = "vERTOPSToolStripMenuItem";
            this.vERTOPSToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.vERTOPSToolStripMenuItem.Text = "Ver TOPS";
            // 
            // crearPreguntaToolStripMenuItem
            // 
            this.crearPreguntaToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.crearPreguntaToolStripMenuItem.Name = "crearPreguntaToolStripMenuItem";
            this.crearPreguntaToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.crearPreguntaToolStripMenuItem.Text = "Crear Pregunta";
            this.crearPreguntaToolStripMenuItem.Click += new System.EventHandler(this.crearPreguntaToolStripMenuItem_Click);
            // 
            // cerrarSesionToolStripMenuItem
            // 
            this.cerrarSesionToolStripMenuItem.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cerrarSesionToolStripMenuItem.Name = "cerrarSesionToolStripMenuItem";
            this.cerrarSesionToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.cerrarSesionToolStripMenuItem.Text = "Cerrar Sesion";
            this.cerrarSesionToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesionToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(102, 17);
            this.toolStripStatusLabel.Text = "Sesion no iniciada";
            // 
            // MDItest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDItest";
            this.Text = "MDItest";
            this.Load += new System.EventHandler(this.MDItest_Load);
            this.EnabledChanged += new System.EventHandler(this.MDItest_EnabledChanged);
            this.VisibleChanged += new System.EventHandler(this.MDItest_VisibleChanged);
            this.Enter += new System.EventHandler(this.MDItest_Enter);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolTip toolTip;
        public System.Windows.Forms.ToolStripMenuItem cerrarSesionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem jUGARToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem iniciarSesionToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem vERTOPSToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem crearPreguntaToolStripMenuItem;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}



