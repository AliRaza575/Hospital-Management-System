using System;
using System.Windows.Forms;

namespace SignInSignUpApplication_WindowsForm_
{
    public partial class Doctor : Form
    {
        private string userID;
        bool DocMenu = false;

        public Doctor(string id)
        {
            InitializeComponent();
            userID = id;
            this.FormClosed += Doctor_FormClosed;
        }

        private void Doctor_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            ShowForms(new DocAppointment(userID));
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            ShowForms(new DocSalary(userID));
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowForms(new DocDashboard());
        }

        private void Doctor_Load(object sender, EventArgs e)
        {
            ShowForms(new DocDashboard());
        }

        private void btnDocAdd_Click(object sender, EventArgs e)
        {
            ShowForms(new AddDocDetails(userID));
        }

        private void btnDocView_Click(object sender, EventArgs e)
        {
            ShowForms(new View_Doctor(int.Parse(userID)));
        }

        private void btnDocUpdate_Click(object sender, EventArgs e)
        {
            ShowForms(new Update_Doctor(userID));
        }

        private void btnDocDelete_Click(object sender, EventArgs e)
        {
            ShowForms(new DocDelete(int.Parse(userID)));
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            DocMenuExpand.Start();
        }

        private void DocMenuExpand_Tick(object sender, EventArgs e)
        {
            if (DocMenu == false)
            {
                DocMenuContainer.Height += 10;
                if (DocMenuContainer.Height >= 390)
                {
                    DocMenuExpand.Stop();
                    DocMenu = true;
                }
            }
            else
            {
                DocMenuContainer.Height -= 10;
                if (DocMenuContainer.Height <= 78)
                {
                    DocMenuExpand.Stop();
                    DocMenu = false;
                }
            }
        }

        private void ShowForms(Form form)
        {
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}
