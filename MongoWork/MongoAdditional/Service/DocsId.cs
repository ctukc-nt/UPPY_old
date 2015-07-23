using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoWork.MongoAdditional.Service
{
    class DocsId
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string DocName { get; set; }

        public int DocId { get; set; }


    }
}
