using Lista_de_Chamadas.Classes;
using MongoDB.Bson;
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
    public partial class FormLista : Form
    {
        bool Editar = false;
        public FormLista(bool editar)
        {
            Editar = editar;
            InitializeComponent();
        }

        BindingList<Aluno> _Alunos;
        ListaChamada _ListaChamada;
        private void FormLista_Load(object sender, EventArgs e)
        {
            if (Editar)
            {
            }
            else
            {
                txtDataCriacao.Text = DateTime.Now.ToString();
                _ListaChamada = new ListaChamada()
                {
                    Id = ObjectId.GenerateNewId(),
                    DataCriacao = DateTime.Now,
                    NomeLista = "",
                    ListaRA = new List<ulong>(),
                };
                _Alunos = new BindingList<Aluno>();
                dgvListaChamada.DataSource = _Alunos;
                txtNomeLista.Focus();
            }
        }

        private void BtnCriar_Click(object sender, EventArgs e)
        {
            if (CheckTextBox(txtNomeLista))
            {
                MessageBox.Show("Você precisa adicionar um nome a lista de chamda antes!");
                return;
            }
            _ListaChamada.NomeLista = txtNomeLista.Text;
            ModuloBanco.ListaChamadaAdd(_ListaChamada);
            btnCriar.Visible = false;
            txtNomeLista.ReadOnly = true;
            txtRa.ReadOnly = false;
            txtNome.ReadOnly = false;
            btnAdicionar.Visible = true;
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            #region Checks
            if (CheckTextBox(txtNomeLista))
            {
                MessageBox.Show("Você precisa adicionar um nome a lista de chamda antes!");
                return;
            }

            if (CheckTextBox(txtRa))
            {
                MessageBox.Show("Você precisa colocar um RA!");
                return;
            }

            if (CheckTextBox(txtNome))
            {
                MessageBox.Show("Você precisa colocar um nome!");
                return;
            }
            #endregion
            Aluno aluno = new Aluno()
            {
                Nome = txtNome.Text,
                RA = Convert.ToUInt64(txtRa.Text)
            };
            foreach (var item in _Alunos)
            {
                if (item.RA == aluno.RA)
                {
                    MessageBox.Show("RA já adicionado na lista!");
                    return;
                }
            }
            _Alunos.Add(aluno);
            _ListaChamada.ListaRA.Add(aluno.RA);
            ModuloBanco.AlunoAdd(aluno);
            ModuloBanco.ListaChamadaEdit(_ListaChamada.Id, _ListaChamada);
            txtNome.Clear();
            txtRa.Focus();
            txtRa.Clear();
        }

        public bool CheckTextBox(TextBox textBox)
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
                return true;
            return false;
        }

        private void TxtRa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        #region Controles do Form
        private void BtnFecharTudo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnMinimar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

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

        private void DgvListaChamada_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (dgvListaChamada.CurrentRow != null && dgvListaChamada.Rows.Count > 0)
                {
                    int selectedIndex = dgvListaChamada.CurrentCell.RowIndex;
                    if (selectedIndex > -1)
                    {
                        ulong ra = (ulong)dgvListaChamada.Rows[selectedIndex].Cells[0].Value;
                        foreach (var item in _Alunos)
                        {
                            if (item.RA == ra)
                            {
                                _Alunos.Remove(item);
                                _ListaChamada.ListaRA.Remove(item.RA);
                                ModuloBanco.ListaChamadaEdit(_ListaChamada.Id, _ListaChamada);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void TxtRa_Leave(object sender, EventArgs e)
        {
            Aluno aluno = ModuloBanco.AlunoGet(Convert.ToUInt32(txtRa.Text));
            if (aluno != null)
            {
                txtNome.Text = aluno.Nome;
                btnAdicionar.Focus();
            }
        }
    }
}
