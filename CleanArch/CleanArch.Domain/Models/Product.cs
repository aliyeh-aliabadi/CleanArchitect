using CleanArch.Domain.Models.Base;

namespace CleanArch.Domain.Models
{
    public class Product : Entity
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
    }
}
