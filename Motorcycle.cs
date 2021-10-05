using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternVehicle
{
    public class Motorcycle :IVehicle
    {
        public Motorcycle()
        {

        }

        public void Drive()
        {
            Console.WriteLine("A new motorcycle is getting ready");
        }
    }
    
}
