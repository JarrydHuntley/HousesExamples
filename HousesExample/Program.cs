using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HousesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();

            Console.WriteLine(student1.FullName);
            //Console.WriteLine(student1.FirstName + " "+ student1.LastName);
            student1.OutputStudentInfo();
        }
    }
}
