namespace ObjectOrientedPractics.View.Controls
{
    partial class ItemControl
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
            CategoryCombobox = new ComboBox();
            CategoryLabel = new Label();
            CostTextbox = new TextBox();
            CostLabel = new Label();
            DescriptionTextbox = new TextBox();
            DescriptionLabel = new Label();
            NameTextbox = new TextBox();
            FullnameLabel = new Label();
            SuspendLayout();
            // 
            // CategoryCombobox
            // 
            CategoryCombobox.FormattingEnabled = true;
            CategoryCombobox.Location = new Point(80, 137);
            CategoryCombobox.Name = "CategoryCombobox";
            CategoryCombobox.Size = new Size(121, 23);
            CategoryCombobox.TabIndex = 25;
            CategoryCombobox.SelectedIndexChanged += CategoryCombobox_SelectedIndexChanged;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(4, 140);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(58, 15);
            CategoryLabel.TabIndex = 24;
            CategoryLabel.Text = "Category:";
            // 
            // CostTextbox
            // 
            CostTextbox.Location = new Point(80, 108);
            CostTextbox.Name = "CostTextbox";
            CostTextbox.Size = new Size(121, 23);
            CostTextbox.TabIndex = 23;
            CostTextbox.TextChanged += CostTextbox_TextChanged;
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Location = new Point(4, 111);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(34, 15);
            CostLabel.TabIndex = 22;
            CostLabel.Text = "Cost:";
            // 
            // DescriptionTextbox
            // 
            DescriptionTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextbox.Location = new Point(80, 35);
            DescriptionTextbox.Multiline = true;
            DescriptionTextbox.Name = "DescriptionTextbox";
            DescriptionTextbox.Size = new Size(309, 67);
            DescriptionTextbox.TabIndex = 21;
            DescriptionTextbox.TextChanged += DescriptionTextbox_TextChanged;
            // 
            // DescriptionLabel
            // 
            DescriptionLabel.AutoSize = true;
            DescriptionLabel.Location = new Point(4, 35);
            DescriptionLabel.Name = "DescriptionLabel";
            DescriptionLabel.Size = new Size(70, 15);
            DescriptionLabel.TabIndex = 20;
            DescriptionLabel.Text = "Description:";
            // 
            // NameTextbox
            // 
            NameTextbox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            NameTextbox.Location = new Point(80, 6);
            NameTextbox.Name = "NameTextbox";
            NameTextbox.Size = new Size(309, 23);
            NameTextbox.TabIndex = 19;
            NameTextbox.TextChanged += NameTextbox_TextChanged;
            // 
            // FullnameLabel
            // 
            FullnameLabel.AutoSize = true;
            FullnameLabel.Location = new Point(4, 9);
            FullnameLabel.Name = "FullnameLabel";
            FullnameLabel.Size = new Size(42, 15);
            FullnameLabel.TabIndex = 18;
            FullnameLabel.Text = "Name:";
            // 
            // ItemControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CategoryCombobox);
            Controls.Add(CategoryLabel);
            Controls.Add(CostTextbox);
            Controls.Add(CostLabel);
            Controls.Add(DescriptionTextbox);
            Controls.Add(DescriptionLabel);
            Controls.Add(NameTextbox);
            Controls.Add(FullnameLabel);
            Name = "ItemControl";
            Size = new Size(395, 166);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox CategoryCombobox;
        private Label CategoryLabel;
        private TextBox CostTextbox;
        private Label CostLabel;
        private TextBox DescriptionTextbox;
        private Label DescriptionLabel;
        private TextBox NameTextbox;
        private Label FullnameLabel;
    }
}
