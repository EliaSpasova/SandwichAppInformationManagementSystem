namespace SandwichesDatabaseManagementProject
{
    partial class order
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
            totalBillLabel = new Label();
            confirmButton = new Button();
            hereOrTakeawayComboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // totalBillLabel
            // 
            totalBillLabel.AccessibleDescription = "totalBillLabel";
            totalBillLabel.AutoSize = true;
            totalBillLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Italic, GraphicsUnit.Point);
            totalBillLabel.Location = new Point(168, 211);
            totalBillLabel.Name = "totalBillLabel";
            totalBillLabel.Size = new Size(89, 37);
            totalBillLabel.TabIndex = 0;
            totalBillLabel.Text = "label1";
            // 
            // confirmButton
            // 
            confirmButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            confirmButton.Location = new Point(423, 329);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(179, 56);
            confirmButton.TabIndex = 1;
            confirmButton.Text = "Confirm Order";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // hereOrTakeawayComboBox
            // 
            hereOrTakeawayComboBox.FormattingEnabled = true;
            hereOrTakeawayComboBox.Items.AddRange(new object[] { "here", "takeaway" });
            hereOrTakeawayComboBox.Location = new Point(168, 128);
            hereOrTakeawayComboBox.Name = "hereOrTakeawayComboBox";
            hereOrTakeawayComboBox.Size = new Size(242, 40);
            hereOrTakeawayComboBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(257, 13);
            label1.Name = "label1";
            label1.Size = new Size(106, 45);
            label1.TabIndex = 3;
            label1.Text = "Order";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 79);
            label2.Name = "label2";
            label2.Size = new Size(206, 32);
            label2.TabIndex = 4;
            label2.Text = "Here or Takeaway:";
            // 
            // button1
            // 
            button1.Location = new Point(12, 329);
            button1.Name = "button1";
            button1.Size = new Size(177, 56);
            button1.TabIndex = 5;
            button1.Text = "Back To Cart";
            button1.UseVisualStyleBackColor = true;
            // 
            // order
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(614, 409);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(hereOrTakeawayComboBox);
            Controls.Add(confirmButton);
            Controls.Add(totalBillLabel);
            Name = "order";
            Text = "order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label totalBillLabel;
        private Button confirmButton;
        private ComboBox hereOrTakeawayComboBox;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}