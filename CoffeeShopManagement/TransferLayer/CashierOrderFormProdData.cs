using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.Remoting.Contexts;

namespace TransferLayer
{
    public  class CashierOrderFormProdData
    {

        public int ID { get; set; }//1
        public string ProductID { get; set; }//2
        public string ProductName { get; set; } //3
        public string type { get; set; } //4
        public string Stock { get; set; } //5
        public string Price { get; set; } //6
        public string Status { get; set; } //7

        SqlConnection connect = new SqlConnection(@"");

        public List<CashierOrderFormProdData> aviliableProductsData()
        {
            List<CashierOrderFormProdData> listData = new List<CashierOrderFormProdData>();
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM Products WHERE status=@stats AND date_delete IS NULL";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@stats", "Available");
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            CashierOrderFormProdData apd = new CashierOrderFormProdData();

                            apd.ID = (int)reader["id"];
                            apd.ProductID = reader["prod_id"].ToString();
                            apd.ProductName = reader["prod_name"].ToString();
                            apd.type = reader["prod_type"].ToString();
                            apd.Stock = reader["prod_stock"].ToString();
                            apd.Price = reader["prod_price"].ToString();
                            apd.Status = reader["status"].ToString();

                            listData.Add(apd);
                        }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Connection Failed: " + ex);
                }
                finally
                {
                    connect.Close();
                }
            }
            return listData;

        }
    }
}
