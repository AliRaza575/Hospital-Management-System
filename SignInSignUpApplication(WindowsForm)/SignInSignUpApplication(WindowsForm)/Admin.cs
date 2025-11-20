using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Windows.Forms;

namespace SignInSignUpApplication_WindowsForm_
{
    public partial class Admin : Form
    {
        bool flag = true;
        bool billxpand = false;
        bool medepand=false;
        
        public Admin()
        {
            InitializeComponent();
            this.FormClosed += Admin_FormClosed;
        }
      

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnDoc_Click(object sender, EventArgs e)
        {
            DocMenuExpand.Start();
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            ShowForms(new Dashboard());
        }

        bool DocMenu = false;
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

        bool PatMenu = false;

        private void btnPat_Click_1(object sender, EventArgs e)
        {
            PatMenuExpand.Start();
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

        private void btnPatAdd_Click(object sender, EventArgs e)
        {
            ShowForms(new AddPatDetails());
        }

        private void btnPatDelete_Click(object sender, EventArgs e)
        {
            ShowForms(new PatDelete(!flag));
        }

        private void btnPatUpdate_Click(object sender, EventArgs e)
        {
            ShowForms(new Update_Patient());
        }

        private void btnPatView_Click(object sender, EventArgs e)
        {
            ShowForms(new View_Patient());
        }

        private void btnDocView_Click(object sender, EventArgs e)
        {
            ShowForms(new View_Doctor());
        }

        private void btnDocUpdate_Click(object sender, EventArgs e)
        {
            ShowForms(new Update_Doctor());
        }

        private void btnDocDelete_Click(object sender, EventArgs e)
        {
            ShowForms(new Delete(flag));
        }

        private void btnDocAdd_Click(object sender, EventArgs e)
        {
            ShowForms(new AddDocDetails());
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            ShowForms(new Salary());
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            ShowForms(new Bill());
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowForms(new Dashboard());
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Hide();
        }

        private void ShowForms(Form form)
        {
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        
        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ShowForms(new Delete_Bill());
        }

        private void Bill_Timer_Tick(object sender, EventArgs e)
        {
            if (billxpand == false)
            {
                bill_Container.Height += 10;
                if (bill_Container.Height >= 470)
                {
                    Bill_Timer.Stop();
                    billxpand= true;
                }
            }
            else
            {
                bill_Container.Height -= 10;
                if (bill_Container.Height <= 100)
                {
                    Bill_Timer.Stop();
                    billxpand = false;
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            Bill_Timer.Start();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
            ShowForms(new Add_Bill());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ShowForms(new View_Bill());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            ShowForms(new Generate_Bill());
        }

        private void medicine_timer_Tick(object sender, EventArgs e)
        {
            if (medepand == false)
            {
                medicine_cont.Height += 10;
                if (medicine_cont.Height >= 340)
                {
                    medicine_timer.Stop();
                    medepand = true;
                }
            }
            else
            {
                medicine_cont.Height -= 10;
                if (medicine_cont.Height <= 80)
                {
                    medicine_timer.Stop();
                    medepand = false;
                }
            }
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            medicine_timer.Start();
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            ShowForms(new ADD_Medicine());
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            ShowForms(new View_Medicine());
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            ShowForms(new Delete_Medicine());
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel2_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
