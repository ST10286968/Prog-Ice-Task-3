namespace Cafe1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            DisplayButton = new Button();
            label1 = new Label();
            label2 = new Label();
            ItemList = new ComboBox();
            QuantityInput = new TextBox();
            Display = new RichTextBox();
            ClearButton = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(76, 97);
            button1.Name = "button1";
            button1.Size = new Size(83, 29);
            button1.TabIndex = 0;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(312, 97);
            button2.Name = "button2";
            button2.Size = new Size(65, 29);
            button2.TabIndex = 1;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // DisplayButton
            // 
            DisplayButton.Location = new Point(123, 169);
            DisplayButton.Name = "DisplayButton";
            DisplayButton.Size = new Size(94, 29);
            DisplayButton.TabIndex = 2;
            DisplayButton.Text = "Display";
            DisplayButton.UseVisualStyleBackColor = true;
            DisplayButton.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(76, 25);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 3;
            label1.Text = "Select Item";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(312, 25);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 4;
            label2.Text = "Quantity";
            // 
            // ItemList
            // 
            ItemList.FormattingEnabled = true;
            ItemList.Items.AddRange(new object[] { "Hot Chocolate", "Latte", "Cappuccino", "Vanilla Maffin", "Chocolate Chip Muffin", "BarOne Cake" });
            ItemList.Location = new Point(44, 63);
            ItemList.Name = "ItemList";
            ItemList.Size = new Size(151, 28);
            ItemList.TabIndex = 5;
            ItemList.Text = "Item list";
            // 
            // QuantityInput
            // 
            QuantityInput.Location = new Point(296, 63);
            QuantityInput.Name = "QuantityInput";
            QuantityInput.Size = new Size(105, 27);
            QuantityInput.TabIndex = 7;
            // 
            // Display
            // 
            Display.Location = new Point(76, 215);
            Display.Name = "Display";
            Display.Size = new Size(325, 99);
            Display.TabIndex = 8;
            Display.Text = "";
            // 
            // ClearButton
            // 
            ClearButton.Location = new Point(274, 169);
            ClearButton.Name = "ClearButton";
            ClearButton.Size = new Size(84, 29);
            ClearButton.TabIndex = 9;
            ClearButton.Text = "Clear";
            ClearButton.UseVisualStyleBackColor = true;
            ClearButton.Click += ClearButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 336);
            Controls.Add(ClearButton);
            Controls.Add(Display);
            Controls.Add(QuantityInput);
            Controls.Add(ItemList);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DisplayButton);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button DisplayButton;
        private Label label1;
        private Label label2;
        private ComboBox ItemList;
        private TextBox QuantityInput;
        private RichTextBox Display;
        private Button ClearButton;
    }
}
