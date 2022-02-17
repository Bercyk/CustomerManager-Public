using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerManager.Model
{
    public class Customer : Entity
    {
        [MaxLength(50)][Required]
        public string Name { get; set; }

        [MaxLength(10)][Required]
        public string NIP { get; set; }

        [Required]
        public CustomerType Type { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }
        
        [Required]
        public bool Status { get; set; }
    }
}