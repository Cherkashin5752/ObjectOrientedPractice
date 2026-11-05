namespace ObjectOrientedPractics.View.Panels
{
    partial class OrdersTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SelectedOrderControl = new ObjectOrientedPractics.View.Controls.SelectedOrderControl();
            OrderControl = new ObjectOrientedPractics.View.Controls.OrderControl();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // SelectedOrderControl
            // 
            SelectedOrderControl.Dock = DockStyle.Fill;
            SelectedOrderControl.Location = new Point(409, 3);
            SelectedOrderControl.Name = "SelectedOrderControl";
            SelectedOrderControl.Size = new Size(401, 504);
            SelectedOrderControl.TabIndex = 1;
            SelectedOrderControl.StatusComboBox.SelectedIndexChanged += StatusOrder_SelectedIndexChanged;
            SelectedOrderControl.DeliveryTimeComboBox.SelectedIndexChanged += DeliveryTimeComboBox_SelectedIndexChanged;
            // 
            // OrderControl
            // 
            OrderControl.Dock = DockStyle.Fill;
            OrderControl.Location = new Point(3, 3);
            OrderControl.Name = "OrderControl";
            OrderControl.Size = new Size(400, 504);
            OrderControl.TabIndex = 0;
            OrderControl.OrdersDataGridView.SelectionChanged += DataGridView_SelectionChanged;
            OrderControl.OnlyPriorityOrders.CheckedChanged += OnlyPriorityOrders_CheckedChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(OrderControl, 0, 0);
            tableLayoutPanel1.Controls.Add(SelectedOrderControl, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(813, 510);
            tableLayoutPanel1.TabIndex = 14;
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "OrdersTab";
            Size = new Size(813, 510);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Controls.SelectedOrderControl SelectedOrderControl;
        private Controls.OrderControl OrderControl;
        private TableLayoutPanel tableLayoutPanel1;
    }
}