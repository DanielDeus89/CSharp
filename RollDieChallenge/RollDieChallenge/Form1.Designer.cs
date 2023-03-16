namespace RollDieChallenge
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
            this.btnRollDie = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtDados = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFaces = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnRollDie
            // 
            this.btnRollDie.Location = new System.Drawing.Point(13, 36);
            this.btnRollDie.Name = "btnRollDie";
            this.btnRollDie.Size = new System.Drawing.Size(183, 23);
            this.btnRollDie.TabIndex = 0;
            this.btnRollDie.Text = "Lançar Dados";
            this.btnRollDie.UseVisualStyleBackColor = true;
            this.btnRollDie.Click += new System.EventHandler(this.btnRollDie_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(10, 62);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(0, 13);
            this.lblOutput.TabIndex = 1;
            // 
            // txtDados
            // 
            this.txtDados.Location = new System.Drawing.Point(202, 36);
            this.txtDados.Name = "txtDados";
            this.txtDados.Size = new System.Drawing.Size(151, 20);
            this.txtDados.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Infome a quantidade de dados.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Infome a quantidade de faces.";
            // 
            // txtFaces
            // 
            this.txtFaces.Location = new System.Drawing.Point(362, 36);
            this.txtFaces.Name = "txtFaces";
            this.txtFaces.Size = new System.Drawing.Size(151, 20);
            this.txtFaces.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFaces);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDados);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnRollDie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRollDie;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFaces;
    }
}

