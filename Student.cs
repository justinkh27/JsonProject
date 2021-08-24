using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace JsonProject
{
    
    public class Studentlist
    {
        public List<Student> MasterList { get; set; }
        public string SchoolName {  get; set; }
        public string SchoolAddress {  get; set; }
        public int SchoolDivision {  get; set; }
    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
    }


}
