using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

//#nullable enable

namespace CSharp8NetCore3._1NullableReferences
{
    internal class MotorCar
    {
        private Person? _driver;
        private Engine _engine;

        public MotorCar(Person? driver, Engine engine)
        {
            _driver = driver;
            _engine = engine;
        }

        public override string ToString()
        {
            //if (IsValid(_driver))
            //    return $"{_driver!.Name} drives a {_engine.Capacity}cc car.";
            //else
            //    return "No driver";

            //if (IsValid(_driver))
            //    return $"{_driver.Name} drives a {_engine.Capacity}cc car.";
            //else
            //    return "No driver";

            return $"{_driver?.Name ?? "No one"} drives a {_engine.Capacity}cc car.";
        }

        //?. null propagating operator
        //?? null coalescing operator

        //!. null forgiving operator => we know that the object
        //would not be null during compile time but if we make
        //a mistake we still may get null reference exception
        //during run time
        public List<string> Tests { get; set; } = null!;

        //private static bool IsValid(Person? driver)
        //{
        //    return driver != null && driver.Name != "";
        //}

        //private static bool IsValid([NotNullWhen(true)] Person? driver)
        //{
        //    return driver != null && driver.Name != "";
        //}
    }
}
