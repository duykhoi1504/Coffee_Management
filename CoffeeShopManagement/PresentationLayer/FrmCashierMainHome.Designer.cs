namespace PresentationLayer
{
    partial class FrmCashierMainHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCashierMainHome));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.customer_btn = new System.Windows.Forms.Button();
            this.order_btn = new System.Windows.Forms.Button();
            this.addProducts_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.frmCashierOrder1 = new PresentationLayer.FrmCashierOrder();
            this.frmCustomers1 = new PresentationLayer.FrmCustomers();
            this.frmAdminAddProducts1 = new PresentationLayer.FrmAdminAddProducts();
            this.frmAdminDashboard1 = new PresentationLayer.FrmAdminDashboard();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.close_btn);
            this.panel3.Location = new System.Drawing.Point(4, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2078, 67);
            this.panel3.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(277, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "CoffeeShop Management";
            // 
            // close_btn
            // 
            this.close_btn.AutoSize = true;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.Location = new System.Drawing.Point(2047, 9);
            this.close_btn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(27, 25);
            this.close_btn.TabIndex = 4;
            this.close_btn.Text = "X";
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.customer_btn);
            this.panel1.Controls.Add(this.order_btn);
            this.panel1.Controls.Add(this.addProducts_btn);
            this.panel1.Controls.Add(this.dashboard_btn);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(4, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(381, 1078);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 402);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(215, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username: title name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(122, 319);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title Name";
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(0, 980);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(372, 67);
            this.logout_btn.TabIndex = 3;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // customer_btn
            // 
            this.customer_btn.Location = new System.Drawing.Point(0, 786);
            this.customer_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.customer_btn.Name = "customer_btn";
            this.customer_btn.Size = new System.Drawing.Size(372, 67);
            this.customer_btn.TabIndex = 3;
            this.customer_btn.Text = "Customers";
            this.customer_btn.UseVisualStyleBackColor = true;
            this.customer_btn.Click += new System.EventHandler(this.customer_btn_Click);
            // 
            // order_btn
            // 
            this.order_btn.Location = new System.Drawing.Point(0, 688);
            this.order_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(372, 67);
            this.order_btn.TabIndex = 3;
            this.order_btn.Text = "Order";
            this.order_btn.UseVisualStyleBackColor = true;
            this.order_btn.Click += new System.EventHandler(this.order_btn_Click);
            // 
            // addProducts_btn
            // 
            this.addProducts_btn.Location = new System.Drawing.Point(0, 577);
            this.addProducts_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addProducts_btn.Name = "addProducts_btn";
            this.addProducts_btn.Size = new System.Drawing.Size(372, 67);
            this.addProducts_btn.TabIndex = 3;
            this.addProducts_btn.Text = "Add Products";
            this.addProducts_btn.UseVisualStyleBackColor = true;
            this.addProducts_btn.Click += new System.EventHandler(this.addProducts_btn_Click);
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.Location = new System.Drawing.Point(4, 470);
            this.dashboard_btn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(372, 67);
            this.dashboard_btn.TabIndex = 3;
            this.dashboard_btn.Text = "Dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = true;
            this.dashboard_btn.Click += new System.EventHandler(this.dashboard_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 25);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.frmCashierOrder1);
            this.panel2.Controls.Add(this.frmCustomers1);
            this.panel2.Controls.Add(this.frmAdminAddProducts1);
            this.panel2.Controls.Add(this.frmAdminDashboard1);
            this.panel2.Location = new System.Drawing.Point(390, 77);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1692, 1112);
            this.panel2.TabIndex = 5;
            // 
            // frmCashierOrder1
            // 
            this.frmCashierOrder1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.frmCashierOrder1.Location = new System.Drawing.Point(-2, -2);
            this.frmCashierOrder1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.frmCashierOrder1.Name = "frmCashierOrder1";
            this.frmCashierOrder1.Size = new System.Drawing.Size(1694, 1114);
            this.frmCashierOrder1.TabIndex = 3;
            // 
            // frmCustomers1
            // 
            this.frmCustomers1.Location = new System.Drawing.Point(0, -2);
            this.frmCustomers1.Name = "frmCustomers1";
            this.frmCustomers1.Size = new System.Drawing.Size(1687, 1099);
            this.frmCustomers1.TabIndex = 2;
            // 
            // frmAdminAddProducts1
            // 
            this.frmAdminAddProducts1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.frmAdminAddProducts1.Location = new System.Drawing.Point(-2, 0);
            this.frmAdminAddProducts1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.frmAdminAddProducts1.Name = "frmAdminAddProducts1";
            this.frmAdminAddProducts1.Size = new System.Drawing.Size(1689, 1097);
            this.frmAdminAddProducts1.TabIndex = 1;
            // 
            // frmAdminDashboard1
            // 
            this.frmAdminDashboard1.Location = new System.Drawing.Point(0, 0);
            this.frmAdminDashboard1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.frmAdminDashboard1.Name = "frmAdminDashboard1";
            this.frmAdminDashboard1.Size = new System.Drawing.Size(1687, 1097);
            this.frmAdminDashboard1.TabIndex = 0;
            // 
            // FrmCashierMainHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2090, 1188);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmCashierMainHome";
            this.Text = "FrmCashierMainHome";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label close_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button order_btn;
        private System.Windows.Forms.Button addProducts_btn;
        private System.Windows.Forms.Button dashboard_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button customer_btn;
        private System.Windows.Forms.Panel panel2;
        private FrmAdminDashboard frmAdminDashboard1;
        private FrmCustomers frmCustomers1;
        private FrmAdminAddProducts frmAdminAddProducts1;
        private FrmCashierOrder frmCashierOrder1;
    }
}