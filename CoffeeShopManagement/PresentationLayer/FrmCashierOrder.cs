using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using TransferLayer;

namespace PresentationLayer
{
    public partial class FrmCashierOrder : UserControl
    {
        SqlConnection connect = new SqlConnection(@"");

        public FrmCashierOrder()
        {
            InitializeComponent();
            DisplayAvailiableProds();
        }

        public void DisplayAvailiableProds()
        {
            CashierOrderFormProdData allProds= new CashierOrderFormProdData();
            List<CashierOrderFormProdData> listData = allProds.aviliableProductsData();
            cashierOrderForm_menuTable.DataSource = listData;
        }

        private void cashierOrderForm_addBtn_Click(object sender, EventArgs e)
        {

        }

        private void cashierOrderForm_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset the product ID dropdown
            cashierOrderForm_productID.SelectedIndex = -1;
            cashierOrderForm_productID.Items.Clear();
            cashierOrderForm_prodName.Text = "";
            cashierOrderForm_price.Text = "";
            // Get the selected product type
            string selectedValue = cashierOrderForm_type.SelectedItem as string;

            if (selectedValue !=null)
            {
                try
                {
                    // Open a new connection
                    using (SqlConnection connect = new SqlConnection(@""))
                    {
                        connect.Open();

                        // Query to fetch products based on the selected type
                        string selectData = "SELECT prod_id FROM Products WHERE prod_type = @prodType AND prod_status = @status AND date_delete IS NULL";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                           
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string value = reader["prod_id"].ToString();
                                    cashierOrderForm_productID.Items.Add(value);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Display error message
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cashierOrderForm_productID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy giá trị được chọn từ dropdown
            string selectedValue = cashierOrderForm_productID.SelectedItem as string;

            if (selectedValue != null)
            {
                try
                {
                    // Mở kết nối cơ sở dữ liệu
                    using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\cafe.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        connect.Open();

                        // Truy vấn để lấy thông tin sản phẩm
                        string selectData = "SELECT prod_name, prod_price FROM Products WHERE prod_id = @prodID AND prod_status = @status AND date_delete IS NULL";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                           
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    // Lấy tên và giá sản phẩm từ kết quả truy vấn
                                    string prodName = reader["prod_name"].ToString();
                                    string prodPrice = reader["prod_price"].ToString();

                                    // Hiển thị thông tin sản phẩm lên giao diện
                                    cashierOrderForm_prodName.Text = prodName;
                                    cashierOrderForm_price.Text = prodPrice;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có ngoại lệ
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
