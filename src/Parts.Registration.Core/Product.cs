using System;

namespace Parts.Registration.Core
{
    public class Product : BaseEntity<Guid>
    {
        public Product(string name, string description, string partNumber,
                       Guid providerId, string createdBy)
        {
            this.Name = name.Trim();
            this.Description = description.Trim();
            this.PartNumber = partNumber.Trim();
            this.ProviderId = providerId;
            this.CreatedBy = createdBy.Trim();
            this.Id = Guid.NewGuid();
            this.CreationDate = DateTime.Now;
            this.LastUpdate = DateTime.Now;
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string PartNumber { get; set; }
        public Guid ProviderId { get; set; }
    }
}
