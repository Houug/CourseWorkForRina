using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class MainForm : Form
    {
        public string CommandText = "SELECT * FROM Main_Table";
        public string ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\db.accdb";
        public MainForm()
        {
            InitializeComponent();
            OleDbConnection connection = new OleDbConnection(ConnectionString);
            connection.Open();
            OleDbCommand command = connection.CreateCommand();

            try
            {
                command.CommandText = @"CREATE TABLE Main_Table(
                    ID COUNTER,
                    `Фамилия` VARCHAR,
                    `Имя` VARCHAR,
                    `Отдел` VARCHAR,
                    `Начало отпуска` DATE,
                    `Зарплата` INT,
                    `Дети до 18 лет` BIT); ";
                command.ExecuteNonQuery();
                infoLabel.Text = "Создана новая таблица!";
            }
            catch
            {

            }
            finally
            {
                LoadDataFromDataBase();
            }
        }

        private void LoadDataFromDataBase()
        {
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Main_Table");
            tableField.DataSource = ds.Tables[0].DefaultView;
            infoLabel.Text = "База обновлена!";
        }
        private void reloadButton_Click(object sender, EventArgs e)
        {
            LoadDataFromDataBase();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                string id = tableField.SelectedRows[0].Cells[0].Value.ToString();
                string query = string.Format("DELETE * FROM Main_Table WHERE ID = {0}", id);
                OleDbConnection connection = new OleDbConnection(ConnectionString);
                connection.Open();
                OleDbCommand command = connection.CreateCommand();
                command.CommandText = query;
                command.ExecuteNonQuery();
                connection.Close();
                LoadDataFromDataBase();
            }
            catch
            {
                infoLabel.Text = "Не выбран человек";
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddNewPersonForm login = new AddNewPersonForm();
            login.Owner = this;
            login.AcceptButton = login.GetAcceptButton();

            if (login.ShowDialog() == DialogResult.OK)
            {
                LoadDataFromDataBase();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string CmdText;
            if (haveMinorChildrenCheckBox.Checked || thisMonthCheckBox.Checked || (departmentTextBox.Text.Trim() != ""))
            {
                CmdText = "SELECT * FROM Main_Table WHERE ";
            }
            else
            {
                CmdText = "SELECT * FROM Main_Table";
            }
            
            if (departmentTextBox.Text.Trim() != "")
            {
                 CmdText += $"[Отдел] = '{departmentTextBox.Text.Trim()}' ";
            }
            if (haveMinorChildrenCheckBox.Checked)
            {
                if ((departmentTextBox.Text.Trim() != ""))
                {
                    CmdText += "AND";
                }
                CmdText += $" [Дети до 18 лет]= -1 ";
            }
            if(thisMonthCheckBox.Checked)
            {
                DateTime today = DateTime.Now;
                if ((departmentTextBox.Text.Trim() != "") || haveMinorChildrenCheckBox.Checked)
                {
                    CmdText += "AND";
                }
                CmdText += $" ([Начало отпуска] >= #{today.Year}-{today.Month}-1# AND [Начало отпуска] < #{today.AddMonths(1).Year}-{today.AddMonths(1).Month}-1#)";
            }

            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnectionString);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds, "Main_Table");
            tableField.DataSource = ds.Tables[0].DefaultView;
            infoLabel.Text = "База обновлена!";
        }
    }
}
