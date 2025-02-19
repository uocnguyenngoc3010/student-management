﻿using BusinessObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmHome : Form
    {
        UserObject user;
        public frmHome(UserObject user)
        {
            this.user = user;
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void AddForm(Form m)
        {
            m.Show();
        }

        private void studentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStudentManagement m = new frmStudentManagement();
            AddForm(m);
        }

        private void markToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMark m = new frmMark();
            AddForm(m);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) => Close();

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            frm.Show();
            this.Hide();
            menuToolStripMenuItem.Enabled = false;
            managementToolStripMenuItem.Enabled = false;
            helpToolStripMenuItem.Enabled = false;
            tsStudent.Hide();
            tsCourse.Hide();
            tsMark.Hide();
            tsMajor.Hide();
            tsCourse.Hide();
            
        }
    }
}
