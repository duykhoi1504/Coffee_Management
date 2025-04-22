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
    public partial class FrmAdminMainHome : Form
    {
        private SqlConnection cn;
        //DataProvider dataProvider = new DataProvider();

        public FrmAdminMainHome()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                this.Hide();
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Hide();
            }
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            frmAdminDashboard1.Visible = true;
            frmAdminAddUser1.Visible = false;
            frmAdminAddProducts1.Visible = false;

            FrmCustomers ccForm = frmCustomers1 as FrmCustomers;

            if (ccForm != null)
            {
                ccForm.RefreshData();
            }
        }

        private void addCashier_Click(object sender, EventArgs e)
        {
            frmAdminDashboard1.Visible = false;
            frmAdminAddUser1.Visible = true;
            frmAdminAddProducts1.Visible = false;

            FrmAdminAddUser aaUsers = frmAdminAddUser1 as FrmAdminAddUser;

            if (aaUsers != null)
            {
                aaUsers.RefreshData();
            }
        }

        private void addProducts_Click(object sender, EventArgs e)
        {
            frmAdminDashboard1.Visible = false;
            frmAdminAddUser1.Visible = false;
            frmAdminAddProducts1.Visible = true;

            FrmAdminAddProducts aaProd = frmAdminAddProducts1 as FrmAdminAddProducts;

            if (aaProd != null)
            {
                aaProd.RefreshData();
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            frmAdminDashboard1.Visible = false;
            frmAdminAddProducts1.Visible = false;
            frmCustomers1.Visible = true;

            FrmCustomers ccForm = frmCustomers1 as FrmCustomers;

            if (ccForm != null)
            {
                ccForm.RefreshData();
            }
        }
    }
}
