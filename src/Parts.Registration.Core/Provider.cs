using System;
namespace Parts.Registration.Core
{
    public class Provider : BaseEntity<Guid>
    {
        public Provider(string name, string alias, string createdBy)
        {
            this.Name = name.Trim();
            this.Alias = alias.Trim();
            this.CreatedBy = createdBy.Trim();
            this.Id = Guid.NewGuid();
            this.CreationDate = DateTime.Now;
            this.LastUpdate = DateTime.Now;
        }

        public string Name { get; set; }
        public string Alias { get; set; }
    }
}
