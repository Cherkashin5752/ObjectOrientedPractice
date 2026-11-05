namespace ObjectOrientedPractics.View.Controls
{
    partial class SelectedPriorityOrdersControl
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
            AmountOrderLabel = new Label();
            AmountLabel = new Label();
            StatusLabel = new Label();
            CreatedLabel = new Label();
            IdLabel = new Label();
            ItemsPriorityOrderListBox = new ListBox();
            OrderItemsLabel = new Label();
            AddressControl = new AddressControl();
            StatusComboBox = new ComboBox();
            CreatedTextBox = new TextBox();
            IdTextBox = new TextBox();
            SelectedOrderLabel = new Label();
            PriorityOptionsLabel = new Label();
            DeliveryTimeLabel = new Label();
            DeliveryTimeComboBox = new ComboBox();
            ClearPriorityOrderButton = new Button();
            RemoveItemButton = new Button();
            AddItemButton = new Button();
            CreatePriorityOrderButton = new Button();
            RemovePriorityOrderButton = new Button();
            ChangeModeButton = new Button();
            SuspendLayout();
            // 
            // AmountOrderLabel
            // 
            AmountOrderLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AmountOrderLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountOrderLabel.Location = new Point(92, 468);
            AmountOrderLabel.Name = "AmountOrderLabel";
            AmountOrderLabel.Size = new Size(371, 38);
            AmountOrderLabel.TabIndex = 23;
            AmountOrderLabel.Text = "0,0";
            AmountOrderLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            AmountLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(389, 448);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(74, 20);
            AmountLabel.TabIndex = 22;
            AmountLabel.Text = "Amount";
            AmountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Location = new Point(3, 85);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(42, 15);
            StatusLabel.TabIndex = 21;
            StatusLabel.Text = "Status:";
            // 
            // CreatedLabel
            // 
            CreatedLabel.AutoSize = true;
            CreatedLabel.Location = new Point(3, 56);
            CreatedLabel.Name = "CreatedLabel";
            CreatedLabel.Size = new Size(51, 15);
            CreatedLabel.TabIndex = 20;
            CreatedLabel.Text = "Created:";
            // 
            // IdLabel
            // 
            IdLabel.AutoSize = true;
            IdLabel.Location = new Point(3, 27);
            IdLabel.Name = "IdLabel";
            IdLabel.Size = new Size(21, 15);
            IdLabel.TabIndex = 19;
            IdLabel.Text = "ID:";
            // 
            // ItemsPriorityOrderListBox
            // 
            ItemsPriorityOrderListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsPriorityOrderListBox.FormattingEnabled = true;
            ItemsPriorityOrderListBox.Location = new Point(3, 277);
            ItemsPriorityOrderListBox.Name = "ItemsPriorityOrderListBox";
            ItemsPriorityOrderListBox.Size = new Size(460, 169);
            ItemsPriorityOrderListBox.TabIndex = 18;
            // 
            // OrderItemsLabel
            // 
            OrderItemsLabel.AutoSize = true;
            OrderItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            OrderItemsLabel.Location = new Point(3, 259);
            OrderItemsLabel.Name = "OrderItemsLabel";
            OrderItemsLabel.Size = new Size(75, 15);
            OrderItemsLabel.TabIndex = 17;
            OrderItemsLabel.Text = "Order Items";
            // 
            // AddressControl
            // 
            AddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            AddressControl.Location = new Point(3, 111);
            AddressControl.Name = "AddressControl";
            AddressControl.Size = new Size(460, 145);
            AddressControl.TabIndex = 16;
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(73, 82);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(110, 23);
            StatusComboBox.TabIndex = 15;
            // 
            // CreatedTextBox
            // 
            CreatedTextBox.Location = new Point(73, 53);
            CreatedTextBox.Name = "CreatedTextBox";
            CreatedTextBox.ReadOnly = true;
            CreatedTextBox.Size = new Size(110, 23);
            CreatedTextBox.TabIndex = 14;
            // 
            // IdTextBox
            // 
            IdTextBox.Location = new Point(73, 24);
            IdTextBox.Name = "IdTextBox";
            IdTextBox.ReadOnly = true;
            IdTextBox.Size = new Size(110, 23);
            IdTextBox.TabIndex = 13;
            // 
            // SelectedOrderLabel
            // 
            SelectedOrderLabel.AutoSize = true;
            SelectedOrderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            SelectedOrderLabel.Location = new Point(3, 0);
            SelectedOrderLabel.Name = "SelectedOrderLabel";
            SelectedOrderLabel.Size = new Size(92, 15);
            SelectedOrderLabel.TabIndex = 12;
            SelectedOrderLabel.Text = "Selected Order";
            // 
            // PriorityOptionsLabel
            // 
            PriorityOptionsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            PriorityOptionsLabel.AutoSize = true;
            PriorityOptionsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            PriorityOptionsLabel.Location = new Point(252, 0);
            PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            PriorityOptionsLabel.Size = new Size(94, 15);
            PriorityOptionsLabel.TabIndex = 24;
            PriorityOptionsLabel.Text = "Priority Options";
            // 
            // DeliveryTimeLabel
            // 
            DeliveryTimeLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeliveryTimeLabel.AutoSize = true;
            DeliveryTimeLabel.Location = new Point(252, 27);
            DeliveryTimeLabel.Name = "DeliveryTimeLabel";
            DeliveryTimeLabel.Size = new Size(82, 15);
            DeliveryTimeLabel.TabIndex = 25;
            DeliveryTimeLabel.Text = "Delivery Time:";
            // 
            // DeliveryTimeComboBox
            // 
            DeliveryTimeComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            DeliveryTimeComboBox.FormattingEnabled = true;
            DeliveryTimeComboBox.Location = new Point(342, 24);
            DeliveryTimeComboBox.Name = "DeliveryTimeComboBox";
            DeliveryTimeComboBox.Size = new Size(121, 23);
            DeliveryTimeComboBox.TabIndex = 26;
            // 
            // ClearPriorityOrderButton
            // 
            ClearPriorityOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ClearPriorityOrderButton.Location = new Point(380, 509);
            ClearPriorityOrderButton.Name = "ClearPriorityOrderButton";
            ClearPriorityOrderButton.Size = new Size(83, 46);
            ClearPriorityOrderButton.TabIndex = 29;
            ClearPriorityOrderButton.Text = "Clear Order";
            ClearPriorityOrderButton.UseVisualStyleBackColor = true;
            // 
            // RemoveItemButton
            // 
            RemoveItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            RemoveItemButton.Location = new Point(92, 509);
            RemoveItemButton.Name = "RemoveItemButton";
            RemoveItemButton.Size = new Size(83, 46);
            RemoveItemButton.TabIndex = 28;
            RemoveItemButton.Text = "Remove Item";
            RemoveItemButton.UseVisualStyleBackColor = true;
            // 
            // AddItemButton
            // 
            AddItemButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddItemButton.Location = new Point(3, 509);
            AddItemButton.Name = "AddItemButton";
            AddItemButton.Size = new Size(83, 46);
            AddItemButton.TabIndex = 27;
            AddItemButton.Text = "Add Item";
            AddItemButton.UseVisualStyleBackColor = true;
            // 
            // CreatePriorityOrderButton
            // 
            CreatePriorityOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CreatePriorityOrderButton.Location = new Point(188, 509);
            CreatePriorityOrderButton.Name = "CreatePriorityOrderButton";
            CreatePriorityOrderButton.Size = new Size(86, 46);
            CreatePriorityOrderButton.TabIndex = 30;
            CreatePriorityOrderButton.Text = "Create Priority Order";
            CreatePriorityOrderButton.UseVisualStyleBackColor = true;
            // 
            // RemovePriorityOrderButton
            // 
            RemovePriorityOrderButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            RemovePriorityOrderButton.Location = new Point(280, 509);
            RemovePriorityOrderButton.Name = "RemovePriorityOrderButton";
            RemovePriorityOrderButton.Size = new Size(86, 46);
            RemovePriorityOrderButton.TabIndex = 31;
            RemovePriorityOrderButton.Text = "Remove Priority Order";
            RemovePriorityOrderButton.UseVisualStyleBackColor = true;
            // 
            // ChangeModeButton
            // 
            ChangeModeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            ChangeModeButton.Location = new Point(3, 457);
            ChangeModeButton.Name = "ChangeModeButton";
            ChangeModeButton.Size = new Size(83, 46);
            ChangeModeButton.TabIndex = 32;
            ChangeModeButton.Text = "Create Mode";
            ChangeModeButton.UseVisualStyleBackColor = true;
            // 
            // SelectedPriorityOrdersControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ChangeModeButton);
            Controls.Add(RemovePriorityOrderButton);
            Controls.Add(CreatePriorityOrderButton);
            Controls.Add(ClearPriorityOrderButton);
            Controls.Add(RemoveItemButton);
            Controls.Add(AddItemButton);
            Controls.Add(DeliveryTimeComboBox);
            Controls.Add(DeliveryTimeLabel);
            Controls.Add(PriorityOptionsLabel);
            Controls.Add(AmountOrderLabel);
            Controls.Add(AmountLabel);
            Controls.Add(StatusLabel);
            Controls.Add(CreatedLabel);
            Controls.Add(IdLabel);
            Controls.Add(ItemsPriorityOrderListBox);
            Controls.Add(OrderItemsLabel);
            Controls.Add(AddressControl);
            Controls.Add(StatusComboBox);
            Controls.Add(CreatedTextBox);
            Controls.Add(IdTextBox);
            Controls.Add(SelectedOrderLabel);
            Name = "SelectedPriorityOrdersControl";
            Size = new Size(466, 562);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label AmountOrderLabel;
        private Label AmountLabel;
        private Label StatusLabel;
        private Label CreatedLabel;
        private Label IdLabel;
        public ListBox ItemsPriorityOrderListBox;
        private Label OrderItemsLabel;
        public AddressControl AddressControl;
        public ComboBox StatusComboBox;
        private TextBox CreatedTextBox;
        private TextBox IdTextBox;
        private Label SelectedOrderLabel;
        private Label PriorityOptionsLabel;
        private Label DeliveryTimeLabel;
        public ComboBox DeliveryTimeComboBox;
        public Button ClearPriorityOrderButton;
        public Button RemoveItemButton;
        public Button AddItemButton;
        public Button CreatePriorityOrderButton;
        public Button RemovePriorityOrderButton;
        public Button ChangeModeButton;
    }
}
