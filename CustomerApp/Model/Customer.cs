using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace CustomerApp.Model
{
    public class Customer
    {
        [BsonId]
        public int Id { get; set; }
        public Guid UserUid { get; set; } = new Guid();
        public string Name { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public DateTime UpdatedOn { get; set; } = DateTime.Now;
    }
}
