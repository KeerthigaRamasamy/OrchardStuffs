using System;
namespace csharpone
{
    class Program
    {
        static void Main()
        {
            int n,m;
            Console.WriteLine("Hello world");
            Console.WriteLine("Enter a number");
            n =int.Parse( Console.ReadLine());
            Console.WriteLine("The entered number is" + n);
            Console.WriteLine("Enter another number");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("The entered number is" + m);
            Console.WriteLine("The sumof the two numbers is"+ (n+m));
            Console.ReadLine();
        }
    }
}
