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
using TransferLayer;
using System.IO;
namespace PresentationLayer
{
    public partial class FrmAdminAddUser : UserControl
    {
        SqlConnection connect = new SqlConnection(@"");
        public FrmAdminAddUser()
        {
            InitializeComponent();
            displayAddUsersData();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayAddUsersData();
        }

        public void displayAddUsersData()
        {
            AdminAddUsersData usersData = new AdminAddUsersData();
            List<AdminAddUsersData> listData = usersData.usersListData();

            dgvUsersTable.DataSource = listData;
        }

        public bool EmptyField()
        {
            if (adminAddUsers_username.Text == ""
                || adminAddUsers_password.Text == ""
                || adminAddUsers_role.Text == ""
                || adminAddUsers_status.Text == ""
                || adminAddUsers_imageView.Image == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void adminAddUsers_addBtn_Click(object sender, EventArgs e)
        {
            if (EmptyField())
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    connect.Open();
                }

                try
                {
                    // CHECK USERNAME IF EXISTING ALREADY
                    string selectUsern = "SELECT * FROM users WHERE username = @usern";
                    using (SqlCommand checkUsern = new SqlCommand(selectUsern, connect))
                    {
                        checkUsern.Parameters.AddWithValue("@usern", adminAddUsers_username.Text.Trim());

                        SqlDataAdapter adapter = new SqlDataAdapter(checkUsern);
                        DataTable table = new DataTable();
                        adapter.Fill(table);

                        if (table.Rows.Count >= 1)
                        {
                            string usern = adminAddUsers_username.Text.Substring(0, 1).ToUpper() + adminAddUsers_username.Text.Substring(1);
                            MessageBox.Show(usern + " is already taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            string insertData = "INSERT INTO users (username, password,profile_image, role, status,date_reg) " +
                                "VALUES (@usern,@pass, @image, @role, @status,@date)";

                            DateTime today = DateTime.Today;

                            string path = Path.Combine(@"D:\GitHub\Coffee_Management\CoffeeShopManagement\PresentationLayer\User_Directory\"
                                                    + adminAddUsers_username.Text.Trim() + ".jpg");
                            string directoryPath = Path.GetDirectoryName(path);

                            File.Copy(adminAddUsers_imageView.ImageLocation, path, true);
                            if (!Directory.Exists(directoryPath))
                            {
                                Directory.CreateDirectory(directoryPath);
                            }
                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", adminAddUsers_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", adminAddUsers_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@image", path);

                                cmd.Parameters.AddWithValue("@role", adminAddUsers_role.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", adminAddUsers_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();
                                ClearFields();
                                MessageBox.Show("User added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayAddUsersData();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connect.Close();
                }
            }

        }

        private void adminAddUsers_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog diaLog = new OpenFileDialog();
                diaLog.Filter = "Image Files (*.jpg; *.jpeg; *.png)|*.jpg; *.jpeg; *.png";
                string imagePath = "";
                if (diaLog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = diaLog.FileName;
                    adminAddUsers_imageView.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         
        private int id = 0;


        private void dgvUsersTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
   
            DataGridViewRow row = dgvUsersTable.Rows[e.RowIndex];
            id=(int)row.Cells[0].Value;
            adminAddUsers_username.Text = row.Cells[1].Value.ToString();
            adminAddUsers_password.Text = row.Cells[2].Value.ToString();
            adminAddUsers_role.Text = row.Cells[3].Value.ToString();
            adminAddUsers_status.Text = row.Cells[4].Value.ToString();

            string imagePath = row.Cells[5].Value.ToString();

            try
            {
                if (imagePath != null)
                {
                    adminAddUsers_imageView.Image = Image.FromFile(imagePath);
                }
                else
                {
                    adminAddUsers_imageView.Image = null;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No image: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
          
        }

        private void adminAddUsers_updateBtn_Click(object sender, EventArgs e)
        {
            if (EmptyField())
            {
                MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to update this user:" + adminAddUsers_username.Text.Trim() +
                   "?", "confirmation message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();
                            string updateData = "UPDATE users SET password = @pass, role = @role, status = @status WHERE username = @usern" +
                                "WHERE id=@id";
                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@usern", adminAddUsers_username.Text.Trim());
                                cmd.Parameters.AddWithValue("@pass", adminAddUsers_password.Text.Trim());
                                cmd.Parameters.AddWithValue("@role", adminAddUsers_role.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", adminAddUsers_status.Text.Trim());
                                cmd.Parameters.AddWithValue("@id", id);

                                cmd.ExecuteNonQuery();
                                ClearFields();
                                MessageBox.Show("User updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                displayAddUsersData();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        finally
                        {
                            connect.Close();
                        }
                    }
                }

            }
        }

        public void ClearFields()
        {
            adminAddUsers_username.Text = "";
            adminAddUsers_password.Text = "";
            adminAddUsers_role.SelectedIndex = -1;
            adminAddUsers_status.SelectedIndex = -1;
            adminAddUsers_imageView.Image = null;
        }
        private void adminAddUsers_clearBtn_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void adminAddUsers_deleteBtn_Click(object sender, EventArgs e)
        {
            if (EmptyField())
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult result = MessageBox.Show("Are you sure you want to Delete Username: " + adminAddUsers_username.Text.Trim()
                    + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        try
                        {
                            connect.Open();

                            string deleteData = "DELETE FROM users WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@id", id);

                                cmd.ExecuteNonQuery();
                                ClearFields();

                                MessageBox.Show("Deleted successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                displayAddUsersData();
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Connection failed: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
}
