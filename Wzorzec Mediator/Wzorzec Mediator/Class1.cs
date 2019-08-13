using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec_Mediator
{
    
    public interface  DeviceMediator
    {
        void Work(string Name);
        void AddDevice(Device device);
    }



    public class Mediator : DeviceMediator
    {

        public Dictionary<string, Device> DeviceList = new Dictionary<string, Device>();

        public Device SelectDevice(string Name)
        {
            return DeviceList[Name];
        }

       

        public void AddDevice(Device device)
        {
            //bardzo ważne//
            device.deviceMediator = this;

            DeviceList.Add(device.Name, device);
        }

        public void Work(string Name)
        {
            Device device = SelectDevice(Name);

            if(device!=null)
            {

                if(device is Clock)
                {

                    Device clock = SelectDevice("Clock");

                    device.Stop();

                    Device express = SelectDevice("CoffeExpress");
                    express.Start();

                    Device gardensprayer = SelectDevice("GardenSprayer");
                    gardensprayer.Start();



                }
                else if(device is CoffeExpress)
                {

                    Device clock = SelectDevice("Clock");

                    clock.Start();

                    Device express = SelectDevice("CoffeExpress");
                    express.Stop();

                    Device gardensprayer = SelectDevice("GardenSprayer");
                    gardensprayer.Stop();


                }
                else if(device is GardenSprayer)
                {
                   

                    Device gardensprayer = SelectDevice("GardenSprayer");
                    gardensprayer.Start();
                }





            }



        }

      
    }


    public abstract class Device
    {

       public string Name;

        public Device(string Name)
        {
            this.Name = Name;
        }

        public DeviceMediator deviceMediator;

      

        public void SetMediator(DeviceMediator deviceMediator)
        {
            this.deviceMediator = deviceMediator;
        }

        public void Act()
        {
            Console.WriteLine("Mediator Working");
            deviceMediator.Work(Name);
        }

        public abstract void Start();
        public abstract void Stop();
       
    }



    public class Clock : Device
    {

        public Clock(string Name) : base(Name)
        {
        }
      


      

        public override void Start()
        {
            Console.WriteLine("Clock is Set ");
        }

        public override void Stop()
        {
            Console.WriteLine("Clock alarm stop ");
        }
    }

    public class CoffeExpress : Device
    {

        public CoffeExpress(string Name) : base(Name)
        {
           
        }


       

        public override void Start()
        {
            Console.WriteLine("Starting Making Coffe"  );
        }

        public override void Stop()
        {
            Console.WriteLine("Coffe is ready turning of");
        }
    }

    public class GardenSprayer : Device
    {


        public GardenSprayer(string Name) : base(Name)
        {
        }


        

        public override void Start()
        {
            Console.WriteLine("Start Spraying");
        }

        public override void Stop()
        {
            Console.WriteLine("Stop spraying"  );
        }
    }


}
