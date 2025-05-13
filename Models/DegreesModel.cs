namespace P3.Models
{
    // represents ONE degree
    public class Degree
    {
        public string degreeName { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public List<string> concentrations { get; set; }

        // only for the available certificates in graduate section
        public List<string> availableCertificates { get; set; }
    }

    // represents the list of undergraduate and graduate degrees
    public class DegreesModel
    {
        public List<Degree> undergraduate {  get; set; }
        public List<Degree> graduate { get; set; }

        public string pageTitle { get; set; }
    }
}
