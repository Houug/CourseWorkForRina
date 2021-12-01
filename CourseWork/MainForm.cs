using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace CourseWork
{
    // Это класс основого окна (MainForm)
    public partial class MainForm : Form // <- Вот эта запись означает что он отнаследован от класса Form (Это, кстати, тоже создается автоматически)
    {
        // Поля класса:
        // SQL команда, надеюсь пояснять не надо
        public string CommandText = "SELECT * FROM Main_Table";
        // Строка для подключения к базе данных v------ это драйвер для подключения. v------А это путь базе данных

        public string ConnectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={Application.StartupPath}\\db.accdb";
        //                               ^                                                              ^-------------------+ Application это класс из которого
        //                               |                                                                                  | можно вытащить путь исполняемого файла
        //                               + Значок доллера означает что в строку можно будет вставлять переменные вот так ---+
       
        // Конструктор класс MainForm (запускается при создании объекта)
        public MainForm()
        {
            // Создается автоматически
            InitializeComponent(); 

            // OleDb - "средство" для работы с БД в C# (скажем так)
            // Создаем объект класса OleDbConnection передавая в его конструктор строку с подключением
            OleDbConnection connection = new OleDbConnection(ConnectionString);

            // Открываем подключение к БД
            connection.Open();

            // Создаем объект с SQL командой, которую пошлем в БД
            OleDbCommand command = connection.CreateCommand();

            // Так как MS Access - х*ета, делаем криво, так чтобы работало
            // Пробуем создать таблицу, если она уже существует нас перебрасывает в блок catch
            try
            {
                // Текст команды, ДА ДА ДА Я ЗНАЮ ЧТО ЕСТЬ "IF NOT EXISTS", НО ЭТА ТЕМА НЕ РАБОТАЕТ С MS ACCESS!
                //                    v------Значит что строка будет на нескольких строках (ох уж этот мой русский язык)
                command.CommandText = @"CREATE TABLE Main_Table(
                    ID COUNTER,
                    `Фамилия` VARCHAR,
                    `Имя` VARCHAR,
                    `Отдел` VARCHAR,
                    `Начало отпуска` DATE,
                    `Зарплата` INT,
                    `Дети до 18 лет` BIT); ";

                // Отправляем команду в БД
                command.ExecuteNonQuery();

                // Выводим инфу что новая таблица создана 
                // Выводим с помощью объекта infoLabel просто изменяя у него свойство Text
                infoLabel.Text = "Создана новая таблица!";
            }
            catch
            {
                // тут мы ничего не делаем, он существует только для кого чтобы избавиться от исключения
            }
            finally // <-- блок, который выполняется в любом случае после try..catch конструкции
            {
                // Вызываем функцию (описание ее дальше)
                LoadDataFromDataBase();

                // Открыл - закрой
                connection.Close();
            }
        }

        // Функция загрузки с отображения данных из БД в таблицу
        private void LoadDataFromDataBase()
        {
            // Создаем объект, через который будем заполнять объект для данных из таблицы
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CommandText, ConnectionString);

            // Объект данных из таблицы
            DataSet ds = new DataSet();

            // Вызываем метод Fill, передаетм объект в который будем записывать данные и название таблицы из который будем вытаскивать данные
            dataAdapter.Fill(ds, "Main_Table");

            // У элемента интерфейса таблицы измменяем свойство с данными, которые он выводит
            tableField.DataSource = ds.Tables[0].DefaultView;

            // Выводим инфу что новая таблица обновлена 
            // Выводим с помощью объекта infoLabel просто изменяя у него свойство Text
            infoLabel.Text = "База обновлена!";
        }

        // Метод, который вызывается при нажатии кнопки "Обновить"
        private void reloadButton_Click(object sender, EventArgs e)
        {
            // Вызываем функцию
            LoadDataFromDataBase();
        }

        // Метод, который вызывается при нажатии кнопки "Удалить"
        private void deleteButton_Click(object sender, EventArgs e)
        {
            // Так как MS Access - х*ета, делаем криво, так чтобы работало
            try
            {
                // Вытаскиваем из таблицы выбранную строку и из нее вытаскиваем значение ID
                string id = tableField.SelectedRows[0].Cells[0].Value.ToString();

                // Создаем объект класса OleDbConnection передавая в его конструктор строку с подключением
                OleDbConnection connection = new OleDbConnection(ConnectionString);

                // Открываем подключение к БД
                connection.Open();

                // Создаем объект с SQL командой, которую пошлем в БД
                OleDbCommand command = connection.CreateCommand();

                // Текст команды
                command.CommandText = $"DELETE * FROM Main_Table WHERE ID = {id}";

                // Отправляем команду в БД
                command.ExecuteNonQuery();

                // Открыл - закрой
                connection.Close();

                // Вызываем функцию
                LoadDataFromDataBase();
            }
            catch
            {
                // Выводим инфу что никто не выбран 
                // Выводим с помощью объекта infoLabel просто изменяя у него свойство Text
                infoLabel.Text = "Не выбран человек";
            }
        }

        // Метод, который вызывается при нажатии кнопки "Добавить"
        private void addButton_Click(object sender, EventArgs e)
        {
            // Создание объекта AddNewPersonForm, то есть создаем новое окно
            // (Почему переменная называется login, я понятия не имею, но менять уже не буду)
            AddNewPersonForm login = new AddNewPersonForm();

            // Говорим что новое окно теперь владеет основным, то есть пока активно новое окно главное недоступно
            login.Owner = this;

            // Так как окно реализованю через диалог, нужно обозначить кнопки
            login.AcceptButton = login.GetAcceptButton(); // <-- Вытаскиваем эту кнопку из нового окна

            // Теперь открываем окно, которое диалог, и если ответ на него будет ОК, то идем дальше
            if (login.ShowDialog() == DialogResult.OK)
            {
                LoadDataFromDataBase();
            }
        }

        // Метод, который вызывается при нажатии кнопки "Найти"
        private void searchButton_Click(object sender, EventArgs e)
        {
            // Создание Франкенштейна-команды хаха
            string CmdText;

            // Если стоят галочки в одном из чекбоксов или текста в поле нет
            if (haveMinorChildrenCheckBox.Checked || thisMonthCheckBox.Checked || (departmentTextBox.Text.Trim() != ""))
            {
                CmdText = "SELECT * FROM Main_Table WHERE ";
            }
            else
            {
                CmdText = "SELECT * FROM Main_Table";
            }
            
            // Если текста нет
            if (departmentTextBox.Text.Trim() != "")
            {
                 CmdText += $"[Отдел] = '{departmentTextBox.Text.Trim()}' ";
            }
            
            // Если галочка в чекбоксе "Дети до 18 лет"
            if (haveMinorChildrenCheckBox.Checked)
            {
                // Если текста нет
                if ((departmentTextBox.Text.Trim() != ""))
                {
                    CmdText += "AND";
                }
                CmdText += $" [Дети до 18 лет]= -1 ";
            }

            // Если галочка в чекбоксе "Отпуск в этом месяце"
            if (thisMonthCheckBox.Checked)
            {
                DateTime today = DateTime.Now;
                if ((departmentTextBox.Text.Trim() != "") || haveMinorChildrenCheckBox.Checked)
                {
                    CmdText += "AND";
                }
                CmdText += $" ([Начало отпуска] >= #{today.Year}-{today.Month}-1# AND [Начало отпуска] < #{today.AddMonths(1).Year}-{today.AddMonths(1).Month}-1#)";
            }


            // Создаем объект, через который будем заполнять объект для данных из таблицы
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(CmdText, ConnectionString);

            // Объект данных из таблицы
            DataSet ds = new DataSet();

            // Вызываем метод Fill, передаетм объект в который будем записывать данные и название таблицы из который будем вытаскивать данные
            dataAdapter.Fill(ds, "Main_Table");

            // У элемента интерфейса таблицы измменяем свойство с данными, которые он выводит
            tableField.DataSource = ds.Tables[0].DefaultView;

            // Выводим инфу что новая таблица обновлена 
            // Выводим с помощью объекта infoLabel просто изменяя у него свойство Text
            infoLabel.Text = "База обновлена!";
        }
    }
}
