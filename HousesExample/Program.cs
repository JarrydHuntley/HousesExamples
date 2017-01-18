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
            House house1 = new House("Green", 4, 1000, 3);
            House house2 = new House("Blue", 700);
            House house3 = new House();

            //house1.DisplayHouseInfo();
            //house2.DisplayHouseInfo();
            //house3.DisplayHouseInfo();

            //house2.Paint("Yellow");

            //house2.DisplayHouseInfo();
            house2.Name = "The blue house!";

            Console.WriteLine("This is the name of the house: "+house2.Name);
            
        }
    }
}
