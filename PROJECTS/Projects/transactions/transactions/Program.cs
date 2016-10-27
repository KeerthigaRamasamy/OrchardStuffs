using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//using sql transactions to transfer money from one account to another account
namespace transactions
{
    class Program
    {
        static void Main(string[] args)
        {
            int result1, result2, result3, result4;
            string connectionstr = "Data Source=172.17.2.13;Initial Catalog=M1037727;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionstr);// connection object
            SqlTransaction tr1 = null; //transaction objects
            SqlTransaction tr2=null;
            try
            {
                conn.Open();        //opening the connection

                //before updation of the table
                transc_display.display();
                //transfering 20,000 from one account to another account              
                SqlCommand com1 = new SqlCommand("UPDATE transactions SET balance=balance-2000 WHERE acc_holder_name='jeevan'", conn);
                SqlCommand com2 = new SqlCommand("UPDATE transactions SET balance=balance+2000 WHERE acc_holder_name='mahesh';", conn);
                SqlCommand com3 = new SqlCommand("UPDATE transactions SET balance=balance-5000 WHERE acc_holder_name='mahesh';", conn);
                SqlCommand com4 = new SqlCommand("UPDATE transactions SET balance=balance+5000 WHERE acc_holder_name='sunil';", conn);

                //beginning the transaction
                tr1 = conn.BeginTransaction();
                tr2 = conn.BeginTransaction();

                //referencing the transaction object to sql command objects to specify that these belong to one transaction
                com1.Transaction = tr1;
                com2.Transaction = tr1;
                com3.Transaction = tr2;
                com4.Transaction = tr2;

                //executing the sql commands and storing the results 
                result1= com1.ExecuteNonQuery();
                result2 = com1.ExecuteNonQuery();
                result3 = com1.ExecuteNonQuery();
                result4 = com1.ExecuteNonQuery();

                if(result1!=0 && result2!=0)
                {
                    tr1.Commit();           //if both the statements executed successfully , save the changes
                    Console.WriteLine("Committed");
                }
                else
                {
                    tr1.Rollback();         //else roll back 
                    Console.WriteLine("Committed");
                }
                if (result3 != 0 && result4 != 0)
                {
                    tr2.Commit();
                }
                else
                {
                    tr2.Rollback();
                }
            }
            catch(SqlException e)
            {
                tr1.Rollback();
                tr2.Rollback();
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                tr1.Rollback();
                tr2.Rollback();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The table after the transaction is");
                transc_display.display();
                conn.Close();
            }
        }
    }
    class transc_display
    {
        static public void display()
        {
            string connectionstr = "Data Source=172.17.2.13;Initial Catalog=M1037727;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connectionstr);// connection object
            try
            {
                conn.Open();
                SqlCommand c1 = new SqlCommand("SELECT* FROM transactions", conn);
                SqlDataReader rdr = c1.ExecuteReader();
                Console.WriteLine("id" + "\t" + "name" + "\t" + "balance");
                while (rdr.Read())
                {
                    Console.Write(rdr["account_id"].ToString()+"\t");
                    Console.Write(rdr["acc_holder_name"].ToString() + "\t");
                    Console.Write(rdr["balance"].ToString() + "\t");
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
                conn.Close();
            }
        }
    }
}
