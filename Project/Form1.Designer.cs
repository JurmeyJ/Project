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
            this.button3 = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.Left.SuspendLayout();
            this.SuspendLayout();
            // 
            // Left
            // 
            this.Left.Controls.Add(this.button3);
            this.Left.Controls.Add(this.btnInventory);
            this.Left.Controls.Add(this.button1);
            this.Left.Location = new System.Drawing.Point(-1, -1);
            this.Left.Name = "Left";
            this.Left.Size = new System.Drawing.Size(155, 452);
            this.Left.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(37, 187);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Product";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
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
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(37, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Home";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Location = new System.Drawing.Point(150, -1);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(653, 451);
            this.pnlContent.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.Left);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Left.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Left;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlContent;
    }
}

