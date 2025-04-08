using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FrmAdminMainHome : Form
    {
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
        }

        private void addCashier_Click(object sender, EventArgs e)
        {
            frmAdminDashboard1.Visible = false;
            frmAdminAddUser1.Visible = true;
            frmAdminAddProducts1.Visible = false;
        }

        private void addProducts_Click(object sender, EventArgs e)
        {
            frmAdminDashboard1.Visible = false;
            frmAdminAddUser1.Visible = false;
            frmAdminAddProducts1.Visible = true;
        }
    }
}
