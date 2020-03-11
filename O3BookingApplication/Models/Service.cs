using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace O3BookingApp.DataModel
{
    public class Service
    {
       
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
       
        [BsonElement("ServiceName")]
        public string ServiceName { get; set; }
        [BsonElement("Prize")]
        public float Prize { get; set; }
        [BsonElement("Duration")]
        public string Duration { get; set; }
        [BsonElement("Description")]
        public string Description { get; set; }
        [BsonElement("Image")]
        public string Image { get; set; }
    }
}
