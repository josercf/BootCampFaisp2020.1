using FAISP.Bootcamp.Pedios.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FAISP.Bootcamp.Pedios.Servicos
{
    public class PedidoServico
    {
        private readonly IMongoDatabase mongoDatabase;

        public PedidoServico()
        {
            var client = new MongoClient("mongodb+srv://usr_db:tusNjCOkt2WdvgYY@cluster0.mbmrq.gcp.mongodb.net/<dbname>?retryWrites=true&w=majority");
            mongoDatabase = client.GetDatabase("PDVBootCamp");
        }

        public void FazerPedido(PedidoModel pedido)
        {
            pedido.DataCriacao = DateTime.Now;
            pedido.Status = "Pedido realizado";

            var collectionPedido = mongoDatabase.GetCollection<PedidoModel>("pedido");

            //gera um id incremental com base no número de registros da coleção;
            pedido.PedidoId = collectionPedido.Count(c => c.PedidoId != 0) + 1;

            //Insere o registro na base de dados;
            collectionPedido.InsertOne(pedido);
        }

        public List<PedidoModel> ListarPedidos()
        {
            var pedidoCollection = mongoDatabase.GetCollection<PedidoModel>("pedido");
            var pedidos = pedidoCollection.AsQueryable()
                            .Where(x => x.Status == "Pedido realizado")
                            .OrderBy(x => x.DataCriacao)
                            .ToList();

            return pedidos;
        }
    }
}
