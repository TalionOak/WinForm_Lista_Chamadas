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
    public partial class FormLista : Form
    {
        public FormLista()
        {
            InitializeComponent();
        }

        private void FormLista_Load(object sender, EventArgs e)
        {
            List<Aluno> alunos = new List<Aluno>();
            dgvListaChamada.DataSource = alunos;
        }
    }
}
