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
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 445);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(1211, 285);
            textBox1.TabIndex = 1;
            // 
            // menoLabel
            // 
            menoLabel.AutoSize = true;
            menoLabel.Location = new Point(113, 157);
            menoLabel.Name = "menoLabel";
            menoLabel.Size = new Size(77, 32);
            menoLabel.TabIndex = 2;
            menoLabel.Text = "Meno";
            // 
            // priezviskoLabel
            // 
            priezviskoLabel.AutoSize = true;
            priezviskoLabel.Location = new Point(113, 228);
            priezviskoLabel.Name = "priezviskoLabel";
            priezviskoLabel.Size = new Size(119, 32);
            priezviskoLabel.TabIndex = 3;
            priezviskoLabel.Text = "Priezvisko";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(113, 298);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(71, 32);
            EmailLabel.TabIndex = 4;
            EmailLabel.Text = "Email";
            // 
            // nameTextbox
            // 
            nameTextbox.Location = new Point(250, 157);
            nameTextbox.Name = "nameTextbox";
            nameTextbox.Size = new Size(200, 39);
            nameTextbox.TabIndex = 5;
            nameTextbox.Enter += nameTextbox_Enter;
            nameTextbox.Leave += nameTextbox_Leave;
            // 
            // priezviskoTextBox
            // 
            priezviskoTextBox.Location = new Point(250, 228);
            priezviskoTextBox.Name = "priezviskoTextBox";
            priezviskoTextBox.Size = new Size(200, 39);
            priezviskoTextBox.TabIndex = 6;
            priezviskoTextBox.Enter += priezviskoTextBox_Enter;
            priezviskoTextBox.Leave += priezviskoTextBox_Leave;
            // 
            // emailTextBox
            // 
            emailTextBox.Location = new Point(250, 298);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(200, 39);
            emailTextBox.TabIndex = 7;
            emailTextBox.Enter += emailTextBox_Enter;
            emailTextBox.Leave += emailTextBox_Leave;
            // 
            // mobilPhoneLabel
            // 
            mobilPhoneLabel.AutoSize = true;
            mobilPhoneLabel.Location = new Point(574, 157);
            mobilPhoneLabel.Name = "mobilPhoneLabel";
            mobilPhoneLabel.Size = new Size(72, 32);
            mobilPhoneLabel.TabIndex = 8;
            mobilPhoneLabel.Text = "Tel. č.";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new Point(574, 228);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new Size(86, 32);
            addressLabel.TabIndex = 9;
            addressLabel.Text = "Adresa";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new Point(574, 298);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new Size(81, 32);
            cityLabel.TabIndex = 10;
            cityLabel.Text = "Mesto";
            // 
            // mobilPhoneTextBox
            // 
            mobilPhoneTextBox.Location = new Point(701, 157);
            mobilPhoneTextBox.Name = "mobilPhoneTextBox";
            mobilPhoneTextBox.Size = new Size(200, 39);
            mobilPhoneTextBox.TabIndex = 11;
            mobilPhoneTextBox.Enter += mobilPhoneTextBox_Enter;
            mobilPhoneTextBox.Leave += mobilPhoneTextBox_Leave;
            // 
            // addressTextBox
            // 
            addressTextBox.Location = new Point(701, 228);
            addressTextBox.Name = "addressTextBox";
            addressTextBox.Size = new Size(200, 39);
            addressTextBox.TabIndex = 12;
            addressTextBox.Enter += addressTextBox_Enter;
            addressTextBox.Leave += addressTextBox_Leave;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(701, 298);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(200, 39);
            cityTextBox.TabIndex = 13;
            cityTextBox.Enter += CityTextBox_Enter;
            cityTextBox.Leave += CityTextBox_Leave;
            // 
            // postalCodeLabel
            // 
            postalCodeLabel.AutoSize = true;
            postalCodeLabel.Location = new Point(980, 157);
            postalCodeLabel.Name = "postalCodeLabel";
            postalCodeLabel.Size = new Size(55, 32);
            postalCodeLabel.TabIndex = 14;
            postalCodeLabel.Text = "PSČ";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new Point(980, 228);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new Size(54, 32);
            stateLabel.TabIndex = 15;
            stateLabel.Text = "Štát";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new Point(980, 298);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new Size(89, 32);
            phoneLabel.TabIndex = 16;
            phoneLabel.Text = "Mobil2";
            // 
            // postalCodeTextBox
            // 
            postalCodeTextBox.Location = new Point(1120, 157);
            postalCodeTextBox.Name = "postalCodeTextBox";
            postalCodeTextBox.Size = new Size(200, 39);
            postalCodeTextBox.TabIndex = 17;
            // 
            // stateTextBox
            // 
            stateTextBox.Location = new Point(1120, 228);
            stateTextBox.Name = "stateTextBox";
            stateTextBox.Size = new Size(200, 39);
            stateTextBox.TabIndex = 18;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(1120, 298);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(200, 39);
            phoneTextBox.TabIndex = 19;
            // 
            // button1
            // 
            button1.BackColor = Color.Plum;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.ForeColor = Color.White;
            button1.Location = new Point(109, 371);
            button1.Name = "button1";
            button1.Size = new Size(243, 46);
            button1.TabIndex = 0;
            button1.Text = "Listázz";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1460, 910);
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
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
    }
}
