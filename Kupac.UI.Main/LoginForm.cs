using Kupac.AdatbazisTablak;
using Kupac.Data.Properties;
using Kupac.DbContexts;
using Kupac.UI.Main.Properties;
using Kupac.UI.Shared.BaseClasses;
using System.Runtime.InteropServices;

namespace Kupac.UI.Main
{
    public partial class LoginForm : BaseForm
    {
        public string imagePath = Path.Combine(Application.StartupPath, "Resources", "human_icon.png");
        public LoginForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            pictureBox1.Image = Image.FromFile(imagePath);
            
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            if (Kupac.Data.Properties.Resources.human_icon != null)
            {
               
                pictureBox1.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show("Obr�zok sa nena�iel");
            }

#if DEBUG
            userNameTextBox.Text = "admin";
            passwordTextBox.Text = "admin";
#endif
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
                MessageBox.Show("Pros�m zadajte prihlasovacie meno!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(passwordTextBox.Text))
            {
                MessageBox.Show("Pros�m zadajte Va�e heslo!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                MessageBox.Show("Zl� prihlasovacie meno alebo heslo!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateLogin();
            }
        }
    }
}
