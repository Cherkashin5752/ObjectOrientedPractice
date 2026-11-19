namespace ObjectOrientedPractics.View.Panels
{
    partial class StandartInterfaceTest
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
            FirstItemLabel = new Label();
            SecondItemLabel = new Label();
            IsEqualButton = new Button();
            MakeEqualButton = new Button();
            FirstItemControl = new ObjectOrientedPractics.View.Controls.ItemControl();
            SecondItemControl = new ObjectOrientedPractics.View.Controls.ItemControl();
            WhichGreaterButton = new Button();
            SuspendLayout();
            // 
            // FirstItemLabel
            // 
            FirstItemLabel.AutoSize = true;
            FirstItemLabel.Location = new Point(3, 0);
            FirstItemLabel.Name = "FirstItemLabel";
            FirstItemLabel.Size = new Size(59, 15);
            FirstItemLabel.TabIndex = 2;
            FirstItemLabel.Text = "First Item:";
            // 
            // SecondItemLabel
            // 
            SecondItemLabel.AutoSize = true;
            SecondItemLabel.Location = new Point(394, 0);
            SecondItemLabel.Name = "SecondItemLabel";
            SecondItemLabel.Size = new Size(76, 15);
            SecondItemLabel.TabIndex = 3;
            SecondItemLabel.Text = "Second Item:";
            // 
            // IsEqualButton
            // 
            IsEqualButton.Location = new Point(3, 194);
            IsEqualButton.Name = "IsEqualButton";
            IsEqualButton.Size = new Size(75, 45);
            IsEqualButton.TabIndex = 20;
            IsEqualButton.Text = "Is Equal";
            IsEqualButton.UseVisualStyleBackColor = true;
            IsEqualButton.Click += IsEqualButton_Click;
            // 
            // MakeEqualButton
            // 
            MakeEqualButton.Location = new Point(84, 194);
            MakeEqualButton.Name = "MakeEqualButton";
            MakeEqualButton.Size = new Size(75, 45);
            MakeEqualButton.TabIndex = 21;
            MakeEqualButton.Text = "Make Equal";
            MakeEqualButton.UseVisualStyleBackColor = true;
            MakeEqualButton.Click += MakeEqualButton_Click;
            // 
            // FirstItemControl
            // 
            FirstItemControl.Location = new Point(0, 22);
            FirstItemControl.Name = "FirstItemControl";
            FirstItemControl.Size = new Size(396, 166);
            FirstItemControl.TabIndex = 22;
            // 
            // SecondItemControl
            // 
            SecondItemControl.Location = new Point(402, 22);
            SecondItemControl.Name = "SecondItemControl";
            SecondItemControl.Size = new Size(377, 166);
            SecondItemControl.TabIndex = 23;
            // 
            // WhichGreaterButton
            // 
            WhichGreaterButton.Location = new Point(165, 194);
            WhichGreaterButton.Name = "WhichGreaterButton";
            WhichGreaterButton.Size = new Size(75, 45);
            WhichGreaterButton.TabIndex = 24;
            WhichGreaterButton.Text = "Which is greater";
            WhichGreaterButton.UseVisualStyleBackColor = true;
            WhichGreaterButton.Click += WhichGreaterButton_Click;
            // 
            // StandartInterfaceTest
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(WhichGreaterButton);
            Controls.Add(SecondItemControl);
            Controls.Add(FirstItemControl);
            Controls.Add(MakeEqualButton);
            Controls.Add(IsEqualButton);
            Controls.Add(SecondItemLabel);
            Controls.Add(FirstItemLabel);
            Name = "StandartInterfaceTest";
            Size = new Size(782, 314);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label FirstItemLabel;
        private Label SecondItemLabel;
        private Button IsEqualButton;
        private Button MakeEqualButton;
        private Controls.ItemControl FirstItemControl;
        private Controls.ItemControl SecondItemControl;
        private Button WhichGreaterButton;
    }
}
