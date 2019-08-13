using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec_Prototyp
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle car = new Car(200, "Suzi","Black");
            Console.WriteLine(car);
            Vehicle copy = (Vehicle)car.Clone();
            Console.WriteLine(copy);
            car.details.Color = "Red";
            Console.WriteLine("After Change");
            Console.WriteLine(car);
            Console.WriteLine(copy);
            Console.ReadLine();


        }
    }
}
