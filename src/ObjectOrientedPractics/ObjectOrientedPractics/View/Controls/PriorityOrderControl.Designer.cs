namespace ObjectOrientedPractics.View.Controls
{
    partial class PriorityOrderControl
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
            PriorityOrdersLabel = new Label();
            PriorityOrdersDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PriorityOrdersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // PriorityOrdersLabel
            // 
            PriorityOrdersLabel.AutoSize = true;
            PriorityOrdersLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PriorityOrdersLabel.Location = new Point(3, 0);
            PriorityOrdersLabel.Name = "PriorityOrdersLabel";
            PriorityOrdersLabel.Size = new Size(86, 15);
            PriorityOrdersLabel.TabIndex = 0;
            PriorityOrdersLabel.Text = "PriorityOrders";
            // 
            // PriorityOrdersDataGridView
            // 
            PriorityOrdersDataGridView.AllowUserToAddRows = false;
            PriorityOrdersDataGridView.AllowUserToDeleteRows = false;
            PriorityOrdersDataGridView.AllowUserToResizeRows = false;
            PriorityOrdersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            PriorityOrdersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            PriorityOrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PriorityOrdersDataGridView.Location = new Point(0, 18);
            PriorityOrdersDataGridView.MultiSelect = false;
            PriorityOrdersDataGridView.Name = "PriorityOrdersDataGridView";
            PriorityOrdersDataGridView.ReadOnly = true;
            PriorityOrdersDataGridView.RowHeadersVisible = false;
            PriorityOrdersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PriorityOrdersDataGridView.Size = new Size(398, 487);
            PriorityOrdersDataGridView.TabIndex = 0;
            // 
            // PriorityOrderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(PriorityOrdersDataGridView);
            Controls.Add(PriorityOrdersLabel);
            Name = "PriorityOrderControl";
            Size = new Size(401, 508);
            ((System.ComponentModel.ISupportInitialize)PriorityOrdersDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PriorityOrdersLabel;
        public DataGridView PriorityOrdersDataGridView;
    }
}