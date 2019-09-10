using MongoDB.Bson;
using MongoDB.Bson.Serialization;
using MongoDB.Bson.Serialization.Options;
using MongoDB.Bson.Serialization.Serializers;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista_de_Chamadas.Classes
{
    public class ModuloBanco
    {
        public static IMongoDatabase Database { get; private set; }

        public static IMongoCollection<Aluno> AlunoColecao { get; private set; }
        public static IMongoCollection<ListaChamada> ListaChamadaColecao { get; private set; }

        public ModuloBanco()
        {
            IMongoClient _client = new MongoClient("mongodb://localhost");
            Database = _client.GetDatabase("ListaDeChamadas");

            AlunoColecao = Database.GetCollection<Aluno>("alunos");
            ListaChamadaColecao = Database.GetCollection<ListaChamada>("listachamadas");
        }


        #region CRUD Aluno

        public static Aluno AlunoGet(ulong ra)
            => AlunoColecao.Find(x => x.RA == ra).FirstOrDefault();

        public static void AlunoEdit(ulong ra)
            => AlunoColecao.ReplaceOne(x => x.RA == ra, AlunoGet(ra));

        #endregion

        #region CRUD ListaChama

        //public static ListaChamada ListaChamadaGet(ulong ra)
        //    => ListaChamadaColecao.Find(x => x.RA == ra).FirstOrDefault();

        //public static void AlunoEdit(ulong ra)
        //    => AlunoColecao.ReplaceOne(x => x.RA == ra, AlunoGet(ra));

        #endregion


    }
}
