﻿using Kupac.AdatbazisTablak;
using Kupac.DbContexts;
using Kupac.UI.Shared;
using Kupac.UI.Shared.BaseClasses;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Kupac
{
    public partial class CustomersEditorForm : BaseForm
    {
        private CustomerManager _customerManager;
        private const string defaultText = "Zadat hodnotu";
        private CustomDataGridView customerDataGridView;

        public CustomersEditorForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            _customerManager = new CustomerManager();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstName = nameTextbox.Text;
            string lastName = priezviskoTextBox.Text;
            string email = emailTextBox.Text;
            string mobilphone = mobilPhoneTextBox.Text;



            var customer = new Customer
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                MobilPhone = mobilphone
            };

            using (var context = new CapillarContext())
            {
                context.Customers.Add(customer);
                context.SaveChanges();

                MessageBox.Show("Uzivatel bol uspesne pridaný");
                _customerManager.LoadCustomersFromDatabase(context);
                var customers = context.Customers.ToList();

                customerDataGridView.DataSource = customers;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nameTextbox.Text = defaultText;
            nameTextbox.ForeColor = Color.Gray;
            priezviskoTextBox.Text = defaultText;
            priezviskoTextBox.ForeColor = Color.Gray;
            emailTextBox.Text = defaultText;
            emailTextBox.ForeColor = Color.Gray;
            mobilPhoneTextBox.Text = defaultText;
            mobilPhoneTextBox.ForeColor = Color.Gray;
            addressTextBox.Text = defaultText;
            addressTextBox.ForeColor = Color.Gray;
            cityTextBox.Text = defaultText;
            cityTextBox.ForeColor = Color.Gray;

            using (var context = new CapillarContext())
            {

                _customerManager.LoadCustomersFromDatabase(context);
                var customers = context.Customers.ToList();

                customerDataGridView.DataSource = customers;

                CustomizeColumns();
            }


        }

        private void nameTextbox_Enter(object sender, EventArgs e)
        {
            if (nameTextbox.Text == defaultText)
            {
                nameTextbox.ForeColor = Color.Black;
                nameTextbox.Text = "";

            }
        }

        private void nameTextbox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameTextbox.Text))
            {
                nameTextbox.Text = defaultText;
                nameTextbox.ForeColor = Color.Gray;
            }

        }

        private void priezviskoTextBox_Enter(object sender, EventArgs e)
        {
            if (priezviskoTextBox.Text == defaultText)
            {
                priezviskoTextBox.ForeColor = Color.Black;
                priezviskoTextBox.Text = "";

            }
        }

        private void priezviskoTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(priezviskoTextBox.Text))
            {
                priezviskoTextBox.Text = defaultText;
                priezviskoTextBox.ForeColor = Color.Gray;
            }
        }

        private void emailTextBox_Enter(object sender, EventArgs e)
        {
            if (emailTextBox.Text == defaultText)
            {
                emailTextBox.ForeColor = Color.Black;
                emailTextBox.Text = "";

            }
        }

        private void emailTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                emailTextBox.Text = defaultText;
                emailTextBox.ForeColor = Color.Gray;
            }
        }

        private void mobilPhoneTextBox_Enter(object sender, EventArgs e)
        {
            if (mobilPhoneTextBox.Text == defaultText)
            {
                mobilPhoneTextBox.ForeColor = Color.Black;
                mobilPhoneTextBox.Text = "";

            }
        }

        private void mobilPhoneTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(mobilPhoneTextBox.Text))
            {
                mobilPhoneTextBox.Text = defaultText;
                mobilPhoneTextBox.ForeColor = Color.Gray;
            }
        }

        private void addressTextBox_Enter(object sender, EventArgs e)
        {
            if (addressTextBox.Text == defaultText)
            {
                addressTextBox.ForeColor = Color.Black;
                addressTextBox.Text = "";

            }
        }

        private void addressTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(addressTextBox.Text))
            {
                addressTextBox.Text = defaultText;
                addressTextBox.ForeColor = Color.Gray;
            }
        }

        private void CityTextBox_Enter(object sender, EventArgs e)
        {
            if (cityTextBox.Text == defaultText)
            {
                cityTextBox.ForeColor = Color.Black;
                cityTextBox.Text = "";

            }
        }

        private void CityTextBox_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                cityTextBox.Text = defaultText;
                cityTextBox.ForeColor = Color.Gray;
            }
        }

        private void CustomizeColumns()
        {
            if (customerDataGridView.Columns["ID"] != null)
            {
                customerDataGridView.Columns["ID"].Visible = false; // Elrejti az ID-t
            }

            if (customerDataGridView.Columns["FirstName"] != null)
            {
                var firstNameColumn = customerDataGridView.Columns["FirstName"];
                firstNameColumn.HeaderText = "Keresztnév";
                firstNameColumn.MinimumWidth = GetHeaderTextWidth(firstNameColumn);
                firstNameColumn.Width = GetOptimalColumnWidth(firstNameColumn);
                firstNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            }

            if (customerDataGridView.Columns["LastName"] != null)
            {
                var lastNameColumn = customerDataGridView.Columns["LastName"];
                lastNameColumn.HeaderText = "Vezetéknév";
                lastNameColumn.MinimumWidth= GetHeaderTextWidth(lastNameColumn);
                lastNameColumn.Width = GetOptimalColumnWidth(lastNameColumn);
                lastNameColumn.AutoSizeMode= DataGridViewAutoSizeColumnMode.None;

            }

            if (customerDataGridView.Columns["Email"] != null)
            {
                customerDataGridView.Columns["Email"].HeaderText = "Email cím";
            }

            if (customerDataGridView.Columns["MobilPhone"] != null)
            {
                customerDataGridView.Columns["MobilPhone"].HeaderText = "Mobiltelefon";
            }
        }

        private int GetHeaderTextWidth(DataGridViewColumn column)
        {
            using (Graphics g = customerDataGridView.CreateGraphics())
            {
                SizeF textSize = g.MeasureString(column.HeaderText, customerDataGridView.Font);
                return (int)(textSize.Width * 1.5) + 10;
            }
        }

        private int GetOptimalColumnWidth(DataGridViewColumn column)
        {
            // Kiszámítja az optimális szélességet a fejléchez és az első néhány adat sorhoz igazítva
            using (Graphics g = customerDataGridView.CreateGraphics())
            {
                // Mérjük meg a fejléc szélességét
                SizeF headerSize = g.MeasureString(column.HeaderText, customerDataGridView.Font);

                // Vegyük figyelembe az első néhány cella szélességét is
                float maxWidth = headerSize.Width;

                foreach (DataGridViewRow row in customerDataGridView.Rows)
                {
                    if (row.Cells[column.Index].Value != null)
                    {
                        SizeF cellSize = g.MeasureString(row.Cells[column.Index].Value.ToString(), customerDataGridView.Font);
                        maxWidth = Math.Max(maxWidth, cellSize.Width);
                    }
                }

                var headerWidth = GetHeaderTextWidth(column);
                if (headerWidth > ((int)maxWidth + 20))
                {
                    return headerWidth;
                }
                // Biztonsági tartalék hozzáadása és kerekítés egész számra
                else
                {
                    return (int)maxWidth + 20;
                }
            }
        }

    }


}
