namespace SandwichesDatabaseManagementProject
{
    partial class sandwichInfo
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
            pictureSandwich = new PictureBox();
            titleOfSandwichLabel = new Label();
            caloriesOfSandwichLabel = new Label();
            allergensLabel = new Label();
            AmountYouWant = new TextBox();
            addToCartButton = new Button();
            backButton = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureSandwich).BeginInit();
            SuspendLayout();
            // 
            // pictureSandwich
            // 
            pictureSandwich.Location = new Point(29, 74);
            pictureSandwich.Name = "pictureSandwich";
            pictureSandwich.Size = new Size(399, 394);
            pictureSandwich.TabIndex = 0;
            pictureSandwich.TabStop = false;
            // 
            // titleOfSandwichLabel
            // 
            titleOfSandwichLabel.AutoSize = true;
            titleOfSandwichLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            titleOfSandwichLabel.Location = new Point(724, 74);
            titleOfSandwichLabel.Name = "titleOfSandwichLabel";
            titleOfSandwichLabel.Size = new Size(113, 45);
            titleOfSandwichLabel.TabIndex = 1;
            titleOfSandwichLabel.Text = "label1";
            // 
            // caloriesOfSandwichLabel
            // 
            caloriesOfSandwichLabel.AutoSize = true;
            caloriesOfSandwichLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            caloriesOfSandwichLabel.Location = new Point(498, 141);
            caloriesOfSandwichLabel.Name = "caloriesOfSandwichLabel";
            caloriesOfSandwichLabel.Size = new Size(90, 37);
            caloriesOfSandwichLabel.TabIndex = 2;
            caloriesOfSandwichLabel.Text = "label2";
            // 
            // allergensLabel
            // 
            allergensLabel.AutoSize = true;
            allergensLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            allergensLabel.Location = new Point(498, 256);
            allergensLabel.Name = "allergensLabel";
            allergensLabel.Size = new Size(90, 37);
            allergensLabel.TabIndex = 3;
            allergensLabel.Text = "label3";
            // 
            // AmountYouWant
            // 
            AmountYouWant.Location = new Point(498, 429);
            AmountYouWant.Name = "AmountYouWant";
            AmountYouWant.Size = new Size(191, 39);
            AmountYouWant.TabIndex = 4;
            // 
            // addToCartButton
            // 
            addToCartButton.Location = new Point(764, 534);
            addToCartButton.Name = "addToCartButton";
            addToCartButton.Size = new Size(222, 72);
            addToCartButton.TabIndex = 5;
            addToCartButton.Text = "Add To Cart";
            addToCartButton.UseVisualStyleBackColor = true;
            addToCartButton.Click += addToCartButton_Click;
            // 
            // backButton
            // 
            backButton.Location = new Point(764, 612);
            backButton.Name = "backButton";
            backButton.Size = new Size(222, 72);
            backButton.TabIndex = 6;
            backButton.Text = "Back To Cart";
            backButton.UseVisualStyleBackColor = true;
            backButton.Click += backButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(498, 373);
            label1.Name = "label1";
            label1.Size = new Size(436, 37);
            label1.TabIndex = 7;
            label1.Text = "Please type how many do you want";
            // 
            // sandwichInfo
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(998, 697);
            Controls.Add(label1);
            Controls.Add(backButton);
            Controls.Add(addToCartButton);
            Controls.Add(AmountYouWant);
            Controls.Add(allergensLabel);
            Controls.Add(caloriesOfSandwichLabel);
            Controls.Add(titleOfSandwichLabel);
            Controls.Add(pictureSandwich);
            Name = "sandwichInfo";
            Text = "sandwichInfo";
            ((System.ComponentModel.ISupportInitialize)pictureSandwich).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureSandwich;
        private Label titleOfSandwichLabel;
        private Label caloriesOfSandwichLabel;
        private Label allergensLabel;
        private TextBox AmountYouWant;
        private Button addToCartButton;
        private Button backButton;
        private Label label1;
    }
}