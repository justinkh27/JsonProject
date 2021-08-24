using System;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace JsonProject
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            string filePath = "students.json";
            List<Student> students = new List<Student>();

            Student student1 = new Student()
            {
                Id = 1,
                Name = "John Smith",
                Degree = "CS"

            };
            Student student2 = new Student()
            {
                Id = 2,
                Name = "Bruce Wayne",
                Degree = "MA"
            };
            Student student3 = new Student()
            {
                Id = 3,
                Name = "Batman",
                Degree = "MA"
            };

            students.Add(student1);
            students.Add(student2);
            students.Add(student3);


            var ml = new Studentlist();
            ml.MasterList = students;
            ml.SchoolAddress = "123 College Ave";
            ml.SchoolName = "Degree Mill";
            ml.SchoolDivision = 4;

            Console.WriteLine(students[0].Name);
            var options = new JsonSerializerOptions { WriteIndented = true };
            var toJsonFile = JsonSerializer.Serialize(ml, options);
            Console.WriteLine(toJsonFile);
            File.WriteAllText(filePath, toJsonFile);

            string fileName = "students.json";
            string jsonFileResult = File.ReadAllText(fileName);
            var sl = JsonSerializer.Deserialize<Studentlist>(jsonFileResult);

            Console.WriteLine(sl);

            

        }
    }
}
