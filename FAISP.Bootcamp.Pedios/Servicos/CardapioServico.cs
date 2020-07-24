using System.Collections.Generic;
using FAISP.Bootcamp.Pedios.Models;
using MongoDB.Driver;

namespace FAISP.Bootcamp.Pedios.Servicos
{
    public class CardapioServico
    {
        private readonly IMongoDatabase mongoDatabase;
        public CardapioServico()
        {
            var client = new MongoClient("mongodb+srv://usr_db:tusNjCOkt2WdvgYY@cluster0.mbmrq.gcp.mongodb.net/<dbname>?retryWrites=true&w=majority");
            mongoDatabase = client.GetDatabase("PDVBootCamp");
        }

        public List<Pizza> ListarCardapio()
        {
            var collection = mongoDatabase.GetCollection<Pizza>("cardapio");

            var cardapio = collection.AsQueryable().ToList();

            return cardapio;
        }

        public Pizza ObterPizza(int idPizza)
        {
            var collection = mongoDatabase.GetCollection<Pizza>("cardapio");
            var item = collection.Find(c => c.IdPizza == idPizza);


            return item.First();
        }
    }
}