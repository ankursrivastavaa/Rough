using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Concept
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Student = new Person { firstname = "Ankur", lastname = "Srivastava" };
            Console.WriteLine(Student.getname());
            Console.ReadKey(true);
        }
    }
}
