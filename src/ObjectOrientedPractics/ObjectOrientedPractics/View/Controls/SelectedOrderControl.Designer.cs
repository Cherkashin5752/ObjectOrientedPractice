namespace ObjectOrientedPractics.View.Controls
{
    partial class SelectedOrderControl
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
            SelectedOrderLabel = new Label();
            IdTextBox = new TextBox();
            CreatedTextBox = new TextBox();
            StatusComboBox = new ComboBox();
            addressControl1 = new ObjectOrientedPractics.View.Control.AddressControl();
            OrderItemsLabel = new Label();
            ItemsOrderListBox = new ListBox();
            IdLabel = new Label();
            CreatedLabel = new Label();
            StatusLabel = new Label();
            AmountLabel = new Label();
            AmountOrderLabel = new Label();
            SuspendLayout();
            // 
            // SelectedOrderLabel
            // 
            SelectedOrderLabel.AutoSize = true;
            SelectedOrderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedOrderLabel.Location = new Point(3, 0);
            SelectedOrderLabel.Name = "SelectedOrderLabel";
            SelectedOrderLabel.Size = new Size(92, 15);
            SelectedOrderLabel.TabIndex = 0;
            SelectedOrderLabel.Text = "Selected Order";
            // 
            // IdTextBox
            // 
            IdTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            IdTextBox.Location = new Point(73, 24);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(157, 23);
            IdTextBox.TabIndex = 1;
            // 
            // CreatedTextBox
            // 
            CreatedTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CreatedTextBox.Location = new Point(73, 53);
            CreatedTextBox.Name = "CreatedTextBox";
            CreatedTextBox.ReadOnly = true;
            CreatedTextBox.Size = new Size(157, 23);
            CreatedTextBox.TabIndex = 2;
            // 
            // StatusComboBox
            // 
            StatusComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(73, 82);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(157, 23);
            StatusComboBox.TabIndex = 3;
            // 
            // addressControl1
            // 
            addressControl1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            addressControl1.Location = new Point(3, 111);
            addressControl1.Name = "addressControl1";
            addressControl1.Size = new Size(458, 145);
            addressControl1.TabIndex = 4;
            // 
            // OrderItemsLabel
            // 
            OrderItemsLabel.AutoSize = true;
            OrderItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrderItemsLabel.Location = new Point(3, 259);
            OrderItemsLabel.Name = "OrderItemsLabel";
            OrderItemsLabel.Size = new Size(75, 15);
            OrderItemsLabel.TabIndex = 5;
            OrderItemsLabel.Text = "Order Items";
            // 
            // ItemsOrderListBox
            // 
            ItemsOrderListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsOrderListBox.FormattingEnabled = true;
            ItemsOrderListBox.Location = new Point(3, 277);
            ItemsOrderListBox.Name = "ItemsOrderListBox";
            ItemsOrderListBox.Size = new Size(458, 154);
            ItemsOrderListBox.TabIndex = 6;
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(3, 27);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 7;
            IdLabel.Text = "ID:";
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Location = new Point(3, 56);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Size = new Size(51, 15);
            CreatedLabel.TabIndex = 8;
            CreatedLabel.Text = "Created:";
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(3, 85);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(42, 15);
            StatusLabel.TabIndex = 9;
            StatusLabel.Text = "Status:";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(387, 434);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(74, 20);
            AmountLabel.TabIndex = 10;
            AmountLabel.Text = "Amount";
            AmountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // AmountOrderLabel
            // 
            AmountOrderLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountOrderLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountOrderLabel.Location = new Point(361, 454);
            AmountOrderLabel.Name = "AmountOrderLabel";
            AmountOrderLabel.Size = new Size(100, 38);
            AmountOrderLabel.TabIndex = 11;
            AmountOrderLabel.Text = "0,0";
            AmountOrderLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // SelectedOrderControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(AmountOrderLabel);
            Controls.Add(AmountLabel);
            Controls.Add(StatusLabel);
            Controls.Add(CreatedLabel);
            Controls.Add(IdLabel);
            Controls.Add(ItemsOrderListBox);
            Controls.Add(OrderItemsLabel);
            Controls.Add(addressControl1);
            Controls.Add(StatusComboBox);
            Controls.Add(CreatedTextBox);
            Controls.Add(IdTextBox);
            Controls.Add(SelectedOrderLabel);
            Name = "SelectedOrderControl";
            Size = new Size(464, 492);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SelectedOrderLabel;
        private TextBox IdTextBox;
        private TextBox CreatedTextBox;
        private ComboBox StatusComboBox;
        private Control.AddressControl addressControl1;
        private Label OrderItemsLabel;
        private ListBox ItemsOrderListBox;
        private Label IdLabel;
        private Label CreatedLabel;
        private Label StatusLabel;
        private Label AmountLabel;
        private Label AmountOrderLabel;
    }
}
