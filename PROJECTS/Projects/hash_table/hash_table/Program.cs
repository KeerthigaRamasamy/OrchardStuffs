using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hash_table
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable h = new Hashtable(); //creating objects of the hash table

            //adding keys and values into hash table
            h.Add("name", "keerthi");
            h.Add("age", 21);
            h.Add("location", "chennai");
            h.Add("MId", "M1037727");
            int n = h.Count;
            Console.WriteLine("The number of entries in the hash table are"+n);
            Console.WriteLine("The entries in the hashtable are"); 

            //iterating through the hash table
            foreach(DictionaryEntry d in h)
            {
                //unboxing before printing
                Console.Write(d.Key.ToString()+"\t");
                Console.WriteLine(d.Value.ToString() + "\t");
            }
            Console.ReadKey();
        }
    }
}
