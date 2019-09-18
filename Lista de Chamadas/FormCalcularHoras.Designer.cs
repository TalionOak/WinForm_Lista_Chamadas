namespace Lista_de_Chamadas
{
    partial class FormCalcularHoras
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
            this.dgvListaChamada = new System.Windows.Forms.DataGridView();
            this.mc = new System.Windows.Forms.MonthCalendar();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.txtHoras = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaChamada)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(14, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Calcular hora aula";
            // 
            // btnMinimar
            // 
            this.btnMinimar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnMinimar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnMinimar.Location = new System.Drawing.Point(570, 3);
            this.btnMinimar.Name = "btnMinimar";
            this.btnMinimar.Size = new System.Drawing.Size(21, 23);
            this.btnMinimar.TabIndex = 10;
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
            this.btnFecharTudo.Location = new System.Drawing.Point(594, 3);
            this.btnFecharTudo.Name = "btnFecharTudo";
            this.btnFecharTudo.Size = new System.Drawing.Size(21, 23);
            this.btnFecharTudo.TabIndex = 9;
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
            this.pictureBox1.Size = new System.Drawing.Size(618, 28);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PictureBox1_MouseUp);
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
            this.dgvListaChamada.Size = new System.Drawing.Size(618, 239);
            this.dgvListaChamada.TabIndex = 16;
            this.dgvListaChamada.TabStop = false;
            // 
            // mc
            // 
            this.mc.Location = new System.Drawing.Point(14, 37);
            this.mc.MaxSelectionCount = 500;
            this.mc.Name = "mc";
            this.mc.TabIndex = 17;
            this.mc.TabStop = false;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Location = new System.Drawing.Point(456, 156);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 2;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.BtnCalcular_ClickAsync);
            // 
            // txtHoras
            // 
            this.txtHoras.Location = new System.Drawing.Point(326, 146);
            this.txtHoras.Name = "txtHoras";
            this.txtHoras.Size = new System.Drawing.Size(54, 20);
            this.txtHoras.TabIndex = 1;
            this.txtHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtHoras_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Quantas horas vale cada aula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(264, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Selecione os dias para estar calculando";
            // 
            // FormCalcularHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(618, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHoras);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.mc);
            this.Controls.Add(this.dgvListaChamada);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMinimar);
            this.Controls.Add(this.btnFecharTudo);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCalcularHoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "t";
            this.Load += new System.EventHandler(this.FormCalcularHoras_Load);
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
        private System.Windows.Forms.DataGridView dgvListaChamada;
        private System.Windows.Forms.MonthCalendar mc;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox txtHoras;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
    }
}