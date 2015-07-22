using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoWork.MongoAdditional
{
    class DocsId
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string DocName { get; set; }

        public int DocId { get; set; }


    }
}
