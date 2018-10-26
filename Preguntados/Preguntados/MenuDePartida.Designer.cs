namespace Preguntados
{
    partial class MenuDePartida
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
            this.lbPregunta = new System.Windows.Forms.Label();
            this.btnOpcion1 = new System.Windows.Forms.Button();
            this.btnOpcion2 = new System.Windows.Forms.Button();
            this.btnOpcion3 = new System.Windows.Forms.Button();
            this.btnOpcion4 = new System.Windows.Forms.Button();
            this.btnSalirDePartida = new System.Windows.Forms.Button();
            this.lbMensaje = new System.Windows.Forms.Label();
            this.btnSiguientePregunta = new System.Windows.Forms.Button();
            this.btnDenunciarPregunta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbPregunta
            // 
            this.lbPregunta.AutoSize = true;
            this.lbPregunta.Location = new System.Drawing.Point(176, 48);
            this.lbPregunta.Name = "lbPregunta";
            this.lbPregunta.Size = new System.Drawing.Size(50, 13);
            this.lbPregunta.TabIndex = 0;
            this.lbPregunta.Text = "Pregunta";
            // 
            // btnOpcion1
            // 
            this.btnOpcion1.Location = new System.Drawing.Point(166, 86);
            this.btnOpcion1.Name = "btnOpcion1";
            this.btnOpcion1.Size = new System.Drawing.Size(75, 23);
            this.btnOpcion1.TabIndex = 1;
            this.btnOpcion1.UseVisualStyleBackColor = true;
            // 
            // btnOpcion2
            // 
            this.btnOpcion2.Location = new System.Drawing.Point(166, 115);
            this.btnOpcion2.Name = "btnOpcion2";
            this.btnOpcion2.Size = new System.Drawing.Size(75, 23);
            this.btnOpcion2.TabIndex = 2;
            this.btnOpcion2.UseVisualStyleBackColor = true;
            // 
            // btnOpcion3
            // 
            this.btnOpcion3.Location = new System.Drawing.Point(166, 144);
            this.btnOpcion3.Name = "btnOpcion3";
            this.btnOpcion3.Size = new System.Drawing.Size(75, 23);
            this.btnOpcion3.TabIndex = 3;
            this.btnOpcion3.UseVisualStyleBackColor = true;
            // 
            // btnOpcion4
            // 
            this.btnOpcion4.Location = new System.Drawing.Point(166, 173);
            this.btnOpcion4.Name = "btnOpcion4";
            this.btnOpcion4.Size = new System.Drawing.Size(75, 23);
            this.btnOpcion4.TabIndex = 4;
            this.btnOpcion4.UseVisualStyleBackColor = true;
            // 
            // btnSalirDePartida
            // 
            this.btnSalirDePartida.Location = new System.Drawing.Point(288, 310);
            this.btnSalirDePartida.Name = "btnSalirDePartida";
            this.btnSalirDePartida.Size = new System.Drawing.Size(113, 23);
            this.btnSalirDePartida.TabIndex = 5;
            this.btnSalirDePartida.Text = "Salir de la partida";
            this.btnSalirDePartida.UseVisualStyleBackColor = true;
            // 
            // lbMensaje
            // 
            this.lbMensaje.AutoSize = true;
            this.lbMensaje.Location = new System.Drawing.Point(180, 216);
            this.lbMensaje.Name = "lbMensaje";
            this.lbMensaje.Size = new System.Drawing.Size(46, 13);
            this.lbMensaje.TabIndex = 6;
            this.lbMensaje.Text = "mensaje";
            // 
            // btnSiguientePregunta
            // 
            this.btnSiguientePregunta.Location = new System.Drawing.Point(112, 246);
            this.btnSiguientePregunta.Name = "btnSiguientePregunta";
            this.btnSiguientePregunta.Size = new System.Drawing.Size(194, 23);
            this.btnSiguientePregunta.TabIndex = 7;
            this.btnSiguientePregunta.Text = "Pasar a siguiente pregunta";
            this.btnSiguientePregunta.UseVisualStyleBackColor = true;
            this.btnSiguientePregunta.Visible = false;
            // 
            // btnDenunciarPregunta
            // 
            this.btnDenunciarPregunta.Location = new System.Drawing.Point(298, 129);
            this.btnDenunciarPregunta.Name = "btnDenunciarPregunta";
            this.btnDenunciarPregunta.Size = new System.Drawing.Size(75, 52);
            this.btnDenunciarPregunta.TabIndex = 8;
            this.btnDenunciarPregunta.Text = "Denunciar pregunta";
            this.btnDenunciarPregunta.UseVisualStyleBackColor = true;
            this.btnDenunciarPregunta.Visible = false;
            // 
            // MenuDePartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 345);
            this.Controls.Add(this.btnDenunciarPregunta);
            this.Controls.Add(this.btnSiguientePregunta);
            this.Controls.Add(this.lbMensaje);
            this.Controls.Add(this.btnSalirDePartida);
            this.Controls.Add(this.btnOpcion4);
            this.Controls.Add(this.btnOpcion3);
            this.Controls.Add(this.btnOpcion2);
            this.Controls.Add(this.btnOpcion1);
            this.Controls.Add(this.lbPregunta);
            this.Name = "MenuDePartida";
            this.Text = "MenuDePartida";
            this.Load += new System.EventHandler(this.MenuDePartida_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPregunta;
        private System.Windows.Forms.Button btnOpcion1;
        private System.Windows.Forms.Button btnOpcion2;
        private System.Windows.Forms.Button btnOpcion3;
        private System.Windows.Forms.Button btnOpcion4;
        private System.Windows.Forms.Button btnSalirDePartida;
        private System.Windows.Forms.Label lbMensaje;
        private System.Windows.Forms.Button btnSiguientePregunta;
        private System.Windows.Forms.Button btnDenunciarPregunta;
    }
}