namespace BingTranslatorAPI
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
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
            this.btnTraducir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOriginal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTraducido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnTraducir
            // 
            this.btnTraducir.Location = new System.Drawing.Point(110, 64);
            this.btnTraducir.Name = "btnTraducir";
            this.btnTraducir.Size = new System.Drawing.Size(75, 23);
            this.btnTraducir.TabIndex = 0;
            this.btnTraducir.Text = "Traducir";
            this.btnTraducir.UseVisualStyleBackColor = true;
            this.btnTraducir.Click += new System.EventHandler(this.btnTraducir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Texto en español:";
            // 
            // txtOriginal
            // 
            this.txtOriginal.Location = new System.Drawing.Point(110, 6);
            this.txtOriginal.Multiline = true;
            this.txtOriginal.Name = "txtOriginal";
            this.txtOriginal.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOriginal.Size = new System.Drawing.Size(338, 52);
            this.txtOriginal.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Texto en inglés:";
            // 
            // txtTraducido
            // 
            this.txtTraducido.Location = new System.Drawing.Point(110, 105);
            this.txtTraducido.Multiline = true;
            this.txtTraducido.Name = "txtTraducido";
            this.txtTraducido.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtTraducido.Size = new System.Drawing.Size(338, 52);
            this.txtTraducido.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 262);
            this.Controls.Add(this.txtTraducido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOriginal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTraducir);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bing Translator API v2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTraducir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOriginal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTraducido;
    }
}

