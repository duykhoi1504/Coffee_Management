using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmLogin : Form
    {
        SqlConnection connect = null; //tam de null, co sql thi ket noi sau

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_RegisterBtn_Click(object sender, EventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();
            frmRegister.Show();
            this.Hide();
        }

        private void login_showPass_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = login_showPass.Checked ? '\0' : '*';
        }

        public bool emptyFields()
        {
            if (txtUsername.Text == "" || txtPassword.Text == "")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            if (emptyFields())
            {
                MessageBox.Show("All fields are required to be filled.", "Error Message", MessageBoxButtons.OK);
            }
            else 
            {
                if(connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        string selectAccount = "SELECT COUNT(*) FROM Users WHERE username = @usern AND password = @pass AND status = @status";

                        using (SqlCommand cmd = new SqlCommand(selectAccount, connect)) 
                        {
                            cmd.Parameters.AddWithValue("@usern", txtUsername.Text.Trim());
                            cmd.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
                            cmd.Parameters.AddWithValue("@status", "Active");


                            int rowCount= (int)cmd.ExecuteScalar();
                            if (rowCount > 0)
                            {
                                string selectRole = "SELECT role FROM Users WHERE username = @usern AND password = @pass";
                                using(SqlCommand getRole= new SqlCommand(selectRole, connect))
                                {
                                    getRole.Parameters.AddWithValue("@usern", txtUsername.Text.Trim());
                                    getRole.Parameters.AddWithValue("@pass", txtPassword.Text.Trim());
                                    string userRole = getRole.ExecuteScalar() as string;
                                    MessageBox.Show("Login successfully!", "Informaion Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    if (userRole == "Admin")
                                    {

                                        FrmAdminMainHome adminForm = new FrmAdminMainHome();
                                        adminForm.Show();
                                        this.Hide();
                                    }
                                    else if (userRole == "Cashier")
                                    {
                                        FrmCashierMainHome cashierForm = new FrmCashierMainHome();
                                        cashierForm.Show();
                                        this.Hide();
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Incorrect Username/Password or there's no Admin's approval.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

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

        }
    }
}
