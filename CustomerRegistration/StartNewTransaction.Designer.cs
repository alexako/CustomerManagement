namespace CustomerRegistration
{
    partial class StartNewTransaction
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.shoppingMenu = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearCart = new System.Windows.Forms.Button();
            this.removeItemFromCart = new System.Windows.Forms.Button();
            this.addItemToCart = new System.Windows.Forms.Button();
            this.shoppingCart = new System.Windows.Forms.ListBox();
            this.checkoutButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Add new customer..."});
            this.comboBox1.Location = new System.Drawing.Point(35, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Customer";
            // 
            // shoppingMenu
            // 
            this.shoppingMenu.FormattingEnabled = true;
            this.shoppingMenu.Location = new System.Drawing.Point(6, 53);
            this.shoppingMenu.Name = "shoppingMenu";
            this.shoppingMenu.Size = new System.Drawing.Size(184, 212);
            this.shoppingMenu.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.clearCart);
            this.groupBox1.Controls.Add(this.removeItemFromCart);
            this.groupBox1.Controls.Add(this.addItemToCart);
            this.groupBox1.Controls.Add(this.shoppingCart);
            this.groupBox1.Controls.Add(this.shoppingMenu);
            this.groupBox1.Location = new System.Drawing.Point(12, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 271);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shopping Cart";
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
            // clearCart
            // 
            this.clearCart.Location = new System.Drawing.Point(196, 208);
            this.clearCart.Name = "clearCart";
            this.clearCart.Size = new System.Drawing.Size(75, 23);
            this.clearCart.TabIndex = 6;
            this.clearCart.Text = "Clear";
            this.clearCart.UseVisualStyleBackColor = true;
            this.clearCart.Click += new System.EventHandler(this.clearCart_Click);
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
            // addItemToCart
            // 
            this.addItemToCart.Location = new System.Drawing.Point(196, 88);
            this.addItemToCart.Name = "addItemToCart";
            this.addItemToCart.Size = new System.Drawing.Size(75, 23);
            this.addItemToCart.TabIndex = 4;
            this.addItemToCart.Text = "Add";
            this.addItemToCart.UseVisualStyleBackColor = true;
            this.addItemToCart.Click += new System.EventHandler(this.addItemToCart_Click);
            // 
            // shoppingCart
            // 
            this.shoppingCart.FormattingEnabled = true;
            this.shoppingCart.Location = new System.Drawing.Point(277, 53);
            this.shoppingCart.Name = "shoppingCart";
            this.shoppingCart.Size = new System.Drawing.Size(177, 212);
            this.shoppingCart.TabIndex = 3;
            // 
            // checkoutButton
            // 
            this.checkoutButton.Enabled = false;
            this.checkoutButton.Location = new System.Drawing.Point(320, 93);
            this.checkoutButton.Name = "checkoutButton";
            this.checkoutButton.Size = new System.Drawing.Size(146, 61);
            this.checkoutButton.TabIndex = 4;
            this.checkoutButton.Text = "Checkout";
            this.checkoutButton.UseVisualStyleBackColor = true;
            this.checkoutButton.Click += new System.EventHandler(this.checkoutButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(491, 64);
            this.panel1.TabIndex = 5;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(320, 171);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(146, 26);
            this.cancelBtn.TabIndex = 6;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
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
            // StartNewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelBtn;
            this.ClientSize = new System.Drawing.Size(487, 501);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkoutButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "StartNewTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Transaction";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox shoppingMenu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearCart;
        private System.Windows.Forms.Button removeItemFromCart;
        private System.Windows.Forms.Button addItemToCart;
        private System.Windows.Forms.ListBox shoppingCart;
        private System.Windows.Forms.Button checkoutButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label label4;
    }
}