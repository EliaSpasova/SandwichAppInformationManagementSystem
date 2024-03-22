namespace SandwichesDatabaseManagementProject
{
    partial class InsertANewSandwich
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
            label1 = new Label();
            nameOfSandwichTextBox = new TextBox();
            capitalLetterLabel = new Label();
            noSpecialCharacters = new Label();
            meatBox = new ComboBox();
            meatLabel = new Label();
            cheeseLabel = new Label();
            cheeseComboBox = new ComboBox();
            tomatoesBox = new ComboBox();
            sauceBox = new ComboBox();
            lettuceBox = new ComboBox();
            pricetextboc = new TextBox();
            insertButton = new Button();
            amount = new TextBox();
            caloriestextBox = new TextBox();
            allergens = new TextBox();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(466, 9);
            label1.Name = "label1";
            label1.Size = new Size(75, 37);
            label1.TabIndex = 0;
            label1.Text = "Title";
            // 
            // nameOfSandwichTextBox
            // 
            nameOfSandwichTextBox.Location = new Point(367, 49);
            nameOfSandwichTextBox.Name = "nameOfSandwichTextBox";
            nameOfSandwichTextBox.Size = new Size(243, 39);
            nameOfSandwichTextBox.TabIndex = 1;
            nameOfSandwichTextBox.TextChanged += nameOfSandwichTextBox_TextChanged;
            nameOfSandwichTextBox.Validated += nameOfSandwichTextBox_Validated;
            // 
            // capitalLetterLabel
            // 
            capitalLetterLabel.AutoSize = true;
            capitalLetterLabel.Location = new Point(3, 14);
            capitalLetterLabel.Name = "capitalLetterLabel";
            capitalLetterLabel.Size = new Size(358, 32);
            capitalLetterLabel.TabIndex = 2;
            capitalLetterLabel.Text = "The first letter should be capital.";
            capitalLetterLabel.Visible = false;
            // 
            // noSpecialCharacters
            // 
            noSpecialCharacters.AutoSize = true;
            noSpecialCharacters.Location = new Point(3, 52);
            noSpecialCharacters.Name = "noSpecialCharacters";
            noSpecialCharacters.Size = new Size(244, 32);
            noSpecialCharacters.TabIndex = 3;
            noSpecialCharacters.Text = "No special characters.";
            noSpecialCharacters.Visible = false;
            // 
            // meatBox
            // 
            meatBox.FormattingEnabled = true;
            meatBox.Items.AddRange(new object[] { "MEAT", "none", "chicken", "puteshko", "pepperoni", "beef", "roast beef", "turkey", "ham", "salami", "tuna", "egg", "bacon" });
            meatBox.Location = new Point(367, 142);
            meatBox.Name = "meatBox";
            meatBox.Size = new Size(243, 40);
            meatBox.TabIndex = 4;
            // 
            // meatLabel
            // 
            meatLabel.AutoSize = true;
            meatLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            meatLabel.Location = new Point(368, 102);
            meatLabel.Name = "meatLabel";
            meatLabel.Size = new Size(80, 37);
            meatLabel.TabIndex = 5;
            meatLabel.Text = "Meat";
            // 
            // cheeseLabel
            // 
            cheeseLabel.AutoSize = true;
            cheeseLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cheeseLabel.Location = new Point(368, 185);
            cheeseLabel.Name = "cheeseLabel";
            cheeseLabel.Size = new Size(104, 37);
            cheeseLabel.TabIndex = 6;
            cheeseLabel.Text = "Cheese";
            // 
            // cheeseComboBox
            // 
            cheeseComboBox.FormattingEnabled = true;
            cheeseComboBox.Items.AddRange(new object[] { "CHEESE", "none", "swiss", "provolone", "cheddar", "feta", "mozarella" });
            cheeseComboBox.Location = new Point(368, 225);
            cheeseComboBox.Name = "cheeseComboBox";
            cheeseComboBox.Size = new Size(242, 40);
            cheeseComboBox.TabIndex = 7;
            cheeseComboBox.SelectedIndexChanged += cheeseComboBox_SelectedIndexChanged;
            // 
            // tomatoesBox
            // 
            tomatoesBox.FormattingEnabled = true;
            tomatoesBox.Items.AddRange(new object[] { "TOMATOES", "yes", "no" });
            tomatoesBox.Location = new Point(368, 391);
            tomatoesBox.Name = "tomatoesBox";
            tomatoesBox.Size = new Size(244, 40);
            tomatoesBox.TabIndex = 8;
            // 
            // sauceBox
            // 
            sauceBox.FormattingEnabled = true;
            sauceBox.Items.AddRange(new object[] { "SAUCE", "none", "milk", "domateno pesto", "domaten sauce", "oil", "mayo", "mustard", "vinegar and oil", "ranch", "pesto", "horseradish sauce" });
            sauceBox.Location = new Point(368, 475);
            sauceBox.Name = "sauceBox";
            sauceBox.Size = new Size(244, 40);
            sauceBox.TabIndex = 9;
            // 
            // lettuceBox
            // 
            lettuceBox.FormattingEnabled = true;
            lettuceBox.Items.AddRange(new object[] { "LETTUCE", "yes", "no" });
            lettuceBox.Location = new Point(368, 308);
            lettuceBox.Name = "lettuceBox";
            lettuceBox.Size = new Size(243, 40);
            lettuceBox.TabIndex = 10;
            // 
            // pricetextboc
            // 
            pricetextboc.Location = new Point(25, 585);
            pricetextboc.Name = "pricetextboc";
            pricetextboc.Size = new Size(149, 39);
            pricetextboc.TabIndex = 11;
            pricetextboc.Text = "PRICE";
            // 
            // insertButton
            // 
            insertButton.Location = new Point(772, 560);
            insertButton.Name = "insertButton";
            insertButton.Size = new Size(201, 112);
            insertButton.TabIndex = 12;
            insertButton.Text = "Insert";
            insertButton.UseVisualStyleBackColor = true;
            insertButton.Click += insertButton_Click;
            // 
            // amount
            // 
            amount.Location = new Point(25, 630);
            amount.Name = "amount";
            amount.Size = new Size(200, 39);
            amount.TabIndex = 13;
            amount.Text = "Amount";
            // 
            // caloriestextBox
            // 
            caloriestextBox.Location = new Point(368, 557);
            caloriestextBox.Name = "caloriestextBox";
            caloriestextBox.Size = new Size(245, 39);
            caloriestextBox.TabIndex = 14;
            // 
            // allergens
            // 
            allergens.Location = new Point(365, 646);
            allergens.Name = "allergens";
            allergens.Size = new Size(245, 39);
            allergens.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(12, 449);
            button1.Name = "button1";
            button1.Size = new Size(180, 66);
            button1.TabIndex = 16;
            button1.Text = "image upload";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 225);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(242, 215);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(367, 268);
            label2.Name = "label2";
            label2.Size = new Size(107, 37);
            label2.TabIndex = 18;
            label2.Text = "Lettuce";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(367, 351);
            label3.Name = "label3";
            label3.Size = new Size(142, 37);
            label3.TabIndex = 19;
            label3.Text = "Tomatoes";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(367, 432);
            label4.Name = "label4";
            label4.Size = new Size(90, 37);
            label4.TabIndex = 20;
            label4.Text = "Sauce";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(367, 517);
            label5.Name = "label5";
            label5.Size = new Size(121, 37);
            label5.TabIndex = 21;
            label5.Text = "Calories";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(365, 596);
            label6.Name = "label6";
            label6.Size = new Size(137, 37);
            label6.TabIndex = 22;
            label6.Text = "Allergens";
            // 
            // InsertANewSandwich
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(998, 697);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(allergens);
            Controls.Add(caloriestextBox);
            Controls.Add(amount);
            Controls.Add(insertButton);
            Controls.Add(pricetextboc);
            Controls.Add(lettuceBox);
            Controls.Add(sauceBox);
            Controls.Add(tomatoesBox);
            Controls.Add(cheeseComboBox);
            Controls.Add(cheeseLabel);
            Controls.Add(meatLabel);
            Controls.Add(meatBox);
            Controls.Add(noSpecialCharacters);
            Controls.Add(capitalLetterLabel);
            Controls.Add(nameOfSandwichTextBox);
            Controls.Add(label1);
            Name = "InsertANewSandwich";
            Text = "Insert A New Sandwich";
            Load += InsertANewSandwich_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nameOfSandwichTextBox;
        private Label capitalLetterLabel;
        private Label noSpecialCharacters;
        private ComboBox meatBox;
        private Label meatLabel;
        private Label cheeseLabel;
        private ComboBox cheeseComboBox;
        private ComboBox tomatoesBox;
        private ComboBox sauceBox;
        private ComboBox lettuceBox;
        private TextBox pricetextboc;
        private Button insertButton;
        private TextBox amount;
        private TextBox caloriestextBox;
        private TextBox allergens;
        private Button button1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}