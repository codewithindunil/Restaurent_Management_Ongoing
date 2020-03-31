using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace project2
{
    class OrderDb
    {
        String eachPrice,max;

        public void saveOrder(String orderNo,String itemCode,String size,String qty,String ePrice,String total)
        {
            String date =DateTime.Now.ToString();
            MySqlDataReader rd;

            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server=localhost;database=restauretdb;uid=root;pwd=;";
            conn = new MySqlConnection(connetionString);
            String query;
            query = "insert into restauretdb.orders_tb ( orderNo,itemCode, size, qty, eachPrice, total, date) values" +
                " ('"+ orderNo + "','" + itemCode + "','" + size + "','" + qty + "','" + ePrice + "','" + total + "','" + date + "')";

            MySqlCommand command = new MySqlCommand(query, conn);

            try
            {
                conn.Open();
                rd = command.ExecuteReader();


                Console.WriteLine("order saved");
                conn.Close();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                conn.Dispose();
            }

        }
        public String searchItem(String itemCode,String size)
        {
            

            MySqlDataReader rd;

            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server=localhost;database=restauretdb;uid=root;pwd=;";
            conn = new MySqlConnection(connetionString);
            String query;
            

            query = "select * from itemlist_tb where itemCode = '" + itemCode + "' and size ='"+size+"'";
            conn.Open();
            MySqlCommand command = new MySqlCommand(query, conn);
            rd = command.ExecuteReader();
            try
            {
                if (rd.Read())
                {
                    eachPrice = (rd["price"].ToString());
                    //txtMobile.Text = (rd["mobile"].ToString());
                    //txtSubject.Text = (rd["subO"].ToString());
                    Console.WriteLine(eachPrice);


                }
                rd.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return eachPrice;
        }

        public String searchNextOrderNo()
        {
            MySqlDataReader rd;

            MySqlConnection conn;
            string connetionString = null;
            connetionString = "server=localhost;database=restauretdb;uid=root;pwd=;";
            conn = new MySqlConnection(connetionString);
            String query;
            conn.Open();
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT MAX(orderNo) from orders_tb", conn);
                max = command.ExecuteScalar().ToString();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                conn.Close();
            }

            return max;
        }

    }
}
