namespace ObjectOrientedPractics
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            ItemsTab = new TabPage();
            itemsTab1 = new ObjectOrientedPractics.View.Panels.ItemsTab();
            CustomersTab = new TabPage();
            customersTab1 = new ObjectOrientedPractics.View.Panels.CustomersTab();
            CartsTab = new TabPage();
            cartsTab1 = new ObjectOrientedPractics.View.Panels.CartsTab();
            tabControl1.SuspendLayout();
            ItemsTab.SuspendLayout();
            CustomersTab.SuspendLayout();
            CartsTab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ItemsTab);
            tabControl1.Controls.Add(CustomersTab);
            tabControl1.Controls.Add(CartsTab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(763, 476);
            tabControl1.TabIndex = 0;
            // 
            // ItemsTab
            // 
            ItemsTab.Controls.Add(itemsTab1);
            ItemsTab.Location = new Point(4, 24);
            ItemsTab.Name = "ItemsTab";
            ItemsTab.Padding = new Padding(3);
            ItemsTab.Size = new Size(755, 448);
            ItemsTab.TabIndex = 0;
            ItemsTab.Text = "Items";
            ItemsTab.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(749, 442);
            itemsTab1.TabIndex = 0;
            // 
            // CustomersTab
            // 
            CustomersTab.Controls.Add(customersTab1);
            CustomersTab.Location = new Point(4, 24);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Padding = new Padding(3);
            CustomersTab.Size = new Size(755, 448);
            CustomersTab.TabIndex = 1;
            CustomersTab.Text = "Cusotmers";
            // 
            // customersTab1
            // 
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(3, 3);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(749, 442);
            customersTab1.TabIndex = 0;
            // 
            // CartsTab
            // 
            CartsTab.Controls.Add(cartsTab1);
            CartsTab.Location = new Point(4, 24);
            CartsTab.Name = "CartsTab";
            CartsTab.Size = new Size(755, 448);
            CartsTab.TabIndex = 2;
            CartsTab.Text = "Carts";
            CartsTab.UseVisualStyleBackColor = true;
            // 
            // cartsTab1
            // 
            cartsTab1.Dock = DockStyle.Fill;
            cartsTab1.Location = new Point(0, 0);
            cartsTab1.Name = "cartsTab1";
            cartsTab1.Size = new Size(755, 448);
            cartsTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 476);
            Controls.Add(tabControl1);
            MinimumSize = new Size(779, 515);
            Name = "MainForm";
            Text = "Object Oriented Practice";
            FormClosing += Main_FormClosing;
            tabControl1.ResumeLayout(false);
            ItemsTab.ResumeLayout(false);
            CustomersTab.ResumeLayout(false);
            CartsTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage ItemsTab;
        private View.Panels.ItemsTab itemsTab1;
        private TabPage CustomersTab;
        private View.Panels.CustomersTab customersTab1;
        private TabPage CartsTab;
        private View.Panels.CartsTab cartsTab1;
    }
}
