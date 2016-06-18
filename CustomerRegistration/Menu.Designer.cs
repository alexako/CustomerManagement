﻿namespace CustomerRegistration
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editRecordEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editCustomerBtn = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.customersList = new BrightIdeasSoftware.ObjectListView();
            this.custIDcol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.lastNameCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.firstNameCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.emailCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.phoneCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.cityCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.transListView = new BrightIdeasSoftware.ObjectListView();
            this.transIDcol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.custCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.dateCol = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.custNum = new System.Windows.Forms.Label();
            this.custNumVal = new System.Windows.Forms.Label();
            this.addNewCustomer = new System.Windows.Forms.Button();
            this.startNewTrans = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.transNumVal = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersList)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transListView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem,
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
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editRecordEntryToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.optionToolStripMenuItem.Text = "Edit";
            // 
            // editRecordEntryToolStripMenuItem
            // 
            this.editRecordEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem});
            this.editRecordEntryToolStripMenuItem.Name = "editRecordEntryToolStripMenuItem";
            this.editRecordEntryToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.editRecordEntryToolStripMenuItem.Text = "Record entry";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.customerToolStripMenuItem.Text = "Edit Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.generateToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersToolStripMenuItem,
            this.transactionsToolStripMenuItem});
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.generateToolStripMenuItem.Text = "Generate";
            // 
            // customersToolStripMenuItem
            // 
            this.customersToolStripMenuItem.Name = "customersToolStripMenuItem";
            this.customersToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.customersToolStripMenuItem.Text = "Customers";
            this.customersToolStripMenuItem.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // transactionsToolStripMenuItem
            // 
            this.transactionsToolStripMenuItem.Name = "transactionsToolStripMenuItem";
            this.transactionsToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.transactionsToolStripMenuItem.Text = "Transactions";
            this.transactionsToolStripMenuItem.Click += new System.EventHandler(this.transactionsToolStripMenuItem_Click);
            // 
            // editCustomerBtn
            // 
            this.editCustomerBtn.Location = new System.Drawing.Point(564, 93);
            this.editCustomerBtn.Name = "editCustomerBtn";
            this.editCustomerBtn.Size = new System.Drawing.Size(126, 27);
            this.editCustomerBtn.TabIndex = 3;
            this.editCustomerBtn.Text = "Edit/View";
            this.editCustomerBtn.UseVisualStyleBackColor = true;
            this.editCustomerBtn.Click += new System.EventHandler(this.editCustomerBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 126);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(684, 352);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.customersList);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(676, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // customersList
            // 
            this.customersList.AllColumns.Add(this.custIDcol);
            this.customersList.AllColumns.Add(this.lastNameCol);
            this.customersList.AllColumns.Add(this.firstNameCol);
            this.customersList.AllColumns.Add(this.emailCol);
            this.customersList.AllColumns.Add(this.phoneCol);
            this.customersList.AllColumns.Add(this.cityCol);
            this.customersList.AllowColumnReorder = true;
            this.customersList.AlternateRowBackColor = System.Drawing.Color.DodgerBlue;
            this.customersList.CellEditUseWholeCell = false;
            this.customersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.custIDcol,
            this.lastNameCol,
            this.firstNameCol,
            this.emailCol,
            this.phoneCol,
            this.cityCol});
            this.customersList.Cursor = System.Windows.Forms.Cursors.Default;
            this.customersList.FullRowSelect = true;
            this.customersList.Location = new System.Drawing.Point(6, 6);
            this.customersList.MultiSelect = false;
            this.customersList.Name = "customersList";
            this.customersList.ShowGroups = false;
            this.customersList.Size = new System.Drawing.Size(664, 314);
            this.customersList.SortGroupItemsByPrimaryColumn = false;
            this.customersList.TabIndex = 13;
            this.customersList.UseCompatibleStateImageBehavior = false;
            this.customersList.View = System.Windows.Forms.View.Details;
            // 
            // custIDcol
            // 
            this.custIDcol.AspectName = "CustomerID";
            this.custIDcol.Text = "ID";
            this.custIDcol.Width = 147;
            // 
            // lastNameCol
            // 
            this.lastNameCol.AspectName = "LastName";
            this.lastNameCol.Text = "Last Name";
            this.lastNameCol.Width = 98;
            // 
            // firstNameCol
            // 
            this.firstNameCol.AspectName = "FirstName";
            this.firstNameCol.Text = "First Name";
            this.firstNameCol.Width = 97;
            // 
            // emailCol
            // 
            this.emailCol.AspectName = "Email";
            this.emailCol.Text = "Email";
            this.emailCol.Width = 94;
            // 
            // phoneCol
            // 
            this.phoneCol.AspectName = "Phone";
            this.phoneCol.Text = "Phone Number";
            this.phoneCol.Width = 90;
            // 
            // cityCol
            // 
            this.cityCol.AspectName = "City";
            this.cityCol.Text = "City";
            this.cityCol.Width = 117;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.transListView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(676, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Transactions";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // transListView
            // 
            this.transListView.AllColumns.Add(this.transIDcol);
            this.transListView.AllColumns.Add(this.custCol);
            this.transListView.AllColumns.Add(this.dateCol);
            this.transListView.CellEditUseWholeCell = false;
            this.transListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.transIDcol,
            this.custCol,
            this.dateCol});
            this.transListView.Cursor = System.Windows.Forms.Cursors.Default;
            this.transListView.FullRowSelect = true;
            this.transListView.Location = new System.Drawing.Point(3, 6);
            this.transListView.Name = "transListView";
            this.transListView.ShowGroups = false;
            this.transListView.Size = new System.Drawing.Size(667, 314);
            this.transListView.TabIndex = 13;
            this.transListView.UseCompatibleStateImageBehavior = false;
            this.transListView.View = System.Windows.Forms.View.Details;
            // 
            // transIDcol
            // 
            this.transIDcol.AspectName = "TransactionID";
            this.transIDcol.Text = "Transaction ID";
            this.transIDcol.Width = 257;
            // 
            // custCol
            // 
            this.custCol.AspectName = "Customer";
            this.custCol.Text = "Customer";
            this.custCol.Width = 185;
            // 
            // dateCol
            // 
            this.dateCol.AspectName = "Date";
            this.dateCol.Text = "Date";
            this.dateCol.Width = 198;
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
            this.Controls.Add(this.editCustomerBtn);
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
            ((System.ComponentModel.ISupportInitialize)(this.customersList)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.transListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button editCustomerBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label custNum;
        private System.Windows.Forms.Label custNumVal;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.Button addNewCustomer;
        private System.Windows.Forms.Button startNewTrans;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label transNumVal;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editRecordEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
        private BrightIdeasSoftware.ObjectListView customersList;
        private BrightIdeasSoftware.OLVColumn custIDcol;
        private BrightIdeasSoftware.OLVColumn lastNameCol;
        private BrightIdeasSoftware.OLVColumn firstNameCol;
        private BrightIdeasSoftware.OLVColumn emailCol;
        private BrightIdeasSoftware.OLVColumn phoneCol;
        private BrightIdeasSoftware.OLVColumn cityCol;
        private BrightIdeasSoftware.ObjectListView transListView;
        private BrightIdeasSoftware.OLVColumn transIDcol;
        private BrightIdeasSoftware.OLVColumn custCol;
        private BrightIdeasSoftware.OLVColumn dateCol;
    }
}

