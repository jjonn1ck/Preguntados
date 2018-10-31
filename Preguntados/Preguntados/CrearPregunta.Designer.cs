namespace Preguntados
{
    partial class CrearPregunta
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
            this.btnCrear = new System.Windows.Forms.Button();
            this.txtOpcion1 = new System.Windows.Forms.TextBox();
            this.txtOpcion2 = new System.Windows.Forms.TextBox();
            this.txtOpcion3 = new System.Windows.Forms.TextBox();
            this.txtOpcion4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.rdOpcion2 = new System.Windows.Forms.RadioButton();
            this.rdOpcion1 = new System.Windows.Forms.RadioButton();
            this.rdOpcion4 = new System.Windows.Forms.RadioButton();
            this.rdOpcion3 = new System.Windows.Forms.RadioButton();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(99, 321);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 0;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // txtOpcion1
            // 
            this.txtOpcion1.Location = new System.Drawing.Point(186, 136);
            this.txtOpcion1.Name = "txtOpcion1";
            this.txtOpcion1.Size = new System.Drawing.Size(232, 20);
            this.txtOpcion1.TabIndex = 1;
            // 
            // txtOpcion2
            // 
            this.txtOpcion2.Location = new System.Drawing.Point(186, 177);
            this.txtOpcion2.Name = "txtOpcion2";
            this.txtOpcion2.Size = new System.Drawing.Size(232, 20);
            this.txtOpcion2.TabIndex = 2;
            // 
            // txtOpcion3
            // 
            this.txtOpcion3.Location = new System.Drawing.Point(186, 219);
            this.txtOpcion3.Name = "txtOpcion3";
            this.txtOpcion3.Size = new System.Drawing.Size(232, 20);
            this.txtOpcion3.TabIndex = 3;
            // 
            // txtOpcion4
            // 
            this.txtOpcion4.Location = new System.Drawing.Point(186, 266);
            this.txtOpcion4.Name = "txtOpcion4";
            this.txtOpcion4.Size = new System.Drawing.Size(232, 20);
            this.txtOpcion4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Opcion 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 266);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Opcion 4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Opcion 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Opcion 2";
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(186, 55);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(232, 20);
            this.txtPregunta.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pregunta";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Location = new System.Drawing.Point(96, 97);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(52, 13);
            this.label77.TabIndex = 11;
            this.label77.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(186, 97);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(116, 21);
            this.cmbCategoria.TabIndex = 12;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // rdOpcion2
            // 
            this.rdOpcion2.AutoSize = true;
            this.rdOpcion2.Location = new System.Drawing.Point(447, 177);
            this.rdOpcion2.Name = "rdOpcion2";
            this.rdOpcion2.Size = new System.Drawing.Size(65, 17);
            this.rdOpcion2.TabIndex = 13;
            this.rdOpcion2.TabStop = true;
            this.rdOpcion2.Text = "Correcta";
            this.rdOpcion2.UseVisualStyleBackColor = true;
            // 
            // rdOpcion1
            // 
            this.rdOpcion1.AutoSize = true;
            this.rdOpcion1.Location = new System.Drawing.Point(447, 137);
            this.rdOpcion1.Name = "rdOpcion1";
            this.rdOpcion1.Size = new System.Drawing.Size(65, 17);
            this.rdOpcion1.TabIndex = 14;
            this.rdOpcion1.TabStop = true;
            this.rdOpcion1.Text = "Correcta";
            this.rdOpcion1.UseVisualStyleBackColor = true;
            // 
            // rdOpcion4
            // 
            this.rdOpcion4.AutoSize = true;
            this.rdOpcion4.Location = new System.Drawing.Point(447, 267);
            this.rdOpcion4.Name = "rdOpcion4";
            this.rdOpcion4.Size = new System.Drawing.Size(65, 17);
            this.rdOpcion4.TabIndex = 15;
            this.rdOpcion4.TabStop = true;
            this.rdOpcion4.Text = "Correcta";
            this.rdOpcion4.UseVisualStyleBackColor = true;
            // 
            // rdOpcion3
            // 
            this.rdOpcion3.AutoSize = true;
            this.rdOpcion3.Location = new System.Drawing.Point(447, 219);
            this.rdOpcion3.Name = "rdOpcion3";
            this.rdOpcion3.Size = new System.Drawing.Size(65, 17);
            this.rdOpcion3.TabIndex = 16;
            this.rdOpcion3.TabStop = true;
            this.rdOpcion3.Text = "Correcta";
            this.rdOpcion3.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(326, 321);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // CrearPregunta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.rdOpcion3);
            this.Controls.Add(this.rdOpcion4);
            this.Controls.Add(this.rdOpcion1);
            this.Controls.Add(this.rdOpcion2);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.label77);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPregunta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtOpcion4);
            this.Controls.Add(this.txtOpcion3);
            this.Controls.Add(this.txtOpcion2);
            this.Controls.Add(this.txtOpcion1);
            this.Controls.Add(this.btnCrear);
            this.Name = "CrearPregunta";
            this.Text = "CrearPregunta";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CrearPregunta_FormClosed);
            this.Load += new System.EventHandler(this.CrearPregunta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtOpcion1;
        private System.Windows.Forms.TextBox txtOpcion2;
        private System.Windows.Forms.TextBox txtOpcion3;
        private System.Windows.Forms.TextBox txtOpcion4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.RadioButton rdOpcion2;
        private System.Windows.Forms.RadioButton rdOpcion1;
        private System.Windows.Forms.RadioButton rdOpcion4;
        private System.Windows.Forms.RadioButton rdOpcion3;
        private System.Windows.Forms.Button btnCancelar;
    }
}