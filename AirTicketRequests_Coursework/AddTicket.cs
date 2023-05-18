using System;
using System.IO;
using System.Windows.Forms;

namespace AirTicketRequests_Coursework
{
    public partial class AddTicket : Form
    {
        bool check;
        public AddTicket()
        {
            InitializeComponent();
        }

        private void AddNewTicket(object sender, EventArgs e) //Добавляем новый тикет
        {
            check = true; //Считывает проверки входных данных
            string path = "Tickets.txt"; //Путь файла, сохраняется в папке программы
            if (!int.TryParse(textBox1.Text, out int flightNumber) && textBox1.Text == "") //Проверки
            {
                ErrorMessage("Номер рейса");
            }
            if (textBox2.Text == "")
            {
                ErrorMessage("Фамилия и инициалы пассажира");
            }
            if (textBox4.Text == "")
            {
                ErrorMessage("Место прибытия");
            }

            if (check) //При успешной проверке идет запись в файл
            {
                AirTicket airTicket = new AirTicket(flightNumber, textBox2.Text, dateTimePicker1.Value.ToShortDateString(), textBox4.Text); //Создание класса

                using (StreamWriter writer = new StreamWriter(path, true)) //Запись в файл
                {
                    writer.WriteLineAsync($"{airTicket.FlightNumber}-{airTicket.PassengerName}-{airTicket.Date}-{airTicket.Destination}"); //Сама запись
                }
                ClearEmpty(); //Очистка
                Close(); //Закрытие формы при успехе
            }
        }
        private void ClearEmpty() //Удаляем пустые строки, могут образоваться из-за удаления из файла тикетов
        {
            int i;
            string path = "Tickets.txt";
            string[] text = System.IO.File.ReadAllLines(path); //Читаем весь файл
            StreamWriter File = System.IO.File.CreateText(path);
            for (i = 0; i < text.Length; i++) //Удаляем пустые строки
            {
                if (text[i] != "")
                {
                    File.WriteLine(text[i]);
                }
            }
            File.Close();//Закрываем файл 
        }
        private void ErrorMessage(string field) //Вывод ошибки
        {
            MessageBox.Show($"Поле \"{field}\" не может быть пустым!", "Ошибка!", MessageBoxButtons.OK);
            check = false; //Проверка провалена
        }
    }
}
