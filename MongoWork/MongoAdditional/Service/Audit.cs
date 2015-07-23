using System;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoWork.MongoAdditional.Service
{
    public class Audit
    {
        /// <summary>
        /// Ид записи
        /// </summary>
        [BsonId]
        public ObjectId Id { get; set; }

        /// <summary>
        /// Дата операции
        /// </summary>
        public DateTime DateOperation { get; set; }

        /// <summary>
        /// Операция
        /// </summary>
        public string Operation { get; set; }
    }
}