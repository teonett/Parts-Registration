using System;

namespace Parts.Registration.Core
{
    public abstract class BaseEntity<TId>
    {
        public TId Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime LastUpdate { get; set; }
        public string CreatedBy { get; set; }
    }
}
