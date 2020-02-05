using System;

namespace hackAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Contact { get; set; }
        public int Age { get; set; }
        public int Company { get; set; }
        public string CompanyName { get; set; }
    }
}