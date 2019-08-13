using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec_Prototyp
{
   public class Details
    {
        public string Color;
        public Details(string Color)
        {
            this.Color = Color;
        }
    }

    public interface Vehicle:ICloneable
    {
        int MaxSpeed { get; set; }
        string Name { get; set; }
        Details details { get; set; }
    }

    public class Car : Vehicle
    {
        public int MaxSpeed { get; set ; }
        public string Name { get; set ; }
        public Details details { get ;set; }

        public override string ToString()
        {
            return $"Max speed {MaxSpeed}   name of car {Name} color {details.Color}";
        }

        public Car(int speed,string name,string Color)
        {
            details = new Details(Color);
            MaxSpeed = speed;
            Name = name;
        }

        public object Clone()
        {
            return new Car(this.MaxSpeed,this.Name,this.details.Color);
        }
    }


}
