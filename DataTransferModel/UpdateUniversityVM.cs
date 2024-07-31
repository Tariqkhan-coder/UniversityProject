namespace webapi.DataTransferModel
{
    public class UpdateUniversityVM
    {
        public long UniversityId { get; set; }
        public string UniversityName { get; set; } = "";
        public string location { get; set; } = "";
        public int EstablishedYear { get; set; }
    }
}
