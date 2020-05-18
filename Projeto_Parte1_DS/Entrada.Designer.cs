namespace UI_Projeto_Parte1_DS
{
    partial class Entrada
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_entrada = new System.Windows.Forms.Button();
            this.btn_cadastre = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI_Projeto_Parte1_DS.Properties.Resources.apple3;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(337, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.textBox1.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(377, 113);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 184);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = " \"Às vezes, quando você inova, você comete erros. É melhor admiti-los rapidamente" +
    ", e seguir em frente para melhorar suas outras inovações.”";
            // 
            // btn_entrada
            // 
            this.btn_entrada.BackColor = System.Drawing.Color.GreenYellow;
            this.btn_entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_entrada.Location = new System.Drawing.Point(377, 322);
            this.btn_entrada.Name = "btn_entrada";
            this.btn_entrada.Size = new System.Drawing.Size(75, 23);
            this.btn_entrada.TabIndex = 2;
            this.btn_entrada.Text = "ENTRAR ";
            this.btn_entrada.UseVisualStyleBackColor = false;
            this.btn_entrada.Click += new System.EventHandler(this.btn_entrada_Click);
            // 
            // btn_cadastre
            // 
            this.btn_cadastre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_cadastre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cadastre.Location = new System.Drawing.Point(475, 322);
            this.btn_cadastre.Name = "btn_cadastre";
            this.btn_cadastre.Size = new System.Drawing.Size(110, 23);
            this.btn_cadastre.TabIndex = 3;
            this.btn_cadastre.Text = "CADASTRAR-SE";
            this.btn_cadastre.UseVisualStyleBackColor = false;
            this.btn_cadastre.Click += new System.EventHandler(this.btn_cadastre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mongolian Baiti", 12.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "ENTRE OU CADASTRE-SE \r\n           NA APPLE";
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(614, 418);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_cadastre);
            this.Controls.Add(this.btn_entrada);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Entrada";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_entrada;
        private System.Windows.Forms.Button btn_cadastre;
        private System.Windows.Forms.Label label1;
    }
}

