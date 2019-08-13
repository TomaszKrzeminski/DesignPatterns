using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec_Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock("Clock");
            CoffeExpress express = new CoffeExpress("CoffeExpress");
            GardenSprayer sprayer = new GardenSprayer("GardenSprayer");


            DeviceMediator mediator = new Mediator();
            mediator.AddDevice(clock);
            mediator.AddDevice(express);
            mediator.AddDevice(sprayer);

            express.Act();

            Console.ReadLine();


        }
    }
}
