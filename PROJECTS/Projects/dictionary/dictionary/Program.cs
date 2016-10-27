using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string,Int64 > d= new Dictionary<string,Int64>(); //dictionary d with string as key and integer as value
            int n=0,i,o=0,flag=1;
            string s;
            Int64 k;
            do
            {
            try
                {
                    Console.WriteLine("Enter the number of contacts to add in the dictionary");
                    n = int.Parse(Console.ReadLine()); flag = 0;
                }
                catch(FormatException)      //exception handling for non integer values
                {
                    Console.WriteLine("Enter only integer values"); flag = 1;
                    
                }
                catch(Exception)            //exception handling
                {
                    Console.WriteLine("Invalid entry"); flag = 1;
                   
                }
            }while(n<=0 || flag==1 || n<0 || n>10);               //boundary condition
            for (i = 0; i < n; i++)
            {
            t2: try
                {
                    Console.WriteLine("Enter the name and contact information for contact" + (i + 1));
                    s = Console.ReadLine();             //getting the key and value
                    k = Convert.ToInt64(Console.ReadLine());
                }
                catch(Exception)
                {
                    Console.WriteLine("Invalid entry");
                    goto t2;
                }
                d.Add(s,k);     //add function
            }
            Console.WriteLine("The name and contact informations are");
            foreach(KeyValuePair<string,Int64> item in d)
            {
                Console.WriteLine(item.Key+"\t"+item.Value);     //printing the key and value of each item in the dictionary
            }
            while (true)
            {
                int flag1 = 1;
                while (flag1 == 1)
                {
                    Console.WriteLine("1.sorting");
                    Console.WriteLine("2.Addition");
                    Console.WriteLine("3.updation");
                    Console.WriteLine("4.deletion");
                    Console.WriteLine("5.Search");
                    Console.WriteLine("6.exit");
                    try
                    {
                        o = int.Parse(Console.ReadLine()); flag1 = 0;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("wrong entry"); flag1 = 1;

                    }
                }

                //specifying the operation to be performed

                switch (o)
                {
                    case 1:
                        Console.WriteLine("1.Sorting");
                        Console.WriteLine("The names after sorting are");
                        var list = d.Keys.ToList();                       //creating a list and acquiring the keys
                        list.Sort();                                    // sorting the list
                        foreach (var key in list)
                        {
                            Console.WriteLine(key + d[key]);          //displaying the sorted list
                        }
                        break;

                    case 2:

                        Console.WriteLine("2.Adding");
                        int flag2= 1;
                        do
                        {
                         try
                            {
                                Console.WriteLine("Enter the number of contacts to be added to the dictionary");
                                n = int.Parse(Console.ReadLine());
                                flag2 = 0;
                            }
                            catch (FormatException)                     //exception handling for non integer values
                            {
                                Console.WriteLine("Enter only integer values");
                                
                                flag2 = 1;
                            }
                            catch (Exception)                            //exception handling
                            {
                                Console.WriteLine("Invalid entry");
                                
                                flag2 = 1;
                            }
                        } while (n <= 0 || flag2==1);                                 //boundary condition
                        for (i = 0; i < n; i++)
                        {
                        t0: try
                            {
                                Console.WriteLine("Enter the name and contact information to be added");
                                s = Console.ReadLine();                    //getting the key and value to be added additionaly
                                k = Convert.ToInt64(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Invalid entry, enter only string and integer values");
                                goto t0;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("Invalid entry");
                                goto t0;
                            }
                            if (d.ContainsKey(s))
                            {
                                Console.WriteLine("The key is already present in the dictionary , enter a new key");
                                goto t0;
                            }
                            else
                            {
                                d.Add(s, k);        //add function
                            }
                        }
                        /* printing the dictionary after adding the keys and values*/
                        Console.WriteLine("The keys after addition are");
                        foreach (KeyValuePair<string, Int64> item in d)
                        {
                            Console.WriteLine(item.Key + " " + item.Value);   //printing the key and value of each item in the dictionary
                        }
                        break;

                    case 3:

                        Console.WriteLine("3.Updation");
                    t4: try
                        {
                            Console.WriteLine("enter the key to be updated");
                            s = Console.ReadLine();
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("invalid entry, enter the key again");
                            goto t4;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("invalid entry, enter the key again");
                            goto t4;
                        }
                        if (d.ContainsKey(s))
                        {
                        t7: try
                            {
                                Console.WriteLine("Enter the new value to be updated");
                                k = Convert.ToInt64(Console.ReadLine());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("invalid entry, enter the new value again");
                                goto t7;
                            }
                            catch (Exception)
                            {
                                Console.WriteLine("invalid entry, enter the new value again");
                                goto t7;
                            }
                            d[s] = k;       //storing the new value
                            Console.WriteLine("The keys after updation are");
                            foreach (KeyValuePair<string, Int64> item in d)
                            {
                                Console.WriteLine(item.Key + " " + item.Value);//printing the key and value of each item in the dictionary
                            }
                        }
                        else
                        {
                            Console.WriteLine("the key is not present in the dictionary");
                            goto t4;
                        }

                        break;

                    case 4:

                        Console.WriteLine("4.Deletion");        //deletion operation
                    t5: try
                        {
                            Console.WriteLine("Enter the key to be deleted");
                            s = Console.ReadLine();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("invalid entry");
                            goto t5;
                        }
                        if (d.ContainsKey(s))
                        {
                            d.Remove(s);            //remove function
                            Console.WriteLine("The keys after deletion are");
                            foreach (KeyValuePair<string, Int64> item in d)
                            {
                                Console.WriteLine(item.Key + " " + item.Value);
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The key is not present in the dictionary");
                            goto t5;
                           

                        }

                    case 5:
                    t6: try
                        {
                            Console.WriteLine("4.Searching");        //searching
                            Console.WriteLine("Enter the key to be searched");
                            s = Console.ReadLine();
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid entry");
                            goto t6;
                        }
                        if (d.ContainsKey(s))
                        {
                            Console.WriteLine("The given is key is found in the dictionary");
                        }
                        else
                        {
                            Console.WriteLine("The given is key is not found in the dictionary");
                            goto t6;
                        }

                        break;
                    case 6:
                        Environment.Exit(0);
                        break;    
                }
            }
        }
    }
}
