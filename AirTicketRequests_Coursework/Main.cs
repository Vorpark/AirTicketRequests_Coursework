using System;
using System.IO;
using System.Windows.Forms;

namespace AirTicketRequests_Coursework
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Renovation();
        }

        private void AddTicket(object sender, EventArgs e) // Добавление тикета
        {
            var addForm = new AddTicket();
            addForm.ShowDialog();
            Renovation();
        }

        private void DeleteTicket(object sender, EventArgs e) //Удаление тикета
        {
            string text;
            string Ticket = $"{dataGridView[0, dataGridView.CurrentRow.Index].Value}-{dataGridView[1, dataGridView.CurrentRow.Index].Value}-{dataGridView[2, dataGridView.CurrentRow.Index].Value}-{dataGridView[3, dataGridView.CurrentRow.Index].Value}"; //Заносим параметры с таблицы
            string path = "Tickets.txt";// Путь
            string @new = "";
            using (StreamReader reader = new StreamReader(path))//Читаем файл
            {
                text = reader.ReadToEnd(); //Полностью
            }
            text = text.Replace(Ticket, @new); //Меняем тикет на пустоту
            using (StreamWriter writer = new StreamWriter(path, false)) //Записываем в файл изменение, полностю переписываем
            {
                writer.WriteLineAsync(text);
            }
            Renovation(); //Обновление таблицы
        }

        private void Renovation() // Чтение с файла, запись в таблицу
        {
            dataGridView.Rows.Clear();// Очистка таблицы
            string path = "Tickets.txt";// Путь
            using (StreamReader reader = new StreamReader(path))//Читаем файл
            {
                string @string;
                while ((@string = reader.ReadLine()) != null)// Построчно
                {
                    string[] words = @string.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);//Заносим в массив 4 параметра, разделенные тире
                    if (words.Length > 0)//Проверка на пустые строки, дабы не вызвать ошибку
                    {
                        dataGridView.Rows.Add(words[0], words[1], words[2], words[3]);//Заносим в таблицу
                    }
                }
            }
        }

        private void ClearDataGridView(object sender, EventArgs e) // Очистка таблицы
        {
            Renovation();
        }

        private void FindFlightNumber(object sender, EventArgs e) // Поиск по номеру рейса
        {
            bool find = false; // Проверка на вывод ошибки при не успехе поиска
            string path = "Tickets.txt"; // Путь
            dataGridView.Rows.Clear(); // Очистка таблицы
            using (StreamReader reader = new StreamReader(path)) //Читаем файл
            {
                string @string;
                while ((@string = reader.ReadLine()) != null) // Построчно
                {
                    string[] words = @string.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries); //Заносим в массив 4 параметра, разделенные тире
                    if (words.Length > 0) //Проверка на пустые строки, дабы не вызвать ошибку
                    {
                        if (words[0] == textBox1.Text) //Поиск сходства
                        {
                            dataGridView.Rows.Add(words[0], words[1], words[2], words[3]); //Заносим в таблицу
                            find = true;
                        }
                    }
                }
                if (!find) //Вывод ошибки
                {
                    ErrorMessage();
                }
            }
        }

        private void FindDate(object sender, EventArgs e) //Поиск по дате
        {
            bool find = false; // Проверка на вывод ошибки при не успехе поиска
            string path = "Tickets.txt";// Путь
            dataGridView.Rows.Clear();// Очистка таблицы
            using (StreamReader reader = new StreamReader(path))
            {
                string @string;
                while ((@string = reader.ReadLine()) != null)// Построчно
                {
                    string[] words = @string.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);//Заносим в массив 4 параметра, разделенные тире
                    if (words.Length > 0)//Проверка на пустые строки, дабы не вызвать ошибку
                    {
                        if (words[2] == dateTimePicker1.Value.ToShortDateString())//Поиск сходства
                        {
                            dataGridView.Rows.Add(words[0], words[1], words[2], words[3]);//Заносим в таблицу
                            find = true;
                        }
                    }
                }
                if (!find) //Вывод ошибки
                {
                    ErrorMessage();
                }
            }
        }
        private void ErrorMessage() // Вывод ошибки
        {
            MessageBox.Show("Ничего не найдено!", "Ошибка!", MessageBoxButtons.OK);
        }
    }
}
