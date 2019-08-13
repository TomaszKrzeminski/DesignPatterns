using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wzorzec_Pyłek_Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {

            WeightsFactory factory = new WeightsFactory();
            int[] Weights = new int[] { 20, 20, 5, 5, 5, 1, 10, 20, 5 };
            List<Weight> List = new List<Weight>();

            foreach (var item in Weights)
            {
             List.Add(   factory.GetWeight(item));
            }


            foreach (var item in List)
            {
                Console.WriteLine(item.name);
            }


            Console.ReadLine();


        }
    }
}
