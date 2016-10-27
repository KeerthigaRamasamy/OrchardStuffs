using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

/* Football matches*/
namespace NEW1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int choice=0;
            string n1="" ,n2=" ",name=" ";
            int g1=0, g2=0, flag = 1,flag1=1,flag2=1;
            DateTime d = new DateTime();
                while (true)
                {
                    Console.WriteLine("********");
                    Console.WriteLine("1.Add match details");
                    Console.WriteLine("2.List all matches won by a given team");
                    Console.WriteLine("3.Exit");
                    Console.WriteLine("********");
                    Console.WriteLine("Enter your choice");
                    flag2 = 1;
                    while (flag2 == 1)
                    {
                        try
                        {
                            choice = int.Parse(Console.ReadLine()); flag2 = 0;
                        }
                        catch(FormatException )
                        {
                            Console.WriteLine("Invalid entry"); flag2 = 1;
                        }
                    }
                    
                    switch (choice)
                    {

                            /*Adding match details*/
                        case 1:
                            //establishing the sql connection
                            SqlConnection s = new SqlConnection("Data Source=172.17.2.13;Initial Catalog=M1037727;Integrated Security=True");
                            while (flag1 == 1)
                            {
                                try
                                {
                                    s.Open();               //open connection
                                    Console.WriteLine("___________________");
                                    Console.WriteLine("Available teams");
                                    Console.WriteLine("___________________");
                                    SqlCommand c1 = new SqlCommand("SELECT* FROM teams", s);            //sql command object
                                    SqlDataReader rdr = c1.ExecuteReader();                             //sql data reader

                                    while (rdr.Read())          //if it has rows to read
                                    {
                                        Console.WriteLine(rdr[0].ToString());   //converting object to string
                                    }
                                    Console.WriteLine("_____________________");
                                    rdr.Close();
                                    Console.WriteLine("Enter 2 teams from the following");
                                    flag = 1;
                                    //flag1 = 1;

                                    while (flag == 1)
                                    {
                                        try
                                        {

                                            Console.WriteLine("Enter match date in the format of YYY/MM/DD");
                                            //date = Console.ReadLine();
                                            d = Convert.ToDateTime(Console.ReadLine()); flag = 1;
                                            //d = Convert.ToDateTime(date);
                                            while(flag==1)
                                            {
                                            Console.WriteLine("select the first team name");
                                            n1 = Console.ReadLine();
                                            Console.WriteLine("select the second team name");
                                            n2 = (Console.ReadLine()); flag = 0;
                                                if(n1==n2)
                                                {
                                                    flag = 1; Console.WriteLine("First team name and second team name cannot be the same");
                                                }

                                            }
                                            Console.WriteLine("Enter the first team goals");
                                            g1 = int.Parse(Console.ReadLine());
                                            Console.WriteLine("Enter the second team goals");
                                            g2 = int.Parse(Console.ReadLine());
                                            flag = 0;
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Invalid entry");
                                            flag = 1;
                                        }
                                    }
                                    /* Command for inserting the match details*/
                                    SqlCommand c = new SqlCommand("INSERT INTO matches(match_date,first_team_name,second_team_name,first_team_goals,second_team_goals) VALUES(@d,@n1,@n2,@g1,@g2)", s);
                                    c.Parameters.AddWithValue("@d", d);
                                    c.Parameters.AddWithValue("@n1", n1);
                                    c.Parameters.AddWithValue("@n2", n2);
                                    c.Parameters.AddWithValue("@g1", g1);
                                    c.Parameters.AddWithValue("@g2", g2);
                                    c.ExecuteNonQuery();                //executing the sql command
                                    Console.WriteLine("Match details added");
                                    flag1 = 0;
                                }
                                catch (SqlException)
                                {
                                    Console.WriteLine("Sql exception,invalid names");
                                    flag1 = 1;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e);
                                    flag1 = 1;
                                }

                                finally
                                {
                                    s.Close();          //closing the connection
                                }
                            }
                            break;


                        /*List all the matches won by a given team*/
                        case 2:
                            SqlConnection s1 = new SqlConnection("Data Source=172.17.2.13;Initial Catalog=M1037727;Integrated Security=True");
                            flag = 1;
                            while(flag==1)
                            {
                            try
                            {
                                s1.Open();  //open connection
                                SqlCommand c1 = new SqlCommand("SELECT team_name from teams", s1);  //sql command object
                                SqlDataReader r = c1.ExecuteReader();
                                Console.WriteLine("Available teams");
                                Console.WriteLine("_____________________");
                                while(r.Read())
                                {
                                    Console.WriteLine(r[0].ToString());
                                }
                                Console.WriteLine("_____________________");
                                r.Close();
                                flag = 1;
                                while(flag==1)
                                {
                                try
                                {
                                    Console.WriteLine("Enter team name");
                                    name = Console.ReadLine();
                                    flag = 0;
                                }
                                catch(FormatException)
                                {
                                    Console.WriteLine("Invalid entry");
                                    flag = 1;
                                }
                                }
                                /* Command to select the list of matches won by a given team*/
                                SqlCommand c2 = new SqlCommand("SELECT* FROM matches WHERE (first_team_name='"+name+"') and (first_team_goals>second_team_goals) UNION SELECT* FROM matches WHERE (second_team_name='"+name+"') and (second_team_goals>first_team_goals)", s1);
                                SqlDataReader r1 = c2.ExecuteReader();
                                int i;
                                /* displaying the table using data reader*/
                                Console.WriteLine("_______________________________________________________________");
                                while(r1.Read())
                                {
                                    for (i = 0; i < 5;i++ )
                                        Console.Write(r1[i].ToString()+"\t");
                                    Console.WriteLine();
                                }
                                Console.WriteLine("________________________________________________________________");
                                flag = 0;
                                r1.Close();
                            }
                            catch (SqlException)
                            {
                                Console.WriteLine("Sql exception,invalid column names or values"); flag = 1;
                            }
                            //catch (Exception)
                            //{
                            //    Console.WriteLine("invalid column names or values"); flag = 1;
                            //}
                           
                            finally
                            {
                               s1.Close();  
                            }
                            }
                            break;
                           
                        case 3:
                            Environment.Exit(0);
                            break;
                    }
                }
        }
        }
    }

