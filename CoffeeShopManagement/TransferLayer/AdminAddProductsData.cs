using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace TransferLayer
{
    public class AdminAddProductsData
    {
        public int ID { get; set; }//1
        public string ProductID { get; set; }//2
        public string ProductName { get; set; } //3
        public string type { get; set; } //4
        public string Stock { get; set; } //5
        public string Price { get; set; } //6
        public string Status { get; set; } //7
        public string Image { get; set; } //8
        public string DateInsert { get; set; } //9
        public string DateUpdate { get; set; } //10

        SqlConnection connect = new SqlConnection(@"");

        public List<AdminAddProductsData> ProductsListData()
        {
            List<AdminAddProductsData> listData = new List<AdminAddProductsData>();
            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    connect.Open();
                    string selectData = "SELECT * FROM Products WHERE date_delete IS NULL";
                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            AdminAddProductsData apd= new AdminAddProductsData();

                            apd.ID = (int)reader["id"];
                            apd.ProductID = reader["prod_id"].ToString();
                            apd.ProductName = reader["prod_name"].ToString();
                            apd.type = reader["prod_type"].ToString();
                            apd.Stock = reader["prod_stock"].ToString();
                            apd.Price = reader["prod_price"].ToString();
                            apd.Status = reader["prod_status"].ToString();
                            apd.Image = reader["prod_image"].ToString();
                            apd.DateInsert = reader["date_insert"].ToString();
                            apd.DateUpdate = reader["date_update"].ToString();

                            listData.Add(apd);



                        }
                    }
                }catch(Exception ex)
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
