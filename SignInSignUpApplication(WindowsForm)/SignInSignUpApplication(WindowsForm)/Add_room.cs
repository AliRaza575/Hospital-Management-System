using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInSignUpApplication_WindowsForm_
{
    public partial class Add_room : Form
    {
        public Add_room()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            
            string type = guna2TextBox2.Text;
            int charges = int.Parse(guna2TextBox3.Text);
            string available = guna2ComboBox1.Text; // Use a checkbox control

            RoomBL.AddRoom(type, charges, available);
        }
    }
}
