using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.DataTransferModel
{
    public class CreateEmployeeVM
    {
        public String Name { get; set; } = "";
   
        public string Title { get; set; } = "";
    }
}

