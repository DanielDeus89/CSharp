namespace ContaPalavrasMaisDeCinco
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
            this.lblAdicionar = new System.Windows.Forms.Button();
            this.txtFrase = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAdicionar
            // 
            this.lblAdicionar.Location = new System.Drawing.Point(13, 13);
            this.lblAdicionar.Name = "lblAdicionar";
            this.lblAdicionar.Size = new System.Drawing.Size(154, 23);
            this.lblAdicionar.TabIndex = 0;
            this.lblAdicionar.Text = "Adicionar";
            this.lblAdicionar.UseVisualStyleBackColor = true;
            this.lblAdicionar.Click += new System.EventHandler(this.lblAdicionar_Click);
            // 
            // txtFrase
            // 
            this.txtFrase.Location = new System.Drawing.Point(13, 43);
            this.txtFrase.Name = "txtFrase";
            this.txtFrase.Size = new System.Drawing.Size(154, 20);
            this.txtFrase.TabIndex = 1;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(173, 50);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(247, 13);
            this.lblResultado.TabIndex = 2;
            this.lblResultado.Text = "Quantidade de palavras com mais de 5 caracteres:";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(173, 13);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(154, 23);
            this.btnVerificar.TabIndex = 3;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 102);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtFrase);
            this.Controls.Add(this.lblAdicionar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lblAdicionar;
        private System.Windows.Forms.TextBox txtFrase;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btnVerificar;
    }
}

