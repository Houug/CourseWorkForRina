using System;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CourseWork
{
    // Это класс (AddNewPersonForm) окна с добавлением нового человека
    public partial class AddNewPersonForm : Form
    {
        // Конструктор класс AddNewPersonForm (запускается при создании объекта)
        public AddNewPersonForm()
        {
            // Создается автоматически
            InitializeComponent();

            // Обозначаем что при нажатии на эту кнопку результат диалога будет ОК
            acceptButton.DialogResult = DialogResult.OK;

            // Запрещаем нажатие на кнопку
            acceptButton.Enabled = false;
        }

        // Метод, который вызывается при нажатии на кнопку если выделено поле salaryTextBox
        private void salaryTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запоминаем нажатую кнопку
            char number = e.KeyChar;

            // Если кнопка не число или Backspace, то "отзываем" нажатие
            if (!char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        // Метод, который вызывается при нажатии на кнопку "Добавить"
        private void acceptButton_Click(object sender, EventArgs e)
        {
            // Создаем SQL команду
            string query = string.Format(@"INSERT INTO Main_Table(
            `Фамилия`,
            `Имя`,
            `Отдел`,
            `Начало отпуска`,
            `Зарплата`,
            `Дети до 18 лет`)
            VALUES('{0}','{1}','{2}','{3}',{4},{5})", surnameTextBox.Text.Trim(), nameTextBox.Text.Trim(), departmentTextBox.Text.Trim(), dateTimePicker.Value.Date.ToString().Split(' ')[0], salaryTextBox.Text.Trim(), haveMinorChildreCheckBox.Checked);
            
            // Строка для подключения к базе данных
            string ConnString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\db.accdb";

            // Создаем объект класса OleDbConnection передавая в его конструктор строку с подключением
            OleDbConnection connection = new OleDbConnection(ConnString);

            // Открываем подключение к БД
            connection.Open();

            // Создаем объект с SQL командой, которую пошлем в БД
            OleDbCommand command = connection.CreateCommand();

            // Текст команды
            command.CommandText = query;

            // Отправляем команду в БД
            command.ExecuteNonQuery();

            // Открыл - закрой
            connection.Close();
        }

        // Метод возвращающий кнопку "Добавить"
        public Button GetAcceptButton()
        {
            return acceptButton;
        }

        // Функция проверяющая нет ли пустых полей
        private bool CheckFields()
        {
            return (surnameTextBox.TextLength > 0 && nameTextBox.TextLength > 0 && departmentTextBox.TextLength > 0 && salaryTextBox.TextLength > 0);
        }

        // Метод, который вызывется при изменении текста в поле "Фамилия"
        private void surnameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Если хотя бы одно поле пустое, то кнопка блокируется
            acceptButton.Enabled = (CheckFields()) ? true : false;
        }

        // Метод, который вызывется при изменении текста в поле "Имя"
        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            // Если хотя бы одно поле пустое, то кнопка блокируется
            acceptButton.Enabled = (CheckFields()) ? true : false;
        }

        // Метод, который вызывется при изменении текста в поле "Отдел"
        private void departmentTextBox_TextChanged(object sender, EventArgs e)
        {
            // Если хотя бы одно поле пустое, то кнопка блокируется
            acceptButton.Enabled = (CheckFields()) ? true : false;
        }

        // Метод, который вызывется при изменении текста в поле "Зарплата"
        private void salaryTextBox_TextChanged(object sender, EventArgs e)
        {
            // Если хотя бы одно поле пустое, то кнопка блокируется
            acceptButton.Enabled = (CheckFields()) ? true : false;
        }
    }
}
