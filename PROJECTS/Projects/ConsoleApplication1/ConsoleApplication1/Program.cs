using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;

//entity framework and linq

namespace ConsoleApplication1
{
    class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Insert");
                Console.WriteLine("2.Update");
                Console.WriteLine("3.display");
                Console.WriteLine("4.delete");
                Console.WriteLine("5.exit");
                int choice = 0, flag = 0;
                int id = 0, age = 0;
                string first = "", last = "";
                do
                {
                    try
                    {
                        choice = int.Parse(Console.ReadLine()); flag = 0;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("invalid entry");
                        flag = 1;
                    }
                } while (flag == 1 || choice < 0 || choice > 6);

                switch (choice)
                {
                    case 1:
                        insert();
                        break;
                    case 2:
                        update(id, age, first, last);
                        break;
                    case 3:
                        display(id, age, first, last);
                        break;
                    case 4:
                        delete(id, age, first, last);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                }
            }
        }

        #region insert
        public static void insert()
        {
            int id; int age; string first;string last;
            Console.WriteLine("Enter the details to insert into the database");
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter the employee id");
                    id = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the first name");
                    first = Console.ReadLine();
                    Console.WriteLine("Enter the last name");
                    last = Console.ReadLine();
                    Console.WriteLine("Enter the age");
                    age = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid entry");
                }
            }
            M1037727Entities d = new M1037727Entities();  //object for data context
            detail emp = new detail();
            try
                {
                         //object for details class(table)
                    emp.emp_id = id;
                    emp.age = age;
                    emp.first_name = first;
                    emp.last_name = last;

                //insertion
                d.details.Add(emp);
                d.SaveChanges();
                Console.WriteLine("Details inserted successfully");
                }
                catch(Exception e)
                {
                    Console.WriteLine("******* ");
                }
            
        }
        #endregion

        #region update
        public static void update(int id, int age, string first, string last)
        {
            using (M1037727Entities d = new M1037727Entities())  //object for data context
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter the employee id to update");
                        id = int.Parse(Console.ReadLine());
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Invalid");
                    }

                    var a = from data in d.details where data.emp_id.Equals(id) select data;  //linq query to retrieve id from database
                    if (a != null)
                    {

                        try
                        {
                            Console.WriteLine("Enter the new name(first name)");
                            first = Console.ReadLine();
                            Console.WriteLine("Enter the new name(last name)");
                            last = Console.ReadLine();
                            Console.WriteLine("Enter the age");
                            age = int.Parse(Console.ReadLine());
                            detail obj2 = d.details.Where(e => e.emp_id.Equals(id)).FirstOrDefault<detail>();
                            obj2.age = age;
                            obj2.first_name = first;
                            obj2.last_name = last;
                            d.SaveChanges();
                            Console.WriteLine("Updation successfull");
                            break;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid entry");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Invalid id");
                        }
                    }
                    else
                    {
                        Console.WriteLine("The employee id is not present in the table");
                    }
                }
            }
        }
        #endregion

        #region display
        public static void display(int id, int age, string first, string last)
        {
            using (M1037727Entities d = new M1037727Entities())  //object for data context
            {
                var disp = from emp in d.details select emp;
                foreach(var item in disp)
                {
                    Console.WriteLine(item.emp_id + " "+ item.first_name + " "+ item.last_name+" "+ item.age);
                }
                
                Console.Read();
            }
        }
        #endregion

        #region delete
        public static void delete(int id, int age, string first, string last)
        {
            using (M1037727Entities d = new M1037727Entities())  //object for data context
            {
                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter the employee id to delete");
                        id = int.Parse(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Invalid");
                    }
                    try
                    {
                        var a = from data in d.details where data.emp_id.Equals(id) select data;

                        if (a != null)
                        {
                            detail obj3 = d.details.Where(e => e.emp_id.Equals(id)).FirstOrDefault<detail>();
                            d.details.Remove(obj3);
                            d.SaveChanges();
                            Console.WriteLine("Deleted");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("There is no row in the table or invalid id");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("There is no row in the table or invalid id");
                    }
                }
            }
        }
        #endregion
    }
}
