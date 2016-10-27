using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace sp_joins
{
    public class Program
    {
        public static string str = "Data Source=172.17.2.13;Initial Catalog=M1037727;Integrated Security=True";
        public static void Main(string[] args)
        {
            int n,i,j;
            string name="", location="";
            //int basic=0, hra=0, dapay=0;
            decimal basic=0, hra=0, dapay=0;
            SqlConnection c = new SqlConnection(str);
            while (true)
            {
                try
                {
                    Console.WriteLine("1.Insert");
                    Console.WriteLine("2.Update");
                    Console.WriteLine("3.select");
                    Console.WriteLine("4.exit");
                    n = int.Parse(Console.ReadLine());
                    switch (n)
                    {
                        case 1:
                            try
                            {
                                c.Open();
                                 try
                                    {
                                    while (true)
                                    {

                                        Console.WriteLine("Enter the no of rows to insert");
                                        i = int.Parse(Console.ReadLine());
                                        for (j = 0; j < i; j++)
                                        {
                                            Console.WriteLine("Enter the employee name");
                                            name = Console.ReadLine();
                                            Console.WriteLine("Enter the basic pay");
                                            basic = decimal.Parse(Console.ReadLine());
                                            Console.WriteLine("Enter the hra pay");
                                            hra = decimal.Parse(Console.ReadLine());
                                            Console.WriteLine("Enter the dapay");
                                            dapay = decimal.Parse(Console.ReadLine());
                                            Console.WriteLine("Enter the location");
                                            location = Console.ReadLine();
                                            //inserting by calling the stored procedure
                                            SqlCommand c1 = new SqlCommand("pay_details_insert_sp @name,@basic,@dapay,@hra,@location", c);
                                            c1.Parameters.AddWithValue("@name", name);
                                            c1.Parameters.AddWithValue("@basic", basic);
                                            c1.Parameters.AddWithValue("@hra", hra);
                                            c1.Parameters.AddWithValue("@dapay", dapay);
                                            c1.Parameters.AddWithValue("@location", location);
                                            c1.ExecuteNonQuery();
                                        }
                                        Console.WriteLine("Inserted");
                                        break;
                                    }
                                    }   
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Invalid");
                                    }
                                    catch (SqlException e)
                                    {
                                        Console.WriteLine(e.Message);
                                    }
                               
                            } 
                            catch(Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            finally
                            {
                                c.Close();
                            }
                            break;

                        case 2:
                            try
                            {
                                int x;
                                c.Open();
                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine("Enter the percent x to update the basic pay and salary");
                                        x = int.Parse(Console.ReadLine());
                                        break;
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Invalid");
                                    }
                                }
                                //stored procedure to update the basic pay of every employee by x% and also update the salary
                                SqlCommand c2 = new SqlCommand("up_details @x", c);
                                c2.Parameters.AddWithValue("@x", x);
                                c2.ExecuteNonQuery();
                                Console.WriteLine("Updated");
                            }
                            catch (SqlException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            finally
                            {
                                c.Close();
                            }
                            break;

                        case 3:
                            try
                            {
                                c.Open();
                                while (true)
                                {
                                    try
                                    {
                                        Console.WriteLine("Enter the location");
                                        location= Console.ReadLine();
                                        break;
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Invalid");
                                    }
                                }

                                //stored procedure to display of the employee for a given location
                                SqlCommand c3 = new SqlCommand("pay_details_display_sp @location", c);
                                c3.Parameters.AddWithValue("@location", location);
                                SqlDataReader rdr = c3.ExecuteReader();
                                DataTable tb = new DataTable();
                                tb.Load(rdr);
                                Console.WriteLine();
                                Console.WriteLine("name" + "\t" + "id" + "\t" + "basic" + "\t" + "dapay" + "\t" + "hrapay" + "\t" + "salary" + "\t");
                                foreach(DataRow r in tb.Rows)
                                {
                                    Console.Write(r["name"] + "\t");
                                    Console.Write(r["id"] + "\t");
                                    Console.Write(r["basic_pay"] + "\t");
                                    Console.Write(r["dapay" ] + "\t");
                                    Console.Write(r["hrapay"] + "\t");
                                    Console.Write(r["salary"] + "\t");
                                    Console.WriteLine();
                                }
                            }
                            catch (SqlException e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(e.Message);
                            }
                            finally
                            {
                                c.Close();
                            }
                            break;

                        case 4:
                            Environment.Exit(0);
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
           
        }
    }
}
