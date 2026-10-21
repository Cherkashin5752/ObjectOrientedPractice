namespace ObjectOrientedPractics.View.Panels
{
    partial class ItemsTab
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
            ItemsGroupBox = new GroupBox();
            AddRandomButton = new Button();
            RemoveButton = new Button();
            AddDefaultButton = new Button();
            ItemsListBox = new ListBox();
            SelectedItemGroupBox = new GroupBox();
            CategoryLabel = new Label();
            CategoryComboBox = new ComboBox();
            DescriptionLabel = new Label();
            NameLabel = new Label();
            label2 = new Label();
            IdLabel = new Label();
            DescriptionTextBox = new TextBox();
            NameTextBox = new TextBox();
            CostTextBox = new TextBox();
            IDTextBox = new TextBox();
            ItemsGroupBox.SuspendLayout();
            SelectedItemGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // ItemsGroupBox
            // 
            ItemsGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsGroupBox.Controls.Add(AddRandomButton);
            ItemsGroupBox.Controls.Add(RemoveButton);
            ItemsGroupBox.Controls.Add(AddDefaultButton);
            ItemsGroupBox.Controls.Add(ItemsListBox);
            ItemsGroupBox.Location = new Point(3, 3);
            ItemsGroupBox.Name = "ItemsGroupBox";
            ItemsGroupBox.Size = new Size(251, 504);
            ItemsGroupBox.TabIndex = 0;
            ItemsGroupBox.TabStop = false;
            ItemsGroupBox.Text = "Items";
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
            RemoveButton.TabIndex = 1;
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
            AddDefaultButton.TabIndex = 1;
            AddDefaultButton.Text = "Add (Default)";
            AddDefaultButton.UseVisualStyleBackColor = true;
            AddDefaultButton.Click += AddDefaultButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.Location = new Point(6, 22);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(237, 424);
            ItemsListBox.TabIndex = 0;
            ItemsListBox.SelectedIndexChanged += ItemsListBox_SelectedIndexChanged;
            // 
            // SelectedItemGroupBox
            // 
            SelectedItemGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            SelectedItemGroupBox.Controls.Add(CategoryLabel);
            SelectedItemGroupBox.Controls.Add(CategoryComboBox);
            SelectedItemGroupBox.Controls.Add(DescriptionLabel);
            SelectedItemGroupBox.Controls.Add(NameLabel);
            SelectedItemGroupBox.Controls.Add(label2);
            SelectedItemGroupBox.Controls.Add(IdLabel);
            SelectedItemGroupBox.Controls.Add(DescriptionTextBox);
            SelectedItemGroupBox.Controls.Add(NameTextBox);
            SelectedItemGroupBox.Controls.Add(CostTextBox);
            SelectedItemGroupBox.Controls.Add(IDTextBox);
            SelectedItemGroupBox.Location = new Point(260, 3);
            SelectedItemGroupBox.Name = "SelectedItemGroupBox";
            SelectedItemGroupBox.Size = new Size(403, 504);
            SelectedItemGroupBox.TabIndex = 1;
            SelectedItemGroupBox.TabStop = false;
            SelectedItemGroupBox.Text = "Selected Item";
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(6, 90);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(58, 15);
            CategoryLabel.TabIndex = 9;
            CategoryLabel.Text = "Category:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(76, 87);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(126, 23);
            CategoryComboBox.TabIndex = 8;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(6, 265);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(70, 15);
            DescriptionLabel.TabIndex = 7;
            DescriptionLabel.Text = "Description:";
            // 
            // NameLabel
            // 
            NameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(6, 124);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(42, 15);
            NameLabel.TabIndex = 6;
            NameLabel.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 61);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 5;
            label2.Text = "Cost:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(6, 32);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 4;
            IdLabel.Text = "ID:";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.Location = new Point(6, 283);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(391, 146);
            DescriptionTextBox.TabIndex = 3;
            DescriptionTextBox.TextChanged += DescriptionTextBox_TextChanged;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(6, 142);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(391, 100);
            NameTextBox.TabIndex = 2;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            NameTextBox.Leave += NameTextBox_Leave;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(76, 58);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(126, 23);
            CostTextBox.TabIndex = 1;
            CostTextBox.TextChanged += CostTextBox_TextChanged;
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(76, 29);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.ReadOnly = true;
            IDTextBox.Size = new Size(126, 23);
            IDTextBox.TabIndex = 0;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SelectedItemGroupBox);
            Controls.Add(ItemsGroupBox);
            Name = "ItemsTab";
            Size = new Size(666, 510);
            ItemsGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.ResumeLayout(false);
            SelectedItemGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox ItemsGroupBox;
        private Button AddRandomButton;
        private Button RemoveButton;
        private Button AddDefaultButton;
        private ListBox ItemsListBox;
        private GroupBox SelectedItemGroupBox;
        private Label DescriptionLabel;
        private Label NameLabel;
        private Label label2;
        private Label IdLabel;
        private TextBox DescriptionTextBox;
        private TextBox NameTextBox;
        private TextBox CostTextBox;
        private TextBox IDTextBox;
        private Label CategoryLabel;
        private ComboBox CategoryComboBox;
    }
}
