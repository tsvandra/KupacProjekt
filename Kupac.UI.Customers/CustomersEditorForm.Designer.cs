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
            textBox1 = new TextBox();
            menoLabel = new Label();
            priezviskoLabel = new Label();
            EmailLabel = new Label();
            nameTextbox = new TextBox();
            priezviskoTextBox = new TextBox();
            emailTextBox = new TextBox();
            mobilPhoneLabel = new Label();
            addressLabel = new Label();
            cityLabel = new Label();
            mobilPhoneTextBox = new TextBox();
            addressTextBox = new TextBox();
            cityTextBox = new TextBox();
            postalCodeLabel = new Label();
            stateLabel = new Label();
            phoneLabel = new Label();
            postalCodeTextBox = new TextBox();
            stateTextBox = new TextBox();
            phoneTextBox = new TextBox();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            customerManagerBindingSource = new BindingSource(components);
            customerManagerBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerManagerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerManagerBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(59, 209);
            textBox1.Margin = new Padding(2, 1, 2, 1);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(654, 136);
            textBox1.TabIndex = 1;
            // 
            // menoLabel
            // 
            menoLabel.AutoSize = true;
            menoLabel.Location = new Point(61, 74);
            menoLabel.Margin = new Padding(2, 0, 2, 0);
            menoLabel.Name = "menoLabel";
            menoLabel.Size = new Size(38, 15);
            menoLabel.TabIndex = 2;
            menoLabel.Text = "Meno";
            // 
            // priezviskoLabel
            // 
            priezviskoLabel.AutoSize = true;
            priezviskoLabel.Location = new Point(61, 107);
            priezviskoLabel.Margin = new Padding(2, 0, 2, 0);
            priezviskoLabel.Name = "priezviskoLabel";
            priezviskoLabel.Size = new Size(59, 15);
            priezviskoLabel.TabIndex = 3;
            priezviskoLabel.Text = "Priezvisko";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(61, 140);
            EmailLabel.Margin = new Padding(2, 0, 2, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(36, 15);
            EmailLabel.TabIndex = 4;
            EmailLabel.Text = "Email";
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(135, 74);
            nameTextbox.Margin = new Padding(2, 1, 2, 1);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(110, 23);
            nameTextbox.TabIndex = 5;
            nameTextbox.Enter += nameTextbox_Enter;
            nameTextbox.Leave += nameTextbox_Leave;
            // 
            // priezviskoTextBox
            // 
            priezviskoTextBox.Location = new Point(135, 107);
            priezviskoTextBox.Margin = new Padding(2, 1, 2, 1);
            priezviskoTextBox.Name = "priezviskoTextBox";
            priezviskoTextBox.Size = new Size(110, 23);
            priezviskoTextBox.TabIndex = 6;
            priezviskoTextBox.Enter += priezviskoTextBox_Enter;
            priezviskoTextBox.Leave += priezviskoTextBox_Leave;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(135, 140);
            emailTextBox.Margin = new Padding(2, 1, 2, 1);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(110, 23);
            emailTextBox.TabIndex = 7;
            emailTextBox.Enter += emailTextBox_Enter;
            emailTextBox.Leave += emailTextBox_Leave;
            // 
            // mobilPhoneLabel
            // 
            mobilPhoneLabel.AutoSize = true;
            mobilPhoneLabel.Location = new Point(309, 74);
            mobilPhoneLabel.Margin = new Padding(2, 0, 2, 0);
            mobilPhoneLabel.Name = "mobilPhoneLabel";
            mobilPhoneLabel.Size = new Size(36, 15);
            mobilPhoneLabel.TabIndex = 8;
            mobilPhoneLabel.Text = "Tel. č.";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(309, 107);
            addressLabel.Margin = new Padding(2, 0, 2, 0);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(43, 15);
            addressLabel.TabIndex = 9;
            addressLabel.Text = "Adresa";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(309, 140);
            cityLabel.Margin = new Padding(2, 0, 2, 0);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(40, 15);
            cityLabel.TabIndex = 10;
            cityLabel.Text = "Mesto";
            // 
            // mobilPhoneTextBox
            // 
            mobilPhoneTextBox.Location = new Point(377, 74);
            mobilPhoneTextBox.Margin = new Padding(2, 1, 2, 1);
            mobilPhoneTextBox.Name = "mobilPhoneTextBox";
            mobilPhoneTextBox.Size = new Size(110, 23);
            mobilPhoneTextBox.TabIndex = 11;
            mobilPhoneTextBox.Enter += mobilPhoneTextBox_Enter;
            mobilPhoneTextBox.Leave += mobilPhoneTextBox_Leave;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(377, 107);
            addressTextBox.Margin = new Padding(2, 1, 2, 1);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(110, 23);
            addressTextBox.TabIndex = 12;
            addressTextBox.Enter += addressTextBox_Enter;
            addressTextBox.Leave += addressTextBox_Leave;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(377, 140);
            cityTextBox.Margin = new Padding(2, 1, 2, 1);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(110, 23);
            cityTextBox.TabIndex = 13;
            cityTextBox.Enter += CityTextBox_Enter;
            cityTextBox.Leave += CityTextBox_Leave;
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new Point(528, 74);
            postalCodeLabel.Margin = new Padding(2, 0, 2, 0);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new Size(28, 15);
            postalCodeLabel.TabIndex = 14;
            postalCodeLabel.Text = "PSČ";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new Point(528, 107);
            stateLabel.Margin = new Padding(2, 0, 2, 0);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(27, 15);
            stateLabel.TabIndex = 15;
            stateLabel.Text = "Štát";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(528, 140);
            phoneLabel.Margin = new Padding(2, 0, 2, 0);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(44, 15);
            phoneLabel.TabIndex = 16;
            phoneLabel.Text = "Mobil2";
            // 
            // postalCodeTextBox
            // 
            postalCodeTextBox.Location = new Point(603, 74);
            postalCodeTextBox.Margin = new Padding(2, 1, 2, 1);
            postalCodeTextBox.Name = "postalCodeTextBox";
            postalCodeTextBox.Size = new Size(110, 23);
            postalCodeTextBox.TabIndex = 17;
            // 
            // stateTextBox
            // 
            stateTextBox.Location = new Point(603, 107);
            stateTextBox.Margin = new Padding(2, 1, 2, 1);
            stateTextBox.Name = "stateTextBox";
            stateTextBox.Size = new Size(110, 23);
            stateTextBox.TabIndex = 18;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(603, 140);
            phoneTextBox.Margin = new Padding(2, 1, 2, 1);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(110, 23);
            phoneTextBox.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = Color.Plum;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = Color.White;
            button1.Location = new Point(59, 174);
            button1.Margin = new Padding(2, 1, 2, 1);
            button1.Name = "button1";
            button1.Size = new Size(131, 22);
            button1.TabIndex = 0;
            button1.Text = "Listázz";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.DataSource = customerManagerBindingSource1;
            dataGridView1.Location = new Point(738, 166);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(368, 249);
            dataGridView1.TabIndex = 20;
            // 
            // customerManagerBindingSource
            // 
            customerManagerBindingSource.DataSource = typeof(AdatbazisTablak.CustomerManager);
            // 
            // customerManagerBindingSource1
            // 
            customerManagerBindingSource1.DataSource = typeof(AdatbazisTablak.CustomerManager);
            // 
            // CustomersEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(1249, 584);
            Controls.Add(dataGridView1);
            Controls.Add(phoneTextBox);
            Controls.Add(stateTextBox);
            Controls.Add(postalCodeTextBox);
            Controls.Add(phoneLabel);
            Controls.Add(stateLabel);
            Controls.Add(postalCodeLabel);
            Controls.Add(cityTextBox);
            Controls.Add(addressTextBox);
            Controls.Add(mobilPhoneTextBox);
            Controls.Add(cityLabel);
            Controls.Add(addressLabel);
            Controls.Add(mobilPhoneLabel);
            Controls.Add(emailTextBox);
            Controls.Add(priezviskoTextBox);
            Controls.Add(nameTextbox);
            Controls.Add(EmailLabel);
            Controls.Add(priezviskoLabel);
            Controls.Add(menoLabel);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "CustomersEditorForm";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerManagerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerManagerBindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox1;
        private Label menoLabel;
        private Label priezviskoLabel;
        private Label EmailLabel;
        private TextBox nameTextbox;
        private TextBox priezviskoTextBox;
        private TextBox emailTextBox;
        private Label mobilPhoneLabel;
        private Label addressLabel;
        private Label cityLabel;
        private TextBox mobilPhoneTextBox;
        private TextBox addressTextBox;
        private TextBox cityTextBox;
        private Label postalCodeLabel;
        private Label stateLabel;
        private Label phoneLabel;
        private TextBox postalCodeTextBox;
        private TextBox stateTextBox;
        private TextBox phoneTextBox;
        private Button button1;
        private DataGridView dataGridView1;
        private BindingSource customerManagerBindingSource1;
        private BindingSource customerManagerBindingSource;
    }
}
