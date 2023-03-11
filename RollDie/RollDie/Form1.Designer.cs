namespace RollDie
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
            this.rollButton = new System.Windows.Forms.Button();
            this.dieLabel1 = new System.Windows.Forms.Label();
            this.dieLabel2 = new System.Windows.Forms.Label();
            this.dieLabel3 = new System.Windows.Forms.Label();
            this.dieLabel4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(295, 761);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(222, 90);
            this.rollButton.TabIndex = 0;
            this.rollButton.Text = "Roll";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // dieLabel1
            // 
            this.dieLabel1.Location = new System.Drawing.Point(24, 19);
            this.dieLabel1.Name = "dieLabel1";
            this.dieLabel1.Size = new System.Drawing.Size(325, 325);
            this.dieLabel1.TabIndex = 0;
            this.dieLabel1.Text = "label1";
            // 
            // dieLabel2
            // 
            this.dieLabel2.Location = new System.Drawing.Point(433, 19);
            this.dieLabel2.Name = "dieLabel2";
            this.dieLabel2.Size = new System.Drawing.Size(325, 325);
            this.dieLabel2.TabIndex = 2;
            this.dieLabel2.Text = "label2";
            this.dieLabel2.Click += new System.EventHandler(this.dieLabel2_Click);
            // 
            // dieLabel3
            // 
            this.dieLabel3.Location = new System.Drawing.Point(24, 393);
            this.dieLabel3.Name = "dieLabel3";
            this.dieLabel3.Size = new System.Drawing.Size(325, 325);
            this.dieLabel3.TabIndex = 3;
            this.dieLabel3.Text = "label3";
            // 
            // dieLabel4
            // 
            this.dieLabel4.Location = new System.Drawing.Point(433, 393);
            this.dieLabel4.Name = "dieLabel4";
            this.dieLabel4.Size = new System.Drawing.Size(325, 325);
            this.dieLabel4.TabIndex = 4;
            this.dieLabel4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 872);
            this.Controls.Add(this.dieLabel4);
            this.Controls.Add(this.dieLabel3);
            this.Controls.Add(this.dieLabel2);
            this.Controls.Add(this.dieLabel1);
            this.Controls.Add(this.rollButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button rollButton;
        private System.Windows.Forms.Label dieLabel1;
        private System.Windows.Forms.Label dieLabel2;
        private System.Windows.Forms.Label dieLabel3;
        private System.Windows.Forms.Label dieLabel4;
    }
}

