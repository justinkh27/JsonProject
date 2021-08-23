using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace JsonProject
{
    //class Masterlist
    //{
    //    public Student[] Studentlist { get; set; }
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Degree { get; set; }
    //}

    //class Student
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //    public string Degree { get; set; }
    //}


    public class Rootobject
    {
        public List<Class1> masterList { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
    }

    public class Class1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
    }


}
