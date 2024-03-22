namespace SandwichesDatabaseManagementProject
{
    partial class cart
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
            welcomeLabel = new Label();
            menuButton = new Button();
            orderButton = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Location = new Point(332, 19);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(177, 32);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome, user!";
            // 
            // menuButton
            // 
            menuButton.Location = new Point(57, 321);
            menuButton.Name = "menuButton";
            menuButton.Size = new Size(150, 99);
            menuButton.TabIndex = 1;
            menuButton.Text = "Menu";
            menuButton.UseVisualStyleBackColor = true;
            menuButton.Click += menuButton_Click;
            // 
            // orderButton
            // 
            orderButton.Location = new Point(515, 321);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(150, 86);
            orderButton.TabIndex = 2;
            orderButton.Text = "Order";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += orderButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(69, 85);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(608, 221);
            dataGridView1.TabIndex = 3;
            // 
            // cart
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(orderButton);
            Controls.Add(menuButton);
            Controls.Add(welcomeLabel);
            Name = "cart";
            Text = "cart";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private Button menuButton;
        private Button orderButton;
        private DataGridView dataGridView1;
    }
}