using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec_Pyłek_Flyweight
{
    public interface Weight
    {
        int weight { get; set; }
        string name { get; set; }
        void GetWeight();
    }



    public class WeightsFactory
    {
        public Weight weight;
        public int Repetitions = 0;
        public Dictionary<int, Weight> WeightList = new Dictionary<int, Weight>();
        int R1;
        int R2;
        int R5;
        int R10;
        int R20;


        public void ShowRepetitions()
        {
            switch (this.weight.weight)
            {
                case 1:
                    R1++;
                    break;
                case 2:
                    R2++;
                    break;
                case 5:
                    R5++;
                    break;
                case 10:
                    R10++;
                    break;
                case 20:
                    R20++;
                    break;

                default:
                    break;
            }
            Console.WriteLine("All Repetitions " + Repetitions + "   ");
            Console.WriteLine("Repetitions of 1 ." + R1 + " ");
            Console.WriteLine("Repetitions of 2 ." + R2 + " ");
            Console.WriteLine("Repetitions of 5 ." + R5 + " ");
            Console.WriteLine("Repetitions of 10 ." + R10 + " ");
            Console.WriteLine("Repetitions of 20 ." + R20 + " ");
            Console.WriteLine();
        }



        public Weight GetWeight(int weight)
        {

            if (WeightList.ContainsKey(weight))
            {
                this.weight = WeightList[weight];
                Repetitions++;

                ShowRepetitions();


            }
            else
            {

                switch (weight)
                {

                    case 1:
                        this.weight = new Weight1();
                        break;
                    case 2:
                        this.weight = new Weight2();
                        break;
                    case 5:
                        this.weight = new Weight5();
                        break;
                    case 10:
                        this.weight = new Weight10();
                        break;
                    case 20:
                        this.weight = new Weight20();
                        break;
                    default:
                        Console.WriteLine("There is no weight like this ");

                        break;
                }


                WeightList.Add(weight, this.weight);




            }


            return this.weight;
        }






    }








    public class Weight1 : Weight
    {
        public int weight { get; set; }
        public string name { get; set; }


        public Weight1()
        {
            this.weight = 1;
            this.name = "1 kilogram";
        }

        public void GetWeight()
        {
            Console.WriteLine("Weight name " + name + " ... " + weight + " kg");
        }
    }



    public class Weight2 : Weight
    {
        public int weight { get; set; }
        public string name { get; set; }


        public Weight2()
        {
            this.weight = 2;
            this.name = "2 kilograms";
        }

        public void GetWeight()
        {
            Console.WriteLine("Weight name " + name + " ... " + weight + " kg");
        }
    }



    public class Weight5 : Weight
    {
        public int weight { get; set; }
        public string name { get; set; }


        public Weight5()
        {
            this.weight = 5;
            this.name = "5 kilograms";
        }

        public void GetWeight()
        {
            Console.WriteLine("Weight name " + name + " ... " + weight + " kg");
        }
    }
    public class Weight10 : Weight
    {
        public int weight { get; set; }
        public string name { get; set; }


        public Weight10()
        {
            this.weight = 10;
            this.name = "10 kilograms";
        }

        public void GetWeight()
        {
            Console.WriteLine("Weight name " + name + " ... " + weight + " kg");
        }
    }
    public class Weight20 : Weight
    {
        public int weight { get; set; }
        public string name { get; set; }


        public Weight20()
        {
            this.weight = 20;
            this.name = "20 kilograms";
        }

        public void GetWeight()
        {
            Console.WriteLine("Weight name " + name + " ... " + weight + " kg");
        }
    }

}
