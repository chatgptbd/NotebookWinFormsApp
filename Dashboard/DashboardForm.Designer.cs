namespace NotebookWinFormsApp
{
    partial class DashboardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            noteBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            notebookEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            userManagementToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            registerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newRegisterShopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            incomeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            incomeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            employeeEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            advenceEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { noteBookToolStripMenuItem, userManagementToolStripMenuItem, registerToolStripMenuItem, incomeToolStripMenuItem, employeeToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(800, 29);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // noteBookToolStripMenuItem
            // 
            noteBookToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { notebookEntryToolStripMenuItem });
            noteBookToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            noteBookToolStripMenuItem.Name = "noteBookToolStripMenuItem";
            noteBookToolStripMenuItem.Size = new System.Drawing.Size(91, 25);
            noteBookToolStripMenuItem.Text = "NoteBook";
            // 
            // notebookEntryToolStripMenuItem
            // 
            notebookEntryToolStripMenuItem.Name = "notebookEntryToolStripMenuItem";
            notebookEntryToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            notebookEntryToolStripMenuItem.Text = "NoteBookEntry";
            notebookEntryToolStripMenuItem.Click += NoteBookEntryToolStripMenuItem_Click;
            // 
            // userManagementToolStripMenuItem
            // 
            userManagementToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItem1 });
            userManagementToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            userManagementToolStripMenuItem.Name = "userManagementToolStripMenuItem";
            userManagementToolStripMenuItem.Size = new System.Drawing.Size(150, 25);
            userManagementToolStripMenuItem.Text = "User Management";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(212, 26);
            toolStripMenuItem1.Text = "User Manage Entry";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // registerToolStripMenuItem
            // 
            registerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { newRegisterShopToolStripMenuItem });
            registerToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            registerToolStripMenuItem.Name = "registerToolStripMenuItem";
            registerToolStripMenuItem.Size = new System.Drawing.Size(79, 25);
            registerToolStripMenuItem.Text = "Register";
            // 
            // newRegisterShopToolStripMenuItem
            // 
            newRegisterShopToolStripMenuItem.Name = "newRegisterShopToolStripMenuItem";
            newRegisterShopToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            newRegisterShopToolStripMenuItem.Text = "New Register Shop";
            newRegisterShopToolStripMenuItem.Click += newRegisterShopToolStripMenuItem_Click;
            // 
            // incomeToolStripMenuItem
            // 
            incomeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { incomeToolStripMenuItem1 });
            incomeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            incomeToolStripMenuItem.Name = "incomeToolStripMenuItem";
            incomeToolStripMenuItem.Size = new System.Drawing.Size(73, 25);
            incomeToolStripMenuItem.Text = "Income";
            // 
            // incomeToolStripMenuItem1
            // 
            incomeToolStripMenuItem1.Name = "incomeToolStripMenuItem1";
            incomeToolStripMenuItem1.Size = new System.Drawing.Size(131, 26);
            incomeToolStripMenuItem1.Text = "Income";
            incomeToolStripMenuItem1.Click += incomeToolStripMenuItem1_Click;
            // 
            // employeeToolStripMenuItem
            // 
            employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { employeeEntryToolStripMenuItem, advenceEntryToolStripMenuItem });
            employeeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            employeeToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            employeeToolStripMenuItem.Text = "Employee";
            // 
            // employeeEntryToolStripMenuItem
            // 
            employeeEntryToolStripMenuItem.Name = "employeeEntryToolStripMenuItem";
            employeeEntryToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            employeeEntryToolStripMenuItem.Text = "EmployeeEntry";
            employeeEntryToolStripMenuItem.Click += employeeEntryToolStripMenuItem_Click;
            // 
            // advenceEntryToolStripMenuItem
            // 
            advenceEntryToolStripMenuItem.Name = "advenceEntryToolStripMenuItem";
            advenceEntryToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            advenceEntryToolStripMenuItem.Text = "Advence Entry";
            advenceEntryToolStripMenuItem.Click += advenceEntryToolStripMenuItem_Click;
            // 
            // DashboardForm
            // 
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "DashboardForm";
            Text = "DashboardForm";
            Load += DashboardForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem noteBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notebookEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userManagementToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem registerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newRegisterShopToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incomeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incomeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeEntryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advenceEntryToolStripMenuItem;
    }
}