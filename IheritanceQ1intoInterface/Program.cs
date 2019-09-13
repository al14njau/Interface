using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IheritanceQ1intoInterface
{
    class Program : ISpeed, IDog, IElephant
    {
        static void Main(string[] args)
        {

            Program p1 = new Program();
            Console.WriteLine("The car speed is " + p1.CarSpeed(77, 28));
            Console.WriteLine("The car Motorcycle speed is " + p1.MotorcycleSpeed(55, 45));
            IDog i1 = p1;
            Console.WriteLine("A dog eats " +i1.Dogfood("biscuits ") + "and lives in a "+i1.Doghabitat("house."));
            IElephant i2 = p1;
            Console.WriteLine("An Elephant eats "+i2.Elephantfood("roots ") + "and lives in the "+i2.Elephanthabitat("jungle."));
            Console.ReadLine();

        }

        public double CarSpeed(double speed, double brake)
        {
            return speed - brake;
        }
        public double MotorcycleSpeed(double speed, double accelerate)
        {
            return speed + accelerate;
        }

        public string Dogfood(string food)
        {
            return food;
        }
        public string Doghabitat(string habitat)
        {
            return habitat;
        }

        public string Elephantfood(string food)
        {
            return food;
        }
        public string Elephanthabitat(string habitat)
        {
            return habitat;
        }
    }
}

       
      