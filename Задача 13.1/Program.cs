using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_13._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Building building = new Building("Новороссийск, пр-кт Ленина, д. 9", 15, 6, 9);
            Console.WriteLine(building.Print());
            MultiBuilding multiBuilding = new MultiBuilding("Сочи, ул. Орджоникидзе, д. 8", 80, 20, 30, 10);
            Console.WriteLine(multiBuilding.Print());
            Console.ReadKey();
        }
    }
}
