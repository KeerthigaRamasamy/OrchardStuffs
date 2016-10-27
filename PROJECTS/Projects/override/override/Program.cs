using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @override
{
    class Program
    {
        static void Main(string[] args)
        {
            animal obj = new dog();
            animal a = new animal();
            dog d = new dog();
            //d.sound();
            //d.description();
            //a.sound();
            //a.description();
            obj.sound();
            obj.description();
            Console.ReadKey();
        }
    }
    public class animal
    {
        virtual public void sound()
        {
            Console.WriteLine("Animal sound(base class)");
        }
        virtual public void description()
        {
            Console.WriteLine("An animal(base class)");
        }
    }
    public class dog:animal
    {
        //extension of the base class method
        public override void sound()
        {
            Console.WriteLine("Barking sound(derived class)");
        }

        //hides the base class method
        public override void description()
        {
            Console.WriteLine("A dog(derived class)");
        }
    }
}
