// ShopListForm.Designer.cs

namespace NotebookWinFormsApp
{
    partial class ShopListForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            cmbSearchBy = new System.Windows.Forms.ComboBox();
            txtSearch = new System.Windows.Forms.TextBox();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cmbSearchBy
            // 
            cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            cmbSearchBy.FormattingEnabled = true;
            cmbSearchBy.Items.AddRange(new object[] { "ShopName", "OwnerName", "Mobile" });
            cmbSearchBy.Location = new System.Drawing.Point(100, 20);
            cmbSearchBy.Name = "cmbSearchBy";
            cmbSearchBy.Size = new System.Drawing.Size(200, 23);
            cmbSearchBy.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Location = new System.Drawing.Point(320, 20);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new System.Drawing.Size(250, 23);
            txtSearch.TabIndex = 1;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(20, 60);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new System.Drawing.Size(750, 350);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            dataGridView1.KeyDown += dataGridViw1_KeyDown;
            // 
            // ShopListForm
            // 
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(cmbSearchBy);
            Controls.Add(txtSearch);
            Controls.Add(dataGridView1);
            Name = "ShopListForm";
            Text = "Shop List";
            Load += ShopListForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}