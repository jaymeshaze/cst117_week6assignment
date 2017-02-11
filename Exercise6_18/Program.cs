using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create an interface, IBendable, with one method, Bend.Create two classes, Spoon and
//Arm, that implement IBendable.Spoon will also have an Eat method, and Arm will
//also have a Raise method.Each of these methods prints a message indicating its function.
//Write another class with a Main method, declaring two objects of type IBendable,
//one a spoon and another an arm.Call the Bend method.

namespace Exercise6_18
{
    class Program
    {
        static void Main(string[] args)
        {
            Spoon testSpoon = new Exercise6_18.Spoon();
            Arm testArm = new Exercise6_18.Arm();

            testSpoon.Bend();
            testArm.Bend();
        }
    }

    public interface IBendable
    {
        void Bend();
    }

    public class Spoon : IBendable
    {

        public void Bend()
        {
            Console.WriteLine("You bend the spoon.");
        }

        public void Eat()
        {
            Console.WriteLine("Eat with the spoon.");
        }
    }

    public class Arm : IBendable
    {
        public void Bend()
        {
            Console.WriteLine("You bend your arm.");
        }
        public void Raise()
        {
            Console.WriteLine("Raise your arm.");
        }
    }
}
