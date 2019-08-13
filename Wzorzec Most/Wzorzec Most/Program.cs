using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec_Most
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Using Messangers in Devices");
            Device device = new Tablet(new FbMessanger());
            device.SelectPerson("Tomasz Krzemiński");
            device.ShowVideo();
            device.StartVideo();
            device.StopVideo();
            device.Text("Jakiś tekst Tomek Cześć");

            Device device2 = new CellPhone(new WhatsUp());
            device2.SelectPerson("Tomasz Krzemiński");
            device2.ShowVideo();
            device2.StartVideo();
            device2.StopVideo();
            device2.Text("Jakiś tekst Tomek Cześć");

            Console.ReadLine();





        }
    }
}
