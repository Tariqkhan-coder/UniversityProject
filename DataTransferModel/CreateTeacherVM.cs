using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.DataTransferModel
{
    public class CreateTeacherVM
    {
        public string TeacherName { get; set; } = "";
     
        
        public string CNIC { get; set; } = "";
     
        public string Religion { get; set; } = "";
      
        public string Email { get; set; } = "";
       
        public string PhoneNumber { get; set; } = ""; 
    }
}
