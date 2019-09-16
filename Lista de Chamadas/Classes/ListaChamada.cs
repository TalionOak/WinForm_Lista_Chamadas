using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Chamadas.Classes
{
    public class ListaChamada
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public DateTime DataCriacao { get; set; }
        public string NomeLista { get; set; }
        public List<ulong> ListaRA { get; set; }
    }
}
