using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp8NetCore3._1NullableReferences
{
    internal class Person
{
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }
    }
}
