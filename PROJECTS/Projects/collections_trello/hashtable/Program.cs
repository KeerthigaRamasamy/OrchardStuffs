using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist_sort
{
    public class Program 
    {
        public static void Main(string[] args)
        {
            int p_id;
            string p_name;
            int p_unit;
            decimal p_price;
            //creating array list
            ArrayList al = new ArrayList();
            Console.WriteLine("Enter the number of produtcs");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the product details");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the product id");
                p_id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the product name");
                p_name = Console.ReadLine();
                Console.WriteLine("Enter the product unit");
                p_unit = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the product price");
                p_price = decimal.Parse(Console.ReadLine());
                al.Add(new product(p_id, p_name, p_unit, p_price));     //adding the objects to the arraylist
            }
            Console.WriteLine("sorting based on product_id");

            //sort function calls the CompareTo function
            al.Sort();
            Console.WriteLine("p_id" + "\t" + "p_name" + "\t" + "p_unit" + "\t" + "p_price");
            foreach (product d in al)
            {
                Console.Write(d.product_id+"\t");
                Console.Write(d.product_name + "\t");
                Console.Write(d.product_unit + "\t");
                Console.Write(d.product_price + "\t");
                Console.WriteLine();
            }
            Console.ReadKey();
        }     
    }
    
    //product class inherited from icomparable interface
    public class product:IComparable
    {
        public int product_id;
        public string product_name;
        public int product_unit;
        public decimal product_price;
        public product(int i,string p_name,int p_unit,decimal p_price)
        {
            product_id= i;
            product_name = p_name;
            product_unit = p_unit;
            product_price = p_price;
        }

        //interface implementation method, sorting based on id,name,unit
        public int CompareTo(object obj)
        {
            product o = (product)obj;
            if ((this.product_id) > (o.product_id))
            {
                return 1;
            }
            else if ((this.product_id) < (o.product_id))
            {
                return -1;
            }
                else if(String.Compare((this.product_name), (o.product_name)) == 1)
                {
                    return 1;
                }
                else if (String.Compare((this.product_name), (o.product_name)) == -1)
                {
                    return -1;
                }
            else if((this.product_unit) > (o.product_unit))
            {
                return 1;
            }
            else if ((this.product_unit) < (o.product_unit))
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
   
}
