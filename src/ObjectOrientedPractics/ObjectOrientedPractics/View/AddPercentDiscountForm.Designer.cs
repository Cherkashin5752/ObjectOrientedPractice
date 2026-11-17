namespace ObjectOrientedPractics.View.Panels
{
    partial class AddPercentDiscountForm
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
            PercentDiscountLabel = new Label();
            CategoryComboBox = new ComboBox();
            CategoryLabel = new Label();
            OKButton = new Button();
            Cancel = new Button();
            SuspendLayout();
            // 
            // PercentDiscountLabel
            // 
            PercentDiscountLabel.AutoSize = true;
            PercentDiscountLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PercentDiscountLabel.Location = new Point(12, 9);
            PercentDiscountLabel.Name = "PercentDiscountLabel";
            PercentDiscountLabel.Size = new Size(106, 15);
            PercentDiscountLabel.TabIndex = 0;
            PercentDiscountLabel.Text = "Percent Discount:";
            // 
            // CategoryComboBox
            // 
            CategoryComboBox.FormattingEnabled = true;
            CategoryComboBox.Location = new Point(76, 33);
            CategoryComboBox.Name = "CategoryComboBox";
            CategoryComboBox.Size = new Size(234, 23);
            CategoryComboBox.TabIndex = 1;
            CategoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            // 
            // CategoryLabel
            // 
            CategoryLabel.AutoSize = true;
            CategoryLabel.Location = new Point(12, 36);
            CategoryLabel.Name = "CategoryLabel";
            CategoryLabel.Size = new Size(58, 15);
            CategoryLabel.TabIndex = 2;
            CategoryLabel.Text = "Category:";
            // 
            // OKButton
            // 
            OKButton.DialogResult = DialogResult.OK;
            OKButton.Location = new Point(151, 82);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(75, 39);
            OKButton.TabIndex = 3;
            OKButton.Text = "OK";
            OKButton.UseVisualStyleBackColor = true;
            // 
            // Cancel
            // 
            Cancel.DialogResult = DialogResult.Cancel;
            Cancel.Location = new Point(235, 82);
            Cancel.Name = "Cancel";
            Cancel.Size = new Size(75, 39);
            Cancel.TabIndex = 4;
            Cancel.Text = "Cancel";
            Cancel.UseVisualStyleBackColor = true;
            // 
            // AddPercentDiscountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(322, 131);
            Controls.Add(Cancel);
            Controls.Add(OKButton);
            Controls.Add(CategoryLabel);
            Controls.Add(CategoryComboBox);
            Controls.Add(PercentDiscountLabel);
            Name = "AddPercentDiscountForm";
            Text = "AddPercentDiscountForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PercentDiscountLabel;
        private ComboBox CategoryComboBox;
        private Label CategoryLabel;
        private Button OKButton;
        private Button Cancel;
    }
}