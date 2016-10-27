using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selection
{
    class Program
    {
        public static void Main(string[] args)
        {
         int[] a = new int[6];
         int i,j,imin,temp;
            for(i=0;i<6;i++)
                {
                     a[i]=Convert.ToInt32(Console.ReadLine());
                }
            for(i=0;i<6;i++)
            {
                j=i+1;
                imin=i;
                while(j<6)
                { 
                if(a[j]<a[imin])
                {
                    imin = j;
                }
                    j++;
                }
                temp=a[imin];
                a[imin]=a[i];
                a[i]=temp;
            }
            for (i = 0; i < 6; i++)
            {
                Console.WriteLine(a[i]);
            }
       }
    }
}
