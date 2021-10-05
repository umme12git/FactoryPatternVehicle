using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternVehicle
{
    public class VehicleFactory
    {
        public VehicleFactory()
        {

        }
        public  static IVehicle GetVehicle(string answer)
        {  
                switch (answer)
                {
                    case "1":
                        return new Motorcycle();
                    case "2":
                        return new Van();
                    case "3":
                        return new Truck();
                    case "4":
                        return new Car();
                    default:
                        return new Car();

                }

            }
        
    }
}
