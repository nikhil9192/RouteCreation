using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RouteCreation.Models
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int classes { get; set; }
        public Address address  { get; set; }
    }
}