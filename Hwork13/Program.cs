using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hwork13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Адрес первого здания");
            Building building = new Building("Улица Циолковского дом 54", 129, 67, 16);
            building.Print();
            Console.WriteLine("\n");
            Console.WriteLine("Адрес второго здания");
            MultiBuilding multiBuilding = new MultiBuilding("Улица Маяковского дом 57", 24, 11, 9, 4);
            multiBuilding.Print();
            Console.ReadKey();
        }
        class Building
        {
            public string Address { get; set; }
            public double Lengthbuilding { get; set; }
            public double Widthhbuilding { get; set; }
            public double Heightbuilding { get; set; }
            public Building(string address, double lengthbuilding, double widthhbuilding, double heightbuilding)
            {
                Address = address;
                Lengthbuilding = lengthbuilding;
                Widthhbuilding = widthhbuilding;
                Heightbuilding = heightbuilding;
            }
            public void Print()
            {
                Console.WriteLine($"Адрес здания: \t{Address}");
                Console.WriteLine($"Длина здания: \t{Lengthbuilding}");
                Console.WriteLine($"Ширина здания: \t{Widthhbuilding}");
                Console.WriteLine($"Высота здания: \t{Heightbuilding}");
            }
        }
        sealed class MultiBuilding : Building
        {
            public int Floor { get; set; }
            public MultiBuilding(string address, double lengthbuilding, double widthhbuilding, double heightbuilding, int floor)
                : base(address, lengthbuilding, widthhbuilding, heightbuilding)
            {
                Floor = floor;
            }

            public void Print()
            {
                base.Print();
                Console.WriteLine($"Этажность здания:{Floor}");
            }

        }
    }
}
