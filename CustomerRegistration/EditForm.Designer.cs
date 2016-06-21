namespace CustomerManagement
{
    partial class EditForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.phoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.country = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.province = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.city = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.address2 = new System.Windows.Forms.TextBox();
            this.address1 = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.middleInitial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.viewTransBtn = new System.Windows.Forms.Button();
            this.custTransView = new System.Windows.Forms.ListView();
            this.transID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.transDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.deleteCustBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.phoneNumber);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.country);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.province);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.city);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.address2);
            this.groupBox1.Controls.Add(this.address1);
            this.groupBox1.Controls.Add(this.lastName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.firstName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.middleInitial);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(544, 174);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            this.groupBox1.Leave += new System.EventHandler(this.groupBox1_Leave);
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(383, 44);
            this.phoneNumber.Mask = "(999) 000-0000";
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(151, 20);
            this.phoneNumber.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(329, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Phone";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Email";
            // 
            // email
            // 
            this.email.Location = new System.Drawing.Point(383, 18);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(151, 20);
            this.email.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Country";
            // 
            // country
            // 
            this.country.Location = new System.Drawing.Point(383, 142);
            this.country.Name = "country";
            this.country.Size = new System.Drawing.Size(151, 20);
            this.country.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Province";
            // 
            // province
            // 
            this.province.Location = new System.Drawing.Point(383, 116);
            this.province.Name = "province";
            this.province.Size = new System.Drawing.Size(151, 20);
            this.province.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "City";
            // 
            // city
            // 
            this.city.Location = new System.Drawing.Point(383, 89);
            this.city.Name = "city";
            this.city.Size = new System.Drawing.Size(151, 20);
            this.city.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Address 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address 1";
            // 
            // address2
            // 
            this.address2.Location = new System.Drawing.Point(71, 116);
            this.address2.Name = "address2";
            this.address2.Size = new System.Drawing.Size(227, 20);
            this.address2.TabIndex = 6;
            // 
            // address1
            // 
            this.address1.Location = new System.Drawing.Point(71, 89);
            this.address1.Name = "address1";
            this.address1.Size = new System.Drawing.Size(227, 20);
            this.address1.TabIndex = 5;
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(71, 45);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(151, 20);
            this.lastName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(230, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "M.I.";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(71, 19);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(151, 20);
            this.firstName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Last name";
            // 
            // middleInitial
            // 
            this.middleInitial.Location = new System.Drawing.Point(261, 19);
            this.middleInitial.Name = "middleInitial";
            this.middleInitial.Size = new System.Drawing.Size(37, 20);
            this.middleInitial.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.viewTransBtn);
            this.groupBox2.Controls.Add(this.custTransView);
            this.groupBox2.Location = new System.Drawing.Point(16, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 232);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Transactions";
            // 
            // viewTransBtn
            // 
            this.viewTransBtn.Location = new System.Drawing.Point(463, 200);
            this.viewTransBtn.Name = "viewTransBtn";
            this.viewTransBtn.Size = new System.Drawing.Size(75, 23);
            this.viewTransBtn.TabIndex = 1;
            this.viewTransBtn.Text = "View";
            this.viewTransBtn.UseVisualStyleBackColor = true;
            this.viewTransBtn.Click += new System.EventHandler(this.viewTransBtn_Click);
            // 
            // custTransView
            // 
            this.custTransView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.transID,
            this.custCol,
            this.transDate});
            this.custTransView.Location = new System.Drawing.Point(7, 20);
            this.custTransView.Name = "custTransView";
            this.custTransView.Size = new System.Drawing.Size(531, 174);
            this.custTransView.TabIndex = 0;
            this.custTransView.UseCompatibleStateImageBehavior = false;
            this.custTransView.View = System.Windows.Forms.View.Details;
            this.custTransView.SelectedIndexChanged += new System.EventHandler(this.custTransView_SelectedIndexChanged);
            // 
            // transID
            // 
            this.transID.Text = "Transaction ID";
            this.transID.Width = 172;
            // 
            // custCol
            // 
            this.custCol.Text = "Customer";
            this.custCol.Width = 241;
            // 
            // transDate
            // 
            this.transDate.Text = "Date";
            this.transDate.Width = 114;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(250, 25);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 18);
            this.label11.TabIndex = 10;
            this.label11.Text = "Edit Customer";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Add new customer..."});
            this.comboBox1.Location = new System.Drawing.Point(35, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(267, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // saveBtn
            // 
            this.saveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.saveBtn.Location = new System.Drawing.Point(354, 115);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(102, 55);
            this.saveBtn.TabIndex = 11;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = false;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.Control;
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(479, 115);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(101, 55);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Close";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // deleteCustBtn
            // 
            this.deleteCustBtn.BackColor = System.Drawing.Color.Red;
            this.deleteCustBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteCustBtn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCustBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.deleteCustBtn.Location = new System.Drawing.Point(178, 662);
            this.deleteCustBtn.Name = "deleteCustBtn";
            this.deleteCustBtn.Size = new System.Drawing.Size(252, 47);
            this.deleteCustBtn.TabIndex = 13;
            this.deleteCustBtn.Text = "Delete Customer Record";
            this.deleteCustBtn.UseVisualStyleBackColor = false;
            this.deleteCustBtn.Click += new System.EventHandler(this.deleteCustBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(-2, -4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(629, 69);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Location = new System.Drawing.Point(21, 199);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 184);
            this.panel2.TabIndex = 15;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Location = new System.Drawing.Point(21, 406);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(579, 250);
            this.panel3.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "Select Customer";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel4.Location = new System.Drawing.Point(-2, 213);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(17, 167);
            this.panel4.TabIndex = 18;
            this.panel4.Visible = false;
            // 
            // viewEdit
            // 
            this.AcceptButton = this.saveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(623, 719);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.deleteCustBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewEdit";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Records";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox phoneNumber;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox country;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox province;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox city;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox address2;
        private System.Windows.Forms.TextBox address1;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox middleInitial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView custTransView;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ColumnHeader transID;
        private System.Windows.Forms.ColumnHeader custCol;
        private System.Windows.Forms.ColumnHeader transDate;
        private System.Windows.Forms.Button viewTransBtn;
        private System.Windows.Forms.Button deleteCustBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel4;
    }
}