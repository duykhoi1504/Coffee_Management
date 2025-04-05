using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferLayer;

namespace PresentationLayer
{
    public partial class FrmAdminAddUser : UserControl
    {
        public FrmAdminAddUser()
        {
            InitializeComponent();
        }

        public void displayAddUsersData()
        {
            AdminAddUsers usersData = new AdminAddUsers();
            List<AdminAddUsers> listData = usersData.usersListData();

            dgvUsersTable.DataSource = listData;
        }
    }
}
