using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

/* Consolidated marksheet of the students*/
namespace employeepgm
{
    class Program
    {
        static public void sort(int[] a, int n)                //sorting the object array on total marks
        {

            int temp, i, j,k;
            /*for (i = 0; i < n - 1; i++)                        //bubble sort 
            {
                for (j = i+1; j < n ; j++)
                {
                    if (a[i] > a[j])
                    {
                        temp = a[j];
                        a[j] = a[i];
                        a[j] = temp;
                    }
                }
            }
            for(k=0;k<n;k++)
            {
                Console.WriteLine(a[k]);
            }*/
           for (j = 0; j < n; j++)
            {
                for (k = 0; k < n - j - 1; k++)
                {
                    if (a[k] < a[k + 1])
                    {
                        temp = a[k];
                        a[k] = a[k + 1];
                        a[k + 1] = temp;
                    }
                }
            }
        }
        public static void Main(string[] args)
        {
        int i,n,j;
        do
        {
        t1: Console.WriteLine("Enter the no of students");   //getting the number of students
            try
            {
                n = int.Parse(Console.ReadLine());
            }
            catch (FormatException)                              //handling format exception
            {
                Console.WriteLine("Enter only ineteger values");
                goto t1;
            }
            catch (Exception)                                    //handling other exceptions
            {
                Console.WriteLine("Invalid entry");
                goto t1;
            }
        }while (n <= 0 || n>10);                                   //boundary condition
        student[] s = new student[n];                       //creating an array of objects
        int[] a = new int[n];
        for(i=0;i<n;i++)
        {
            student st =new student();
            st.details();                                  //getting the details of n students
            s[i] = st;
        }
        Console.WriteLine(" ");
        Console.WriteLine("_____________________________________________________________________");
        Console.Write("Name\t");
        Console.Write("Id\t");
        Console.Write("phy\t");
        Console.Write("che\t");
        Console.Write("Maths\t");
        Console.Write("tot\t");
        Console.Write("avg\t");
        Console.WriteLine(" ");
        
        for(i=0;i<n;i++)
        {
           s[i].display();
           a[i] = s[i].total();      //displaying the marks,total and average
        }
        Console.WriteLine("_____________________________________________________________________");
        Console.WriteLine(" ");

        DataTable table = new DataTable("Students Consolidated Marksheet");
        table.Columns.Add(new DataColumn("Student name"));
        table.Columns.Add(new DataColumn("Student id"));
        table.Columns.Add(new DataColumn("phy"));
        table.Columns.Add(new DataColumn("che"));
        table.Columns.Add(new DataColumn("maths"));
        table.Columns.Add(new DataColumn("tot"));
        table.Columns.Add(new DataColumn("avg"));
        for (i = 0; i < n; i++)
        {
            table.Rows.Add(s[i].name);
            table.Rows.Add(s[i].id);
            table.Rows.Add(s[i].phy);
            table.Rows.Add(s[i].che);
            table.Rows.Add(s[i].mat);
            table.Rows.Add(s[i].t);
            table.Rows.Add(s[i].a);
        }
        sort(a, n);
                                              //sorting the obj array based on total marks
        if (n >= 3)
        {
            Console.WriteLine("The three toperrs are");
            for (j = 0; j < 3; j++)
              {
                  i = 0;
                  while (i < n)
                  {
                      if (s[i].t == a[j])             //Printing the three topers
                      {
                          Console.WriteLine(s[i].name);
                      }
                      i++;
                  }
              }
        }
        Console.ReadKey();
        }
    }

    /* Student class*/
    class student
    {
        public string name;
        bool flag;
        public int id, che, phy, mat, t;
        public float a;
        public void details()                               //getting the details of the students
        {
            do
            {
            t2: try
                {
                    Console.WriteLine("Enter the student name");
                    name = Console.ReadLine();
                    flag = name.All(Char.IsLetter);
                }
                catch (FormatException)                                //handling exceptions
                {
                    Console.WriteLine("Invalid entry");
                    goto t2;
                }
                catch (Exception)                                //handling exceptions
                {
                    Console.WriteLine("Invalid entry");
                    goto t2;
                }
            } while (flag == false);                                //boundary condition
            do
            {
            t3: try
                {
                    Console.WriteLine("Enter the student id");
                    id = int.Parse(Console.ReadLine());
                }
                catch (Exception)                             //handling exceptions
                {
                    Console.WriteLine("Invalid entry");
                    goto t3;
                }
            } while (id < 0);                                  //boundary condition
            do
            {
            t4: try
                {
                    Console.WriteLine("Enter the physics marks");
                    phy = int.Parse(Console.ReadLine());
                }
                catch (Exception)                                 //handling exceptions
                {
                    Console.WriteLine("Invalid entry");
                    goto t4;
                }
            } while (phy < 0 || phy>100);                          //boundary condition
            do
            {
            t5: try
                {
                    Console.WriteLine("Enter the Chemistry marks");
                    che = int.Parse(Console.ReadLine());
                }
                catch (Exception)                                   //handling exceptions
                {
                    Console.WriteLine("Invalid entry");
                    goto t5;
                }
            } while (che < 0 || che > 100);                          //boundary condition
            do
            {
            t6: try
                {
                    Console.WriteLine("Enter the Maths marks");
                    mat = int.Parse(Console.ReadLine());
                }
                catch (Exception)                                    //handling exceptions
                {
                    Console.WriteLine("Invalid entry");
                    goto t6;
                }
            } while (mat < 0 || mat > 100);
            t = phy + che + mat;                            //calculating the total marks
            a = t / 3;                                      //calculating the average
        }
        public int total()
        {
            return t;
        }
        public void display()                               //dispalying the marks and results
        {
      
            Console.Write(name+"\t");
            Console.Write(id + "\t");
            Console.Write(phy + "\t");
            Console.Write(che + "\t");
            Console.Write(mat + "\t");
            Console.Write(t + "\t");
            Console.Write(a + "\t");
            Console.WriteLine(" ");
          
        }
        
    }
}
