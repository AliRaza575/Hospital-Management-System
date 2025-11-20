using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignInSignUpApplication_WindowsForm_
{
    public partial class DocDelete : Form
    {
        int userID;
        public DocDelete(int id)
        {
            InitializeComponent();
            userID = id;
           
        }

        private void DocDelete_Load(object sender, EventArgs e)
        {
            //this.ControlBox = false;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            //DoctorBL.DeleteQuery(userID);
            //DL.DeleteDetails();
        }
    }
}
