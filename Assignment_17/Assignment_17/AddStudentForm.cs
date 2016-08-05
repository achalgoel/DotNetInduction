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
    public partial class AddStudentForm : Form
    {
  
         public AddStudentForm()
        {
            InitializeComponent();
        }
        private void AddStudentForm_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            StudentDataHandler obj = new StudentDataHandler();
            if (obj.AddStudent(
                            txtFirstName.Text,
                            txtLastName.Text,
                            Int32.Parse(txtEnroll.Text),
                            Int32.Parse(cmbClass.SelectedItem.ToString()),
                            cmbStream.SelectedItem.ToString(),
                            cmbState.SelectedItem.ToString()
                           ))
                lblMessage.Text = "Value entered successfully !!!";
            else
                lblMessage.Text = "Unsuccessful";

        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            MainForm obj = new MainForm();
            obj.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }


    }
}
