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
            List<Class1> students = new List<Class1>();

            Class1 student1 = new Class1()
            {
                Id = 1,
                Name = "John Smith",
                Degree = "CS"

            };
            Class1 student2 = new Class1()
            {
                Id = 2,
                Name = "Bruce Wayne",
                Degree = "MA"
            };
            students.Add(student1);
            students.Add(student2);

            Console.WriteLine(students[0].Name);
            var options = new JsonSerializerOptions { WriteIndented = true };
            var toJsonFile = JsonSerializer.Serialize(students, options);
            Console.WriteLine(toJsonFile);
            File.WriteAllText(filePath, toJsonFile);

            string fileName = "students.json";
            string jsonFileResult = File.ReadAllText(fileName);
            var ro = JsonSerializer.Deserialize<Rootobject[]>(jsonFileResult);

            Console.WriteLine(ro[0].Degree);

            foreach (var item in ro)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);
                Console.WriteLine(item.Degree);
            }
            
            


            

        }
    }
}
