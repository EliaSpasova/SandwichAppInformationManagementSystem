namespace SandwichesDatabaseManagementProject
{
    partial class menu
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
            dataGridView1 = new DataGridView();
            Meat = new ComboBox();
            Cheese = new ComboBox();
            Lettuce = new ComboBox();
            Tomatoes = new ComboBox();
            Sauce = new ComboBox();
            Price = new ComboBox();
            filterButton = new Button();
            cleanFilter = new Button();
            Back = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 281);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(958, 285);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Meat
            // 
            Meat.FormattingEnabled = true;
            Meat.Items.AddRange(new object[] { "MEAT", "none", "chicken", "puteshko", "pepperoni", "beef", "roast beef", "turkey", "ham", "salami", "tuna", "egg", "bacon" });
            Meat.Location = new Point(28, 182);
            Meat.Name = "Meat";
            Meat.Size = new Size(220, 40);
            Meat.TabIndex = 1;
            // 
            // Cheese
            // 
            Cheese.FormattingEnabled = true;
            Cheese.Items.AddRange(new object[] { "CHEESE", "none", "swiss", "provolone", "cheddar", "feta", "mozarella" });
            Cheese.Location = new Point(378, 182);
            Cheese.Name = "Cheese";
            Cheese.Size = new Size(220, 40);
            Cheese.TabIndex = 2;
            // 
            // Lettuce
            // 
            Lettuce.FormattingEnabled = true;
            Lettuce.Items.AddRange(new object[] { "LETTUCE", "yes", "no" });
            Lettuce.Location = new Point(724, 182);
            Lettuce.Name = "Lettuce";
            Lettuce.Size = new Size(220, 40);
            Lettuce.TabIndex = 3;
            // 
            // Tomatoes
            // 
            Tomatoes.FormattingEnabled = true;
            Tomatoes.Items.AddRange(new object[] { "TOMATOES", "yes", "no" });
            Tomatoes.Location = new Point(28, 235);
            Tomatoes.Name = "Tomatoes";
            Tomatoes.Size = new Size(220, 40);
            Tomatoes.TabIndex = 4;
            // 
            // Sauce
            // 
            Sauce.FormattingEnabled = true;
            Sauce.Items.AddRange(new object[] { "SAUCE", "none", "milk", "domateno pesto", "domaten sauce", "oil", "mayo", "mustard", "vinegar and oil", "ranch", "pesto", "horseradish sauce" });
            Sauce.Location = new Point(378, 235);
            Sauce.Name = "Sauce";
            Sauce.Size = new Size(220, 40);
            Sauce.TabIndex = 5;
            // 
            // Price
            // 
            Price.FormattingEnabled = true;
            Price.Items.AddRange(new object[] { "PRICE", "10.00", "6.49", "8.99", "5.99", "9.49", "1000.00", "5000.00", "4500.00", "10000.00" });
            Price.Location = new Point(724, 235);
            Price.Name = "Price";
            Price.Size = new Size(220, 40);
            Price.TabIndex = 6;
            // 
            // filterButton
            // 
            filterButton.Location = new Point(28, 639);
            filterButton.Name = "filterButton";
            filterButton.Size = new Size(220, 46);
            filterButton.TabIndex = 7;
            filterButton.Text = "Filter";
            filterButton.UseVisualStyleBackColor = true;
            filterButton.Click += filterButton_Click;
            // 
            // cleanFilter
            // 
            cleanFilter.Location = new Point(28, 587);
            cleanFilter.Name = "cleanFilter";
            cleanFilter.Size = new Size(220, 46);
            cleanFilter.TabIndex = 8;
            cleanFilter.Text = "Clean Filter";
            cleanFilter.UseVisualStyleBackColor = true;
            cleanFilter.Click += cleanFilter_Click;
            // 
            // Back
            // 
            Back.Location = new Point(772, 639);
            Back.Name = "Back";
            Back.Size = new Size(214, 46);
            Back.TabIndex = 9;
            Back.Text = "Back To Cart";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(442, 9);
            label1.Name = "label1";
            label1.Size = new Size(103, 45);
            label1.TabIndex = 10;
            label1.Text = "Menu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(54, 54);
            label2.Name = "label2";
            label2.Size = new Size(895, 32);
            label2.TabIndex = 11;
            label2.Text = "Filter, based on your likings and double-click on a sandwich to look at its information";
            // 
            // menu
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(998, 697);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Back);
            Controls.Add(cleanFilter);
            Controls.Add(filterButton);
            Controls.Add(Price);
            Controls.Add(Sauce);
            Controls.Add(Tomatoes);
            Controls.Add(Lettuce);
            Controls.Add(Cheese);
            Controls.Add(Meat);
            Controls.Add(dataGridView1);
            Name = "menu";
            Text = "menu";
            Load += menu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ComboBox Meat;
        private ComboBox Cheese;
        private ComboBox Lettuce;
        private ComboBox Tomatoes;
        private ComboBox Sauce;
        private ComboBox Price;
        private Button filterButton;
        private Button cleanFilter;
        private Button Back;
        private Label label1;
        private Label label2;
    }
}