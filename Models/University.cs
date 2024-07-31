using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace webapi.Models
{
    public class University
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public long UniversityId { get; set; }
        [Column(TypeName = "NVARCHAR(50)")]
        public string UniversityName { get; set; } = "";
        [Column(TypeName = "NVARCHAR(50)")] 
        public string location { get; set; } = "";
     
        public int EstablishedYear { get; set; }
    }
}
