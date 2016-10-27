using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p;
            p.getdata();
            p.add();
            p.sub();
            p.mult();
            p.print();
        }
        public void getdata();
        public void add();
        public void sub();
        public void mult();
        public void print();
    }
   public void getdata()
{
    int i,j;
    Console.WriteLine("Enter two numebers");
    i=Convert.ToInt32(Console.ReadLine());
     j=Convert.ToInt32(Console.ReadLine());
}
 public   void add()
{
   int a;
    a=i+j;
}
    public void sub()
{
    int s;
    s=i-j;
}
    public void mult()
{
    int m;
    m=i*j;
}
    public void print()
{
    Console.WriteLine("The addition of the two numbers are"+a);
     Console.WriteLine("The subtraction of the two numbers are"+s);
     Console.WriteLine("The multiplication of the two numbers are"+m);
}

}
