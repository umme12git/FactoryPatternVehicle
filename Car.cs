﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternVehicle
{
    public class Car : IVehicle
    {
        public Car()
        {

        }

        public void Drive()
        {
            Console.WriteLine("A new Car is getting ready");
        }

    }
}
