namespace CustomerRegistration
{
    partial class TransactionForm
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
            this.cancelBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearShoppingCart = new System.Windows.Forms.Button();
            this.shoppingMenu = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.addItemToCart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.removeItemFromCart = new System.Windows.Forms.Button();
            this.shoppingCart = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(328, 184);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(146, 26);
            this.cancelBtn.TabIndex = 12;
            this.cancelBtn.Text = "Close";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(6, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 64);
            this.panel1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(169, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "New Transaction";
            // 
            // checkoutButton
            // 
            this.checkoutButton.Enabled = false;
            this.checkoutButton.Location = new System.Drawing.Point(328, 106);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(146, 61);
            this.checkoutButton.TabIndex = 10;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearShoppingCart);
            this.groupBox1.Controls.Add(this.shoppingMenu);
            this.groupBox1.Controls.Add(this.addItemToCart);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.removeItemFromCart);
            this.groupBox1.Controls.Add(this.shoppingCart);
            this.groupBox1.Location = new System.Drawing.Point(20, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 271);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shopping Cart";
            // 
            // clearShoppingCart
            // 
            this.clearShoppingCart.Location = new System.Drawing.Point(196, 200);
            this.clearShoppingCart.Name = "clearShoppingCart";
            this.clearShoppingCart.Size = new System.Drawing.Size(75, 23);
            this.clearShoppingCart.TabIndex = 12;
            this.clearShoppingCart.Text = "Clear";
            this.clearShoppingCart.UseVisualStyleBackColor = true;
            this.clearShoppingCart.Click += new System.EventHandler(this.clearShoppingCart_Click);
            // 
            // shoppingMenu
            // 
            this.shoppingMenu.AllColumns.Add(this.olvColumn1);
            this.shoppingMenu.AllColumns.Add(this.olvColumn2);
            this.shoppingMenu.CellEditUseWholeCell = false;
            this.shoppingMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2});
            this.shoppingMenu.Cursor = System.Windows.Forms.Cursors.Default;
            this.shoppingMenu.FullRowSelect = true;
            this.shoppingMenu.HasCollapsibleGroups = false;
            this.shoppingMenu.Location = new System.Drawing.Point(7, 53);
            this.shoppingMenu.Name = "shoppingMenu";
            this.shoppingMenu.Size = new System.Drawing.Size(183, 212);
            this.shoppingMenu.TabIndex = 11;
            this.shoppingMenu.UseCompatibleStateImageBehavior = false;
            this.shoppingMenu.View = System.Windows.Forms.View.Details;
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Item";
            this.olvColumn1.Groupable = false;
            this.olvColumn1.Text = "Item";
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Price";
            this.olvColumn2.Groupable = false;
            this.olvColumn2.Text = "Price";
            // 
            // addItemToCart
            // 
            this.addItemToCart.Location = new System.Drawing.Point(196, 81);
            this.addItemToCart.Name = "addItemToCart";
            this.addItemToCart.Size = new System.Drawing.Size(75, 23);
            this.addItemToCart.TabIndex = 10;
            this.addItemToCart.Text = "Add";
            this.addItemToCart.UseVisualStyleBackColor = true;
            this.addItemToCart.Click += new System.EventHandler(this.addItemToCart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Currently in cart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Menu:";
            // 
            // removeItemFromCart
            // 
            this.removeItemFromCart.Location = new System.Drawing.Point(196, 117);
            this.removeItemFromCart.Name = "removeItemFromCart";
            this.removeItemFromCart.Size = new System.Drawing.Size(75, 23);
            this.removeItemFromCart.TabIndex = 5;
            this.removeItemFromCart.Text = "Remove";
            this.removeItemFromCart.UseVisualStyleBackColor = true;
            this.removeItemFromCart.Click += new System.EventHandler(this.removeItemFromCart_Click);
            // 
            // shoppingCart
            // 
            this.shoppingCart.FormattingEnabled = true;
            this.shoppingCart.Location = new System.Drawing.Point(277, 53);
            this.shoppingCart.Name = "shoppingCart";
            this.shoppingCart.Size = new System.Drawing.Size(177, 212);
            this.shoppingCart.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Customer";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Add new customer..."});
            this.comboBox1.Location = new System.Drawing.Point(43, 122);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 7;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // TransactionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 519);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Name = "TransactionForm";
            this.Text = "TransactionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shoppingMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addItemToCart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button removeItemFromCart;
        private System.Windows.Forms.ListBox shoppingCart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private BrightIdeasSoftware.ObjectListView shoppingMenu;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
        private System.Windows.Forms.Button clearShoppingCart;
    }
}