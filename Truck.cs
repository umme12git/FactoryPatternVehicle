using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternVehicle
{
    public class Truck :IVehicle 
    {
        public Truck ()
        {

        }

        public void Drive()
        {
            Console.WriteLine("A new truck is getting ready");
        }
    }
}
