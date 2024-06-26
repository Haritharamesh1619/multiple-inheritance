using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiple_inheritance
{

    interface Ishape  // 1 st interface
    {
        void shape();// method
    }

    class A: Ishape// create a class "shape" and implement  interface "Ishape "
    {
        public void shape()
        {
            Console.WriteLine("shape: square");// to implementing the method "shape method"
        }

    }

    public interface Icolor    // 2 st interface
    {
        void color();// method
    }
    class B : Icolor // create a class "B" and implement  interface "Icolor "
    {
        public void color()
        {
            Console.WriteLine("color : red");//  to implementing the method "color method"
        }

    }
    // this class have both capabilites of  "A,B ". so we can only use interface(Ishape ,Icolor) to inherit both A & B class
    class AB :Ishape, Icolor 
    {
        
       A a= new A();
        B b = new B();

        public void shape()
        {
            a.shape();// call the method
        }
        public void color()
        {
            b.color();// call the method
        }
     

    }
    class Program
    {
        public static void Main()
        {
            AB d = new AB();// instance of a class
            // invoke shape method and color method
            d.shape();
            d.color();
            Console.Read();
        }
    }
}
