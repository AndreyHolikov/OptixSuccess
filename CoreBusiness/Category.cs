using System.ComponentModel.DataAnnotations;

namespace CoreBusiness // Core Business - Основной бизнес
{
    public class Category
    {
        public int СategoryId { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
    }
}