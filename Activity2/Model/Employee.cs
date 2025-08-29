using System.ComponentModel.DataAnnotations;

namespace Activity2.Entities
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Position { get; set; } = string.Empty;
        public double Salary { get; set; } = 0;
        public string SSSNumber { get; set; } = string.Empty;
        public string PagIbigNumber { get; set; } = string.Empty;
        public bool IsDeleted { get; set; } = false;
    }
}
