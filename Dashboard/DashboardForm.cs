using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NotebookSQLiteApp;

namespace NotebookWinFormsApp
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
            this.IsAccessible = true;
        }

        private void NoteBookEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 entryForm = new Form1();
            entryForm.ShowDialog();

        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            notebookEntryToolStripMenuItem.Enabled = true;
            this.menuStrip1.Select();


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            UserManagementForm userManagementForm = new UserManagementForm();
            userManagementForm.ShowDialog();
        }

        private void newRegisterShopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewRegisterShopForm newRegisterShopForm = new NewRegisterShopForm();
            newRegisterShopForm.ShowDialog();
        }

        private void incomeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IncomeEntryForm incomeEntryForm = new IncomeEntryForm();
            incomeEntryForm.ShowDialog();
        }

        private void employeeEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeEntryForm employeeEntryForm = new EmployeeEntryForm();
            employeeEntryForm.ShowDialog();
        }

        private void advenceEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdvanceEntryForm advanceEntryForm = new AdvanceEntryForm();
            advanceEntryForm.ShowDialog();
        }
    }

}

    




     





















