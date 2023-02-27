using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignement_2._1
{
    /*
     Assignment 1 
Consider Class Demo1 with instance methods D1() and D2().
The class Demo1 has only 1 user-defined constructor and it is marked as private. 
Considering the above situation, we can not instantiate the class Demo1 in any other class and also can not be able to access its method. 
You are allowed to modify the class but do not add a constructor, do not inherit the class Demo1 & also do not modify the existing constructor.
Try to find the solution to access the instance methods D1 and D2.
     */
    class Demo1
    {
        // obj = by default it is private.
        static Demo1 obj = null;

        public int a;
        public void D1()
        {
            Console.WriteLine("In Method D1");
        }

        public void D2()
        {
            Console.WriteLine("In Method D2");
        }

        //we have created a private constructor
        private Demo1()
        {

        }

        public static Demo1 displayInstance
        {

            get
            {
                if (obj == null)
                    // From below it will first jump to private constructor n then will create the obj.
                    obj = new Demo1();

                //singleton class object is created
                return obj;
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Demo1 demo1 = Demo1.displayInstance;

            demo1.a = 10;

            Demo1 demo2 = Demo1.displayInstance;

            demo2.a = 20;

            // Only a single instance is created .
            Console.WriteLine(demo1.a); // retruns 20
            Console.WriteLine(demo2.a); // returns 20 
            demo1.D1();
            demo1.D2();
            Console.ReadLine();
            Console.WriteLine("Heloo");

        }
    }
}
