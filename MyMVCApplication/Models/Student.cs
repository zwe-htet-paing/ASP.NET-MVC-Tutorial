using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyMVCApplication.Models
{
    //store id, name, and age of the students
    //The model class can be used in the view to populate the data, as well as sending data to the controller.
    public class Student
    {
        public int StudentId { get; set; }

        //[Display(Name = "Name")]
        public string StudentName { get; set; }
        public int Age { get; set; }
        public Standard standard { get; set; }
    }

    public class Standard
    {
        public int StandardId { get; set; }
        public string StandardName { get; set; }
    }
}