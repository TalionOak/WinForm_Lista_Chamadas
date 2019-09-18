using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Chamadas.Classes
{
    public class ListaParaEditar
    {
        public ObjectId Id { get; set; }
        public string Nome { get; set; }
        public int Alunos { get; set; }
        public DateTime Dia { get; set; }
    }
}
