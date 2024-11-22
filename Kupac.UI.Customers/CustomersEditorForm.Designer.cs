﻿using Kupac.UI.Shared;
using Kupac.UI.Shared.BaseClasses;
using Kupac.Resources;

namespace Kupac
{
    partial class CustomersEditorForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            customerDataGridView = new CustomDataGridView();
            customerManagerBindingSource1 = new BindingSource(components);
            customerManagerBindingSource = new BindingSource(components);
            addNewCustomerButton = new Button();
            loadingPictureBox = new PictureBox();
            deleteCustomerButton = new Button();
            ((System.ComponentModel.ISupportInitialize)customerDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerManagerBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerManagerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loadingPictureBox).BeginInit();
            SuspendLayout();
            // 
            // customerDataGridView
            // 
            customerDataGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240);
            customerDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            customerDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customerDataGridView.BorderStyle = BorderStyle.None;
            customerDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            customerDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(58, 68, 90);
            dataGridViewCellStyle2.Font = new Font("Arial", 12F, FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            customerDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            customerDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerDataGridView.EnableHeadersVisualStyles = false;
            customerDataGridView.GridColor = Color.LightGray;
            customerDataGridView.Location = new Point(49, 53);
            customerDataGridView.MultiSelect = false;
            customerDataGridView.Name = "customerDataGridView";
            customerDataGridView.ReadOnly = true;
            customerDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = Color.White;
            customerDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            customerDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customerDataGridView.Size = new Size(1020, 493);
            customerDataGridView.TabIndex = 21;
            customerDataGridView.CellDoubleClick += customerDataGridView_CellDoubleClick;
            // 
            // customerManagerBindingSource1
            // 
            customerManagerBindingSource1.DataSource = typeof(AdatbazisTablak.CustomerManager);
            // 
            // customerManagerBindingSource
            // 
            customerManagerBindingSource.DataSource = typeof(AdatbazisTablak.CustomerManager);
            // 
            // addNewCustomerButton
            // 
            addNewCustomerButton.BackColor = Color.Plum;
            addNewCustomerButton.Cursor = Cursors.Hand;
            addNewCustomerButton.FlatAppearance.BorderSize = 0;
            addNewCustomerButton.ForeColor = Color.White;
            addNewCustomerButton.Location = new Point(49, 15);
            addNewCustomerButton.Margin = new Padding(2, 1, 2, 1);
            addNewCustomerButton.Name = "addNewCustomerButton";
            addNewCustomerButton.Size = new Size(131, 25);
            addNewCustomerButton.TabIndex = 22;
            addNewCustomerButton.Text = "Új ügyfél";
            addNewCustomerButton.UseVisualStyleBackColor = false;
            addNewCustomerButton.Click += addNewCustomerButton_Click;
            // 
            // loadingPictureBox
            // 
            loadingPictureBox.Location = new Point(543, 238);
            loadingPictureBox.Name = "loadingPictureBox";
            loadingPictureBox.Size = new Size(140, 21);
            loadingPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            loadingPictureBox.TabIndex = 23;
            loadingPictureBox.TabStop = false;
            loadingPictureBox.Visible = false;
            // 
            // deleteCustomerButton
            // 
            deleteCustomerButton.BackColor = Color.Plum;
            deleteCustomerButton.Cursor = Cursors.Hand;
            deleteCustomerButton.FlatAppearance.BorderSize = 0;
            deleteCustomerButton.ForeColor = Color.White;
            deleteCustomerButton.Location = new Point(203, 15);
            deleteCustomerButton.Margin = new Padding(2, 1, 2, 1);
            deleteCustomerButton.Name = "deleteCustomerButton";
            deleteCustomerButton.Size = new Size(131, 25);
            deleteCustomerButton.TabIndex = 24;
            deleteCustomerButton.Text = "ügyfél törlése";
            deleteCustomerButton.UseVisualStyleBackColor = false;
            deleteCustomerButton.Click += deleteCustomerButton_Click;
            // 
            // CustomersEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1249, 584);
            Controls.Add(deleteCustomerButton);
            Controls.Add(loadingPictureBox);
            Controls.Add(addNewCustomerButton);
            Controls.Add(customerDataGridView);
            Margin = new Padding(2, 1, 2, 1);
            Name = "CustomersEditorForm";
            Text = "Form1";
            Load += CustomerEditorForm_Load;
            ((System.ComponentModel.ISupportInitialize)customerDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerManagerBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerManagerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)loadingPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private BindingSource customerManagerBindingSource1;
        private BindingSource customerManagerBindingSource;
        private Button addNewCustomerButton;
        private PictureBox loadingPictureBox;
        private Button deleteCustomerButton;
        //private CustomDataGridView customerDataGridView;
    }
}
