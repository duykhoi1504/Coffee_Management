using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLayer;
using TransferLayer;

namespace PresentationLayer
{
    public partial class FrmCashierMainHome : Form
    {
        public FrmCashierMainHome()
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

        private void addProducts_btn_Click(object sender, EventArgs e)
        {
            frmAdminDashboard1.Visible = false;
            frmAdminAddProducts1.Visible = true;
            frmCashierOrder1.Visible = false;
            frmCustomers1.Visible = false;

            FrmAdminAddProducts aaProd = frmAdminAddProducts1 as FrmAdminAddProducts;

            if (aaProd != null)
            {
                aaProd.RefreshData();
            }
        }

        private void order_btn_Click(object sender, EventArgs e)
        {
            frmAdminDashboard1.Visible = false;
            frmAdminAddProducts1.Visible = false;
            frmCashierOrder1.Visible = true;
            frmCustomers1.Visible = false;

            FrmCashierOrder coForm = frmCashierOrder1 as FrmCashierOrder;

            if (coForm != null)
            {
                coForm.RefreshData();
            }
        }

        private void customer_btn_Click(object sender, EventArgs e)
        {
            frmAdminDashboard1.Visible = false;
            frmAdminAddProducts1.Visible = false;
            frmCashierOrder1.Visible = false;
            frmCustomers1.Visible = true;

            FrmCustomers ccForm = frmCustomers1 as FrmCustomers;

            if (ccForm != null)
            {
                ccForm.RefreshData();
            }
        }

        private void dashboard_btn_Click(object sender, EventArgs e)
        {
            frmAdminDashboard1.Visible = false;
            frmAdminAddProducts1.Visible = false;
            frmCashierOrder1.Visible = false;
            frmCustomers1.Visible = true;

            FrmCustomers ccForm = frmCustomers1 as FrmCustomers;

            if (ccForm != null)
            {
                ccForm.RefreshData();
            }
        }
    }
}
