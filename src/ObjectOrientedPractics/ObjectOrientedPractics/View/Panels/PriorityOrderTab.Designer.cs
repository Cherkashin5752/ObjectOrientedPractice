using System.Xml.Linq;

namespace ObjectOrientedPractics.View.Panels
{
    partial class PriorityOrdersTab
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
            tableLayoutPanel1 = new TableLayoutPanel();
            priorityOrderControl1 = new ObjectOrientedPractics.View.Controls.PriorityOrderControl();
            selectedPriorityOrdersControl1 = new SelectedPriorityOrdersControl();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.4464951F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.5535049F));
            tableLayoutPanel1.Controls.Add(priorityOrderControl1, 0, 0);
            tableLayoutPanel1.Controls.Add(selectedPriorityOrdersControl1, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(813, 510);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // priorityOrderControl1
            // 
            priorityOrderControl1.Dock = DockStyle.Fill;
            priorityOrderControl1.Location = new Point(3, 3);
            priorityOrderControl1.Name = "priorityOrderControl1";
            priorityOrderControl1.Size = new Size(396, 504);
            priorityOrderControl1.TabIndex = 1;
            priorityOrderControl1.dataGridView2.SelectionChanged += DataGridView_SelectionChanged;
            // 
            // selectedPriorityOrdersControl1
            // 
            selectedPriorityOrdersControl1.Dock = DockStyle.Fill;
            selectedPriorityOrdersControl1.Location = new Point(405, 3);
            selectedPriorityOrdersControl1.Name = "selectedPriorityOrdersControl1";
            selectedPriorityOrdersControl1.Size = new Size(405, 504);
            selectedPriorityOrdersControl1.TabIndex = 2;
            selectedPriorityOrdersControl1.StatusComboBox.SelectedIndexChanged += StatusPriority_SelectedIndexChanged;
            selectedPriorityOrdersControl1.ChangeModeButton.Click += ChangeModeButton_Click;
            selectedPriorityOrdersControl1.AddItemButton.Click += AddItemButton_Click;
            selectedPriorityOrdersControl1.RemoveItemButton.Click += RemoveItemButton_Click;
            selectedPriorityOrdersControl1.CreatePriorityOrderButton.Click += CreatePriorityOrderButton_Click;
            selectedPriorityOrdersControl1.RemovePriorityOrderButton.Click += RemovePriorityOrder_Click;
            selectedPriorityOrdersControl1.ClearPriorityOrderButton.Click += ClearPriorityOrderButton_Click;
            // 
            // PriorityOrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "PriorityOrdersTab";
            Size = new Size(813, 510);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Controls.PriorityOrderControl priorityOrderControl1;
        private SelectedPriorityOrdersControl selectedPriorityOrdersControl1;
    }
}