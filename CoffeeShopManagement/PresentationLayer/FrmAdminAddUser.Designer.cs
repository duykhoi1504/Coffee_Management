namespace PresentationLayer
{
    partial class FrmAdminAddUser
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.adminAddUsers_imageView = new System.Windows.Forms.PictureBox();
            this.adminAddUsers_status = new System.Windows.Forms.ComboBox();
            this.adminAddUsers_role = new System.Windows.Forms.ComboBox();
            this.adminAddUsers_clearBtn = new System.Windows.Forms.Button();
            this.adminAddUsers_deleteBtn = new System.Windows.Forms.Button();
            this.adminAddUsers_updateBtn = new System.Windows.Forms.Button();
            this.adminAddUsers_importBtn = new System.Windows.Forms.Button();
            this.adminAddUsers_addBtn = new System.Windows.Forms.Button();
            this.adminAddUsers_password = new System.Windows.Forms.TextBox();
            this.adminAddUsers_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvUsersTable = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adminAddUsers_imageView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.adminAddUsers_status);
            this.panel1.Controls.Add(this.adminAddUsers_role);
            this.panel1.Controls.Add(this.adminAddUsers_clearBtn);
            this.panel1.Controls.Add(this.adminAddUsers_deleteBtn);
            this.panel1.Controls.Add(this.adminAddUsers_updateBtn);
            this.panel1.Controls.Add(this.adminAddUsers_importBtn);
            this.panel1.Controls.Add(this.adminAddUsers_addBtn);
            this.panel1.Controls.Add(this.adminAddUsers_password);
            this.panel1.Controls.Add(this.adminAddUsers_username);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(335, 725);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel3.Controls.Add(this.adminAddUsers_imageView);
            this.panel3.Location = new System.Drawing.Point(126, 39);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(138, 123);
            this.panel3.TabIndex = 6;
            // 
            // adminAddUsers_imageView
            // 
            this.adminAddUsers_imageView.Location = new System.Drawing.Point(15, 3);
            this.adminAddUsers_imageView.Name = "adminAddUsers_imageView";
            this.adminAddUsers_imageView.Size = new System.Drawing.Size(107, 117);
            this.adminAddUsers_imageView.TabIndex = 0;
            this.adminAddUsers_imageView.TabStop = false;
            // 
            // adminAddUsers_status
            // 
            this.adminAddUsers_status.FormattingEnabled = true;
            this.adminAddUsers_status.Location = new System.Drawing.Point(86, 371);
            this.adminAddUsers_status.Name = "adminAddUsers_status";
            this.adminAddUsers_status.Size = new System.Drawing.Size(234, 24);
            this.adminAddUsers_status.TabIndex = 5;
            // 
            // adminAddUsers_role
            // 
            this.adminAddUsers_role.FormattingEnabled = true;
            this.adminAddUsers_role.Location = new System.Drawing.Point(86, 321);
            this.adminAddUsers_role.Name = "adminAddUsers_role";
            this.adminAddUsers_role.Size = new System.Drawing.Size(234, 24);
            this.adminAddUsers_role.TabIndex = 5;
            // 
            // adminAddUsers_clearBtn
            // 
            this.adminAddUsers_clearBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.adminAddUsers_clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUsers_clearBtn.Location = new System.Drawing.Point(173, 555);
            this.adminAddUsers_clearBtn.Name = "adminAddUsers_clearBtn";
            this.adminAddUsers_clearBtn.Size = new System.Drawing.Size(147, 69);
            this.adminAddUsers_clearBtn.TabIndex = 4;
            this.adminAddUsers_clearBtn.Text = "CLEAR";
            this.adminAddUsers_clearBtn.UseVisualStyleBackColor = false;
            this.adminAddUsers_clearBtn.Click += new System.EventHandler(this.adminAddUsers_clearBtn_Click);
            // 
            // adminAddUsers_deleteBtn
            // 
            this.adminAddUsers_deleteBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.adminAddUsers_deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUsers_deleteBtn.Location = new System.Drawing.Point(17, 555);
            this.adminAddUsers_deleteBtn.Name = "adminAddUsers_deleteBtn";
            this.adminAddUsers_deleteBtn.Size = new System.Drawing.Size(147, 69);
            this.adminAddUsers_deleteBtn.TabIndex = 4;
            this.adminAddUsers_deleteBtn.Text = "DELETE";
            this.adminAddUsers_deleteBtn.UseVisualStyleBackColor = false;
            this.adminAddUsers_deleteBtn.Click += new System.EventHandler(this.adminAddUsers_deleteBtn_Click);
            // 
            // adminAddUsers_updateBtn
            // 
            this.adminAddUsers_updateBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.adminAddUsers_updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUsers_updateBtn.Location = new System.Drawing.Point(173, 471);
            this.adminAddUsers_updateBtn.Name = "adminAddUsers_updateBtn";
            this.adminAddUsers_updateBtn.Size = new System.Drawing.Size(147, 69);
            this.adminAddUsers_updateBtn.TabIndex = 4;
            this.adminAddUsers_updateBtn.Text = "UPDATE";
            this.adminAddUsers_updateBtn.UseVisualStyleBackColor = false;
            this.adminAddUsers_updateBtn.Click += new System.EventHandler(this.adminAddUsers_updateBtn_Click);
            // 
            // adminAddUsers_importBtn
            // 
            this.adminAddUsers_importBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.adminAddUsers_importBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUsers_importBtn.Location = new System.Drawing.Point(117, 168);
            this.adminAddUsers_importBtn.Name = "adminAddUsers_importBtn";
            this.adminAddUsers_importBtn.Size = new System.Drawing.Size(147, 32);
            this.adminAddUsers_importBtn.TabIndex = 4;
            this.adminAddUsers_importBtn.Text = "Import";
            this.adminAddUsers_importBtn.UseVisualStyleBackColor = false;
            this.adminAddUsers_importBtn.Click += new System.EventHandler(this.adminAddUsers_importBtn_Click);
            // 
            // adminAddUsers_addBtn
            // 
            this.adminAddUsers_addBtn.BackColor = System.Drawing.Color.PaleTurquoise;
            this.adminAddUsers_addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminAddUsers_addBtn.Location = new System.Drawing.Point(17, 471);
            this.adminAddUsers_addBtn.Name = "adminAddUsers_addBtn";
            this.adminAddUsers_addBtn.Size = new System.Drawing.Size(147, 69);
            this.adminAddUsers_addBtn.TabIndex = 4;
            this.adminAddUsers_addBtn.Text = "ADD";
            this.adminAddUsers_addBtn.UseVisualStyleBackColor = false;
            this.adminAddUsers_addBtn.Click += new System.EventHandler(this.adminAddUsers_addBtn_Click);
            // 
            // adminAddUsers_password
            // 
            this.adminAddUsers_password.Location = new System.Drawing.Point(86, 280);
            this.adminAddUsers_password.Name = "adminAddUsers_password";
            this.adminAddUsers_password.Size = new System.Drawing.Size(234, 22);
            this.adminAddUsers_password.TabIndex = 3;
            // 
            // adminAddUsers_username
            // 
            this.adminAddUsers_username.Location = new System.Drawing.Point(86, 230);
            this.adminAddUsers_username.Name = "adminAddUsers_username";
            this.adminAddUsers_username.Size = new System.Drawing.Size(234, 22);
            this.adminAddUsers_username.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 371);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Role:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 280);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvUsersTable);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(344, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(752, 725);
            this.panel2.TabIndex = 0;
            // 
            // dgvUsersTable
            // 
            this.dgvUsersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUsersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsersTable.Location = new System.Drawing.Point(3, 42);
            this.dgvUsersTable.Name = "dgvUsersTable";
            this.dgvUsersTable.RowHeadersWidth = 51;
            this.dgvUsersTable.RowTemplate.Height = 24;
            this.dgvUsersTable.Size = new System.Drawing.Size(626, 658);
            this.dgvUsersTable.TabIndex = 3;
            this.dgvUsersTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsersTable_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Data of Users";
            // 
            // FrmAdminAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmAdminAddUser";
            this.Size = new System.Drawing.Size(976, 706);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adminAddUsers_imageView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsersTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button adminAddUsers_clearBtn;
        private System.Windows.Forms.Button adminAddUsers_deleteBtn;
        private System.Windows.Forms.Button adminAddUsers_updateBtn;
        private System.Windows.Forms.Button adminAddUsers_addBtn;
        private System.Windows.Forms.TextBox adminAddUsers_password;
        private System.Windows.Forms.TextBox adminAddUsers_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvUsersTable;
        private System.Windows.Forms.ComboBox adminAddUsers_status;
        private System.Windows.Forms.ComboBox adminAddUsers_role;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox adminAddUsers_imageView;
        private System.Windows.Forms.Button adminAddUsers_importBtn;
    }
}
