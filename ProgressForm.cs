// Step 1: using directives
using System;
using System.Windows.Forms;

namespace NotebookWinFormsApp
{
    public partial class ProgressForm : Form
    {
        public ProgressForm()
        {
            InitializeComponent();
        }

        // Step 2: UpdateCount method with progress
        public void UpdateCount(int count, int total, bool isImport = true)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => UpdateCount(count, total, isImport)));
                return;
            }

            string status = isImport ? "Importing" : "Exporting";
            lblStatus.Text = $"{status} Row: {count:N0} of {total:N0}";

            if (progressBar1.Maximum != total)
                progressBar1.Maximum = total;

            progressBar1.Value = Math.Min(count, total);
        }

        // Step 3: Optional cancel button (future use)
        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancel not implemented yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
