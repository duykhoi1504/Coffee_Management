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
using System.Drawing.Printing;
using System.Configuration;
using TransferLayer;

namespace PresentationLayer
{
    public partial class FrmCashierOrder : UserControl
    {
        public static int getCustID;

        SqlConnection connect = new SqlConnection (@"");

        public FrmCashierOrder()
        {
            InitializeComponent();

            DisplayAvailiableProds();
            DisplayAllOrders();
            DisplayTotalPrice();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            DisplayAvailableProds();
            DisplayAllOrders();

            DisplayTotalPrice();
        }

        public void DisplayAvailableProds()
        {
            CashierOrderFormProdData allProds = new CashierOrderFormProdData();

            List<CashierOrderFormProdData> listData = allProds.aviliableProductsData();

            cashierOrderForm_menuTable.DataSource = listData;
        }

        public void DisplayAvailiableProds()
        {
            CashierOrderFormProdData allProds= new CashierOrderFormProdData();
            List<CashierOrderFormProdData> listData = allProds.aviliableProductsData();
            cashierOrderForm_menuTable.DataSource = listData;
        }

        public void DisplayAllOrders()
        {
            CashierOrdersData allOrders = new CashierOrdersData();
            List<CashierOrdersData> listData = allOrders.ordersListData();

            cashierOrderForm_orderTable.DataSource = listData;
        }

