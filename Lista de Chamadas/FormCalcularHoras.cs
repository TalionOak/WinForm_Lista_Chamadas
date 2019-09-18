using Lista_de_Chamadas.Classes;
using MongoDB.Driver;
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
    public partial class FormCalcularHoras : Form
    {
        public FormCalcularHoras()
        {
            InitializeComponent();
        }

        private void FormCalcularHoras_Load(object sender, EventArgs e)
        {

        }

        private async void BtnCalcular_ClickAsync(object sender, EventArgs e)
        {
            var min = mc.SelectionStart;
            var max = mc.SelectionEnd;
            double.TryParse(txtHoras.Text, out double horas);
            this.UseWaitCursor = true;
            List<ListaChamada> ListaResultadoPesquisa = await ModuloBanco.ListaChamadaColecao.Find(
                        x => x.DataCriacao >= min &&
                        x.DataCriacao <= max
                        ).ToListAsync();

            Dictionary<ulong, ListaHoras> listahoras = new Dictionary<ulong, ListaHoras>();
            foreach (var listas in ListaResultadoPesquisa)
            {
                foreach (var alunoRA in listas.ListaRA)
                {
                    listahoras.TryGetValue(alunoRA, out ListaHoras listaPresensa);
                    var alunoNome = ModuloBanco.AlunoGet(alunoRA);
                    if (listaPresensa != null)
                    {
                        listaPresensa.Horas += horas;
                        listaPresensa.NomeAluno = alunoNome.Nome;
                        listaPresensa.RA = alunoRA;
                    }
                    else
                    {
                        ListaHoras alu = new ListaHoras();
                        alu.Horas = horas;
                        alu.NomeAluno = alunoNome.Nome;
                        alu.RA = alunoRA;
                        listahoras.Add(alunoRA, alu);
                    }
                }
            }
            dgvListaChamada.DataSource = listahoras.Values.ToList();
            this.UseWaitCursor = false;
        }

        private void BtnFecharTudo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        #region Arrastando Form
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
        #endregion

        private void TxtHoras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
