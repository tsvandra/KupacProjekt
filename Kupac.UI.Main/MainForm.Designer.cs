namespace Kupac.UI.Main
{
    partial class MainForm
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
            mainPanel = new TableLayoutPanel();
            userPictureBox = new PictureBox();
            navigationPanel = new TableLayoutPanel();
            dashboardButton = new Button();
            mainFunctionPanel = new TableLayoutPanel();
            mainInformationPanel = new Panel();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).BeginInit();
            navigationPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.ColumnCount = 2;
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.0540543F));
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.9459457F));
            mainPanel.Controls.Add(userPictureBox, 0, 0);
            mainPanel.Controls.Add(navigationPanel, 0, 1);
            mainPanel.Controls.Add(mainFunctionPanel, 1, 0);
            mainPanel.Controls.Add(mainInformationPanel, 1, 1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(10, 15);
            mainPanel.Name = "mainPanel";
            mainPanel.RowCount = 3;
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 23.2167835F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 76.78322F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 61F));
            mainPanel.Size = new Size(1480, 736);
            mainPanel.TabIndex = 1;
            // 
            // userPictureBox
            // 
            userPictureBox.Dock = DockStyle.Fill;
            userPictureBox.Location = new Point(3, 3);
            userPictureBox.Name = "userPictureBox";
            userPictureBox.Size = new Size(202, 150);
            userPictureBox.TabIndex = 2;
            userPictureBox.TabStop = false;
            // 
            // navigationPanel
            // 
            navigationPanel.ColumnCount = 1;
            navigationPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            navigationPanel.Controls.Add(dashboardButton, 0, 0);
            navigationPanel.Location = new Point(3, 159);
            navigationPanel.Name = "navigationPanel";
            navigationPanel.RowCount = 3;
            navigationPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            navigationPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            navigationPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            navigationPanel.Size = new Size(200, 512);
            navigationPanel.TabIndex = 0;
            // 
            // dashboardButton
            // 
            dashboardButton.BackColor = Color.MistyRose;
            dashboardButton.Cursor = Cursors.Hand;
            dashboardButton.Dock = DockStyle.Top;
            dashboardButton.FlatAppearance.BorderSize = 0;
            dashboardButton.FlatAppearance.MouseDownBackColor = Color.LavenderBlush;
            dashboardButton.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            dashboardButton.FlatStyle = FlatStyle.Flat;
            dashboardButton.Location = new Point(2, 1);
            dashboardButton.Margin = new Padding(2, 1, 2, 1);
            dashboardButton.Name = "dashboardButton";
            dashboardButton.Size = new Size(196, 27);
            dashboardButton.TabIndex = 4;
            dashboardButton.Text = "Dashboard";
            dashboardButton.UseVisualStyleBackColor = false;
            dashboardButton.Click += loginButton_Click;
            // 
            // mainFunctionPanel
            // 
            mainFunctionPanel.BackColor = Color.LightCoral;
            mainFunctionPanel.ColumnCount = 1;
            mainFunctionPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainFunctionPanel.Dock = DockStyle.Fill;
            mainFunctionPanel.Location = new Point(211, 3);
            mainFunctionPanel.Name = "mainFunctionPanel";
            mainFunctionPanel.RowCount = 2;
            mainFunctionPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.625F));
            mainFunctionPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 84.375F));
            mainFunctionPanel.Size = new Size(1266, 150);
            mainFunctionPanel.TabIndex = 1;
            // 
            // mainInformationPanel
            // 
            mainInformationPanel.Dock = DockStyle.Fill;
            mainInformationPanel.Location = new Point(211, 159);
            mainInformationPanel.Name = "mainInformationPanel";
            mainInformationPanel.Size = new Size(1266, 512);
            mainInformationPanel.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1500, 761);
            Controls.Add(mainPanel);
            Location = new Point(0, 0);
            Name = "MainForm";
            Padding = new Padding(10, 15, 10, 10);
            Text = "MainForm";
            mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)userPictureBox).EndInit();
            navigationPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainPanel;
        private TableLayoutPanel navigationPanel;
        private PictureBox userPictureBox;
        private TableLayoutPanel mainFunctionPanel;
        private Button dashboardButton;
        private Panel mainInformationPanel;
    }
}