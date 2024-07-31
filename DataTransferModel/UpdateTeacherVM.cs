namespace webapi.DataTransferModel
{
    public class UpdateTeacherVM
    {
        public long TeacherId { get; set; }
        public string TeacherName { get; set; } = "";

        public long CNIC { get; set; }
        public string Religion { get; set; } = "";
        public string Email { get; set; } = "";
        public string PhoneNumber { get; set; } = "";
    }
}
