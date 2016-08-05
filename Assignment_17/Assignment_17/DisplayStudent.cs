﻿using System;
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
    public partial class DisplayStudent : Form
    {
        public DisplayStudent()
        {
            InitializeComponent();
        }

        private void DisplayStudent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentDataSet.StudentDetails' table. You can move, or remove it, as needed.
            this.studentDetailsTableAdapter.Fill(this.studentDataSet.StudentDetails);

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            StudentDataHandler obj = new StudentDataHandler();
            string str =cmbStream.SelectedItem.ToString();
           dataGridView1.DataSource = obj.DisplayStudent(str);
        }

        private void btnBack_Click()
        {
            MainForm obj = new MainForm();
            obj.Show();
        }
    }
}
