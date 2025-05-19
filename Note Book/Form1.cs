using System;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace NotebookSQLiteApp
{
    public partial class Form1 : Form
    {
        private string dbPath = "Notebook.db";
        private string connStr => $"Data Source={dbPath};Version=3;";

        public Form1()
        {
            InitializeComponent();
            CreateDatabaseIfNotExists();
            GenerateID();
        }

        private void CreateDatabaseIfNotExists()
        {
            if (!File.Exists(dbPath))
            {
                SQLiteConnection.CreateFile(dbPath);
                using var conn = new SQLiteConnection(connStr);
                conn.Open();
                string sql = @"CREATE TABLE IF NOT EXISTS Notebook(
                                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                Model TEXT,
                                ReverseNo TEXT,
                                Description TEXT
                            )";
                new SQLiteCommand(sql, conn).ExecuteNonQuery();
            }
        }

        private void GenerateID()
        {
            using var conn = new SQLiteConnection(connStr);
            conn.Open();
            var cmd = new SQLiteCommand("SELECT IFNULL(MAX(ID),0)+1 FROM Notebook", conn);
            txtID.Text = cmd.ExecuteScalar().ToString();
        }

        private void ClearFields()
        {
            txtID.Clear();
            txtModel.Clear();
            txtReverseNo.Clear();
            txtDescription.Clear();
            txtModel.Focus();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearFields();
            GenerateID();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtID.Tag?.ToString() == "FromForm2")
            {
                MessageBox.Show("Update করুন। নতুন করে Save করবেন না!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using var conn = new SQLiteConnection(connStr);
            conn.Open();
            var cmd = new SQLiteCommand("INSERT INTO Notebook(Model, ReverseNo, Description) VALUES (@Model,@ReverseNo,@Description)", conn);
            cmd.Parameters.AddWithValue("@Model", txtModel.Text.Trim());
            cmd.Parameters.AddWithValue("@ReverseNo", txtReverseNo.Text.Trim());
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
            cmd.ExecuteNonQuery();

            MessageBox.Show("Saved Successfully!");
            ClearFields();
            GenerateID();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text)) return;

            using var conn = new SQLiteConnection(connStr);
            conn.Open();
            var cmd = new SQLiteCommand("UPDATE Notebook SET Model=@Model, ReverseNo=@ReverseNo, Description=@Description WHERE ID=@ID", conn);
            cmd.Parameters.AddWithValue("@Model", txtModel.Text.Trim());
            cmd.Parameters.AddWithValue("@ReverseNo", txtReverseNo.Text.Trim());
            cmd.Parameters.AddWithValue("@Description", txtDescription.Text.Trim());
            cmd.Parameters.AddWithValue("@ID", txtID.Text);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Updated Successfully!");
            ClearFields();
            GenerateID();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text)) return;

            var confirm = MessageBox.Show("Delete this record?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                using var conn = new SQLiteConnection(connStr);
                conn.Open();
                var cmd = new SQLiteCommand("DELETE FROM Notebook WHERE ID=@ID", conn);
                cmd.Parameters.AddWithValue("@ID", txtID.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Deleted Successfully!");
                ClearFields();
                GenerateID();
            }
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            Form2 viewer = new Form2(this);
            viewer.ShowDialog();
        }

        public void SetDataFromForm2(string id, string model, string reverseNo, string description)
        {
            txtID.Text = id;  // এখন এখানে ID লাগবে না চাইলে এখানে বাদ দিতে পারেন
            txtModel.Text = model;
            txtReverseNo.Text = reverseNo;
            txtDescription.Text = description;
            txtID.Tag = "FromForm2"; // Update বোঝানোর জন্য
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
