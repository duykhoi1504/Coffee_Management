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
namespace PresentationLayer
{
    public partial class FrmRegister : Form
    {
        SqlConnection connect = new SqlConnection(@"");
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void Register_LoginBtn_Click(object sender, EventArgs e)
        {
            FrmLogin loginForm = new FrmLogin();
            loginForm.Show();
            this.Hide();
        }

        private void register_showPass_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar=register_showPass.Checked ? '\0' : '*';
            register_confirmPass.PasswordChar=register_showPass.Checked ? '\0' : '*';
        }
        public bool emptyFields()
        {
            if(register_username.Text == "" || register_password.Text == "" || register_confirmPass.Text == "" )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void register_btn_Click(object sender, EventArgs e)
        {
            if (emptyFields()) {
                MessageBox.Show("Please fill all fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
               if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectUserName = "SELECT * FROM Users WHERE username = @usern";
                        using (SqlCommand checkUsername = new SqlCommand(selectUserName, connect))
                        {
                            checkUsername.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                            SqlDataAdapter adapter = new SqlDataAdapter(checkUsername);
                            DataTable table = new DataTable();
                            adapter.Fill(table);
                            if (table.Rows.Count >= 1)
                            {
                                string usern=register_username.Text.Substring(0,1).ToUpper() + register_username.Text.Substring(1);
                                MessageBox.Show(usern + " - is alreay taken", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if(register_password.Text!= register_confirmPass.Text)
                            {
                                MessageBox.Show("Password doesn't match", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else if (register_password.Text.Length<8)
                            {
                                MessageBox.Show("invalid password, at least 8 characters are needed", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData= "INSERT INTO Users (username, password,profile_image, role,status,date_reg) " +
                                    "VALUES(@usern, @pass, @image, @role, @status, @date)";
                                DateTime today=DateTime.Today;
                                using (SqlCommand cmd= new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@usern", register_username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@pass", register_password.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image","");
                                    cmd.Parameters.AddWithValue("@role", "Cashier");
                                    cmd.Parameters.AddWithValue("@status", "Approval");
                                    cmd.Parameters.AddWithValue("@date",today);
                                    int rows = cmd.ExecuteNonQuery();
                                   
                                        MessageBox.Show("Registered Successfully", "Infomation Meassage", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                   //switch form into login form
                                   FrmLogin loginForm = new FrmLogin();
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally{
                        connect.Close();
                    }
                }
                
            }
        }
    }
}
