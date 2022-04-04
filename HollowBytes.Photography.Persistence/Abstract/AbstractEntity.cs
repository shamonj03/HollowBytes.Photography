using MongoDB.Bson;
using System;

namespace HollowBytes.Photography.Persistence.Interfaces
{
    public abstract class AbstractEntity
    {
        protected AbstractEntity()
        {
            Id = ObjectId.GenerateNewId();
        }

        public ObjectId Id { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}
