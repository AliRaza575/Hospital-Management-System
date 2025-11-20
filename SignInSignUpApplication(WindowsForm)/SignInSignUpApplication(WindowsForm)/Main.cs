using System;
using System.Drawing;
using System.Windows.Forms;

namespace SignInSignUpApplication_WindowsForm_
{
    public partial class Main : Form
    {
        bool docexp = false;
        bool patexp = false;
        bool billxpand = false;
        bool salaexp = false;
        bool medepand = false;
        bool roomexp=false;
        bool flag = true;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.IsMdiContainer = true; // ✅ Ensure the form acts as an MDI container
            this.BackColor = Color.Cornsilk;
            ShowForms(new DocDashboard());
        }

        private void ShowForms(Form form)
        {
            // ✅ Close existing MDI children (optional, but recommended)
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }

            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void DOC_TIME_Tick(object sender, EventArgs e)
        {
            if (!docexp)
            {
                DocMenuContainer.Height += 10;
                if (DocMenuContainer.Height >= 390)
                {
                    DOC_TIME.Stop();
                    docexp = true;
                }
            }
            else
            {
                DocMenuContainer.Height -= 10;
                if (DocMenuContainer.Height <= 78)
                {
                    DOC_TIME.Stop();
                    docexp = false;
                }
            }
        }

        private void PATIENT_TIMER_Tick(object sender, EventArgs e)
        {
            if (!patexp)
            {
                PatMenuContainer.Height += 10;
                if (PatMenuContainer.Height >= 390)
                {
                    PATIENT_TIMER.Stop();
                    patexp = true;
                }
            }
            else
            {
                PatMenuContainer.Height -= 10;
                if (PatMenuContainer.Height <= 78)
                {
                    PATIENT_TIMER.Stop();
                    patexp = false;
                }
            }
        }

        private void Med_Timer_Tick(object sender, EventArgs e)
        {
            if (!medepand)
            {
                medicine_cont.Height += 10;
                if (medicine_cont.Height >= 400)
                {
                    Med_Timer.Stop();
                    medepand = true;
                }
            }
            else
            {
                medicine_cont.Height -= 10;
                if (medicine_cont.Height <= 80)
                {
                    Med_Timer.Stop();
                    medepand = false;
                }
            }
        }

        private void BILL_TIMER_Tick(object sender, EventArgs e)
        {
            if (!billxpand)
            {
                bill_Container.Height += 10;
                if (bill_Container.Height >= 325)
                {
                    BILL_TIMER.Stop();
                    billxpand = true;
                }
            }
            else
            {
                bill_Container.Height -= 10;
                if (bill_Container.Height <= 70)
                {
                    BILL_TIMER.Stop();
                    billxpand = false;
                }
            }
        }

        private void Room_timer_Tick(object sender, EventArgs e)
        {
            if (!roomexp)
            {
                room_cont.Height += 10;
                if (room_cont.Height >= 320)
                {
                    Room_timer.Stop();
                    roomexp = true;
                }
            }
            else
            {
                room_cont.Height -= 10;
                if (room_cont.Height <= 80)
                {
                    Room_timer.Stop();
                    roomexp = false;
                }
            }
        }

        private void Salary_timer_Tick(object sender, EventArgs e)
        {
            if (!salaexp)
            {
                salary_con.Height += 10;
                if (salary_con.Height >= 240)
                {
                    Salary_timer.Stop();
                    salaexp = true;
                }
            }
            else
            {
                salary_con.Height -= 10;
                if (salary_con.Height <= 70)
                {
                    Salary_timer.Stop();
                    salaexp = false;
                }
            }
        }
        private void btnDoc_Click(object sender, EventArgs e)
        {
            DOC_TIME.Start();
        }

       

        private void btnPat_Click(object sender, EventArgs e)
        {
            PATIENT_TIMER.Start();
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            Med_Timer.Start();
        }

    
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            BILL_TIMER.Start();
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

        private void btnPatAdd_Click(object sender, EventArgs e)
        {
            ShowForms(new AddPatDetails());
        }

        private void btnPatView_Click(object sender, EventArgs e)
        {
            ShowForms(new View_Patient());
        }

        private void btnPatUpdate_Click(object sender, EventArgs e)
        {
            ShowForms(new Update_Patient());
        }

        private void btnPatDelete_Click(object sender, EventArgs e)
        {
            ShowForms(new PatDelete(!flag));
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ShowForms(new Add_Bill());
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            ShowForms(new View_Bill());
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            ShowForms(new Delete_Bill());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            ShowForms(new Generate_Bill());
        }

        private void btnDocAdd_Click(object sender, EventArgs e)
        {
            ShowForms(new AddDocDetails());
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

        private void guna2Button10_Click(object sender, EventArgs e)
        {
            Room_timer.Start();
        }

      

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            ShowForms(new Add_room());
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            ShowForms(new Room_Allocation());
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            ShowForms(new Delete_Allocation());
        }

        

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            Salary_timer.Start();
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            ShowForms(new Add_Salary());
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            ShowForms(new View_Salary());
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            ShowForms(new Delete_Salary());
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            ShowForms(new Generate_Report());
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            ShowForms(new DocDashboard());
        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            ShowForms(new Issue_Medicine());
        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {
            ShowForms(new View_room());
        }
    }
}
