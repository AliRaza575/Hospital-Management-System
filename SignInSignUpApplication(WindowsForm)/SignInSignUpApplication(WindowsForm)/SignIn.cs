using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Windows.Forms;

namespace SignInSignUpApplication_WindowsForm_
{
    public partial class SignIn : Form
    {
        bool click= true;

        public SignIn()
        {
            InitializeComponent();
            textBox2.UseSystemPasswordChar = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            string userID = BL.SignIn(username, password);
            if (userID != null)
            {
                string userRole = BL.GetUserRole(userID);

                if (userRole == "Admin")
                {
                    MessageBox.Show("Signin Successful as Admin");
                    Main adminForm = new Main();
                    adminForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Access Denied. Only Admins are allowed.");
                }
            }
            else
            {
                MessageBox.Show("Username or Password is Incorrect");
            }
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

        private void SignIn_Load(object sender, EventArgs e)
        {
            this.FormClosed += SignIn_FormClosed;
        }

        private void SignIn_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
