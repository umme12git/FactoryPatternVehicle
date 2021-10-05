using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternVehicle
{
    public class Van : IVehicle
    {
        public Van()
        {

        }

        public void Drive()
        {
            Console.WriteLine("A new van is getting ready");
        }
    }
}
