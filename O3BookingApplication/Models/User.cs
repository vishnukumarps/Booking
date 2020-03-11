using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace O3BookingApplication.Models
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("Id")]
        public string Id { get; set; }
        [BsonElement("SerialNo")]
        public int SerailNo { get; set; }
        [BsonElement("Name")]
        public string Name { get; set; }
        [BsonElement("Email")]
        public string Email { get; set; }
        [BsonElement("PhNo")]
        public string PhNo { get; set; }
        [BsonElement("Service")]
        public string Service { get; set; }
        [BsonElement("Price")]
        public string Price { get; set; }
        [BsonElement("Duration")]
        public string Duration { get; set; }
        [BsonElement("Date")]
        public DateTime Date { get; set; }
    }
}
