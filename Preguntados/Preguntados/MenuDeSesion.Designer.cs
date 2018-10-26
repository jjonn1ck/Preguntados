namespace Preguntados
{
    partial class MenuDeSesion
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnCrearPartida = new System.Windows.Forms.Button();
            this.btnVerTops = new System.Windows.Forms.Button();
            this.btnCrearPregunta = new System.Windows.Forms.Button();
            this.btnDeslogearse = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PREGUNTADOS";
            // 
            // btnCrearPartida
            // 
            this.btnCrearPartida.Location = new System.Drawing.Point(125, 109);
            this.btnCrearPartida.Name = "btnCrearPartida";
            this.btnCrearPartida.Size = new System.Drawing.Size(138, 23);
            this.btnCrearPartida.TabIndex = 1;
            this.btnCrearPartida.Text = "Crear partida";
            this.btnCrearPartida.UseVisualStyleBackColor = true;
            // 
            // btnVerTops
            // 
            this.btnVerTops.Location = new System.Drawing.Point(125, 159);
            this.btnVerTops.Name = "btnVerTops";
            this.btnVerTops.Size = new System.Drawing.Size(138, 23);
            this.btnVerTops.TabIndex = 2;
            this.btnVerTops.Text = "Ver tops";
            this.btnVerTops.UseVisualStyleBackColor = true;
            // 
            // btnCrearPregunta
            // 
            this.btnCrearPregunta.Location = new System.Drawing.Point(125, 211);
            this.btnCrearPregunta.Name = "btnCrearPregunta";
            this.btnCrearPregunta.Size = new System.Drawing.Size(138, 23);
            this.btnCrearPregunta.TabIndex = 3;
            this.btnCrearPregunta.Text = "Crear pregunta";
            this.btnCrearPregunta.UseVisualStyleBackColor = true;
            this.btnCrearPregunta.Click += new System.EventHandler(this.btnCrearPregunta_Click);
            // 
            // btnDeslogearse
            // 
            this.btnDeslogearse.Location = new System.Drawing.Point(38, 315);
            this.btnDeslogearse.Name = "btnDeslogearse";
            this.btnDeslogearse.Size = new System.Drawing.Size(75, 23);
            this.btnDeslogearse.TabIndex = 4;
            this.btnDeslogearse.Text = "Deslogearse";
            this.btnDeslogearse.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(264, 315);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(121, 23);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir del juego";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 350);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnDeslogearse);
            this.Controls.Add(this.btnCrearPregunta);
            this.Controls.Add(this.btnVerTops);
            this.Controls.Add(this.btnCrearPartida);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCrearPartida;
        private System.Windows.Forms.Button btnVerTops;
        private System.Windows.Forms.Button btnCrearPregunta;
        private System.Windows.Forms.Button btnDeslogearse;
        private System.Windows.Forms.Button btnSalir;
    }
}

