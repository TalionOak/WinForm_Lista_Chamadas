namespace Lista_de_Chamadas
{
    partial class FormTodasAsListas
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
            this.mc = new System.Windows.Forms.MonthCalendar();
            this.dgvListaChamada = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaChamada)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(10, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Listas";
            // 
            // btnMinimar
            // 
            this.btnMinimar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMinimar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMinimar.Location = new System.Drawing.Point(337, 4);
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
            this.btnFecharTudo.Location = new System.Drawing.Point(362, 4);
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
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 28);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
            // 
            // mc
            // 
            this.mc.Location = new System.Drawing.Point(18, 37);
            this.mc.MaxSelectionCount = 500;
            this.mc.Name = "mc";
            this.mc.TabIndex = 18;
            this.mc.TabStop = false;
            this.mc.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Mc_MouseUpAsync);
            // 
            // dgvListaChamada
            // 
            this.dgvListaChamada.AllowUserToAddRows = false;
            this.dgvListaChamada.AllowUserToDeleteRows = false;
            this.dgvListaChamada.AllowUserToResizeColumns = false;
            this.dgvListaChamada.AllowUserToResizeRows = false;
            this.dgvListaChamada.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListaChamada.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListaChamada.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvListaChamada.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaChamada.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvListaChamada.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvListaChamada.Location = new System.Drawing.Point(0, 211);
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
            this.dgvListaChamada.Size = new System.Drawing.Size(385, 206);
            this.dgvListaChamada.TabIndex = 19;
            this.dgvListaChamada.TabStop = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExcluir.Location = new System.Drawing.Point(262, 82);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(101, 23);
            this.btnExcluir.TabIndex = 20;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_ClickAsync);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEditar.Location = new System.Drawing.Point(262, 138);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(101, 23);
            this.btnEditar.TabIndex = 21;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click);
            // 
            // FormTodasAsListas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(385, 417);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvListaChamada);
            this.Controls.Add(this.mc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinimar);
            this.Controls.Add(this.btnFecharTudo);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTodasAsListas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Todas as listas";
            this.Load += new System.EventHandler(this.FormTodasAsListas_Load);
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
        private System.Windows.Forms.MonthCalendar mc;
        private System.Windows.Forms.DataGridView dgvListaChamada;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
    }
}