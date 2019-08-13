using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polecenie_Command
{
    class Program
    {
        static void Main(string[] args)
        {

            SuperPilot pilot = new SuperPilot();
            Światło jadalniaŚwiatło = new Światło("Jadalnia");
            Światło kuchniaŚwiatło = new Światło("Kuchnia");
            DrzwiGarażowe drzwiGarażowe = new DrzwiGarażowe("Garaż");
            WieżaStereo wieżaStereo = new WieżaStereo("Wieża");
            WentylatorSufitowy wentylatorSufitowy = new WentylatorSufitowy("Jadalnia wentylator");
            //PolecenieOtwórzDrzwiGarażowe otwórzDrzwi = new PolecenieOtwórzDrzwiGarażowe(drzwiGarażowe);
            //PolecenieZamknijDrzwiGarażowe zamknijDrzwi = new PolecenieZamknijDrzwiGarażowe(drzwiGarażowe);
            //PolecenieWieżaStereoWłączCD właczCD = new PolecenieWieżaStereoWłączCD(wieżaStereo);
            //PolecenieWieżaStereoWyłączCD wyłączCD = new PolecenieWieżaStereoWyłączCD(wieżaStereo);
            //PolecenieWłączŚwiatło właczŚwiatło = new PolecenieWłączŚwiatło(kuchniaŚwiatło);
            //PolecenieWyłączŚwiatło wyłączŚwiatło = new PolecenieWyłączŚwiatło(kuchniaŚwiatło);
            //PolecenieWłączŚwiatło właczŚwiatło2 = new PolecenieWłączŚwiatło(jadalniaŚwiatło);
            //PolecenieWyłączŚwiatło wyłączŚwiatło2 = new PolecenieWyłączŚwiatło(jadalniaŚwiatło);
            //pilot.ustawPolecenie(0, otwórzDrzwi, otwórzDrzwi);
            //pilot.ustawPolecenie(1, właczŚwiatło, wyłączŚwiatło);
            //pilot.ustawPolecenie(2, właczCD, wyłączCD);
            //pilot.ustawPolecenie(3, właczŚwiatło2, wyłączŚwiatło2);
            //Console.WriteLine(pilot);

            //Console.ReadLine();
            //pilot.wciśniętoPrzyciskWyłącz(0);
            //pilot.wciśniętoPrzyciskWłącz(0);

            //pilot.wciśniętoPrzyciskWyłącz(2);
            //pilot.wciśniętoPrzyciskWłącz(2);

            //pilot.wciśniętoPrzyciskWyłącz(1);
            //pilot.wciśniętoPrzyciskWłącz(1);
            //pilot.wciśniętoPrzyciskWycofaj();
            //pilot.wciśniętoPrzyciskWyłącz(3);
            //pilot.wciśniętoPrzyciskWłącz(3);


             PolecenieWentylatorSufitowySzybko wentylatorSzybko = new PolecenieWentylatorSufitowySzybko(wentylatorSufitowy);
             PolecenieWentylatorSufitowyŚrednio wentylatorŚrednio = new PolecenieWentylatorSufitowyŚrednio(wentylatorSufitowy);
            PolecenieWentylatorSufitowyWyłącz wentylatorWyłącz = new PolecenieWentylatorSufitowyWyłącz(wentylatorSufitowy);

            pilot.ustawPolecenie(0, wentylatorŚrednio, wentylatorWyłącz);
            pilot.ustawPolecenie(1, wentylatorSzybko, wentylatorWyłącz);

            pilot.wciśniętoPrzyciskWłącz(0);
            pilot.wciśniętoPrzyciskWyłącz(0);
            
            pilot.wciśniętoPrzyciskWycofaj();
            pilot.wciśniętoPrzyciskWłącz(1);
            pilot.wciśniętoPrzyciskWycofaj();
            Console.ReadLine();

        }
    }
}
