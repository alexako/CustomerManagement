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
            this.menu = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.shoppingCart = new System.Windows.Forms.ListBox();
            this.addItemToCart = new System.Windows.Forms.Button();
            this.removeItemFromCart = new System.Windows.Forms.Button();
            this.clearCart = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Add new customer..."});
            this.comboBox1.Location = new System.Drawing.Point(23, 43);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Customer";
            // 
            // menu
            // 
            this.menu.FormattingEnabled = true;
            this.menu.Location = new System.Drawing.Point(6, 53);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(184, 212);
            this.menu.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.clearCart);
            this.groupBox1.Controls.Add(this.removeItemFromCart);
            this.groupBox1.Controls.Add(this.addItemToCart);
            this.groupBox1.Controls.Add(this.shoppingCart);
            this.groupBox1.Controls.Add(this.menu);
            this.groupBox1.Location = new System.Drawing.Point(13, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(463, 271);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Shopping Cart";
            // 
            // shoppingCart
            // 
            this.shoppingCart.FormattingEnabled = true;
            this.shoppingCart.Location = new System.Drawing.Point(277, 53);
            this.shoppingCart.Name = "shoppingCart";
            this.shoppingCart.Size = new System.Drawing.Size(177, 212);
            this.shoppingCart.TabIndex = 3;
            // 
            // addItemToCart
            // 
            this.addItemToCart.Location = new System.Drawing.Point(196, 88);
            this.addItemToCart.Name = "addItemToCart";
            this.addItemToCart.Size = new System.Drawing.Size(75, 23);
            this.addItemToCart.TabIndex = 4;
            this.addItemToCart.Text = "Add";
            this.addItemToCart.UseVisualStyleBackColor = true;
            // 
            // removeItemFromCart
            // 
            this.removeItemFromCart.Location = new System.Drawing.Point(196, 117);
            this.removeItemFromCart.Name = "removeItemFromCart";
            this.removeItemFromCart.Size = new System.Drawing.Size(75, 23);
            this.removeItemFromCart.TabIndex = 5;
            this.removeItemFromCart.Text = "Remove";
            this.removeItemFromCart.UseVisualStyleBackColor = true;
            // 
            // clearCart
            // 
            this.clearCart.Location = new System.Drawing.Point(196, 208);
            this.clearCart.Name = "clearCart";
            this.clearCart.Size = new System.Drawing.Size(75, 23);
            this.clearCart.TabIndex = 6;
            this.clearCart.Text = "Clear";
            this.clearCart.UseVisualStyleBackColor = true;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(277, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Currently in cart";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 61);
            this.button1.TabIndex = 4;
            this.button1.Text = "Checkout";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // StartNewTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 418);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.MaximizeBox = false;
            this.Name = "StartNewTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Transaction";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox menu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button clearCart;
        private System.Windows.Forms.Button removeItemFromCart;
        private System.Windows.Forms.Button addItemToCart;
        private System.Windows.Forms.ListBox shoppingCart;
        private System.Windows.Forms.Button button1;
    }
}