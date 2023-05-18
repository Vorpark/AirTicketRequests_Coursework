using System;
using System.IO;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace AirTicketRequests_Coursework
{
    public partial class AddTicket : Form
    {
        bool check;
        public AddTicket()
        {
            InitializeComponent();
        }

        private void AddNewTicket(object sender, EventArgs e)
        {
            check = true;
            string path = "Tickets.txt";
            if (!int.TryParse(textBox1.Text, out int flightNumber) && textBox1.Text == "")
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

            if (check)
            {
                AirTicket airTicket = new AirTicket(flightNumber, textBox2.Text, dateTimePicker1.Value.ToShortDateString(), textBox4.Text);
                string ticket = $"{airTicket.FlightNumber}-{airTicket.PassengerName}-{airTicket.Date}-{airTicket.Destination}";

                using (StreamWriter writer = new StreamWriter(path, true))
                {
                    writer.WriteLineAsync(ticket);
                }
                ClearEmptyLines();
                Close();
            }
        }
        private void ClearEmptyLines()
        {
            int i;
            string path = "Tickets.txt";
            string[] text = System.IO.File.ReadAllLines(path);
            StreamWriter File = System.IO.File.CreateText(path);
            for (i = 0; i < text.Length; i++)
            {
                if (text[i] != "")
                {
                    File.WriteLine(text[i]);
                }
            }
            File.Close();
        }
        private void ErrorMessage(string field)
        {
            MessageBox.Show($"Поле \"{field}\" не может быть пустым!", "Ошибка!", MessageBoxButtons.OK);
            check = false;
        }
    }
}
