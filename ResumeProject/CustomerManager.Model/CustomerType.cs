using System.ComponentModel.DataAnnotations;

namespace CustomerManager.Model
{
    public class CustomerType : Entity
    {
        [Required]
        public string Name { get; set; }
    }
}
