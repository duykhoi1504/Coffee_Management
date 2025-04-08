namespace PresentationLayer
{
    partial class FrmAdminMainHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdminMainHome));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.logout_btn = new System.Windows.Forms.Button();
            this.addCustomer = new System.Windows.Forms.Button();
            this.addProducts = new System.Windows.Forms.Button();
            this.addCashier = new System.Windows.Forms.Button();
            this.dashboard = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.frmAdminDashboard1 = new PresentationLayer.FrmAdminDashboard();
            this.frmAdminAddProducts1 = new PresentationLayer.FrmAdminAddProducts();
            this.frmAdminAddUser1 = new PresentationLayer.FrmAdminAddUser();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightYellow;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.logout_btn);
            this.panel1.Controls.Add(this.addCustomer);
            this.panel1.Controls.Add(this.addProducts);
            this.panel1.Controls.Add(this.addCashier);
            this.panel1.Controls.Add(this.dashboard);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(-1, 37);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 690);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Username: title name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title Name";
            // 
            // logout_btn
            // 
            this.logout_btn.Location = new System.Drawing.Point(0, 584);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(248, 43);
            this.logout_btn.TabIndex = 3;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // addCustomer
            // 
            this.addCustomer.Location = new System.Drawing.Point(0, 514);
            this.addCustomer.Name = "addCustomer";
            this.addCustomer.Size = new System.Drawing.Size(248, 43);
            this.addCustomer.TabIndex = 3;
            this.addCustomer.Text = "Customers";
            this.addCustomer.UseVisualStyleBackColor = true;
            // 
            // addProducts
            // 
            this.addProducts.Location = new System.Drawing.Point(0, 443);
            this.addProducts.Name = "addProducts";
            this.addProducts.Size = new System.Drawing.Size(248, 43);
            this.addProducts.TabIndex = 3;
            this.addProducts.Text = "Add Products";
            this.addProducts.UseVisualStyleBackColor = true;
            this.addProducts.Click += new System.EventHandler(this.addProducts_Click);
            // 
            // addCashier
            // 
            this.addCashier.Location = new System.Drawing.Point(0, 372);
            this.addCashier.Name = "addCashier";
            this.addCashier.Size = new System.Drawing.Size(248, 43);
            this.addCashier.TabIndex = 3;
            this.addCashier.Text = "Add Cashiers";
            this.addCashier.UseVisualStyleBackColor = true;
            this.addCashier.Click += new System.EventHandler(this.addCashier_Click);
            // 
            // dashboard
            // 
            this.dashboard.Location = new System.Drawing.Point(3, 301);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(248, 43);
            this.dashboard.TabIndex = 3;
            this.dashboard.Text = "dashboard";
            this.dashboard.UseVisualStyleBackColor = true;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.frmAdminDashboard1);
            this.panel2.Controls.Add(this.frmAdminAddProducts1);
            this.panel2.Controls.Add(this.frmAdminAddUser1);
            this.panel2.Location = new System.Drawing.Point(253, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1155, 670);
            this.panel2.TabIndex = 1;
            // 
            // frmAdminDashboard1
            // 
            this.frmAdminDashboard1.Location = new System.Drawing.Point(0, 3);
            this.frmAdminDashboard1.Name = "frmAdminDashboard1";
            this.frmAdminDashboard1.Size = new System.Drawing.Size(1191, 752);
            this.frmAdminDashboard1.TabIndex = 3;
            // 
            // frmAdminAddProducts1
            // 
            this.frmAdminAddProducts1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.frmAdminAddProducts1.Location = new System.Drawing.Point(-16, -26);
            this.frmAdminAddProducts1.Name = "frmAdminAddProducts1";
            this.frmAdminAddProducts1.Size = new System.Drawing.Size(1202, 790);
            this.frmAdminAddProducts1.TabIndex = 2;
            // 
            // frmAdminAddUser1
            // 
            this.frmAdminAddUser1.Location = new System.Drawing.Point(0, 3);
            this.frmAdminAddUser1.Name = "frmAdminAddUser1";
            this.frmAdminAddUser1.Size = new System.Drawing.Size(976, 664);
            this.frmAdminAddUser1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.close_btn);
            this.panel3.Location = new System.Drawing.Point(2, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1406, 43);
            this.panel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "CoffeeShop Management";
            // 
            // close_btn
            // 
            this.close_btn.AutoSize = true;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close_btn.Location = new System.Drawing.Point(1365, 14);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(16, 16);
            this.close_btn.TabIndex = 4;
            this.close_btn.Text = "X";
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // FrmAdminMainHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1411, 807);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdminMainHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button addCustomer;
        private System.Windows.Forms.Button addProducts;
        private System.Windows.Forms.Button addCashier;
        private System.Windows.Forms.Button dashboard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label close_btn;
        private System.Windows.Forms.Label label4;
        private FrmAdminAddUser frmAdminAddUser1;
        private FrmAdminAddProducts frmAdminAddProducts1;
        private FrmAdminDashboard frmAdminDashboard1;
    }
}

