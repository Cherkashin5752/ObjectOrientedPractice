namespace ObjectOrientedPractics.View.Panels
{
    partial class CartsTab
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
            ItemsCartsListBox = new ListBox();
            ItemsLabel = new Label();
            AddToCartButton = new Button();
            CustomerLabel = new Label();
            CustomerComboBox = new ComboBox();
            CartContentListBox = new ListBox();
            CartLabel = new Label();
            AmountLabel = new Label();
            CartAmountLabel = new Label();
            ClearCartButton = new Button();
            RemoveItemButotn = new Button();
            CreateOrderButton = new Button();
            SuspendLayout();
            // 
            // ItemsCartsListBox
            // 
            ItemsCartsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            ItemsCartsListBox.FormattingEnabled = true;
            ItemsCartsListBox.Location = new Point(6, 22);
            ItemsCartsListBox.Name = "ItemsCartsListBox";
            ItemsCartsListBox.Size = new Size(237, 424);
            ItemsCartsListBox.TabIndex = 0;
            // 
            // ItemsLabel
            // 
            ItemsLabel.AutoSize = true;
            ItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            ItemsLabel.Location = new Point(6, 4);
            ItemsLabel.Name = "ItemsLabel";
            ItemsLabel.Size = new Size(39, 15);
            ItemsLabel.TabIndex = 1;
            ItemsLabel.Text = "Items";
            // 
            // AddToCartButton
            // 
            AddToCartButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddToCartButton.Location = new Point(6, 452);
            AddToCartButton.Name = "AddToCartButton";
            AddToCartButton.Size = new Size(75, 46);
            AddToCartButton.TabIndex = 2;
            AddToCartButton.Text = "Add to Cart";
            AddToCartButton.UseVisualStyleBackColor = true;
            AddToCartButton.Click += AddToCartButton_Click;
            // 
            // CustomerLabel
            // 
            CustomerLabel.AutoSize = true;
            CustomerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CustomerLabel.Location = new Point(263, 25);
            CustomerLabel.Name = "CustomerLabel";
            CustomerLabel.Size = new Size(64, 15);
            CustomerLabel.TabIndex = 3;
            CustomerLabel.Text = "Customer:";
            // 
            // CustomerComboBox
            // 
            CustomerComboBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CustomerComboBox.FormattingEnabled = true;
            CustomerComboBox.Location = new Point(331, 22);
            CustomerComboBox.Name = "CustomerComboBox";
            CustomerComboBox.Size = new Size(319, 23);
            CustomerComboBox.TabIndex = 4;
            CustomerComboBox.SelectedIndexChanged += CustomerComboBox_SelectedIndexChanged;
            // 
            // CartContentListBox
            // 
            CartContentListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartContentListBox.FormattingEnabled = true;
            CartContentListBox.Location = new Point(263, 83);
            CartContentListBox.Name = "CartContentListBox";
            CartContentListBox.Size = new Size(387, 154);
            CartContentListBox.TabIndex = 5;
            // 
            // CartLabel
            // 
            CartLabel.AutoSize = true;
            CartLabel.Location = new Point(263, 65);
            CartLabel.Name = "CartLabel";
            CartLabel.Size = new Size(32, 15);
            CartLabel.TabIndex = 6;
            CartLabel.Text = "Cart:";
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            AmountLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            AmountLabel.Location = new Point(550, 254);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.Size = new Size(100, 19);
            AmountLabel.TabIndex = 7;
            AmountLabel.Text = "Amount:";
            AmountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // CartAmountLabel
            // 
            CartAmountLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            CartAmountLabel.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 204);
            CartAmountLabel.Location = new Point(263, 273);
            CartAmountLabel.Name = "CartAmountLabel";
            CartAmountLabel.Size = new Size(387, 32);
            CartAmountLabel.TabIndex = 8;
            CartAmountLabel.Text = "0,0";
            CartAmountLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // ClearCartButton
            // 
            ClearCartButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            ClearCartButton.Location = new Point(575, 308);
            ClearCartButton.Name = "ClearCartButton";
            ClearCartButton.Size = new Size(75, 46);
            ClearCartButton.TabIndex = 9;
            ClearCartButton.Text = "Clear Cart";
            ClearCartButton.UseVisualStyleBackColor = true;
            // 
            // RemoveItemButotn
            // 
            RemoveItemButotn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RemoveItemButotn.Location = new Point(494, 308);
            RemoveItemButotn.Name = "RemoveItemButotn";
            RemoveItemButotn.Size = new Size(75, 46);
            RemoveItemButotn.TabIndex = 10;
            RemoveItemButotn.Text = "Remove item";
            RemoveItemButotn.UseVisualStyleBackColor = true;
            RemoveItemButotn.Click += RemoveItemButotn_Click;
            // 
            // CreateOrderButton
            // 
            CreateOrderButton.Location = new Point(263, 308);
            CreateOrderButton.Name = "CreateOrderButton";
            CreateOrderButton.Size = new Size(75, 46);
            CreateOrderButton.TabIndex = 11;
            CreateOrderButton.Text = "Create Order";
            CreateOrderButton.UseVisualStyleBackColor = true;
            // 
            // CartsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(CreateOrderButton);
            Controls.Add(RemoveItemButotn);
            Controls.Add(ClearCartButton);
            Controls.Add(CartAmountLabel);
            Controls.Add(AmountLabel);
            Controls.Add(CartLabel);
            Controls.Add(CartContentListBox);
            Controls.Add(CustomerComboBox);
            Controls.Add(CustomerLabel);
            Controls.Add(AddToCartButton);
            Controls.Add(ItemsLabel);
            Controls.Add(ItemsCartsListBox);
            Name = "CartsTab";
            Size = new Size(666, 510);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ItemsCartsListBox;
        private Label ItemsLabel;
        private Button AddToCartButton;
        private Label CustomerLabel;
        private ComboBox CustomerComboBox;
        private ListBox CartContentListBox;
        private Label CartLabel;
        private Label AmountLabel;
        private Label CartAmountLabel;
        private Button ClearCartButton;
        private Button RemoveItemButotn;
        private Button CreateOrderButton;
    }
}
