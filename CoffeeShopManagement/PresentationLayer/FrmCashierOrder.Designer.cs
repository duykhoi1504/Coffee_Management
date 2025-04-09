namespace PresentationLayer
{
    partial class FrmCashierOrder
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.cashierOrderForm_menuTable = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cashierOrderForm_quantity = new System.Windows.Forms.NumericUpDown();
            this.cashierOrderForm_clearBtn = new System.Windows.Forms.Button();
            this.cashierOrderForm_removeBtn = new System.Windows.Forms.Button();
            this.cashierOrderForm_addBtn = new System.Windows.Forms.Button();
            this.cashierOrderForm_type = new System.Windows.Forms.ComboBox();
            this.cashierOrderForm_productID = new System.Windows.Forms.ComboBox();
            this.cashierOrderForm_prodName = new System.Windows.Forms.Label();
            this.cashierOrderForm_price = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cashierOrderForm_amount = new System.Windows.Forms.TextBox();
            this.cashierOrderForm_orderTable = new System.Windows.Forms.DataGridView();
            this.cashierOrderForm_receiptBtn = new System.Windows.Forms.Button();
            this.cashierOrderForm_payBtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cashierOrderForm_change = new System.Windows.Forms.Label();
            this.cashierOrderForm_orderPrice = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_menuTable)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_quantity)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_orderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.cashierOrderForm_menuTable);
            this.panel1.Location = new System.Drawing.Point(15, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(815, 379);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Menu";
            // 
            // cashierOrderForm_menuTable
            // 
            this.cashierOrderForm_menuTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashierOrderForm_menuTable.Location = new System.Drawing.Point(17, 37);
            this.cashierOrderForm_menuTable.Name = "cashierOrderForm_menuTable";
            this.cashierOrderForm_menuTable.RowHeadersWidth = 51;
            this.cashierOrderForm_menuTable.RowTemplate.Height = 24;
            this.cashierOrderForm_menuTable.Size = new System.Drawing.Size(782, 325);
            this.cashierOrderForm_menuTable.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.cashierOrderForm_quantity);
            this.panel2.Controls.Add(this.cashierOrderForm_clearBtn);
            this.panel2.Controls.Add(this.cashierOrderForm_removeBtn);
            this.panel2.Controls.Add(this.cashierOrderForm_addBtn);
            this.panel2.Controls.Add(this.cashierOrderForm_type);
            this.panel2.Controls.Add(this.cashierOrderForm_productID);
            this.panel2.Controls.Add(this.cashierOrderForm_prodName);
            this.panel2.Controls.Add(this.cashierOrderForm_price);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(15, 412);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(815, 302);
            this.panel2.TabIndex = 2;
            // 
            // cashierOrderForm_quantity
            // 
            this.cashierOrderForm_quantity.Location = new System.Drawing.Point(440, 112);
            this.cashierOrderForm_quantity.Name = "cashierOrderForm_quantity";
            this.cashierOrderForm_quantity.Size = new System.Drawing.Size(165, 22);
            this.cashierOrderForm_quantity.TabIndex = 18;
            // 
            // cashierOrderForm_clearBtn
            // 
            this.cashierOrderForm_clearBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cashierOrderForm_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_clearBtn.Location = new System.Drawing.Point(437, 217);
            this.cashierOrderForm_clearBtn.Name = "cashierOrderForm_clearBtn";
            this.cashierOrderForm_clearBtn.Size = new System.Drawing.Size(147, 69);
            this.cashierOrderForm_clearBtn.TabIndex = 14;
            this.cashierOrderForm_clearBtn.Text = "CLEAR";
            this.cashierOrderForm_clearBtn.UseVisualStyleBackColor = false;
            // 
            // cashierOrderForm_removeBtn
            // 
            this.cashierOrderForm_removeBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cashierOrderForm_removeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_removeBtn.Location = new System.Drawing.Point(270, 217);
            this.cashierOrderForm_removeBtn.Name = "cashierOrderForm_removeBtn";
            this.cashierOrderForm_removeBtn.Size = new System.Drawing.Size(147, 69);
            this.cashierOrderForm_removeBtn.TabIndex = 15;
            this.cashierOrderForm_removeBtn.Text = "REMOVE";
            this.cashierOrderForm_removeBtn.UseVisualStyleBackColor = false;
            // 
            // cashierOrderForm_addBtn
            // 
            this.cashierOrderForm_addBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cashierOrderForm_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_addBtn.Location = new System.Drawing.Point(99, 217);
            this.cashierOrderForm_addBtn.Name = "cashierOrderForm_addBtn";
            this.cashierOrderForm_addBtn.Size = new System.Drawing.Size(147, 69);
            this.cashierOrderForm_addBtn.TabIndex = 17;
            this.cashierOrderForm_addBtn.Text = "ADD";
            this.cashierOrderForm_addBtn.UseVisualStyleBackColor = false;
            this.cashierOrderForm_addBtn.Click += new System.EventHandler(this.cashierOrderForm_addBtn_Click);
            // 
            // cashierOrderForm_type
            // 
            this.cashierOrderForm_type.FormattingEnabled = true;
            this.cashierOrderForm_type.Items.AddRange(new object[] {
            "Meal",
            "Drinks"});
            this.cashierOrderForm_type.Location = new System.Drawing.Point(122, 40);
            this.cashierOrderForm_type.Name = "cashierOrderForm_type";
            this.cashierOrderForm_type.Size = new System.Drawing.Size(190, 24);
            this.cashierOrderForm_type.TabIndex = 12;
            this.cashierOrderForm_type.SelectedIndexChanged += new System.EventHandler(this.cashierOrderForm_type_SelectedIndexChanged);
            // 
            // cashierOrderForm_productID
            // 
            this.cashierOrderForm_productID.FormattingEnabled = true;
            this.cashierOrderForm_productID.Location = new System.Drawing.Point(440, 37);
            this.cashierOrderForm_productID.Name = "cashierOrderForm_productID";
            this.cashierOrderForm_productID.Size = new System.Drawing.Size(173, 24);
            this.cashierOrderForm_productID.TabIndex = 13;
            this.cashierOrderForm_productID.SelectedIndexChanged += new System.EventHandler(this.cashierOrderForm_productID_SelectedIndexChanged);
            // 
            // cashierOrderForm_prodName
            // 
            this.cashierOrderForm_prodName.AutoSize = true;
            this.cashierOrderForm_prodName.Location = new System.Drawing.Point(135, 110);
            this.cashierOrderForm_prodName.Name = "cashierOrderForm_prodName";
            this.cashierOrderForm_prodName.Size = new System.Drawing.Size(103, 16);
            this.cashierOrderForm_prodName.TabIndex = 6;
            this.cashierOrderForm_prodName.Text = "Test Products";
            // 
            // cashierOrderForm_price
            // 
            this.cashierOrderForm_price.AutoSize = true;
            this.cashierOrderForm_price.Location = new System.Drawing.Point(122, 171);
            this.cashierOrderForm_price.Name = "cashierOrderForm_price";
            this.cashierOrderForm_price.Size = new System.Drawing.Size(31, 16);
            this.cashierOrderForm_price.TabIndex = 6;
            this.cashierOrderForm_price.Text = "100";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Price(VND):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Product Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(74, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Type:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(362, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product ID:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.cashierOrderForm_amount);
            this.panel3.Controls.Add(this.cashierOrderForm_orderTable);
            this.panel3.Controls.Add(this.cashierOrderForm_receiptBtn);
            this.panel3.Controls.Add(this.cashierOrderForm_payBtn);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.cashierOrderForm_change);
            this.panel3.Controls.Add(this.cashierOrderForm_orderPrice);
            this.panel3.Location = new System.Drawing.Point(836, 18);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(412, 712);
            this.panel3.TabIndex = 1;
            // 
            // cashierOrderForm_amount
            // 
            this.cashierOrderForm_amount.Location = new System.Drawing.Point(142, 470);
            this.cashierOrderForm_amount.Name = "cashierOrderForm_amount";
            this.cashierOrderForm_amount.Size = new System.Drawing.Size(112, 22);
            this.cashierOrderForm_amount.TabIndex = 12;
            // 
            // cashierOrderForm_orderTable
            // 
            this.cashierOrderForm_orderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashierOrderForm_orderTable.Location = new System.Drawing.Point(17, 37);
            this.cashierOrderForm_orderTable.Name = "cashierOrderForm_orderTable";
            this.cashierOrderForm_orderTable.RowHeadersWidth = 51;
            this.cashierOrderForm_orderTable.RowTemplate.Height = 24;
            this.cashierOrderForm_orderTable.Size = new System.Drawing.Size(381, 356);
            this.cashierOrderForm_orderTable.TabIndex = 4;
            // 
            // cashierOrderForm_receiptBtn
            // 
            this.cashierOrderForm_receiptBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cashierOrderForm_receiptBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_receiptBtn.Location = new System.Drawing.Point(17, 621);
            this.cashierOrderForm_receiptBtn.Name = "cashierOrderForm_receiptBtn";
            this.cashierOrderForm_receiptBtn.Size = new System.Drawing.Size(381, 50);
            this.cashierOrderForm_receiptBtn.TabIndex = 15;
            this.cashierOrderForm_receiptBtn.Text = "RECEIPT";
            this.cashierOrderForm_receiptBtn.UseVisualStyleBackColor = false;
            // 
            // cashierOrderForm_payBtn
            // 
            this.cashierOrderForm_payBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.cashierOrderForm_payBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierOrderForm_payBtn.Location = new System.Drawing.Point(17, 565);
            this.cashierOrderForm_payBtn.Name = "cashierOrderForm_payBtn";
            this.cashierOrderForm_payBtn.Size = new System.Drawing.Size(381, 50);
            this.cashierOrderForm_payBtn.TabIndex = 15;
            this.cashierOrderForm_payBtn.Text = "PAY";
            this.cashierOrderForm_payBtn.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 524);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 16);
            this.label12.TabIndex = 6;
            this.label12.Text = "Change(VND):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 473);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 16);
            this.label9.TabIndex = 6;
            this.label9.Text = "Amount(VND):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(55, 431);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Price(VND):";
            // 
            // cashierOrderForm_change
            // 
            this.cashierOrderForm_change.AutoSize = true;
            this.cashierOrderForm_change.Location = new System.Drawing.Point(150, 524);
            this.cashierOrderForm_change.Name = "cashierOrderForm_change";
            this.cashierOrderForm_change.Size = new System.Drawing.Size(14, 16);
            this.cashierOrderForm_change.TabIndex = 6;
            this.cashierOrderForm_change.Text = "0";
            // 
            // cashierOrderForm_orderPrice
            // 
            this.cashierOrderForm_orderPrice.AutoSize = true;
            this.cashierOrderForm_orderPrice.Location = new System.Drawing.Point(150, 431);
            this.cashierOrderForm_orderPrice.Name = "cashierOrderForm_orderPrice";
            this.cashierOrderForm_orderPrice.Size = new System.Drawing.Size(28, 16);
            this.cashierOrderForm_orderPrice.TabIndex = 6;
            this.cashierOrderForm_orderPrice.Text = "100";
            // 
            // FrmCashierOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCashierOrder";
            this.Size = new System.Drawing.Size(1251, 745);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_menuTable)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_quantity)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cashierOrderForm_orderTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView cashierOrderForm_menuTable;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown cashierOrderForm_quantity;
        private System.Windows.Forms.Button cashierOrderForm_clearBtn;
        private System.Windows.Forms.Button cashierOrderForm_removeBtn;
        private System.Windows.Forms.Button cashierOrderForm_addBtn;
        private System.Windows.Forms.ComboBox cashierOrderForm_type;
        private System.Windows.Forms.ComboBox cashierOrderForm_productID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cashierOrderForm_prodName;
        private System.Windows.Forms.Label cashierOrderForm_price;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView cashierOrderForm_orderTable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label cashierOrderForm_orderPrice;
        private System.Windows.Forms.TextBox cashierOrderForm_amount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button cashierOrderForm_receiptBtn;
        private System.Windows.Forms.Button cashierOrderForm_payBtn;
        private System.Windows.Forms.Label cashierOrderForm_change;
    }
}
