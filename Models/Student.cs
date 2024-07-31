using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]  
        public long StudentId { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public string FirstName { get; set; } = "";
        [Column(TypeName = "NVARCHAR(50)")]
        public string lastName { get; set; } = "";
        [Column(TypeName = "NVARCHAR(50)")] 
         public int Age { get; set; } 
        [Column(TypeName = "NVARCHAR(50)")] 
        public string CNIC { get; set; }= "";
        [Column(TypeName = "NVARCHAR(50)")]
        public string DateofBirth { get; set; } = "";
        [Column(TypeName = "NVARCHAR(50)")] 
        public string Religion { get; set; } = "";
        [Column(TypeName = "NVARCHAR(50)")]
        public string AdmissionDate { get; set; } = "";
        [Column(TypeName = "NVARCHAR(50)")]
        public string City { get; set; } = "";
        [Column(TypeName = "NVARCHAR(50)")]
        public string Country { get; set; }= "";
        [Column(TypeName = "NVARCHAR(50)")] 
        
        public string State { get; set; }= "";
        [Column(TypeName = "NVARCHAR(50)")]
        public string Email { get; set; } = "";
        [Column(TypeName = "NVARCHAR(50)")] 
        public string PhoneNumber { get; set; } = "";


    }
}
