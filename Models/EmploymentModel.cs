namespace P3.Models
{
    // each intro paragraph of the content in the intro
    // either "Employment" or "Cooperative Education" sections
    public class Paragraph
    {
        public string title { get; set; }

        public string description { get; set; }
    }
    public class Introduction
    {
        public string title { get; set; }

        public List<Paragraph> content { get; set; }
    }

    // represents a statistic on degree statitics
    public class Statistic
    {
        public string value { get; set; }

        public string description { get; set; }

    }

    // list of statistics
    public class DegreeStatitics
    {
        public string title { get; set; }

        public List<Statistic> statistics { get; set; }

    }


    // list of employers
    public class Employers
    {
        public List<string> employerNames { get; set; }
    }

    // list of careers
    public class Careers
    {
        public List<string> careerNames { get; set; }
    }

    // represents one coop on the coop table
    public class Coop
    {
        public string employer { get; set; }
        
        public string degree { get; set; }

        public string city { get; set; }

        public string term { get; set; }

    }

    public class CoopTable
    {
        public List<Coop> coopInformation { get; set; }
    }

    // represents an employer in the employerstable
    public class Employer
    {
        public string employer {  get; set; }

        public string degree { get; set; }

        public string city { get; set; }

        public string title { get; set; }

        public string startDate { get; set; }
    }

    public class EmploymentTable
    {
        public List<Employer> professionalEmploymentInformation { get; set; }
    }
    public class EmploymentModel
    {
        public Introduction introduction { get; set; }

        public DegreeStatitics degreeStatistics { get; set; }

        public Employers employers { get; set; }

        public Careers careers { get; set; }

        public EmploymentTable employmentTable { get; set; }

        public CoopTable coopTable { get; set; }

        public string pageTitle { get; set; }
    }
}
