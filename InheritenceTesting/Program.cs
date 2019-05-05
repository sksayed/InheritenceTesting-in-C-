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
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app!
            Rectangle r = new Rectangle();
        }
    }

    class Shape
    {
        protected double height;
        protected double width;

        public Shape()
        {
            this.height = 0;
            this.width = 0;
            Console.WriteLine(" base shape constructor has been made ");

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


    }

    class Rectangle : Shape
    {
        public Rectangle()
        {
            Console.WriteLine(" inside the child rectangle class ");
        }
    }

    

}
