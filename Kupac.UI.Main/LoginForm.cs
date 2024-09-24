using Kupac.AdatbazisTablak;
using Kupac.Data.Properties;
using Kupac.DbContexts;
using Kupac.UI.Main.Properties;
using Kupac.UI.Main.BaseClasses;
using System.Runtime.InteropServices;

namespace Kupac.UI.Main
{
    public partial class LoginForm : BaseForm
    {

        public LoginForm()
        {
            InitializeComponent();

            pictureBox1.InitialImage = Kupac.Data.Properties.Resources.human_icon;
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            //pictureBox1.Left = (this.ClientSize.Width - pictureBox1.Width) / 2;
            //pictureBox1.Top = ((this.ClientSize.Height - pictureBox1.Height) / 2) - 50;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (Kupac.Data.Properties.Resources.human_icon != null)
            {
                pictureBox1.Image = Kupac.Data.Properties.Resources.human_icon;
            }
            else
            {
                MessageBox.Show("Obrázok sa nenašiel");
            }
        }
        // Cancel button
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            ValidateLogin();
        }

        private void ValidateLogin()
        {
            if (string.IsNullOrEmpty(userNameTextBox.Text))
            {
                MessageBox.Show("Prosím zadajte prihlasovacie meno!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Prosím zadajte Vaše heslo!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (IsValidUser(userNameTextBox.Text, passwordTextBox.Text))
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Zlé prihlasovacie meno alebo heslo!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidUser(string username, string password)
        {
            if (username == "admin" && password == "admin")
            {
                return true;
            }

            return false;
        }
    }
}
