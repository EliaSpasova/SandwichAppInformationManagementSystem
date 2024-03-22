namespace SandwichesDatabaseManagementProject
{
    partial class loginForm
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
            usernameText = new TextBox();
            passwordTextbox = new TextBox();
            usernameLabel = new Label();
            passwordLabel = new Label();
            loginButton = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // usernameText
            // 
            usernameText.BackColor = SystemColors.ButtonHighlight;
            usernameText.Location = new Point(242, 235);
            usernameText.Name = "usernameText";
            usernameText.Size = new Size(218, 39);
            usernameText.TabIndex = 0;
            // 
            // passwordTextbox
            // 
            passwordTextbox.BackColor = SystemColors.ButtonHighlight;
            passwordTextbox.Location = new Point(242, 340);
            passwordTextbox.Name = "passwordTextbox";
            passwordTextbox.PasswordChar = '*';
            passwordTextbox.Size = new Size(218, 39);
            passwordTextbox.TabIndex = 1;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(242, 182);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(126, 32);
            usernameLabel.TabIndex = 2;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(242, 292);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(116, 32);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password:";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(342, 422);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(150, 46);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 22.125F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(242, 70);
            label1.Name = "label1";
            label1.Size = new Size(317, 78);
            label1.TabIndex = 5;
            label1.Text = "Welcome!";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.125F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(286, 9);
            label2.Name = "label2";
            label2.Size = new Size(206, 37);
            label2.TabIndex = 6;
            label2.Text = "Sandwiches App";
            // 
            // loginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(774, 529);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(loginButton);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(passwordTextbox);
            Controls.Add(usernameText);
            Name = "loginForm";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameText;
        private TextBox passwordTextbox;
        private Label usernameLabel;
        private Label passwordLabel;
        private Button loginButton;
        private Label label1;
        private Label label2;
    }
}