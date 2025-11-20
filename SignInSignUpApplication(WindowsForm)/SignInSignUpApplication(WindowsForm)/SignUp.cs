using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInSignUpApplication_WindowsForm_
{
    public partial class SignUpForm : Form
    {
        bool click = true;

        public SignUpForm()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;
            string role = guna2ComboBox1.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageBox.Show("All fields must be filled out.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BL.Register(username, password,role);
          //  DL.AddDetails();

            textBox1.Clear();
            textBox2.Clear();
            guna2ComboBox1.SelectedIndex = -1; 
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            if (click)
            {
                textBox2.UseSystemPasswordChar = false;
                click = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
                click = true;
            }
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {
            this.FormClosed += SignUpForm_FormClosed;
        }

        private void SignUpForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
