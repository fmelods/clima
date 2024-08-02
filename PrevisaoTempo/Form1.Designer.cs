namespace PrevisaoTempo
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
            this.textBox1 = new System.Windows.Forms.Label();
            this.TBCidade = new System.Windows.Forms.TextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labNascerSol = new System.Windows.Forms.Label();
            this.labPorSol = new System.Windows.Forms.Label();
            this.labPressao = new System.Windows.Forms.Label();
            this.labVelocidadeVento = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.labTempAtual = new System.Windows.Forms.Label();
            this.labTempMax = new System.Windows.Forms.Label();
            this.labTempMin = new System.Windows.Forms.Label();
            this.labDetalhes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = true;
            this.textBox1.BackColor = System.Drawing.Color.Transparent;
            this.textBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(200, 114);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(67, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Cidade:";
            // 
            // TBCidade
            // 
            this.TBCidade.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBCidade.Location = new System.Drawing.Point(277, 111);
            this.TBCidade.Margin = new System.Windows.Forms.Padding(5);
            this.TBCidade.Name = "TBCidade";
            this.TBCidade.Size = new System.Drawing.Size(339, 31);
            this.TBCidade.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.ForeColor = System.Drawing.Color.White;
            this.btnPesquisar.Location = new System.Drawing.Point(662, 105);
            this.btnPesquisar.Margin = new System.Windows.Forms.Padding(5);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(125, 41);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(622, 218);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nascer do Sol:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(622, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pôr do Sol:";
            // 
            // labNascerSol
            // 
            this.labNascerSol.AutoSize = true;
            this.labNascerSol.BackColor = System.Drawing.Color.Transparent;
            this.labNascerSol.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labNascerSol.ForeColor = System.Drawing.Color.White;
            this.labNascerSol.Location = new System.Drawing.Point(751, 218);
            this.labNascerSol.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labNascerSol.Name = "labNascerSol";
            this.labNascerSol.Size = new System.Drawing.Size(39, 23);
            this.labNascerSol.TabIndex = 7;
            this.labNascerSol.Text = "N/A";
            // 
            // labPorSol
            // 
            this.labPorSol.AutoSize = true;
            this.labPorSol.BackColor = System.Drawing.Color.Transparent;
            this.labPorSol.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPorSol.ForeColor = System.Drawing.Color.White;
            this.labPorSol.Location = new System.Drawing.Point(725, 263);
            this.labPorSol.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labPorSol.Name = "labPorSol";
            this.labPorSol.Size = new System.Drawing.Size(39, 23);
            this.labPorSol.TabIndex = 8;
            this.labPorSol.Text = "N/A";
            // 
            // labPressao
            // 
            this.labPressao.AutoSize = true;
            this.labPressao.BackColor = System.Drawing.Color.Transparent;
            this.labPressao.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labPressao.ForeColor = System.Drawing.Color.White;
            this.labPressao.Location = new System.Drawing.Point(286, 263);
            this.labPressao.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labPressao.Name = "labPressao";
            this.labPressao.Size = new System.Drawing.Size(39, 23);
            this.labPressao.TabIndex = 12;
            this.labPressao.Text = "N/A";
            // 
            // labVelocidadeVento
            // 
            this.labVelocidadeVento.AutoSize = true;
            this.labVelocidadeVento.BackColor = System.Drawing.Color.Transparent;
            this.labVelocidadeVento.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labVelocidadeVento.ForeColor = System.Drawing.Color.White;
            this.labVelocidadeVento.Location = new System.Drawing.Point(270, 218);
            this.labVelocidadeVento.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labVelocidadeVento.Name = "labVelocidadeVento";
            this.labVelocidadeVento.Size = new System.Drawing.Size(39, 23);
            this.labVelocidadeVento.TabIndex = 11;
            this.labVelocidadeVento.Text = "N/A";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(200, 263);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Pressão:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(200, 218);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 23);
            this.label6.TabIndex = 9;
            this.label6.Text = "Vento:";
            // 
            // picIcon
            // 
            this.picIcon.BackColor = System.Drawing.Color.Transparent;
            this.picIcon.Location = new System.Drawing.Point(427, 236);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(77, 50);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picIcon.TabIndex = 13;
            this.picIcon.TabStop = false;
            // 
            // labTempAtual
            // 
            this.labTempAtual.AutoSize = true;
            this.labTempAtual.BackColor = System.Drawing.Color.Transparent;
            this.labTempAtual.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTempAtual.ForeColor = System.Drawing.Color.White;
            this.labTempAtual.Location = new System.Drawing.Point(313, 327);
            this.labTempAtual.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labTempAtual.Name = "labTempAtual";
            this.labTempAtual.Size = new System.Drawing.Size(39, 23);
            this.labTempAtual.TabIndex = 14;
            this.labTempAtual.Text = "N/A";
            // 
            // labTempMax
            // 
            this.labTempMax.AutoSize = true;
            this.labTempMax.BackColor = System.Drawing.Color.Transparent;
            this.labTempMax.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTempMax.ForeColor = System.Drawing.Color.White;
            this.labTempMax.Location = new System.Drawing.Point(577, 327);
            this.labTempMax.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labTempMax.Name = "labTempMax";
            this.labTempMax.Size = new System.Drawing.Size(39, 23);
            this.labTempMax.TabIndex = 15;
            this.labTempMax.Text = "N/A";
            // 
            // labTempMin
            // 
            this.labTempMin.AutoSize = true;
            this.labTempMin.BackColor = System.Drawing.Color.Transparent;
            this.labTempMin.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labTempMin.ForeColor = System.Drawing.Color.White;
            this.labTempMin.Location = new System.Drawing.Point(452, 327);
            this.labTempMin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labTempMin.Name = "labTempMin";
            this.labTempMin.Size = new System.Drawing.Size(39, 23);
            this.labTempMin.TabIndex = 16;
            this.labTempMin.Text = "N/A";
            // 
            // labDetalhes
            // 
            this.labDetalhes.AutoSize = true;
            this.labDetalhes.BackColor = System.Drawing.Color.Transparent;
            this.labDetalhes.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDetalhes.ForeColor = System.Drawing.Color.White;
            this.labDetalhes.Location = new System.Drawing.Point(427, 199);
            this.labDetalhes.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labDetalhes.Name = "labDetalhes";
            this.labDetalhes.Size = new System.Drawing.Size(77, 23);
            this.labDetalhes.TabIndex = 4;
            this.labDetalhes.Text = "Detalhes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PrevisaoTempo.Properties.Resources.desktop_wallpaper_blue_sky_clear_sky;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1333, 749);
            this.Controls.Add(this.labTempMin);
            this.Controls.Add(this.labTempMax);
            this.Controls.Add(this.labTempAtual);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.labPressao);
            this.Controls.Add(this.labVelocidadeVento);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labPorSol);
            this.Controls.Add(this.labNascerSol);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labDetalhes);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.TBCidade);
            this.Controls.Add(this.textBox1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textBox1;
        private System.Windows.Forms.TextBox TBCidade;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labNascerSol;
        private System.Windows.Forms.Label labPorSol;
        private System.Windows.Forms.Label labPressao;
        private System.Windows.Forms.Label labVelocidadeVento;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.Label labTempAtual;
        private System.Windows.Forms.Label labTempMax;
        private System.Windows.Forms.Label labTempMin;
        private System.Windows.Forms.Label labDetalhes;
    }
}

