using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmAdminAddProducts : UserControl
    {
        SqlConnection connect = new SqlConnection(@"");
        public FrmAdminAddProducts()
        {
            InitializeComponent();
        }

        public bool emptyFields()
        {
            if (adminAddProducts_id.Text == ""
                || adminAddProducts_name.Text == ""
                || adminAddProducts_type.SelectedIndex == -1
                || adminAddProducts_stock.Text == ""
                || adminAddProducts_price.Text == ""
                || adminAddProducts_status.SelectedIndex == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void adminAddProducts_addBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Please fill in all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();


                        //Checking if the product ID already exists
                        string selectProID = "SELECT * FROM Products WHERE prod_id = @prodID";

                        using (SqlCommand selectPID = new SqlCommand(selectProID, connect))
                        {
                            selectPID.Parameters.AddWithValue("@prodID", adminAddProducts_id.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(selectPID);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show("Product ID" + adminAddProducts_id.Text.Trim() + " is already exists. Please enter a different ID.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            else
                            {
                                string insertData = "INSERT INTO Products (prod_id, prod_name, prod_type," +
                                    " prod_stock, prod_price, prod_status, prod_image, date_insert)" +
                                    " VALUES (@prodID, @prodName, @prodType, @prodStock," +
                                    " @prodPrice, @prodStatus, @prodImage,@dateInsert)";
                                DateTime Today = DateTime.Today;
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@prodID", adminAddProducts_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodName", adminAddProducts_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodType", adminAddProducts_type.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodStock", adminAddProducts_stock.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodPrice", adminAddProducts_price.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodStatus", adminAddProducts_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodImage", "image path"); // Assuming you will add image later
                                    cmd.Parameters.AddWithValue("@dateInsert", Today);


                                    cmd.ExecuteNonQuery();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("fail connecton:" + ex, "Error Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        MessageBox.Show("Product added successfully!");
                        connect.Close();
                    }

                }
            }
        }

        private void adminAddProducts_importBtn_Click(object sender, EventArgs e)
        {

        }
       }   
   }
