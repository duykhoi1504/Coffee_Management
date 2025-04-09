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
            this.order_btn = new System.Windows.Forms.Button();
            this.addProducts_btn = new System.Windows.Forms.Button();
            this.dashboard_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customer_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.close_btn);
            this.panel3.Location = new System.Drawing.Point(3, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1385, 43);
            this.panel3.TabIndex = 3;
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
            this.panel1.Location = new System.Drawing.Point(3, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 690);
            this.panel1.TabIndex = 4;
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
            this.logout_btn.Location = new System.Drawing.Point(0, 627);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(248, 43);
            this.logout_btn.TabIndex = 3;
            this.logout_btn.Text = "Logout";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // order_btn
            // 
            this.order_btn.Location = new System.Drawing.Point(0, 440);
            this.order_btn.Name = "order_btn";
            this.order_btn.Size = new System.Drawing.Size(248, 43);
            this.order_btn.TabIndex = 3;
            this.order_btn.Text = "Order";
            this.order_btn.UseVisualStyleBackColor = true;
            // 
            // addProducts_btn
            // 
            this.addProducts_btn.Location = new System.Drawing.Point(0, 369);
            this.addProducts_btn.Name = "addProducts_btn";
            this.addProducts_btn.Size = new System.Drawing.Size(248, 43);
            this.addProducts_btn.TabIndex = 3;
            this.addProducts_btn.Text = "Add Products";
            this.addProducts_btn.UseVisualStyleBackColor = true;
            // 
            // dashboard_btn
            // 
            this.dashboard_btn.Location = new System.Drawing.Point(3, 301);
            this.dashboard_btn.Name = "dashboard_btn";
            this.dashboard_btn.Size = new System.Drawing.Size(248, 43);
            this.dashboard_btn.TabIndex = 3;
            this.dashboard_btn.Text = "dashboard";
            this.dashboard_btn.UseVisualStyleBackColor = true;
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
            // customer_btn
            // 
            this.customer_btn.Location = new System.Drawing.Point(0, 503);
            this.customer_btn.Name = "customer_btn";
            this.customer_btn.Size = new System.Drawing.Size(248, 43);
            this.customer_btn.TabIndex = 3;
            this.customer_btn.Text = "Customers";
            this.customer_btn.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(260, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1128, 712);
            this.panel2.TabIndex = 5;
            // 
            // FrmCashierMainHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1393, 760);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCashierMainHome";
            this.Text = "FrmCashierMainHome";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}