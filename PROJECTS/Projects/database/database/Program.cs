using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

/*storing and retrieving from the database using connected architecture*/
namespace database
{
    class Program
    {
        public static string str = "Data Source=172.17.2.13;Initial Catalog=M1037727;Integrated Security=True";  //connection string
        public static SqlConnection c = new SqlConnection(str);   //acquiring a connection
        public static void Main(string[] args)
        {
            
            string name="",name1="", designation="",designation1="";
            int id1 = 0,id2=0;
            int n=0,  s=0;
            
            try
            {
                c.Open();                                  //opening the connection
                SqlCommand com = new SqlCommand();         //sql command object
                t: while (true)
                {
                    Console.WriteLine("1.Add");
                    Console.WriteLine("2.Update");
                    Console.WriteLine("3.Delete");
                    Console.WriteLine("4.Display");
                    Console.WriteLine("5.Exit");
                    int flag = 1;
                    while (flag == 1)
                    {
                        try
                        {
                            s = int.Parse(Console.ReadLine());
                            flag = 0;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid entry");
                            flag = 1;
                        }
                    }
                    if (s > 5 || s < 0)
                    {
                        Console.WriteLine("Enter values from 1 to 5");
                        goto t;
                    }
                    switch (s)
                    {
                        case 1:
                            /*Adding*/
                            add(n,name,id1,designation);
                            break;
                        case 2:
                            /*Updating*/
                            update(name1,id2,designation1,n);
                            break;

                        case 3:
                            /*deleting*/
                            delete();
                            break;

                        case 4:
                            /*displaying*/
                            display();
                            break;

                        case 5:
                            /*Exit*/
                            Environment.Exit(0);
                            break;
                    }
                }  
            }
           
             catch(SqlException e)          //sql exception handling
            {
                Console.WriteLine(e);
            }
             catch(Exception e)             //other possible exceptions handling
            {
                Console.WriteLine(e);
            }
            finally
            {
                c.Close();
                Console.ReadKey();
            }
        }

        /* Function for adding the entries into the database*/
        static public void add(int n,string name,int id1, string designation)
        {
            int i;
        t1: try
            {
                do
                {
                    Console.WriteLine("Enter the number of rows to be inserted in the employee table");
                    n = int.Parse(Console.ReadLine());   //getting the number of rows to be inserted
                } while ((n <= 0) || (n > 20));
            }
            catch (Exception)                            //handling the exception
            {
                Console.WriteLine("Invalid entry");
                goto t1;
            }
            Console.WriteLine("Enter the values to be inserted");
           
            for (i = 0; i < n; i++)                //getting the details of employee 
            {
            t3: try
                {
                    Console.WriteLine("Enter the employee name");
                    name = Console.ReadLine();
                    Console.WriteLine("Enter the employee's designation");
                    designation = Console.ReadLine();
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid entries, enter again");
                    goto t3;
                }
                SqlCommand com;
                
                com = new SqlCommand("INSERT INTO employee(emp_name,designation) VALUES(@name,@designation);", c);
                com.Parameters.AddWithValue("@name", name);
               
                com.Parameters.AddWithValue("@designation", designation);
                
                com.ExecuteNonQuery();          //executing the query
            }

        }

        /* Function for updating the entries into the database*/
           static public void update(string name1,int id2, string designation1,int n)
        {
            Console.WriteLine("Updation");
            Console.WriteLine("Enter the employee id to be updated");
            id2 = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Enter the new employee name");
            name1 = Console.ReadLine();
            Console.WriteLine("Enter the new employee designation");
            designation1 = Console.ReadLine();
           
            SqlCommand com1 = new SqlCommand("UPDATE employee SET emp_name=@name1 ,designation=@designation1 WHERE emp_id=@id2;", c);
            com1.Parameters.AddWithValue("@name1", name1);
            com1.Parameters.AddWithValue("@id2", id2);
            com1.Parameters.AddWithValue("@designation1", designation1);
            com1.ExecuteNonQuery();
            Console.WriteLine("Updated");
        }

           /* Function for deleting the entries into the database*/
           static public void delete()
           {
               Console.WriteLine("deletion");
           t2: try
               {
                   Console.WriteLine("Enter the employee name to be deleted");    //column to be deleted
                   string val = Console.ReadLine();
                   SqlCommand com2;
                   com2 = new SqlCommand("DELETE from employee WHERE emp_name=@val", c);
                   com2.Parameters.AddWithValue("@val", val);
                   //com2.Connection = c;
                   com2.ExecuteNonQuery();
                   Console.WriteLine("Deleted");
               }
               catch (SqlException)
               {
                   Console.WriteLine("Invalid entry,enter again");
                   goto t2;
               }
           }

           /* Function for displaying the entries into the database*/
            static public void display()
           {
               Console.WriteLine("Display");
               SqlCommand comm = new SqlCommand("SELECT* FROM employee;", c);
               SqlDataReader reader = comm.ExecuteReader();     //reader object to read from database
             
               if (reader.HasRows)
               {
                   while (reader.Read())
                   {
                       string n1 = String.Format("{0} {1} {2}", reader["emp_name"], reader["emp_id"], reader["designation"]);
                       Console.WriteLine(n1);
                   }
                   
               }
                
               else
               {
                   Console.WriteLine("no  rows in the table");
               }
               reader.Close();
           }
    }
}
