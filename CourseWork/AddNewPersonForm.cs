using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class AddNewPersonForm : Form
    {
        public AddNewPersonForm()
        {
            InitializeComponent();
            acceptButton.DialogResult = DialogResult.OK;
            acceptButton.Enabled = false;
        }

        private void salaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            string query = string.Format(@"INSERT INTO Main_Table(
            `Фамилия`,
            `Имя`,
            `Отдел`,
            `Начало отпуска`,
            `Зарплата`,
            `Дети до 18 лет`)
            VALUES('{0}','{1}','{2}','{3}',{4},{5})", surnameTextBox.Text.Trim(), nameTextBox.Text.Trim(), departmentTextBox.Text.Trim(), dateTimePicker.Value.Date.ToString().Split(' ')[0], salaryTextBox.Text.Trim(), haveMinorChildreCheckBox.Checked);

            string ConnString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\db.accdb";
            OleDbConnection connection = new OleDbConnection(ConnString);
            connection.Open();
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = query;
            command.ExecuteNonQuery();
            connection.Close();
        }

        public Button GetAcceptButton()
        {
            return acceptButton;
        }

        private bool CheckFields()
        {
            return (surnameTextBox.TextLength > 0 && nameTextBox.TextLength > 0 && departmentTextBox.TextLength > 0 && salaryTextBox.TextLength > 0);
        }

        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {
            acceptButton.Enabled = (CheckFields()) ? true : false;
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            acceptButton.Enabled = (CheckFields()) ? true : false;
        }

        private void departmentTextBox_TextChanged(object sender, EventArgs e)
        {
            acceptButton.Enabled = (CheckFields()) ? true : false;
        }

        private void salaryTextBox_TextChanged(object sender, EventArgs e)
        {
            acceptButton.Enabled = (CheckFields()) ? true : false;
        }
    }
}
