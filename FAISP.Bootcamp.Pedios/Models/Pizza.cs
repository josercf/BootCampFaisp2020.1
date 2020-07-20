using MongoDB.Bson.Serialization.Attributes;

namespace FAISP.Bootcamp.Pedios.Models
{
    public class Pizza
    {
        public object _id { get; set; }

        [BsonElement("idPizza")]
        public int IdPizza { get; set; }

        [BsonElement("urlImagem")]
        public string UrlImagem { get; set; }

        [BsonElement("titulo")]
        public string Titulo { get; set; }

        [BsonElement("descricao")]
        public string Descricao { get; set; }

        [BsonElement("valor")]
        public decimal Valor { get; set; }
    }
}