namespace SandwichesDatabaseManagementProject
{
    partial class AdminWindow
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
            insertANewItemButton = new Button();
            updateASandwich = new Button();
            allOrdersButton = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // welcomeLabel
            // 
            welcomeLabel.AutoSize = true;
            welcomeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            welcomeLabel.Location = new Point(369, 39);
            welcomeLabel.Name = "welcomeLabel";
            welcomeLabel.Size = new Size(331, 45);
            welcomeLabel.TabIndex = 0;
            welcomeLabel.Text = "Welcome, employee!";
            // 
            // insertANewItemButton
            // 
            insertANewItemButton.Location = new Point(76, 157);
            insertANewItemButton.Name = "insertANewItemButton";
            insertANewItemButton.Size = new Size(272, 126);
            insertANewItemButton.TabIndex = 1;
            insertANewItemButton.Text = "Insert a new sandwich";
            insertANewItemButton.UseVisualStyleBackColor = true;
            insertANewItemButton.Click += insertANewItemButton_Click;
            // 
            // updateASandwich
            // 
            updateASandwich.Location = new Point(76, 326);
            updateASandwich.Name = "updateASandwich";
            updateASandwich.Size = new Size(272, 126);
            updateASandwich.TabIndex = 2;
            updateASandwich.Text = "Update information";
            updateASandwich.UseVisualStyleBackColor = true;
            updateASandwich.Click += updateASandwich_Click;
            // 
            // allOrdersButton
            // 
            allOrdersButton.Location = new Point(76, 495);
            allOrdersButton.Name = "allOrdersButton";
            allOrdersButton.Size = new Size(272, 126);
            allOrdersButton.TabIndex = 3;
            allOrdersButton.Text = "All Orders";
            allOrdersButton.UseVisualStyleBackColor = true;
            allOrdersButton.Click += allOrdersButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(349, 84);
            label1.Name = "label1";
            label1.Size = new Size(383, 32);
            label1.TabIndex = 4;
            label1.Text = "Please select what you want to do!";
            // 
            // AdminWindow
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(998, 697);
            Controls.Add(label1);
            Controls.Add(allOrdersButton);
            Controls.Add(updateASandwich);
            Controls.Add(insertANewItemButton);
            Controls.Add(welcomeLabel);
            Name = "AdminWindow";
            Text = "AdminWindow";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeLabel;
        private Button insertANewItemButton;
        private Button updateASandwich;
        private Button allOrdersButton;
        private Label label1;
    }
}