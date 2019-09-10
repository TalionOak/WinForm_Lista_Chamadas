namespace Lista_de_Chamadas
{
    partial class FormLista
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnMinimar = new System.Windows.Forms.Button();
            this.btnFecharTudo = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRa = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtNomeLista = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvListaChamada = new System.Windows.Forms.DataGridView();
            this.txtDataCriacao = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaChamada)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(13, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Lista de Chamada";
            // 
            // btnMinimar
            // 
            this.btnMinimar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMinimar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMinimar.Location = new System.Drawing.Point(506, 3);
            this.btnMinimar.Name = "btnMinimar";
            this.btnMinimar.Size = new System.Drawing.Size(21, 23);
            this.btnMinimar.TabIndex = 6;
            this.btnMinimar.TabStop = false;
            this.btnMinimar.Text = "_";
            this.btnMinimar.UseVisualStyleBackColor = false;
            this.btnMinimar.Click += new System.EventHandler(this.BtnMinimar_Click);
            // 
            // btnFecharTudo
            // 
            this.btnFecharTudo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFecharTudo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFecharTudo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFecharTudo.Location = new System.Drawing.Point(533, 3);
            this.btnFecharTudo.Name = "btnFecharTudo";
            this.btnFecharTudo.Size = new System.Drawing.Size(21, 23);
            this.btnFecharTudo.TabIndex = 5;
            this.btnFecharTudo.TabStop = false;
            this.btnFecharTudo.Text = "X";
            this.btnFecharTudo.UseVisualStyleBackColor = false;
            this.btnFecharTudo.Click += new System.EventHandler(this.BtnFecharTudo_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 28);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "R.A";
            // 
            // txtRa
            // 
            this.txtRa.Location = new System.Drawing.Point(16, 98);
            this.txtRa.Name = "txtRa";
            this.txtRa.Size = new System.Drawing.Size(100, 20);
            this.txtRa.TabIndex = 1;
            this.txtRa.Text = " ";
            this.txtRa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtRa_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(122, 98);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(264, 20);
            this.txtNome.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nome";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(403, 95);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.BtnAdicionar_Click);
            // 
            // txtNomeLista
            // 
            this.txtNomeLista.Location = new System.Drawing.Point(16, 59);
            this.txtNomeLista.Name = "txtNomeLista";
            this.txtNomeLista.Size = new System.Drawing.Size(200, 20);
            this.txtNomeLista.TabIndex = 14;
            this.txtNomeLista.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Nome da Lista de Chamada";
            // 
            // dgvListaChamada
            // 
            this.dgvListaChamada.AllowUserToAddRows = false;
            this.dgvListaChamada.AllowUserToOrderColumns = true;
            this.dgvListaChamada.AllowUserToResizeColumns = false;
            this.dgvListaChamada.AllowUserToResizeRows = false;
            this.dgvListaChamada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaChamada.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvListaChamada.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaChamada.Location = new System.Drawing.Point(0, 124);
            this.dgvListaChamada.MultiSelect = false;
            this.dgvListaChamada.Name = "dgvListaChamada";
            this.dgvListaChamada.ReadOnly = true;
            this.dgvListaChamada.RowHeadersVisible = false;
            this.dgvListaChamada.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListaChamada.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaChamada.ShowCellErrors = false;
            this.dgvListaChamada.ShowCellToolTips = false;
            this.dgvListaChamada.ShowEditingIcon = false;
            this.dgvListaChamada.ShowRowErrors = false;
            this.dgvListaChamada.Size = new System.Drawing.Size(555, 245);
            this.dgvListaChamada.TabIndex = 15;
            this.dgvListaChamada.TabStop = false;
            // 
            // txtDataCriacao
            // 
            this.txtDataCriacao.Location = new System.Drawing.Point(222, 59);
            this.txtDataCriacao.Name = "txtDataCriacao";
            this.txtDataCriacao.Size = new System.Drawing.Size(86, 20);
            this.txtDataCriacao.TabIndex = 17;
            this.txtDataCriacao.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Data criação lista";
            // 
            // FormLista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(555, 369);
            this.Controls.Add(this.txtDataCriacao);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvListaChamada);
            this.Controls.Add(this.txtNomeLista);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtRa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinimar);
            this.Controls.Add(this.btnFecharTudo);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLista";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista";
            this.Load += new System.EventHandler(this.FormLista_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaChamada)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMinimar;
        private System.Windows.Forms.Button btnFecharTudo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRa;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.TextBox txtNomeLista;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvListaChamada;
        private System.Windows.Forms.TextBox txtDataCriacao;
        private System.Windows.Forms.Label label5;
    }
}