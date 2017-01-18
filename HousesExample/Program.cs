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

            house1.DisplayHouseInfo();

            House house2 = new House("Blue", 700);
            
        }
    }
}
