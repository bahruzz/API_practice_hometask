using System.ComponentModel.DataAnnotations;

namespace API_Practice.Models
{
    public class Book:BaseEntity
    {
        [StringLength(10)]
        public string Name { get; set; }
        public int Page { get; set; }
    }
}
