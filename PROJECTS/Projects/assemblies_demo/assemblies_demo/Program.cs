using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assemblies_demo
{
    class Program
    {
        static void Main(string[] args)
        {
            student s = new student();
            s.student_details();
            Console.ReadKey();

        }

    }
    class student
    {
        public int id { get; set; }
        public string  name { get; set; }
        public int marks{ get; set; }
        public string location { get; set; }
        public student()
        {
            id = 1;
            name = "keerthi";
            marks = 100;
            location = "salem";
        }
        public void student_details()
        {
            Console.WriteLine(id);
            Console.WriteLine(name);
            Console.WriteLine(marks);
            Console.WriteLine(location);
        }
    }
}
