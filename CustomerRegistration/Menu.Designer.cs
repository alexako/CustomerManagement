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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersList)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.transListView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 65);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 10, 0, 10);
            this.menuStrip1.Size = new System.Drawing.Size(220, 39);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem,
            this.exitToolStripMenuItem1,
            this.exitToolStripMenuItem2});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 19);
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
            this.optionToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editRecordEntryToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(39, 19);
            this.optionToolStripMenuItem.Text = "Edit";
            // 
            // editRecordEntryToolStripMenuItem
            // 
            this.editRecordEntryToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerToolStripMenuItem});
            this.editRecordEntryToolStripMenuItem.Name = "editRecordEntryToolStripMenuItem";
            this.editRecordEntryToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.editRecordEntryToolStripMenuItem.Text = "Record entry";
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.customerToolStripMenuItem.Text = "Edit Customer...";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.generateToolStripMenuItem});
            this.helpToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 19);
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 215);
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
            this.customersList.DoubleClick += new System.EventHandler(this.customersList_DoubleClick);
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
            this.custNum.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custNum.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.custNum.Location = new System.Drawing.Point(11, 10);
            this.custNum.Name = "custNum";
            this.custNum.Size = new System.Drawing.Size(124, 15);
            this.custNum.TabIndex = 7;
            this.custNum.Text = "Number of Customers:";
            // 
            // custNumVal
            // 
            this.custNumVal.AutoSize = true;
            this.custNumVal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.custNumVal.Location = new System.Drawing.Point(156, 10);
            this.custNumVal.Name = "custNumVal";
            this.custNumVal.Size = new System.Drawing.Size(33, 13);
            this.custNumVal.TabIndex = 9;
            this.custNumVal.Text = "value";
            // 
            // addNewCustomer
            // 
            this.addNewCustomer.BackColor = System.Drawing.SystemColors.Control;
            this.addNewCustomer.Location = new System.Drawing.Point(243, 128);
            this.addNewCustomer.Name = "addNewCustomer";
            this.addNewCustomer.Size = new System.Drawing.Size(179, 53);
            this.addNewCustomer.TabIndex = 2;
            this.addNewCustomer.Text = "Add new Customer";
            this.addNewCustomer.UseVisualStyleBackColor = false;
            this.addNewCustomer.Click += new System.EventHandler(this.addNewCustomer_Click);
            // 
            // startNewTrans
            // 
            this.startNewTrans.BackColor = System.Drawing.SystemColors.Control;
            this.startNewTrans.Location = new System.Drawing.Point(17, 127);
            this.startNewTrans.Name = "startNewTrans";
            this.startNewTrans.Size = new System.Drawing.Size(187, 54);
            this.startNewTrans.TabIndex = 10;
            this.startNewTrans.Text = "Begin Transaction";
            this.startNewTrans.UseVisualStyleBackColor = false;
            this.startNewTrans.Click += new System.EventHandler(this.startNewTrans_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "Number of Transactions:";
            // 
            // transNumVal
            // 
            this.transNumVal.AutoSize = true;
            this.transNumVal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.transNumVal.Location = new System.Drawing.Point(156, 31);
            this.transNumVal.Name = "transNumVal";
            this.transNumVal.Size = new System.Drawing.Size(33, 13);
            this.transNumVal.TabIndex = 12;
            this.transNumVal.Text = "value";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.transNumVal);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.custNumVal);
            this.panel1.Controls.Add(this.custNum);
            this.panel1.Location = new System.Drawing.Point(501, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(206, 53);
            this.panel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(707, 62);
            this.panel2.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(216, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Customer Records Management";
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refreshToolStripMenuItem.Text = "Refresh";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(707, 579);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.startNewTrans);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.addNewCustomer);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
    }
}

