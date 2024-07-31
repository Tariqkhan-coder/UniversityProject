using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class Department
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long DepartmentId { get; set; }
        [Column(TypeName = "NVARCHAR(50)")] 
        public string DepartmentName { get; set; } = "";
        [Column(TypeName = "NVARCHAR(50)")] 
        public string DepartDescription { get; set; } = "";
       



    }
}
