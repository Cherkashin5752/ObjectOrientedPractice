using ObjectOrientedPractics.View.Controls;

namespace ObjectOrientedPractics.View.Panels
{
    partial class CustomersTab
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
            CustomersGroupBox = new GroupBox();
            AddRandomButton = new Button();
            RemoveButton = new Button();
            AddDefaultButton = new Button();
            CustomersListBox = new ListBox();
            SelectedCustomerGroupBox = new GroupBox();
            IsPriorityCheckBox = new CheckBox();
            AddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            FullNameLabel = new Label();
            IDLabel = new Label();
            FullnameTextBox = new TextBox();
            IDTextBox = new TextBox();
            CustomersGroupBox.SuspendLayout();
            SelectedCustomerGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // CustomersGroupBox
            // 
            CustomersGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersGroupBox.Controls.Add(AddRandomButton);
            CustomersGroupBox.Controls.Add(RemoveButton);
            CustomersGroupBox.Controls.Add(AddDefaultButton);
            CustomersGroupBox.Controls.Add(CustomersListBox);
            CustomersGroupBox.Location = new Point(3, 3);
            CustomersGroupBox.Name = "CustomersGroupBox";
            CustomersGroupBox.Size = new Size(251, 504);
            CustomersGroupBox.TabIndex = 0;
            CustomersGroupBox.TabStop = false;
            CustomersGroupBox.Text = "Customers";
            // 
            // AddRandomButton
            // 
            AddRandomButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddRandomButton.Location = new Point(168, 452);
            AddRandomButton.Name = "AddRandomButton";
            AddRandomButton.Size = new Size(75, 46);
            AddRandomButton.TabIndex = 2;
            AddRandomButton.Text = "Add (Random)";
            AddRandomButton.UseVisualStyleBackColor = true;
            AddRandomButton.Click += AddRandomButton_Click;
            // 
            // RemoveButton
            // 
            RemoveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveButton.Location = new Point(87, 452);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(75, 46);
            RemoveButton.TabIndex = 2;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            RemoveButton.Click += RemoveButton_Click;
            // 
            // AddDefaultButton
            // 
            AddDefaultButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddDefaultButton.Location = new Point(6, 452);
            AddDefaultButton.Name = "AddDefaultButton";
            AddDefaultButton.Size = new Size(75, 46);
            AddDefaultButton.TabIndex = 2;
            AddDefaultButton.Text = "Add (Default)";
            AddDefaultButton.UseVisualStyleBackColor = true;
            AddDefaultButton.Click += AddDefaultButton_Click;
            // 
            // CustomersListBox
            // 
            CustomersListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            CustomersListBox.FormattingEnabled = true;
            CustomersListBox.Location = new Point(6, 22);
            CustomersListBox.Name = "CustomersListBox";
            CustomersListBox.Size = new Size(237, 424);
            CustomersListBox.TabIndex = 2;
            CustomersListBox.SelectedIndexChanged += CustomersListBox_SelectedIndexChanged;
            // 
            // SelectedCustomerGroupBox
            // 
            SelectedCustomerGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SelectedCustomerGroupBox.Controls.Add(IsPriorityCheckBox);
            SelectedCustomerGroupBox.Controls.Add(AddressControl);
            SelectedCustomerGroupBox.Controls.Add(FullNameLabel);
            SelectedCustomerGroupBox.Controls.Add(IDLabel);
            SelectedCustomerGroupBox.Controls.Add(FullnameTextBox);
            SelectedCustomerGroupBox.Controls.Add(IDTextBox);
            SelectedCustomerGroupBox.Location = new Point(260, 3);
            SelectedCustomerGroupBox.Name = "SelectedCustomerGroupBox";
            SelectedCustomerGroupBox.Size = new Size(403, 259);
            SelectedCustomerGroupBox.TabIndex = 1;
            SelectedCustomerGroupBox.TabStop = false;
            SelectedCustomerGroupBox.Text = "Selected Customer";
            // 
            // IsPriorityCheckBox
            // 
            IsPriorityCheckBox.AutoSize = true;
            IsPriorityCheckBox.Location = new Point(76, 87);
            IsPriorityCheckBox.Name = "IsPriorityCheckBox";
            IsPriorityCheckBox.Size = new Size(75, 19);
            IsPriorityCheckBox.TabIndex = 6;
            IsPriorityCheckBox.Text = "Is Priority";
            IsPriorityCheckBox.UseVisualStyleBackColor = true;
            IsPriorityCheckBox.CheckedChanged += IsPriorityCheckBox_CheckedChanged;
            // 
            // AddressControl
            // 
            AddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressControl.Location = new Point(6, 112);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(391, 145);
            AddressControl.TabIndex = 5;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Location = new Point(6, 61);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(64, 15);
            FullNameLabel.TabIndex = 4;
            FullNameLabel.Text = "Full Name:";
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Location = new Point(6, 32);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(21, 15);
            IDLabel.TabIndex = 3;
            IDLabel.Text = "ID:";
            // 
            // FullnameTextBox
            // 
            FullnameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            FullnameTextBox.Location = new Point(76, 58);
            FullnameTextBox.Name = "FullnameTextBox";
            FullnameTextBox.Size = new Size(321, 23);
            FullnameTextBox.TabIndex = 1;
            FullnameTextBox.TextChanged += FullnameTextBox_TextChanged;
            FullnameTextBox.Leave += FullnameTextBox_Leave;
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(76, 29);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(126, 23);
            IDTextBox.TabIndex = 0;
            // 
            // CustomersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedCustomerGroupBox);
            Controls.Add(CustomersGroupBox);
            Name = "CustomersTab";
            Size = new Size(666, 510);
            CustomersGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.ResumeLayout(false);
            SelectedCustomerGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox CustomersGroupBox;
        private GroupBox SelectedCustomerGroupBox;
        private ListBox CustomersListBox;
        private Button AddRandomButton;
        private Button RemoveButton;
        private Button AddDefaultButton;
        private TextBox IDTextBox;
        private Label FullNameLabel;
        private Label IDLabel;
        private TextBox FullnameTextBox;
        private AddressControl AddressControl;
        private CheckBox IsPriorityCheckBox;
    }
}