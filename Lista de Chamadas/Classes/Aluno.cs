using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Chamadas.Classes
{
    public class Aluno
    {
        [BsonId]
        public ulong RA { get; set; }
        public string Nome { get; set; }
    }
}
