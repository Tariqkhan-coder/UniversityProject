using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;




namespace webapi.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long EmpId {  get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public String Name { get; set; } = "";
        [Column(TypeName = "NVARCHAR(50)")]
        public string Title { get; set; } = "";
    }
}
