namespace Tech_ShopManagemant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.OrderListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.orderscount = new System.Windows.Forms.Label();
            this.viewbutton = new System.Windows.Forms.Button();
            this.SortingMode = new System.Windows.Forms.ComboBox();
            this.modelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // OrderListBox
            // 
            this.OrderListBox.BackColor = System.Drawing.Color.White;
            this.OrderListBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderListBox.FormattingEnabled = true;
            this.OrderListBox.ItemHeight = 32;
            this.OrderListBox.Items.AddRange(new object[] {
            "1",
            "4",
            "56",
            "3",
            "5"});
            this.OrderListBox.Location = new System.Drawing.Point(230, 73);
            this.OrderListBox.Name = "OrderListBox";
            this.OrderListBox.Size = new System.Drawing.Size(586, 164);
            this.OrderListBox.TabIndex = 0;
            this.OrderListBox.SelectedIndexChanged += new System.EventHandler(this.OrderListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(345, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "Unchecked Orders";
            // 
            // orderscount
            // 
            this.orderscount.AutoSize = true;
            this.orderscount.BackColor = System.Drawing.Color.Transparent;
            this.orderscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.orderscount.Location = new System.Drawing.Point(752, 54);
            this.orderscount.Name = "orderscount";
            this.orderscount.Size = new System.Drawing.Size(64, 16);
            this.orderscount.TabIndex = 2;
            this.orderscount.Text = "17 orders";
            // 
            // viewbutton
            // 
            this.viewbutton.BackColor = System.Drawing.Color.Transparent;
            this.viewbutton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewbutton.Location = new System.Drawing.Point(415, 261);
            this.viewbutton.Name = "viewbutton";
            this.viewbutton.Size = new System.Drawing.Size(205, 79);
            this.viewbutton.TabIndex = 3;
            this.viewbutton.Text = " View ";
            this.viewbutton.UseVisualStyleBackColor = false;
            this.viewbutton.Click += new System.EventHandler(this.viewbutton_Click);
            // 
            // SortingMode
            // 
            this.SortingMode.AllowDrop = true;
            this.SortingMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SortingMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortingMode.FormattingEnabled = true;
            this.SortingMode.Items.AddRange(new object[] {
            "DATE",
            "NAME",
            "ORDERED ITEMS"});
            this.SortingMode.Location = new System.Drawing.Point(695, 236);
            this.SortingMode.Name = "SortingMode";
            this.SortingMode.Size = new System.Drawing.Size(121, 24);
            this.SortingMode.TabIndex = 4;
            this.SortingMode.SelectedIndexChanged += new System.EventHandler(this.SortingMode_SelectedIndexChanged);
            // 
            // modelabel
            // 
            this.modelabel.AutoSize = true;
            this.modelabel.BackColor = System.Drawing.Color.Transparent;
            this.modelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.modelabel.Location = new System.Drawing.Point(638, 240);
            this.modelabel.Name = "modelabel";
            this.modelabel.Size = new System.Drawing.Size(55, 13);
            this.modelabel.TabIndex = 5;
            this.modelabel.Text = "Order by";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Tech_ShopManagemant.Properties.Resources.Tech_ShopManagemantBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1044, 501);
            this.Controls.Add(this.modelabel);
            this.Controls.Add(this.SortingMode);
            this.Controls.Add(this.viewbutton);
            this.Controls.Add(this.orderscount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OrderListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TechShopManagemant";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox OrderListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label orderscount;
        private System.Windows.Forms.Button viewbutton;
        private System.Windows.Forms.ComboBox SortingMode;
        private System.Windows.Forms.Label modelabel;
    }
}

