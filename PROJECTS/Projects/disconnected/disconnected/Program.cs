using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

//disconnected architecture
namespace disconnected
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int c1;
            int id, age;
            //string n1, n2;
            Console.WriteLine("----Disconnected Architecture-----");
            while (true)
            {
                Console.WriteLine("1.select");
                Console.WriteLine("2.insert");
                Console.WriteLine("3.update");
                Console.WriteLine("4.delete");
                Console.WriteLine("5.exit");
                while (!(int.TryParse(Console.ReadLine(), out c1)) || c1 < 0 || c1 > 6)
                {
                    Console.WriteLine("Invalid, enter again");
                }
                SqlConnection c = new SqlConnection("Data Source=172.17.2.13;Initial Catalog=M1037727;Integrated Security=True");      //connection object
                SqlDataAdapter a = new SqlDataAdapter("SELECT* FROM details ", c);
                DataSet s = new DataSet();
                SqlCommandBuilder com = new SqlCommandBuilder(a);
                //fill method implicitly opens and closes the connection
                a.Fill(s, "Details");
                switch (c1)
                {
                    case 1:
                        //SqlConnection c = new SqlConnection("Data Source=172.17.2.13;Initial Catalog=M1037727;Integrated Security=True");      //connection object
                        //a = new SqlDataAdapter("SELECT* FROM details ", c);      //data adapter
                                                                                 //DataSet s = new DataSet();

                        // fill method implicitly opens and closes the connection
                        //a.Fill(s, "Details");
                        Console.WriteLine("Display!!");
                        DataTable t = new DataTable();
                        t = s.Tables["Details"];                    //populating the data table from data set
                        Console.WriteLine("The employee details table");
                        Console.WriteLine("Emp_id" + "\t" + "F_name" + "\t" + "l_name" + "\t" + "Age");
                        Console.WriteLine();

                        //printing the rows in the data table
                        foreach (DataRow r in t.Rows)
                        {
                            Console.Write(r["emp_id"].ToString() + "\t");
                            Console.Write(r["first_name"].ToString() + "\t");
                            Console.Write(r["last_name"].ToString() + "\t");
                            Console.Write(r["age"].ToString() + "\t");
                            Console.WriteLine();
                        }
                        break;
                    case 2:
                        Console.WriteLine("Insertion!!");
                        DataRow row = s.Tables["Details"].NewRow();
                       // row = s.Tables["Details"].NewRow();
                        Console.WriteLine("Enter the employee id");
                        while (!(int.TryParse(Console.ReadLine(), out id)))
                            Console.WriteLine("Invalid number");
                        row["emp_id"] = id;
                        Console.WriteLine("Enter the first name");
                        //n1=Console.ReadLine();
                        Console.WriteLine("Enter the last name");
                        row["first_name"] = Console.ReadLine();
                        row["last_name"] = Console.ReadLine();
                        //n2= Console.ReadLine();
                        Console.WriteLine("Enter the age");
                        while (!(int.TryParse(Console.ReadLine(), out age)))
                            Console.WriteLine("Invalid number");
                        row["age"] = age;
                        //SqlCommandBuilder scb=new SqlCommandBuilder
                        s.Tables["Details"].Rows.Add(row);

                        //update command internally opens the connection make the changes and close it
                        try
                        {
                            int f = a.Update(s, "Details");
                            if (f > 0)
                                Console.WriteLine("Inserted Successfully");
                            else
                                Console.WriteLine("insertion failed");
                        }
                        catch (SqlException e)
                        {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 3:
                        //Console.WriteLine("Updation!!");
                        //Console.WriteLine("Enter the employee id to update");
                        //while (!(int.TryParse(Console.ReadLine(), out id)))
                        //    Console.WriteLine("Invalid number");
                        //try
                        //{
                        //    DataRow row1 = s.Tables["Details"].Rows.Find(id);
                        //    Console.WriteLine("Enter the new employee details");
                        //    Console.WriteLine("Enter the new employee first name");
                        //    row1["first_name"] = Console.ReadLine();
                        //    Console.WriteLine("Enter the new employee last name");
                        //    row1["last_name"] = Console.ReadLine();
                        //    Console.WriteLine("Enter the new employee age");
                        //    row1["age"] = Console.ReadLine();

                        //    //updating the updated changes from dataset to dataadapter
                        //    a.Update(s, "Details");
                        //    Console.WriteLine("Updated successfully!!");
                        //}
                        //catch (SqlException e)
                        //{
                        //    Console.WriteLine(e.Message);
                        //}
                        break;
                    case 4:
                    //    Console.WriteLine("Deletion!");
                    //    Console.WriteLine("Enter the employee id to delete");
                    //    while (!(int.TryParse(Console.ReadLine(), out id)))
                    //        Console.WriteLine("Invalid number");
                    //    try
                    //    {
                    //        DataRow row2 = s.Tables["Details"].Rows.Find(id);
                    //        s.Tables["Details"].Rows.Remove(row2);
                    //        a.Update(s, "Details");
                    //    }
                    //    catch (SqlException e)
                    //    {
                    //        Console.WriteLine(e.Message);
                    //    }
                    //    break;
                    //case 5:
                    //    Environment.Exit(0);
                        break;
                }
            }
            
            Console.ReadKey();
        }
    }
}
