namespace Lista_de_Chamadas
{
    partial class FormMenu
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
            this.btnFecharTudo = new System.Windows.Forms.Button();
            this.btnMinimar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNova = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 28);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // btnFecharTudo
            // 
            this.btnFecharTudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFecharTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharTudo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFecharTudo.Location = new System.Drawing.Point(532, 3);
            this.btnFecharTudo.Name = "btnFecharTudo";
            this.btnFecharTudo.Size = new System.Drawing.Size(21, 23);
            this.btnFecharTudo.TabIndex = 1;
            this.btnFecharTudo.TabStop = false;
            this.btnFecharTudo.Text = "X";
            this.btnFecharTudo.UseVisualStyleBackColor = false;
            this.btnFecharTudo.Click += new System.EventHandler(this.BtnFecharTudo_Click);
            // 
            // btnMinimar
            // 
            this.btnMinimar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMinimar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMinimar.Location = new System.Drawing.Point(507, 3);
            this.btnMinimar.Name = "btnMinimar";
            this.btnMinimar.Size = new System.Drawing.Size(21, 23);
            this.btnMinimar.TabIndex = 2;
            this.btnMinimar.TabStop = false;
            this.btnMinimar.Text = "_";
            this.btnMinimar.UseVisualStyleBackColor = false;
            this.btnMinimar.Click += new System.EventHandler(this.BtnMinimar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Menu";
            // 
            // btnNova
            // 
            this.btnNova.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNova.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNova.Location = new System.Drawing.Point(95, 86);
            this.btnNova.Name = "btnNova";
            this.btnNova.Size = new System.Drawing.Size(101, 23);
            this.btnNova.TabIndex = 8;
            this.btnNova.Text = "Nova lista";
            this.btnNova.UseVisualStyleBackColor = false;
            this.btnNova.Click += new System.EventHandler(this.BtnNova_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Location = new System.Drawing.Point(95, 57);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 23);
            this.btnEditar.TabIndex = 7;
            this.btnEditar.Text = "Todas as listas";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Location = new System.Drawing.Point(349, 73);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(101, 23);
            this.btnCalcular.TabIndex = 5;
            this.btnCalcular.Text = "Calcular horas";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(356, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Copyright Ailton Silva ®™  2019 - Infinito. Feita para a Prof. Simonia Fukue";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(555, 159);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNova);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinimar);
            this.Controls.Add(this.btnFecharTudo);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnFecharTudo;
        private System.Windows.Forms.Button btnMinimar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNova;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label2;
    }
}

