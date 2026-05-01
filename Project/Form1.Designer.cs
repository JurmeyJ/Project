namespace Project
{
    partial class Form1
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
            this.Left = new System.Windows.Forms.Panel();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.btnOrders = new System.Windows.Forms.Button();
            this.Left.SuspendLayout();
            this.SuspendLayout();
            // 
            // Left
            // 
            this.Left.Controls.Add(this.btnOrders);
            this.Left.Controls.Add(this.btnEditProduct);
            this.Left.Controls.Add(this.btnInventory);
            this.Left.Controls.Add(this.btnHome);
            this.Left.Location = new System.Drawing.Point(-1, -1);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(155, 546);
            this.Left.TabIndex = 0;
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(37, 191);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(75, 23);
            this.btnEditProduct.TabIndex = 2;
            this.btnEditProduct.Text = "Edit Product";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(37, 138);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(75, 23);
            this.btnInventory.TabIndex = 1;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(37, 84);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(75, 23);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Location = new System.Drawing.Point(150, -1);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(814, 546);
            this.pnlContent.TabIndex = 1;
            // 
            // btnOrders
            // 
            this.btnOrders.Location = new System.Drawing.Point(37, 244);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(74, 19);
            this.btnOrders.TabIndex = 3;
            this.btnOrders.Text = "Orders";
            this.btnOrders.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 543);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.Left);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Left;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlContent;
        private System.Windows.Forms.Button btnOrders;
    }
}

