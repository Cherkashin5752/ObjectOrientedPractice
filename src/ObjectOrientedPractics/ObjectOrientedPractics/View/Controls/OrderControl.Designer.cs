namespace ObjectOrientedPractics.View.Controls
{
    partial class OrderControl
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
            OrdersDataGridView = new DataGridView();
            OrdersLabel = new Label();
            OnlyPriorityOrders = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToDeleteRows = false;
            OrdersDataGridView.AllowUserToResizeRows = false;
            OrdersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Location = new Point(0, 18);
            OrdersDataGridView.MultiSelect = false;
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.ReadOnly = true;
            OrdersDataGridView.RowHeadersVisible = false;
            OrdersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrdersDataGridView.Size = new Size(398, 462);
            OrdersDataGridView.TabIndex = 0;
            // 
            // OrdersLabel
            // 
            OrdersLabel.AutoSize = true;
            OrdersLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrdersLabel.Location = new Point(-1, 0);
            OrdersLabel.Name = "OrdersLabel";
            OrdersLabel.Size = new Size(45, 15);
            OrdersLabel.TabIndex = 1;
            OrdersLabel.Text = "Orders";
            // 
            // OnlyPriorityOrders
            // 
            OnlyPriorityOrders.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            OnlyPriorityOrders.AutoSize = true;
            OnlyPriorityOrders.Location = new Point(3, 486);
            OnlyPriorityOrders.Name = "OnlyPriorityOrders";
            OnlyPriorityOrders.Size = new Size(162, 19);
            OnlyPriorityOrders.TabIndex = 2;
            OnlyPriorityOrders.Text = "Show Only Priority Orders";
            OnlyPriorityOrders.UseVisualStyleBackColor = true;
            // 
            // OrderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(OnlyPriorityOrders);
            Controls.Add(OrdersLabel);
            Controls.Add(OrdersDataGridView);
            Name = "OrderControl";
            Size = new Size(401, 508);
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public DataGridView OrdersDataGridView;
        private Label OrdersLabel;
        public CheckBox OnlyPriorityOrders;
    }
}