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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddStudentForm obj = new AddStudentForm();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateStudent obj = new UpdateStudent();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DisplayStudent obj = new DisplayStudent();
            obj.Show();
        }
    }
}
