using Kupac.Data.Properties;
using Kupac.UI.Main.Properties;

namespace Kupac.UI.Main
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            pictureBox1.InitialImage = Kupac.Data.Properties.Resources.human_icon;
        }

        private void Form1_Load(object sender, EventArgs e)
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
                MessageBox.Show("A kép nem található");
            }
        }
    }
}
