﻿namespace P3.Models
{
    // represents a staff / faculty member
    public class Person
    {
        public string username { get; set; }

        public string name { get; set; }

        public string tagline { get; set; }

        public string imagePath { get; set; }

        public string title { get; set; }

        public string interestArea { get; set; }

        public string office { get; set; }

        public string email { get; set; }

        public string phone { get; set; }

        public string twitter { get; set; }

        public string facebook { get; set; }

        public string website { get; set; }
    }
    public class PeopleModel
    {
        public List<Person> faculty { get; set; }

        public List<Person> staff { get; set; }
        public string title { get; set; }

        public string subTitle { get; set; }

    }
}

