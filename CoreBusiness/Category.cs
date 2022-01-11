using System.ComponentModel.DataAnnotations;

namespace CoreBusiness // Core Business - Основной бизнес
{
    public class Category
    {
        public int СategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Password { get; set; }
        public string Fullname { get; set; }
        public string Email { get; set; }
        public string Company { get; set; }
        public string Phone { get; set; }
    }
}