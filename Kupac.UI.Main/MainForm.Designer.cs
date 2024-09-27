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
            navigationTablePanel = new TableLayoutPanel();
            navigationalPanel = new Panel();
            customersButton = new Button();
            dashBoardButton = new Button();
            ordersButton = new Button();
            mainFunctionPanel = new TableLayoutPanel();
            mainInformationPanel = new Panel();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)userPictureBox).BeginInit();
            navigationTablePanel.SuspendLayout();
            navigationalPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.ColumnCount = 2;
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainPanel.Controls.Add(userPictureBox, 0, 0);
            mainPanel.Controls.Add(navigationTablePanel, 0, 1);
            mainPanel.Controls.Add(mainFunctionPanel, 1, 0);
            mainPanel.Controls.Add(mainInformationPanel, 1, 1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(10, 15);
            mainPanel.Margin = new Padding(0);
            mainPanel.Name = "mainPanel";
            mainPanel.RowCount = 3;
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 200F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            mainPanel.Size = new Size(1480, 736);
            mainPanel.TabIndex = 1;
            // 
            // userPictureBox
            // 
            userPictureBox.Dock = DockStyle.Fill;
            userPictureBox.Image = Properties.Resource1.kinga_200x200;
            userPictureBox.InitialImage = Properties.Resource1.kinga_200x200;
            userPictureBox.Location = new Point(0, 0);
            userPictureBox.Margin = new Padding(0);
            userPictureBox.Name = "userPictureBox";
            userPictureBox.Size = new Size(200, 200);
            userPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            userPictureBox.TabIndex = 2;
            userPictureBox.TabStop = false;
            // 
            // navigationTablePanel
            // 
            navigationTablePanel.ColumnCount = 1;
            navigationTablePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 200F));
            navigationTablePanel.Controls.Add(navigationalPanel, 0, 0);
            navigationTablePanel.Dock = DockStyle.Fill;
            navigationTablePanel.Location = new Point(0, 203);
            navigationTablePanel.Margin = new Padding(0, 3, 0, 0);
            navigationTablePanel.Name = "navigationTablePanel";
            navigationTablePanel.RowCount = 3;
            navigationTablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 300F));
            navigationTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            navigationTablePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            navigationTablePanel.Size = new Size(200, 425);
            navigationTablePanel.TabIndex = 0;
            // 
            // navigationalPanel
            // 
            navigationalPanel.Controls.Add(customersButton);
            navigationalPanel.Controls.Add(dashBoardButton);
            navigationalPanel.Controls.Add(ordersButton);
            navigationalPanel.Dock = DockStyle.Fill;
            navigationalPanel.Location = new Point(0, 0);
            navigationalPanel.Margin = new Padding(0);
            navigationalPanel.Name = "navigationalPanel";
            navigationalPanel.Size = new Size(200, 300);
            navigationalPanel.TabIndex = 0;
            // 
            // customersButton
            // 
            customersButton.BackColor = Color.SeaShell;
            customersButton.Cursor = Cursors.Hand;
            customersButton.FlatAppearance.BorderSize = 0;
            customersButton.FlatAppearance.MouseDownBackColor = Color.LavenderBlush;
            customersButton.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            customersButton.FlatStyle = FlatStyle.Flat;
            customersButton.Location = new Point(0, 54);
            customersButton.Margin = new Padding(0);
            customersButton.Name = "customersButton";
            customersButton.Size = new Size(200, 27);
            customersButton.TabIndex = 8;
            customersButton.Text = "Zákazníci";
            customersButton.UseVisualStyleBackColor = false;
            customersButton.Click += customersButton_Click;
            // 
            // dashBoardButton
            // 
            dashBoardButton.BackColor = Color.SeaShell;
            dashBoardButton.Cursor = Cursors.Hand;
            dashBoardButton.FlatAppearance.BorderSize = 0;
            dashBoardButton.FlatAppearance.MouseDownBackColor = Color.LavenderBlush;
            dashBoardButton.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            dashBoardButton.FlatStyle = FlatStyle.Flat;
            dashBoardButton.Location = new Point(0, 0);
            dashBoardButton.Margin = new Padding(0);
            dashBoardButton.Name = "dashBoardButton";
            dashBoardButton.Size = new Size(200, 27);
            dashBoardButton.TabIndex = 7;
            dashBoardButton.Text = "Dashboard";
            dashBoardButton.UseVisualStyleBackColor = false;
            dashBoardButton.Click += dashBoardButton_Click;
            // 
            // ordersButton
            // 
            ordersButton.BackColor = Color.SeaShell;
            ordersButton.Cursor = Cursors.Hand;
            ordersButton.FlatAppearance.BorderSize = 0;
            ordersButton.FlatAppearance.MouseDownBackColor = Color.LavenderBlush;
            ordersButton.FlatAppearance.MouseOverBackColor = Color.SeaShell;
            ordersButton.FlatStyle = FlatStyle.Flat;
            ordersButton.Location = new Point(0, 27);
            ordersButton.Margin = new Padding(0);
            ordersButton.Name = "ordersButton";
            ordersButton.Size = new Size(200, 27);
            ordersButton.TabIndex = 6;
            ordersButton.Text = "Objednávky";
            ordersButton.UseVisualStyleBackColor = false;
            // 
            // mainFunctionPanel
            // 
            mainFunctionPanel.BackColor = Color.Thistle;
            mainFunctionPanel.ColumnCount = 1;
            mainFunctionPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainFunctionPanel.Dock = DockStyle.Fill;
            mainFunctionPanel.Location = new Point(203, 3);
            mainFunctionPanel.Name = "mainFunctionPanel";
            mainFunctionPanel.RowCount = 2;
            mainFunctionPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 15.625F));
            mainFunctionPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 84.375F));
            mainFunctionPanel.Size = new Size(1274, 194);
            mainFunctionPanel.TabIndex = 1;
            // 
            // mainInformationPanel
            // 
            mainInformationPanel.Dock = DockStyle.Fill;
            mainInformationPanel.Location = new Point(200, 203);
            mainInformationPanel.Margin = new Padding(0, 3, 0, 0);
            mainInformationPanel.Name = "mainInformationPanel";
            mainInformationPanel.Size = new Size(1280, 425);
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
            navigationTablePanel.ResumeLayout(false);
            navigationalPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainPanel;
        private TableLayoutPanel navigationTablePanel;
        private PictureBox userPictureBox;
        private TableLayoutPanel mainFunctionPanel;
        private Panel mainInformationPanel;
        private Panel navigationalPanel;
        private Button customersButton;
        private Button dashBoardButton;
        private Button ordersButton;
    }
}