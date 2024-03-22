namespace SandwichesDatabaseManagementProject
{
    partial class UpdateSandwichForm
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
            updateSandwich = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            allergens = new TextBox();
            caloriestextBox = new TextBox();
            lettuceBox = new ComboBox();
            sauceBox = new ComboBox();
            tomatoesBox = new ComboBox();
            cheeseComboBox = new ComboBox();
            cheeseLabel = new Label();
            meatLabel = new Label();
            meatBox = new ComboBox();
            amount = new TextBox();
            pricetextboc = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(312, 9);
            label1.Name = "label1";
            label1.Size = new Size(340, 32);
            label1.TabIndex = 0;
            label1.Text = "Update sandwiche's properties";
            label1.Click += label1_Click;
            // 
            // updateSandwich
            // 
            updateSandwich.Location = new Point(806, 580);
            updateSandwich.Name = "updateSandwich";
            updateSandwich.Size = new Size(150, 96);
            updateSandwich.TabIndex = 34;
            updateSandwich.Text = "Update";
            updateSandwich.UseVisualStyleBackColor = true;
            updateSandwich.Click += updateSandwich_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(343, 571);
            label6.Name = "label6";
            label6.Size = new Size(137, 37);
            label6.TabIndex = 48;
            label6.Text = "Allergens";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(345, 492);
            label5.Name = "label5";
            label5.Size = new Size(121, 37);
            label5.TabIndex = 47;
            label5.Text = "Calories";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(345, 407);
            label4.Name = "label4";
            label4.Size = new Size(90, 37);
            label4.TabIndex = 46;
            label4.Text = "Sauce";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(345, 326);
            label3.Name = "label3";
            label3.Size = new Size(142, 37);
            label3.TabIndex = 45;
            label3.Text = "Tomatoes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(345, 243);
            label2.Name = "label2";
            label2.Size = new Size(107, 37);
            label2.TabIndex = 44;
            label2.Text = "Lettuce";
            // 
            // allergens
            // 
            allergens.Location = new Point(343, 621);
            allergens.Name = "allergens";
            allergens.Size = new Size(245, 39);
            allergens.TabIndex = 43;
            // 
            // caloriestextBox
            // 
            caloriestextBox.Location = new Point(346, 532);
            caloriestextBox.Name = "caloriestextBox";
            caloriestextBox.Size = new Size(245, 39);
            caloriestextBox.TabIndex = 42;
            // 
            // lettuceBox
            // 
            lettuceBox.FormattingEnabled = true;
            lettuceBox.Items.AddRange(new object[] { "LETTUCE", "yes", "no" });
            lettuceBox.Location = new Point(346, 283);
            lettuceBox.Name = "lettuceBox";
            lettuceBox.Size = new Size(243, 40);
            lettuceBox.TabIndex = 41;
            // 
            // sauceBox
            // 
            sauceBox.FormattingEnabled = true;
            sauceBox.Items.AddRange(new object[] { "SAUCE", "none", "milk", "domateno pesto", "domaten sauce", "oil", "mayo", "mustard", "vinegar and oil", "ranch", "pesto", "horseradish sauce" });
            sauceBox.Location = new Point(346, 450);
            sauceBox.Name = "sauceBox";
            sauceBox.Size = new Size(244, 40);
            sauceBox.TabIndex = 40;
            // 
            // tomatoesBox
            // 
            tomatoesBox.FormattingEnabled = true;
            tomatoesBox.Items.AddRange(new object[] { "TOMATOES", "yes", "no" });
            tomatoesBox.Location = new Point(346, 366);
            tomatoesBox.Name = "tomatoesBox";
            tomatoesBox.Size = new Size(244, 40);
            tomatoesBox.TabIndex = 39;
            // 
            // cheeseComboBox
            // 
            cheeseComboBox.FormattingEnabled = true;
            cheeseComboBox.Items.AddRange(new object[] { "CHEESE", "none", "swiss", "provolone", "cheddar", "feta", "mozarella" });
            cheeseComboBox.Location = new Point(346, 200);
            cheeseComboBox.Name = "cheeseComboBox";
            cheeseComboBox.Size = new Size(242, 40);
            cheeseComboBox.TabIndex = 38;
            // 
            // cheeseLabel
            // 
            cheeseLabel.AutoSize = true;
            cheeseLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            cheeseLabel.Location = new Point(346, 160);
            cheeseLabel.Name = "cheeseLabel";
            cheeseLabel.Size = new Size(104, 37);
            cheeseLabel.TabIndex = 37;
            cheeseLabel.Text = "Cheese";
            // 
            // meatLabel
            // 
            meatLabel.AutoSize = true;
            meatLabel.Font = new Font("Segoe UI", 10.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            meatLabel.Location = new Point(346, 77);
            meatLabel.Name = "meatLabel";
            meatLabel.Size = new Size(80, 37);
            meatLabel.TabIndex = 36;
            meatLabel.Text = "Meat";
            // 
            // meatBox
            // 
            meatBox.FormattingEnabled = true;
            meatBox.Items.AddRange(new object[] { "MEAT", "none", "chicken", "puteshko", "pepperoni", "beef", "roast beef", "turkey", "ham", "salami", "tuna", "egg", "bacon" });
            meatBox.Location = new Point(345, 117);
            meatBox.Name = "meatBox";
            meatBox.Size = new Size(243, 40);
            meatBox.TabIndex = 35;
            // 
            // amount
            // 
            amount.Location = new Point(24, 623);
            amount.Name = "amount";
            amount.Size = new Size(200, 39);
            amount.TabIndex = 50;
            amount.Text = "Amount";
            // 
            // pricetextboc
            // 
            pricetextboc.Location = new Point(24, 578);
            pricetextboc.Name = "pricetextboc";
            pricetextboc.Size = new Size(149, 39);
            pricetextboc.TabIndex = 49;
            pricetextboc.Text = "PRICE";
            // 
            // UpdateSandwichForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(998, 697);
            Controls.Add(amount);
            Controls.Add(pricetextboc);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(allergens);
            Controls.Add(caloriestextBox);
            Controls.Add(lettuceBox);
            Controls.Add(sauceBox);
            Controls.Add(tomatoesBox);
            Controls.Add(cheeseComboBox);
            Controls.Add(cheeseLabel);
            Controls.Add(meatLabel);
            Controls.Add(meatBox);
            Controls.Add(updateSandwich);
            Controls.Add(label1);
            Name = "UpdateSandwichForm";
            Text = "UpdateSandwichForm";
            Load += UpdateSandwichForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button updateSandwich;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox allergens;
        private TextBox caloriestextBox;
        private ComboBox lettuceBox;
        private ComboBox sauceBox;
        private ComboBox tomatoesBox;
        private ComboBox cheeseComboBox;
        private Label cheeseLabel;
        private Label meatLabel;
        private ComboBox meatBox;
        private TextBox amount;
        private TextBox pricetextboc;
    }
}