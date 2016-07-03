using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example4
{
    // Define a base class, Car. The class defines two methods,
    // Desicribe and showDetails. DescribeCar calss ShowDetails, and each derive
    // class also defines a ShowDetails method. The example tests which version of
    // ShowDetails is selected, the base class method or the derived class method.
    class Car
    {
        public void DescribeCar()
        {
            Console.WriteLine("Four wheels and an engine.");
            ShowDetails();
        }
        public virtual void ShowDetails()
        {
            Console.WriteLine("Standard transportation");
        }
    }

    // Define the derived classes

    // Class convertibleCar uses the new modifier to acknowledge that ShowDetails
    // hides the base class method
    class ConvertibleCar : Car
    {
        public new void ShowDetails()
        {
            Console.WriteLine("A roof that opens up.");
        }
    }

    // Class Minivan uses the override modifier to specify that ShowDetails
    // extends the base class method.
    class Minivan : Car
    {
        public override void ShowDetails()
        {
            //base.ShowDetails();
            Console.WriteLine("Carries seven people.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car2 = new ConvertibleCar();
            Car car3 = new Minivan();
            car2.ShowDetails();
            car3.ShowDetails();

            Console.Read();
        }
    }
}
