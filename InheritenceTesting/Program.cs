using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Hello World!");


            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app!
            Rectangle r = new Rectangle(8.0, 9.6);
            C c = new C();
            r.cost();
        }
    }

    class Shape
    {
        protected double height;
        protected double width;

        public Shape(double height, double width)
        {
            this.height = height;
            this.width = width;
            Console.WriteLine(" base shape constructor has been made ");
            display();

        }

        public void setHeight(double height)
        {
            this.height = height;
        }

        public void setWidth(double weidth)
        {
            this.height = weidth;
        }

        public double getHeight()
        {
            return this.height;
        }
        public double getWeidth()
        {
            return this.width;
        }

        protected double GetArea()
        {
            return this.width * this.height;
        }

        void display()
        {
            Console.WriteLine(" the height is " + this.height);
            Console.WriteLine(" the weidth is " + this.width);
        }


    }

    class Rectangle : Shape
    {
        public Rectangle(double h, double w) : base(h, w)
        {
            Console.WriteLine(" inside the child rectangle class ");

        }
        
       public  void cost ()
        {
            var x = height * width * 90;
            Console.WriteLine(x);
        }
    }

    //this is the way where derived class has initailized the base constructor 


    class A
    {
        public A()
        {
            Console.WriteLine(" this is class a constructor ");
        }

    }
    class B : A
    {
        public B()
        {
            Console.WriteLine(" this is class B constructor ");
        }
    }

    class C : B
    {
        public C()
        {
            Console.WriteLine(" this is class C constructor ");
        }
    }




}
