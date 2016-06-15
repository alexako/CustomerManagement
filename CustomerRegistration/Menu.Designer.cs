namespace CustomerRegistration
{
    partial class Menu
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "",
            "",
            ""}, -1);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCustomer = new System.Windows.Forms.Button();
            this.view = new System.Windows.Forms.Button();
            this.delete = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.customersList = new System.Windows.Forms.ListView();
            this.customerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.firstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.phoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.city = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.custNum = new System.Windows.Forms.Label();
            this.custNumVal = new System.Windows.Forms.Label();
            this.addNewCustomer = new System.Windows.Forms.Button();
            this.startNewTrans = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.transNumVal = new System.Windows.Forms.Label();
            this.transListView = new System.Windows.Forms.ListView();
            this.transID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.transDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(709, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1,
            this.exitToolStripMenuItem2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.exitToolStripMenuItem.Text = "New &Customer...";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(171, 22);
            this.exitToolStripMenuItem1.Text = "New &Transaction...";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem2
            // 
            this.exitToolStripMenuItem2.Name = "exitToolStripMenuItem2";
            this.exitToolStripMenuItem2.Size = new System.Drawing.Size(171, 22);
            this.exitToolStripMenuItem2.Text = "E&xit";
            this.exitToolStripMenuItem2.Click += new System.EventHandler(this.exitToolStripMenuItem2_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // editCustomer
            // 
            this.editCustomer.Location = new System.Drawing.Point(574, 210);
            this.editCustomer.Name = "editCustomer";
            this.editCustomer.Size = new System.Drawing.Size(126, 23);
            this.editCustomer.TabIndex = 3;
            this.editCustomer.Text = "Edit";
            this.editCustomer.UseVisualStyleBackColor = true;
            // 
            // view
            // 
            this.view.Location = new System.Drawing.Point(574, 240);
            this.view.Name = "view";
            this.view.Size = new System.Drawing.Size(126, 23);
            this.view.TabIndex = 4;
            this.view.Text = "View";
            this.view.UseVisualStyleBackColor = true;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(574, 317);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(126, 23);
            this.delete.TabIndex = 5;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 125);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(559, 353);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.customersList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(551, 327);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // customersList
            // 
            this.customersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.customerID,
            this.lastName,
            this.firstName,
            this.email,
            this.phoneNumber,
            this.city});
            this.customersList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.customersList.Location = new System.Drawing.Point(7, 7);
            this.customersList.Name = "customersList";
            this.customersList.Size = new System.Drawing.Size(538, 314);
            this.customersList.TabIndex = 0;
            this.customersList.UseCompatibleStateImageBehavior = false;
            this.customersList.View = System.Windows.Forms.View.Details;
            // 
            // customerID
            // 
            this.customerID.Text = "ID";
            this.customerID.Width = 90;
            // 
            // lastName
            // 
            this.lastName.Text = "Last Name";
            this.lastName.Width = 98;
            // 
            // firstName
            // 
            this.firstName.Text = "First Name";
            this.firstName.Width = 97;
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 93;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Text = "Phone";
            this.phoneNumber.Width = 76;
            // 
            // city
            // 
            this.city.Text = "City";
            this.city.Width = 80;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.transListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(551, 327);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transactions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // custNum
            // 
            this.custNum.AutoSize = true;
            this.custNum.Location = new System.Drawing.Point(520, 46);
            this.custNum.Name = "custNum";
            this.custNum.Size = new System.Drawing.Size(111, 13);
            this.custNum.TabIndex = 7;
            this.custNum.Text = "Number of Customers:";
            // 
            // custNumVal
            // 
            this.custNumVal.AutoSize = true;
            this.custNumVal.Location = new System.Drawing.Point(657, 45);
            this.custNumVal.Name = "custNumVal";
            this.custNumVal.Size = new System.Drawing.Size(33, 13);
            this.custNumVal.TabIndex = 9;
            this.custNumVal.Text = "value";
            // 
            // addNewCustomer
            // 
            this.addNewCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addNewCustomer.Location = new System.Drawing.Point(251, 46);
            this.addNewCustomer.Name = "addNewCustomer";
            this.addNewCustomer.Size = new System.Drawing.Size(179, 53);
            this.addNewCustomer.TabIndex = 2;
            this.addNewCustomer.Text = "Add new Customer";
            this.addNewCustomer.UseVisualStyleBackColor = true;
            this.addNewCustomer.Click += new System.EventHandler(this.addNewCustomer_Click);
            // 
            // startNewTrans
            // 
            this.startNewTrans.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startNewTrans.Location = new System.Drawing.Point(35, 45);
            this.startNewTrans.Name = "startNewTrans";
            this.startNewTrans.Size = new System.Drawing.Size(187, 54);
            this.startNewTrans.TabIndex = 10;
            this.startNewTrans.Text = "Begin Transaction";
            this.startNewTrans.UseVisualStyleBackColor = true;
            this.startNewTrans.Click += new System.EventHandler(this.startNewTrans_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Number of Transactions:";
            // 
            // transNumVal
            // 
            this.transNumVal.AutoSize = true;
            this.transNumVal.Location = new System.Drawing.Point(657, 66);
            this.transNumVal.Name = "transNumVal";
            this.transNumVal.Size = new System.Drawing.Size(33, 13);
            this.transNumVal.TabIndex = 12;
            this.transNumVal.Text = "value";
            // 
            // transListView
            // 
            this.transListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.transID,
            this.customer,
            this.transDate});
            this.transListView.Location = new System.Drawing.Point(6, 6);
            this.transListView.Name = "transListView";
            this.transListView.Size = new System.Drawing.Size(539, 315);
            this.transListView.TabIndex = 0;
            this.transListView.UseCompatibleStateImageBehavior = false;
            this.transListView.View = System.Windows.Forms.View.Details;
            // 
            // transID
            // 
            this.transID.Text = "Transaction ID";
            this.transID.Width = 184;
            // 
            // customer
            // 
            this.customer.Text = "Customer";
            this.customer.Width = 208;
            // 
            // transDate
            // 
            this.transDate.Text = "Date";
            this.transDate.Width = 142;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 490);
            this.Controls.Add(this.transNumVal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.startNewTrans);
            this.Controls.Add(this.custNumVal);
            this.Controls.Add(this.custNum);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.view);
            this.Controls.Add(this.editCustomer);
            this.Controls.Add(this.addNewCustomer);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Records Management";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button editCustomer;
        private System.Windows.Forms.Button view;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListView customersList;
        private System.Windows.Forms.ColumnHeader customerID;
        private System.Windows.Forms.ColumnHeader lastName;
        private System.Windows.Forms.ColumnHeader firstName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label custNum;
        private System.Windows.Forms.Label custNumVal;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Button addNewCustomer;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader phoneNumber;
        private System.Windows.Forms.ColumnHeader city;
        private System.Windows.Forms.Button startNewTrans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label transNumVal;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ListView transListView;
        private System.Windows.Forms.ColumnHeader transID;
        private System.Windows.Forms.ColumnHeader customer;
        private System.Windows.Forms.ColumnHeader transDate;
    }
}

