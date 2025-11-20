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
    public partial class View_room : Form
    {
        public View_room()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            guna2DataGridView1.DataSource = RoomBL.GetRoomDataTable();
        }

        private void View_room_Load(object sender, EventArgs e)
        {

        }
    }
}
