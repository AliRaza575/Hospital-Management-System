using System;
using System.Windows.Forms;

namespace SignInSignUpApplication_WindowsForm_
{
    public partial class Patient : Form
    {
        string userID;
        bool PatMenu = false;

        public Patient(string userID)
        {
            InitializeComponent();
            this.userID = userID;
            this.FormClosed += Patient_FormClosed;
        }

        private void Patient_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Patient_Load(object sender, EventArgs e)
        {
            ShowForms(new PatientDashboard());
        }

        private void btnAppointment_Click(object sender, EventArgs e)
        {
            ShowForms(new PatAppointment(userID));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }

        private void BtnBill_Click(object sender, EventArgs e)
        {
            ShowForms(new PatBill(userID));
        }

        private void btnPatAdd_Click(object sender, EventArgs e)
        {
            ShowForms(new AddPatDetails(userID));
        }

        private void btnPatView_Click(object sender, EventArgs e)
        {
            ShowForms(new View_Patient(userID));
        }

        private void btnPatUpdate_Click(object sender, EventArgs e)
        {
            ShowForms(new Update_Patient(userID));
        }

        private void btnPatDelete_Click(object sender, EventArgs e)
        {
          //  ShowForms(new PatDelete(int.Parse(userID)));
        }

        private void PatMenuExpand_Tick(object sender, EventArgs e)
        {
            if (PatMenu == false)
            {
                PatMenuContainer.Height += 10;
                if (PatMenuContainer.Height >= 390)
                {
                    PatMenuExpand.Stop();
                    PatMenu = true;
                }
            }
            else
            {
                PatMenuContainer.Height -= 10;
                if (PatMenuContainer.Height <= 78)
                {
                    PatMenuExpand.Stop();
                    PatMenu = false;
                }
            }
        }

        private void btnPat_Click(object sender, EventArgs e)
        {
            PatMenuExpand.Start();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowForms(new PatientDashboard());
        }

        private void ShowForms(Form form)
        {
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}
