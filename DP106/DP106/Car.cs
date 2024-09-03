using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DP106
{
    public class Car
    {
        private string _model;
        private string _brand;
        public Car(string model, string brand)
        {
            _model = model;
            _brand = brand;

            Console.WriteLine($"A {_brand} of the" + $" model {_model} " +
                $"has been created");
        }
    }
}
