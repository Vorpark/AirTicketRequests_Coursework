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

        private void AddNewTicket(object sender, EventArgs e)
        {
            check = true;
            string path = "FlightTickets.txt";
            if (textBoxFlightNumber.Text == "") 
            {
                ShowErrorMessage("Номер рейса");
            }
            if (textBoxPassengerName.Text == "")
            {
                ShowErrorMessage("Фамилия и инициалы пассажира");
            }
            if (textBoxDestination.Text == "")
            {
                ShowErrorMessage("Место прибытия");
            }

            if (check) 
            {
                AirTicket airTicket = new AirTicket(Int32.Parse(textBoxFlightNumber.Text), textBoxPassengerName.Text, dateTimePicker.Value.ToShortDateString(), textBoxDestination.Text); 

                using (StreamWriter writer = new StreamWriter(path, true)) 
                {
                    writer.WriteLineAsync($"{airTicket.FlightNumber}-{airTicket.PassengerName}-{airTicket.Date}-{airTicket.Destination}"); 
                }
                ClearEmpty(); 
                Close(); 
            }
        }
        private void ClearEmpty() 
        {
            int i;
            string path = "FlightTickets.txt";
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
        private void ShowErrorMessage(string field) 
        {
            MessageBox.Show($"Поле \"{field}\" не может быть пустым!", "Ошибка!", MessageBoxButtons.OK);
            check = false; 
        }
    }
}
