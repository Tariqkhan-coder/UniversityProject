using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class Teacher
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public long TeacherId { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public string TeacherName { get; set; } = "";
       
        [Column(TypeName = "NVARCHAR(50)")] 
        public string CNIC { get; set; } = "";
        [Column(TypeName = "NVARCHAR(50)")]
        public string Religion { get; set; } = "";
        [Column(TypeName = "NVARCHAR(50)")]
        public string Email { get; set; } = "";
        [Column(TypeName = "NVARCHAR(50)")]
        public string PhoneNumber { get; set; } = "";
    }
}
