using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp1
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
               private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string user = maskedTextBox1.Text.Trim();
            string pass = maskedTextBox2.Text;
            string role = maskedTextBox3.Text.Trim();

            if (user.ToLower() == "martina nabil" && pass == "12345" && role.ToLower() == "doctor")
            {
                if (checkBox1.Checked)
                {
                    Properties.Settings.Default.SavedUser = user;
                    Properties.Settings.Default.RememberMe = true;
                }
                else
                {
                    Properties.Settings.Default.SavedUser = "";
                    Properties.Settings.Default.RememberMe = false;
                }
                Properties.Settings.Default.Save();

                Dashboard mainDashboard = new Dashboard();
                mainDashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username, password or role.", "Login Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                maskedTextBox2.Clear();
                maskedTextBox2.Focus();
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