        private float totalPrice;
        public void DisplayTotalPrice()
        {
            //IDGenerator();

            if (connect.State == ConnectionState.Closed)
            {
                try
                {
                    //connect.Open();

                    string selectData = "SELECT SUM(prod_price) FROM orders WHERE customer_id = @custId";

                    using (SqlCommand cmd = new SqlCommand(selectData, connect))
                    {
                        cmd.Parameters.AddWithValue("@custId", idGen);

                        object result = cmd.ExecuteScalar();

                        if (result != DBNull.Value)
                        {
                            totalPrice = Convert.ToSingle(result);

                            cashierOrderForm_orderPrice.Text = totalPrice.ToString("0.00");
                        }
                        else
                        {

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

        private void cashierOrderForm_addBtn_Click(object sender, EventArgs e)
        {
            IDGenerator();

            //Báo lỗi khi thông tin sản phẩm bị thiếu
            if (cashierOrderForm_type.SelectedIndex == -1 || cashierOrderForm_productID.SelectedIndex == -1
                || cashierOrderForm_prodName.Text == "" || cashierOrderForm_quantity.Value == 0
                || cashierOrderForm_price.Text == "")
            {
                MessageBox.Show("Please select the product first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Tạo đơn hàng khi thông tin sản phẩm hợp lệ
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();

                        //Truy vấn giá của sản phẩm
                        float getPrice = 0;
                        string selectOrder = "SELECT * FROM products WHERE prod_id = @prodID";

                        using (SqlCommand getOrder = new SqlCommand(selectOrder, connect))
                        {
                            getOrder.Parameters.AddWithValue("@prodID", cashierOrderForm_productID.Text.Trim());

                            using (SqlDataReader reader = getOrder.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    object rawValue = reader["prod_price"];
                                    if (rawValue != DBNull.Value)
                                    {
                                        getPrice = Convert.ToSingle(rawValue);
                                    }
                                }
                            }
                        }

                        //Thêm sản phẩm vào đơn hàng hiện tại
                        string insertOrder = "INSERT INTO orders (customer_id, prod_id, prod_name, prod_type, qty, prod_price, order_date) " +
                            "VALUES(@customerID, @prodID, @prodName, @prodType, @qty, @prodPrice, @orderDate)";

                        DateTime today = DateTime.Today;

                        using (SqlCommand cmd = new SqlCommand(insertOrder, connect))
                        {
                            cmd.Parameters.AddWithValue("@customerID", idGen);
                            cmd.Parameters.AddWithValue("@prodID", cashierOrderForm_productID.Text.Trim());
                            cmd.Parameters.AddWithValue("@prodName", cashierOrderForm_prodName.Text);
                            cmd.Parameters.AddWithValue("@prodType", cashierOrderForm_type.Text.Trim());

                            float totalPrice = (getPrice * (int)cashierOrderForm_quantity.Value);

                            cmd.Parameters.AddWithValue("@qty", cashierOrderForm_quantity.Value);
                            cmd.Parameters.AddWithValue("@prodPrice", totalPrice);
                            cmd.Parameters.AddWithValue("@orderDate", today);

                            cmd.ExecuteNonQuery();

                            DisplayAllOrders();
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
            DisplayTotalPrice();
        }

        private int idGen = 0;
        //Tạo ID cho đơn hàng hiện tại
        public void IDGenerator()
        {
            using (SqlConnection connect = new SqlConnection(@""))
            {
                //connect.Open();

                //Lấy ID lớn nhẩt trong bảng Customers rồi tăng lên 1 đơn vị để tạo ID mới cho đơn hiện tại
                string selectID = "SELECT MAX(customer_id) FROM customers";

                using (SqlCommand cmd = new SqlCommand(selectID, connect))
                {
                    object result = cmd.ExecuteScalar();

                    if (result != DBNull.Value)
                    {
                        int temp = Convert.ToInt32(result);

                        if (temp == 0)
                        {
                            idGen = 1;
                        }
                        else
                        {
                            idGen = temp + 1;
                        }
                    }
                    else
                    {
                        idGen = 1;
                    }
                    getCustID = idGen;
                }
            }
        }

        private void cashierOrderForm_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Reset the product ID dropdown
            cashierOrderForm_productID.SelectedIndex = -1;
            cashierOrderForm_productID.Items.Clear();
            cashierOrderForm_prodName.Text = "";
            cashierOrderForm_price.Text = "";
            // Get the selected product type
            string selectedValue = cashierOrderForm_type.SelectedItem as string;

            if (selectedValue !=null)
            {
                try
                {
                    // Open a new connection
                    using (SqlConnection connect = new SqlConnection(@""))
                    {
                        connect.Open();

                        // Query to fetch products based on the selected type
                        string selectData = "SELECT prod_id FROM Products WHERE prod_type = @prodType AND prod_status = @status AND date_delete IS NULL";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                           
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    string value = reader["prod_id"].ToString();
                                    cashierOrderForm_productID.Items.Add(value);
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Display error message
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cashierOrderForm_productID_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy giá trị được chọn từ dropdown
            string selectedValue = cashierOrderForm_productID.SelectedItem as string;

            if (selectedValue != null)
            {
                try
                {
                    // Mở kết nối cơ sở dữ liệu
                    using (SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\USER\Documents\cafe.mdf;Integrated Security=True;Connect Timeout=30"))
                    {
                        connect.Open();

                        // Truy vấn để lấy thông tin sản phẩm
                        string selectData = "SELECT prod_name, prod_price FROM Products WHERE prod_id = @prodID AND prod_status = @status AND date_delete IS NULL";

                        using (SqlCommand cmd = new SqlCommand(selectData, connect))
                        {
                           
                            cmd.Parameters.AddWithValue("@status", "Available");

                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    // Lấy tên và giá sản phẩm từ kết quả truy vấn
                                    string prodName = reader["prod_name"].ToString();
                                    string prodPrice = reader["prod_price"].ToString();

                                    // Hiển thị thông tin sản phẩm lên giao diện
                                    cashierOrderForm_prodName.Text = prodName;
                                    cashierOrderForm_price.Text = prodPrice;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Hiển thị thông báo lỗi nếu có ngoại lệ
                    MessageBox.Show("Error: " + ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        //Tính tiền thừa
        private void cashierOrderForm_amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    float getAmount = Convert.ToSingle(cashierOrderForm_amount.Text);

                    float getChange = (getAmount - totalPrice);

                    if (getChange <= -1)
                    {
                        cashierOrderForm_amount.Text = "";
                        cashierOrderForm_change.Text = "";
                    }
                    else
                    {
                        cashierOrderForm_change.Text = getChange.ToString();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Invalid", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cashierOrderForm_amount.Text = "";
                    cashierOrderForm_change.Text = "";
                }
            }
        }

        private void cashierOrderForm_payBtn_Click(object sender, EventArgs e)
        {
            if (cashierOrderForm_amount.Text == "" || cashierOrderForm_orderTable.Rows.Count < 0)
            {
                MessageBox.Show("Something went wrong.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure for paying?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();

                            IDGenerator();

                            string insertData = "INSERT INTO customers (customer_id, total_price, amount, change, date) " +
                                "VALUES(@custID, @totalprice, @amount, @change, @date)";

                            DateTime today = DateTime.Today;

                            using (SqlCommand cmd = new SqlCommand(insertData, connect))
                            {
                                cmd.Parameters.AddWithValue("@custID", idGen);
                                cmd.Parameters.AddWithValue("@totalprice", totalPrice);
                                cmd.Parameters.AddWithValue("@amount", cashierOrderForm_amount.Text);
                                cmd.Parameters.AddWithValue("@change", cashierOrderForm_change.Text);
                                cmd.Parameters.AddWithValue("@date", today);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Paid successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DisplayTotalPrice();
        }

        private int rowIndex = 0;
        //Hiển thị bản xem trước hóa đơn để in
        private void cashierOrderForm_receiptBtn_Click(object sender, EventArgs e)
        {
            pdReceiptOfPayment.PrintPage += new PrintPageEventHandler(pdReceiptOfPayment_PrintPage);
            pdReceiptOfPayment.BeginPrint += new PrintEventHandler(pdReceiptOfPayment_BeginPrint);

            ppdReceiptOfPayment.Document = pdReceiptOfPayment;
            ppdReceiptOfPayment.ShowDialog();
        }

        private void pdReceiptOfPayment_BeginPrint(object sender, PrintEventArgs e)
        {
            rowIndex = 0;
        }

        //In hóa đơn thanh toán
        private void pdReceiptOfPayment_PrintPage(object sender, PrintPageEventArgs e)
        {
            DisplayTotalPrice();

            float y = 0; //Vị trí hiện tại trên trục dọc
            int count = 0; //Đếm dòng hiện tại
            int colWidth = 120;
            int headerMargin = 10;
            int tableMargin = 20;

            Font font = new Font("Arial", 12);
            Font bold = new Font("Arial", 12, FontStyle.Bold);
            Font headerFont = new Font("Arial", 16, FontStyle.Bold);
            Font labelFont = new Font("Arial", 14, FontStyle.Bold);

            float margin = e.MarginBounds.Top;

            StringFormat alignCenter = new StringFormat();
            alignCenter.Alignment = StringAlignment.Center;
            alignCenter.LineAlignment = StringAlignment.Center;

            //In tên quán làm tiêu đề hóa đơn
            string headerText = "MarcoMan's Cafe Shop";
            y = (margin + count * headerFont.GetHeight(e.Graphics) + headerMargin);
            e.Graphics.DrawString(headerText, headerFont, Brushes.Black, e.MarginBounds.Left
                + (cashierOrderForm_orderTable.Columns.Count / 2) * colWidth, y, alignCenter);

            count++;
            y += tableMargin;

            //Tạo các tiêu đề các cột cho bảng sản phẩm
            string[] header = { "CID", "ProdID", "ProdName", "ProdType", "Qty", "Price" };

            for (int i = 0; i < header.Length; i++)
            {
                y = margin + count * bold.GetHeight(e.Graphics) + tableMargin;
                e.Graphics.DrawString(header[i], bold, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, alignCenter);
            }
            count++;

            float rSpace = e.MarginBounds.Bottom - y;

            //In thông tin sản phẩm đã mua trong hóa đơn
            while (rowIndex < cashierOrderForm_orderTable.Rows.Count)
            {
                DataGridViewRow row = cashierOrderForm_orderTable.Rows[rowIndex];

                for (int i = 0; i < cashierOrderForm_orderTable.Columns.Count; i++)
                {
                    object cellValue = row.Cells[i].Value;
                    string cell = (cellValue != null) ? cellValue.ToString() : string.Empty;

                    y = margin + count * font.GetHeight(e.Graphics) + tableMargin;
                    e.Graphics.DrawString(cell, font, Brushes.Black, e.MarginBounds.Left + i * colWidth, y, alignCenter);
                }
                count++;
                rowIndex++;

                //Nếu sắp in quá lề dưới trang giấy thì dừng lại và đánh dấu còn trang tiếp theo
                if (y + font.GetHeight(e.Graphics) > e.MarginBounds.Bottom)
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            int labelMargin = (int)Math.Min(rSpace, 200);

            DateTime today = DateTime.Now;

            float labelX = e.MarginBounds.Right - e.Graphics.MeasureString("------------------------------", labelFont).Width;

            //In tổng tiền, số tiền khách trả, và tiền thối
            y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString("Total Price: \t$" + totalPrice + "\nAmount: \t$"
                + cashierOrderForm_amount.Text + "\n\t\t------------\nChange: \t$" + cashierOrderForm_change.Text, labelFont, Brushes.Black, labelX, y);

            labelMargin = (int)Math.Min(rSpace, -40);

            //In ngày/giờ hiện tại dưới cùng
            string labelText = today.ToString();
            y = e.MarginBounds.Bottom - labelMargin - labelFont.GetHeight(e.Graphics);
            e.Graphics.DrawString(labelText, labelFont, Brushes.Black, e.MarginBounds.Right - e.Graphics.MeasureString("------------------------------", labelFont).Width, y);
        }

        private void cashierOrderForm_removeBtn_Click(object sender, EventArgs e)
        {
            if (getOrderID == 0)
            {
                MessageBox.Show("Select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to Remove the Order ID: " + getOrderID + "?", "Confirmation Message"
                , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (connect.State == ConnectionState.Closed)
                    {
                        try
                        {
                            connect.Open();

                            string deleteData = "DELETE FROM orders WHERE id = @id"; //Nên xóa sản phẩm trong đơn hàng đã thêm vào thay vì xóa đơn hàng

                            using (SqlCommand cmd = new SqlCommand(deleteData, connect))
                            {
                                cmd.Parameters.AddWithValue("@id", getOrderID);

                                cmd.ExecuteNonQuery();

                                MessageBox.Show("Removed successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            DisplayAllOrders();
            DisplayTotalPrice();
        }

        private int getOrderID = 0;
        //Lưu ID đơn hàng được chọn khi click vào bảng đơn hàng
        private void cashierOrderForm_orderTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = cashierOrderForm_orderTable.Rows[e.RowIndex];
            getOrderID = (int)row.Cells[0].Value;
        }

        public void clearFields()
        {
            cashierOrderForm_type.SelectedIndex = -1;
            cashierOrderForm_productID.Items.Clear();
            cashierOrderForm_prodName.Text = "";
            cashierOrderForm_price.Text = "";
            cashierOrderForm_quantity.Value = 0;
        }

        private void cashierOrderForm_clearBtn_Click_1(object sender, EventArgs e)
        {
            DisplayAllOrders();
            DisplayTotalPrice();

            clearFields();
        }
    }
}
