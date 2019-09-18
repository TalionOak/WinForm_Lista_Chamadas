using Lista_de_Chamadas.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_Chamadas
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {
            ModuloBanco m = new ModuloBanco();
        }

        private void BtnNova_Click(object sender, EventArgs e)
        {
            new FormLista(false).ShowDialog();
        }

        private void BtnMinimar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnFecharTudo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        Point ArrastarCursor;
        Point ArrastarForm;
        bool Arrastando;
        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastando = false;
        }

        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            Arrastando = true;
            ArrastarCursor = Cursor.Position;
            ArrastarForm = this.Location;
        }

        private void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Arrastando)
            {
                Point diferenca = Point.Subtract(Cursor.Position, new Size(ArrastarCursor));
                this.Location = Point.Add(ArrastarForm, new Size(diferenca));
            }
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            new FormCalcularHoras().ShowDialog();
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            new FormTodasAsListas().ShowDialog();
        }
    }
}
