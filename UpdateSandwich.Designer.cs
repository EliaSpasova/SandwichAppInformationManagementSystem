namespace SandwichesDatabaseManagementProject
{
    partial class UpdateSandwich
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
            dataGridView12 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView12).BeginInit();
            SuspendLayout();
            // 
            // dataGridView12
            // 
            dataGridView12.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView12.Location = new Point(31, 243);
            dataGridView12.Name = "dataGridView12";
            dataGridView12.RowHeadersWidth = 82;
            dataGridView12.RowTemplate.Height = 41;
            dataGridView12.Size = new Size(938, 396);
            dataGridView12.TabIndex = 0;
            dataGridView12.CellContentClick += dataGridView12_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.125F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(251, 203);
            label1.Name = "label1";
            label1.Size = new Size(524, 37);
            label1.TabIndex = 1;
            label1.Text = "Click on a sandwich to update its properties";
            // 
            // button1
            // 
            button1.Location = new Point(371, 129);
            button1.Name = "button1";
            button1.Size = new Size(255, 71);
            button1.TabIndex = 2;
            button1.Text = "View All";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // UpdateSandwich
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(998, 697);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView12);
            Name = "UpdateSandwich";
            Text = "UpdateSandwich";
            ((System.ComponentModel.ISupportInitialize)dataGridView12).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView12;
        private Label label1;
        private Button button1;
    }
}