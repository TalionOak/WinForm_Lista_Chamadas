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

        public static void AlunoEdit(ulong ra, Aluno aluno)
            => AlunoColecao.ReplaceOne(x => x.RA == ra, aluno);

        public static void AlunoAdd(Aluno aluno)
        {
            Aluno tem = AlunoGet(aluno.RA);
            if (tem != null)
            {
                AlunoEdit(aluno.RA, aluno);
                return;
            }
            AlunoColecao.InsertOne(aluno);
        }

        #endregion

        #region CRUD ListaChama

        public static ListaChamada ListaChamadaGet(ObjectId id)
            => ListaChamadaColecao.Find(x => x.Id == id).FirstOrDefault();

        public static void ListaChamadaEdit(ObjectId id, ListaChamada lista)
            => ListaChamadaColecao.ReplaceOne(x => x.Id == id, lista);

        public static void ListaChamadaAdd(ListaChamada lista)
            => ListaChamadaColecao.InsertOne(lista);

        #endregion


    }
}
