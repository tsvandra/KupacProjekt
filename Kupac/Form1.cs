using Kupac.AdatbazisTablak;
using Kupac.DbContexts;

namespace Kupac
{
    public partial class Form1 : Form
    {
        private CustomerManager _customerManager;
        private string defaultText = "Zadat hodnotu";

        public Form1()
        {
            InitializeComponent();
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

                textBox1.Text = _customerManager.ListCustomers();
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
    }
}
