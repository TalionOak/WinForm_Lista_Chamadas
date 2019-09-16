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
            List<ListaChamada> searchResult = await ModuloBanco.ListaChamadaColecao.Find(
                        x => x.DataCriacao >= min &&
                        x.DataCriacao <= max
                        ).ToListAsync();
            dgvListaChamada.DataSource = searchResult;

            //var now = DateTime.UtcNow;
            //var currentDate = now.Date;
            //var tomorrow = currentDate.AddDays(1);
            //var left = currentDate.ToUnixTimeSeconds();
            //var right = tomorrow.ToUnixTimeSeconds();

            //var results = await Settings.DataBase.GetCollection<Video>("Videos")
            //        .Find(x => x.ViewsToday != null &&
            //              x.ViewsToday.Date >= left &&
            //              x.ViewsToday.Date < right)
            //            .ToListAsync();
        }
    }
}
