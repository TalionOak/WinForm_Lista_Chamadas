using Lista_de_Chamadas.Classes;
using MongoDB.Bson;
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
    public partial class FormTodasAsListas : Form
    {
        public FormTodasAsListas()
        {
            InitializeComponent();
        }
        #region Movendo Form
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
        private void FormTodasAsListas_Load(object sender, EventArgs e)
        {
            List<ListaParaEditar> list = new List<ListaParaEditar>();
            dgvListaChamada.DataSource = list;
            dgvListaChamada.Columns[0].Visible = false;
        }

        private async void Mc_MouseUpAsync(object sender, MouseEventArgs e)
        {
            var min = mc.SelectionStart;
            var max = mc.SelectionEnd;
            this.UseWaitCursor = true;
            List<ListaChamada> ListaResultadoPesquisa = await ModuloBanco.ListaChamadaColecao.Find(
                        x => x.DataCriacao >= min &&
                        x.DataCriacao <= max
                        ).ToListAsync();

            List<ListaParaEditar> list = new List<ListaParaEditar>();
            foreach (var listas in ListaResultadoPesquisa)
            {
                ListaParaEditar l = new ListaParaEditar();
                l.Id = listas.Id;
                l.Alunos = listas.ListaRA.Count;
                l.Dia = listas.DataCriacao;
                l.Nome = listas.NomeLista;
                list.Add(l);
            }
            dgvListaChamada.DataSource = list;
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

        private async void BtnExcluir_ClickAsync(object sender, EventArgs e)
        {
            if (dgvListaChamada.CurrentRow != null && dgvListaChamada.Rows.Count > 0)
            {
                int selectedIndex = dgvListaChamada.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    ObjectId id = (ObjectId)dgvListaChamada.Rows[selectedIndex].Cells[0].Value;
                    if (MessageBox.Show("Você tem certeza que deseja deletar esta lista de chamada?", "Deletando lista...", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        ModuloBanco.ListaChamadaDel(id);
                        var min = mc.SelectionStart;
                        var max = mc.SelectionEnd;
                        this.UseWaitCursor = true;
                        List<ListaChamada> ListaResultadoPesquisa = await ModuloBanco.ListaChamadaColecao.Find(
                                    x => x.DataCriacao >= min &&
                                    x.DataCriacao <= max
                                    ).ToListAsync();

                        List<ListaParaEditar> list = new List<ListaParaEditar>();
                        foreach (var listas in ListaResultadoPesquisa)
                        {
                            ListaParaEditar l = new ListaParaEditar();
                            l.Id = listas.Id;
                            l.Alunos = listas.ListaRA.Count;
                            l.Dia = listas.DataCriacao;
                            l.Nome = listas.NomeLista;
                            list.Add(l);
                        }
                        dgvListaChamada.DataSource = list;
                        this.UseWaitCursor = false;
                    }
                    else
                        return;
                }
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            if (dgvListaChamada.CurrentRow != null && dgvListaChamada.Rows.Count > 0)
            {
                int selectedIndex = dgvListaChamada.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    ObjectId id = (ObjectId)dgvListaChamada.Rows[selectedIndex].Cells[0].Value;
                    new FormLista(true, id).ShowDialog();
                }
            }
        }
    }
}
