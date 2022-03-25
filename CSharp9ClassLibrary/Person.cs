using System;

namespace CSharp9ClassLibraryNetStd2._1
{
    public class Person
    {
        //init keyword demonstarion 

        //private int _age;

        //public int Age
        //{
        //    get
        //    {
        //        return _age;
        //    }
        //    set
        //    //private set
        //    {
        //        _age = value;

        //        //safety code is placed more commonly on setter instead of getter
        //        if (_age <= 0)
        //        {
        //            throw new ArgumentException("Age should be more than zero!");
        //        }
        //    }
        //}

        //auto implemented property, it chooses its own name for backing field 
        //public int Age { get; set; }

        //it can be set extrenally by using private set
        //public int Age { get; private set; }

        public Person()
        {

        }

        public Person(int age)
        {
            Age = age;
        }

        //even private set is used, Age value can be changed internally 
        //inside the class although the value can not be changed externally

        //public void SomeFunc()
        //{
        //    Age = 50;
        //}

        //by removing the private set, property is made immutable
        //so its value can be set in constructor
        //but member initializer can not be used anymore since there is no setter
        //so init keyword comes into the picture
        //the value can be set only through constructor or member initializer
        //it can not be set externally or internally
        public int Age { get; init; }

    }
}
