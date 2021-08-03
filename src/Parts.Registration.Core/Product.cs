using System;

namespace Parts.Registration.Core
{
    public class Product : BaseEntity<Guid>
    {
        public Product(string name, string description, string partNumber, string createdBy)
        {
            this.Name = name.Trim();
            this.Description = description.Trim();
            this.PartNumber = partNumber.Trim();
            this.Id = Guid.NewGuid();
            this.CreationDate = DateTime.Now;
            this.LastUpdate = DateTime.Now;
            this.CreatedBy = createdBy.Trim();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public string PartNumber { get; set; }
    }
}
