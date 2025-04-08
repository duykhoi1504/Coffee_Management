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
using System.IO;
using System.Security.Cryptography;
using TransferLayer;
namespace PresentationLayer
{
    public partial class FrmAdminAddProducts : UserControl
    {
        SqlConnection connect = new SqlConnection(@"");
        public FrmAdminAddProducts()
        {
            InitializeComponent();
            displayData();
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


        public void displayData()
        {
            AdminAddProductsData prodData = new AdminAddProductsData();
            List<AdminAddProductsData> listData = prodData.ProductsListData();

            dataGridView1.DataSource = listData;
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
                        string selectProID = "SELECT * FROM products WHERE prod_id = @prodID";

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

                                string path = Path.Combine(@"D:\GitHub\Coffee_Management\CoffeeShopManagement\PresentationLayer\Product_Directory\"
                                         + adminAddProducts_id.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);
                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(adminAddProducts_imageView.ImageLocation, path, true);



                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@prodID", adminAddProducts_id.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodName", adminAddProducts_name.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodType", adminAddProducts_type.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodStock", adminAddProducts_stock.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodPrice", adminAddProducts_price.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodStatus", adminAddProducts_status.Text.Trim());
                                    cmd.Parameters.AddWithValue("@prodImage", path); // Assuming you will add image later
                                    cmd.Parameters.AddWithValue("@dateInsert", Today);


                                    cmd.ExecuteNonQuery();

                                    ClearFields();

                                    MessageBox.Show("Added Succesfully", "Infomation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    displayData();
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
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                string imagePath = "";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    adminAddProducts_imageView.ImageLocation = imagePath;

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void ClearFields()
        {
            adminAddProducts_id.Text = "";
            adminAddProducts_name.Text = "";
            adminAddProducts_stock.Text = "";
            adminAddProducts_price.Text = "";
            adminAddProducts_type.SelectedIndex = -1;
            adminAddProducts_status.SelectedIndex = -1;
            adminAddProducts_imageView.Image = null;
        }

        private void adminAddProducts_clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                adminAddProducts_id.Text = row.Cells[1].Value.ToString();
                adminAddProducts_name.Text = row.Cells[2].Value.ToString();
                adminAddProducts_type.Text = row.Cells[3].Value.ToString();
                adminAddProducts_stock.Text = row.Cells[4].Value.ToString();
                adminAddProducts_price.Text = row.Cells[5].Value.ToString();
                adminAddProducts_status.Text = row.Cells[6].Value.ToString();

                string imagePath = row.Cells[7].Value.ToString();
                try
                {
                    if (imagePath != null)
                    {
                        adminAddProducts_imageView.Image = Image.FromFile(imagePath);
                    }
                    else
                    {
                        adminAddProducts_imageView.Image = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Image: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void adminAddProducts_updateBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Please fill in all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to update this product id:" + adminAddProducts_id.Text.Trim() + "?",
                    "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string updateData = "UPDATE Products SET" +
                            " prod_name = @prodName," +
                            " prod_type = @prodType," +
                            " prod_stock = @prodStock," +
                            " prod_price = @prodPrice," +
                            " prod_status = @prodStatus," +
                            " date_update = @dateUpdate," +
                            "WHERE prod_id = @prodID";
                        DateTime today = DateTime.Today;

                        using (SqlCommand updateD = new SqlCommand(updateData, connect))
                        {
                            updateD.Parameters.AddWithValue("@prodName", adminAddProducts_name.Text.Trim());
                            updateD.Parameters.AddWithValue("@prodType", adminAddProducts_type.Text.Trim());
                            updateD.Parameters.AddWithValue("@prodStock", adminAddProducts_stock.Text.Trim());
                            updateD.Parameters.AddWithValue("@prodPrice", adminAddProducts_price.Text.Trim());
                            updateD.Parameters.AddWithValue("@prodStatus", adminAddProducts_status.Text.Trim());
                            updateD.Parameters.AddWithValue("@dateUpdate", today);
                            updateD.Parameters.AddWithValue("@prodID", adminAddProducts_id.Text.Trim());

                            updateD.ExecuteNonQuery();
                            ClearFields();
                            MessageBox.Show("Updated Succesfully", "Infomation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            displayData();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("connection fail: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void adminAddProducts_deleteBtn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("Please fill in all fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure you want to Delete this product id:" + adminAddProducts_id.Text.Trim() + "?",
                    "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (check == DialogResult.Yes)
                {
                    try
                    {
                        connect.Open();

                        string updateData = "UPDATE products SET date_delete = @dateDelete WHERE prod_id=@prodID";
                        DateTime today = DateTime.Today;

                        using (SqlCommand updateD = new SqlCommand(updateData, connect))
                        {
                     
                            updateD.Parameters.AddWithValue("@dateDelete", today);
                            updateD.Parameters.AddWithValue("@prodID", adminAddProducts_id.Text.Trim());

                            updateD.ExecuteNonQuery();
                            ClearFields();
                            MessageBox.Show("DELETE Succesfully", "Infomation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            displayData();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Delete fail: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
}