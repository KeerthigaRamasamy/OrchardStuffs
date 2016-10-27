using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace sp
{
    public class Program
    {
        public static string first = "", last = "", job_id = "";
        public static int salary = 0, dep_id = 0, id1 = 0, id2 = 0;
        public static DateTime join_date;
        public static void Main(string[] args)
        {
            int n = 0, s = 0;
            try
            {

            t: while (true)
                {
                    Console.WriteLine("1.Insert using stored procedure");
                    Console.WriteLine("2.Update using stored procedure");
                    Console.WriteLine("3.Use Group by and having");
                    Console.WriteLine("4.Exit");
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
                            add();
                            break;
                        case 2:
                            /*Updating*/
                            update();
                            break;

                        case 3:
                            /*deleting*/
                            groupby();
                            break;
                        case 4:
                            /*Exit*/
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            catch (SqlException e)          //sql exception handling
            {
                Console.WriteLine(e);
            }
            catch (Exception e)             //other possible exceptions handling
            {
                Console.WriteLine(e);
            }

        }

        /* Function for adding the entries into the database*/
        static public void add()
        {
            string str = "Data Source=172.17.2.13;Initial Catalog=M1037727;Integrated Security=True";  //connection string
            SqlConnection c = new SqlConnection(str);   //acquiring a connection
            try
            {
                c.Open();                                  //opening the connection
                SqlCommand com = new SqlCommand();         //sql command object 
                int i, n;
            t1: try
                {
                    do
                    {
                        Console.WriteLine("Enter the number of rows to be inserted in the employee table");
                        n = int.Parse(Console.ReadLine());   //getting the number of rows to be inserted
                    } while ((n <= 0) || (n > 10));
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
                        Console.WriteLine("Enter the employee's first name");
                        first = Console.ReadLine();
                        Console.WriteLine("Enter the employee's last name");
                        last = Console.ReadLine();
                        Console.WriteLine("Enter the join date");
                        join_date = Convert.ToDateTime(Console.ReadLine());
                        Console.WriteLine("Enter the salary");
                        salary = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the job id");
                        job_id = Console.ReadLine();
                        Console.WriteLine("Enter the department id");
                        dep_id = Convert.ToInt32(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid entries, enter again");
                        goto t3;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid entries, enter again");
                        goto t3;
                    }

                    //executing the stored procedure to insert values into the table
                    com = new SqlCommand("insert_employee_details_sp @first,@last,@date,@salary,@job_id,@dep_id", c);
                    com.Parameters.AddWithValue("@first", first);
                    com.Parameters.AddWithValue("@last", last);
                    com.Parameters.AddWithValue("@date", join_date);
                    com.Parameters.AddWithValue("@salary", salary);
                    com.Parameters.AddWithValue("@job_id", job_id);
                    com.Parameters.AddWithValue("@dep_id", dep_id);
                    com.ExecuteNonQuery();          //executing the query
                }
            }
            catch (SqlException)
            {
                Console.WriteLine("sql exception");
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid");
            }
            finally
            {
                c.Close();
                Console.ReadKey();
            }
        }

        /* Function for updating the entries into the database*/
        static public void update()
        {
            string str = "Data Source=172.17.2.13;Initial Catalog=M1037727;Integrated Security=True";  //connection string
            SqlConnection c = new SqlConnection(str);   //acquiring a connection
            while (true)
            {
                try
                {
                    c.Open();
                    while (true)
                    {
                        try
                        {
                            Console.WriteLine("Updation");
                            Console.WriteLine("Enter the employee id to be updated");
                            id2 = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the employee's first name");
                            first = Console.ReadLine();
                            Console.WriteLine("Enter the employee's last name");
                            last = Console.ReadLine();
                            Console.WriteLine("Enter the join date");
                            join_date = Convert.ToDateTime(Console.ReadLine());
                            Console.WriteLine("Enter the salary");
                            salary = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the job id");
                            job_id = Console.ReadLine();
                            Console.WriteLine("Enter the department id");
                            dep_id = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid entry");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid");
                        }
                    }

                    //update using stored procedure
                    SqlCommand com1 = new SqlCommand("update_employee_details_sp @id2,@first,@last,@date,@salary,@job_id,@dep_id", c);
                    com1.Parameters.AddWithValue("@first", first);
                    com1.Parameters.AddWithValue("@last", last);
                    com1.Parameters.AddWithValue("@id2", id2);
                    com1.Parameters.AddWithValue("@date", join_date);
                    com1.Parameters.AddWithValue("@salary", salary);
                    com1.Parameters.AddWithValue("@job_id", job_id);
                    com1.Parameters.AddWithValue("@dep_id", dep_id);
                    com1.ExecuteNonQuery();
                    Console.WriteLine("Updated");
                    break;
                }
                catch (SqlException)
                {
                    Console.WriteLine("sql exception");
                }
                finally
                {
                    c.Close();
                    Console.ReadKey();
                }
                
            }
        }

        static public void groupby()
        {
            Console.WriteLine("Sum of Salary paid to each department:");
            string str = "Data Source=172.17.2.13;Initial Catalog=M1037727;Integrated Security=True";  //connection string
            SqlConnection c = new SqlConnection(str);   //acquiring a connection
            while (true)
            {
                try
                {
                    c.Open();
                    SqlCommand com = new SqlCommand("SELECT SUM(salary) AS sum_of_salary,dep_id FROM employee_details GROUP BY dep_id;", c);
                    SqlDataReader rdr = com.ExecuteReader();
                    DataTable tb = new DataTable();
                    tb.Load(rdr);
                    Console.WriteLine("sum" + "\t" + "Dep_id" + "\t");
                    foreach(DataRow r in tb.Rows)
                    {
                        Console.Write(r["sum_of_salary"]+"\t");
                        Console.Write(r["dep_id"] + "\t");
                        Console.WriteLine();
                    }

                    Console.WriteLine("No of employees in each department:");
                    Console.WriteLine();
                    SqlCommand com1 = new SqlCommand("   SELECT COUNT(emp_id)AS no_of_employees, dep_id FROM employee_details GROUP BY dep_id;", c);
                    SqlDataReader rdr1 = com1.ExecuteReader();
                    DataTable tb1 = new DataTable();
                    tb1.Load(rdr1);
                    Console.WriteLine("num" + "\t" + "Dep_id" + "\t");
                    foreach (DataRow r1 in tb1.Rows)
                    {
                        Console.Write(r1["no_of_employees"] + "\t");
                        Console.Write(r1["dep_id"] + "\t");
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine("sum of salary paid to department id=50:");
                    Console.WriteLine();
                    SqlCommand com2 = new SqlCommand("SELECT SUM(salary) AS sum_of_salary, dep_id FROM employee_details WHERE dep_id = 50 GROUP BY dep_id; ", c);
                    SqlDataReader rdr2 = com2.ExecuteReader();
                    DataTable tb2 = new DataTable();
                    tb2.Load(rdr2);
                    Console.WriteLine("sum" + "\t" + "Dep_id(50)" + "\t");
                    foreach (DataRow r2 in tb2.Rows)
                    {
                        Console.Write(r2["sum_of_salary"] + "\t");
                        Console.Write(r2["dep_id"] + "\t");
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    Console.WriteLine("number of employees from each department where at least two employee present in department");
                    Console.WriteLine();
                    SqlCommand com3 = new SqlCommand("SELECT COUNT(emp_id) AS no_of_employees,dep_id FROM employee_details GROUP BY dep_id HAVING count(emp_id)>=2 ;", c);
                    SqlDataReader rdr3 = com3.ExecuteReader();
                    DataTable tb3 = new DataTable();
                    tb3.Load(rdr3);
                    Console.WriteLine("Num" + "\t" + "Dep_id" + "\t");
                    foreach (DataRow r3 in tb3.Rows)
                    {
                        Console.Write(r3["no_of_employees"] + "\t");
                        Console.Write(r3["dep_id"] + "\t");
                        Console.WriteLine();
                    }
                    break;
                }
                catch (SqlException)
                {
                    Console.WriteLine("Sql exception");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid");
                }
                finally
                {
                    c.Close();
                }
            }
        }
    }
}









