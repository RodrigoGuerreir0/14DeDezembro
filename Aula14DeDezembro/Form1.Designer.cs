namespace Aula14DeDezembro
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
            this.BotaoLimpar = new System.Windows.Forms.Button();
            this.Menssagem1 = new System.Windows.Forms.Label();
            this.InputSenha = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BotaoLimpar
            // 
            this.BotaoLimpar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotaoLimpar.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoLimpar.ForeColor = System.Drawing.Color.Green;
            this.BotaoLimpar.Location = new System.Drawing.Point(352, 63);
            this.BotaoLimpar.Name = "BotaoLimpar";
            this.BotaoLimpar.Size = new System.Drawing.Size(85, 27);
            this.BotaoLimpar.TabIndex = 0;
            this.BotaoLimpar.Text = "limpar";
            this.BotaoLimpar.UseVisualStyleBackColor = false;
            this.BotaoLimpar.Click += new System.EventHandler(this.BotaoLimpar_Click);
            // 
            // Menssagem1
            // 
            this.Menssagem1.AutoSize = true;
            this.Menssagem1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menssagem1.Location = new System.Drawing.Point(61, 117);
            this.Menssagem1.Name = "Menssagem1";
            this.Menssagem1.Size = new System.Drawing.Size(0, 22);
            this.Menssagem1.TabIndex = 1;
            // 
            // InputSenha
            // 
            this.InputSenha.Location = new System.Drawing.Point(64, 67);
            this.InputSenha.Name = "InputSenha";
            this.InputSenha.Size = new System.Drawing.Size(248, 20);
            this.InputSenha.TabIndex = 2;
            this.InputSenha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.VerificarCaracter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 159);
            this.Controls.Add(this.InputSenha);
            this.Controls.Add(this.Menssagem1);
            this.Controls.Add(this.BotaoLimpar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BotaoLimpar;
        private System.Windows.Forms.Label Menssagem1;
        private System.Windows.Forms.TextBox InputSenha;
    }
}

