using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InheritenceTesting
{
    class generics
    {

    }

    public class Mygenerics<T> //here my generics class is of type T
    {
        private T genereicMember; //object variable in that class

        public Mygenerics(T value) //jei type er , ota diyei eta ke initialize kora hoise 
        {
            this.genereicMember = value;
        }

        public T GenericMethod<U>(T genericParamerter, U anotherParameter) where U: struct
        {
            Console.WriteLine("Parameter type: {0}, value: {1}", typeof(T).ToString(), genericParamerter);
            Console.WriteLine("Return type: {0}, value: {1}", typeof(T).ToString(), anotherParameter);

            return genereicMember;

        }
        /*
         * here in this method , the return type is T , and it contains 2 parameters
         * one is type of T and another is type of U and u should be value type
         * and it returns the member initailized at the constructor 
         * 
        */


    }
}
