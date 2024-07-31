using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.DataTransferModel
{
    public class CreateDepartmentVM
    {

        public string DepartmentName { get; set; } = "";

        public string DepartDescription { get; set; } = "";

    }
}
