namespace RandomInt
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.showOutputButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // showOutputButton
            // 
            this.showOutputButton.Location = new System.Drawing.Point(15, 12);
            this.showOutputButton.Name = "showOutputButton";
            this.showOutputButton.Size = new System.Drawing.Size(222, 23);
            this.showOutputButton.TabIndex = 0;
            this.showOutputButton.Text = "Show Output";
            this.showOutputButton.UseVisualStyleBackColor = true;
            this.showOutputButton.Click += new System.EventHandler(this.showOutputButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(12, 66);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 180);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.showOutputButton);
            this.Name = "Form1";
            this.Text = "RandomInt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showOutputButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

