namespace webapi.DataTransferModel
{
    public class UpdateStudentVM
    {
        public long StudentID { get; set; }
        public string FirstName { get; set; } = "";

        public string lastName { get; set; } = "";

        public int Age { get; set; }

        public string CNIC { get; set; } = "";

        public string DateofBirth { get; set; } = "";

        public string Religion { get; set; } = "";

        public string AdmissionDate { get; set; } = "";

        public string City { get; set; } = "";

        public string Country { get; set; } = "";


        public string State { get; set; } = "";

        public string Email { get; set; } = "";

        public string PhoneNumber { get; set; } = "";
    }
}
