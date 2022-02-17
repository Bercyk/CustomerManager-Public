namespace CustomerManager.Domain.DTOs
{
    public class CustomerDTO : EntityDTO
    {
        public string Name { get; set; }

        public string NIP { get; set; }

        public CustomerTypeDTO Type { get; set; }

        public string Description { get; set; }
        
        public bool Status { get; set; }
    }
}