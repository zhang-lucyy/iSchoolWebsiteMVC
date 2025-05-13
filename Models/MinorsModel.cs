namespace P3.Models
{
    // represents a course that students have to take for each minor
    public class Minor
    {
        public string title { get; set; }

        public string description { get; set; }

        public List<string> courses { get; set; }

        public string note { get; set; }

    }
    public class MinorsModel
    {
        public List<Minor> UgMinors { get; set; }

        public string pageTitle { get; set; }
    }
}
