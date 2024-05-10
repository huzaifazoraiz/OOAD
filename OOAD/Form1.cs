using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace OOAD
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadSavedSettings();
            txtPassword.PasswordChar = '*';
        }
        private void LoadSavedSettings()
        {
            // Load saved settings into ComboBoxes
            cboServerIP.Text = Properties.Settings.Default.ServerIP;
            cboServerName.Text = Properties.Settings.Default.ServerName;
            cboUsername.Text = Properties.Settings.Default.Username;
        }

        private void ConnectToServer(string connectionString)
        {
            if (string.IsNullOrEmpty(cboServerName.Text) || string.IsNullOrEmpty(cboServerIP.Text) || string.IsNullOrEmpty(txtPassword.Text) || string.IsNullOrEmpty(cboUsername.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    MessageBox.Show("Connected successfully to SQL Server.");

                    // Open DatabaseListForm if connection is successful
                    DatabaseListForm databaseListForm = new DatabaseListForm(connection);
                    databaseListForm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(  object sender, EventArgs e)
        {

            string serverName = cboServerName.Text;
            string connectionString = $"Data Source={serverName};Initial Catalog=master;Integrated Security=True";
            ConnectToServer(connectionString);
            SaveSettings();
        }
        private void btnConnectRemote_Click_1(object sender, EventArgs e)
        {
            string serverIP = cboServerIP.Text;
            string username = cboUsername.Text;
            string password = txtPassword.Text;
            string connectionString = $"Data Source={serverIP};Initial Catalog=master;User ID={username};Password={password}";
            ConnectToServer(connectionString);
            SaveSettings();
        }
        private void SaveSettings()
        {
            // Save settings
            Properties.Settings.Default.ServerIP = cboServerIP.Text;
            Properties.Settings.Default.ServerName = cboServerName.Text;
            Properties.Settings.Default.Username = cboUsername.Text;
            Properties.Settings.Default.Save();
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
