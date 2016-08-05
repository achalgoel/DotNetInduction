using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_17
{
    public partial class UpdateStudent : Form
    {
        public UpdateStudent()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm obj = new MainForm();
            obj.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            StudentDataHandler obj = new StudentDataHandler();
            if(obj.UpdateStudent(
                            Int32.Parse(txtEnroll.Text),
                            Int32.Parse(cmbClass.SelectedItem.ToString()),
                            cmbStream.SelectedItem.ToString(),
                            cmbState.SelectedItem.ToString()
                           ))
                lblMessage.Text = "Value Updated successfully !!!";
            else
                lblMessage.Text = "Unsuccessful";

        }
        
    }
}
