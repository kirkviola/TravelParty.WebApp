using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelParty.Domain.Entities;

namespace TravelParty.Infrastructure.Entities
{
    public class Trip : ITrip
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;
        [BsonElement("tripName")]
        public string TripName { get; set; } = string.Empty;
        [BsonElement("travellers")]
        [BsonRepresentation(BsonType.Array)]
        public IEnumerable<IUser>? Travellers { get; set; }
        [BsonElement("viewers")]
        [BsonRepresentation(BsonType.Array)]
        public IEnumerable<IUser>? Viewers { get; set; }

        public Trip() { }
    }
}
