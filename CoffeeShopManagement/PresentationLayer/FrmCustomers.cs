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
    public partial class FrmCustomers : UserControl
    {
        public FrmCustomers()
        {
            InitializeComponent();
            DisplayCustomersData();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            DisplayCustomersData();
        }

        public void DisplayCustomersData()
        {
            CustomersData cData = new CustomersData();

            List<CustomersData> listData = cData.AllCustomersData();

            dgvCustomers.DataSource = listData;
        }
    }
}
