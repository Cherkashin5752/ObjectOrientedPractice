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
            tabControl1.SuspendLayout();
            ItemsTab.SuspendLayout();
            CustomersTab.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(ItemsTab);
            tabControl1.Controls.Add(CustomersTab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(763, 532);
            tabControl1.TabIndex = 0;
            // 
            // ItemsTab
            // 
            ItemsTab.Controls.Add(itemsTab1);
            ItemsTab.Location = new Point(4, 24);
            ItemsTab.Name = "ItemsTab";
            ItemsTab.Padding = new Padding(3);
            ItemsTab.Size = new Size(755, 504);
            ItemsTab.TabIndex = 0;
            ItemsTab.Text = "tabPage1";
            ItemsTab.UseVisualStyleBackColor = true;
            // 
            // itemsTab1
            // 
            itemsTab1.Dock = DockStyle.Fill;
            itemsTab1.Location = new Point(3, 3);
            itemsTab1.Name = "itemsTab1";
            itemsTab1.Size = new Size(749, 498);
            itemsTab1.TabIndex = 0;
            // 
            // CustomersTab
            // 
            CustomersTab.Controls.Add(customersTab1);
            CustomersTab.Location = new Point(4, 24);
            CustomersTab.Name = "CustomersTab";
            CustomersTab.Padding = new Padding(3);
            CustomersTab.Size = new Size(755, 504);
            CustomersTab.TabIndex = 1;
            CustomersTab.Text = "tabPage2";
            CustomersTab.UseVisualStyleBackColor = true;
            // 
            // customersTab1
            // 
            customersTab1.Dock = DockStyle.Fill;
            customersTab1.Location = new Point(3, 3);
            customersTab1.Name = "customersTab1";
            customersTab1.Size = new Size(749, 498);
            customersTab1.TabIndex = 0;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 532);
            Controls.Add(tabControl1);
            MinimumSize = new Size(779, 515);
            Name = "MainForm";
            Text = "Object Oriented Practice";
            FormClosing += Main_FormClosing;
            tabControl1.ResumeLayout(false);
            ItemsTab.ResumeLayout(false);
            CustomersTab.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private View.Panels.ItemsTab itemsTab1;
        private TabControl tabControl1;
        private TabPage ItemsTab;
        private TabPage CustomersTab;
        private View.Panels.CustomersTab customersTab1;
    }
}
