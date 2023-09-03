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
    public class User : IUser
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; } = string.Empty;
        [BsonElement("username")]
        public string Username { get; set; } = string.Empty;
        [BsonElement("firstName")]
        public string FirstName { get; set; } = string.Empty;
        [BsonElement("lastName")] 
        public string LastName { get; set;} = string.Empty;
        [BsonElement("email")]
        public string Email { get; set; } = string.Empty;

        public User() { }

    }
}
