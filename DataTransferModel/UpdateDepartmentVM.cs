using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.DataTransferModel
{
    public class UpdateDepartmentVM
    {

        public long DepartmentId { get; set; }
        
        public string DepartmentName { get; set; } = "";
       
        public string DepartDescription { get; set; } = "";
    }
}
