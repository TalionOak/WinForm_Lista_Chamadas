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
        public FormLista()
        {
            InitializeComponent();
        }
        private void BtnFecharTudo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnMinimar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        BindingList<Aluno> alunos;
        ListaChamada chamada;
        private void FormLista_Load(object sender, EventArgs e)
        {
            alunos = new BindingList<Aluno>();
            dgvListaChamada.DataSource = alunos;
            chamada = new ListaChamada()
            {
                Id = new ObjectId(),
                ListaRA = new List<ulong>(),
            };

            try
            {
                ModuloBanco.ListaChamadaAdd(chamada);
            }
            catch
            {
                MessageBox.Show("Aconteceu um erro no banco de dados!!");
                Application.Exit();
            }
        }




        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
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

            Aluno aluno = new Aluno()
            {
                Nome = txtNome.Text,
                RA = Convert.ToUInt64(txtRa.Text)
            };

            alunos.Add(aluno);

            txtRa.Clear();
            txtNome.Clear();
            txtRa.Focus();
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
    }
}
