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
            UpdateTable();
        }

        private void AddFlightTicket(object sender, EventArgs e) 
        {
            var addForm = new AddTicket();
            addForm.ShowDialog();
            UpdateTable();
        }

        private void DeleteFlightTicket(object sender, EventArgs e) 
        {
            string text;
            string Ticket = $"{table[0, table.CurrentRow.Index].Value}-{table[1, table.CurrentRow.Index].Value}-{table[2, table.CurrentRow.Index].Value}-{table[3, table.CurrentRow.Index].Value}";
            string path = "FlightTickets.txt";
            string @new = "";
            using (StreamReader reader = new StreamReader(path))
            {
                text = reader.ReadToEnd();
            }
            text = text.Replace(Ticket, @new); 
            using (StreamWriter writer = new StreamWriter(path, false)) 
            {
                writer.WriteLineAsync(text);
            }
            UpdateTable(); 
        }

        private void UpdateTable() 
        {
            table.Rows.Clear();
            string path = "FlightTickets.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string @string;
                while ((@string = reader.ReadLine()) != null)
                {
                    string[] words = @string.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    if (words.Length > 0)
                    {
                        table.Rows.Add(words[0], words[1], words[2], words[3]);
                    }
                }
            }
        }

        private void ClearTable(object sender, EventArgs e) 
        {
            UpdateTable();
        }

        private void SortFlightNumber(object sender, EventArgs e) 
        {
            bool find = false; 
            string path = "FlightTickets.txt"; 
            table.Rows.Clear(); 
            using (StreamReader reader = new StreamReader(path)) 
            {
                string @string;
                while ((@string = reader.ReadLine()) != null) 
                {
                    string[] words = @string.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries); 
                    if (words.Length > 0) 
                    {
                        if (words[0] == textBoxFlightNumber.Text) 
                        {
                            table.Rows.Add(words[0], words[1], words[2], words[3]); 
                            find = true;
                        }
                    }
                }
                if (!find) 
                {
                    ShowErrorMessage();
                }
            }
        }

        private void SortDate(object sender, EventArgs e) 
        {
            bool find = false; 
            string path = "FlightTickets.txt";
            table.Rows.Clear();
            using (StreamReader reader = new StreamReader(path))
            {
                string @string;
                while ((@string = reader.ReadLine()) != null)
                {
                    string[] words = @string.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    if (words.Length > 0)
                    {
                        if (words[2] == dateTimePicker.Value.ToShortDateString())
                        {
                            table.Rows.Add(words[0], words[1], words[2], words[3]);
                            find = true;
                        }
                    }
                }
                if (!find) 
                {
                    ShowErrorMessage();
                }
            }
        }
        private void ShowErrorMessage() 
        {
            MessageBox.Show("Ничего не обнаружено!", "Ошибка!", MessageBoxButtons.OK);
        }
    }
}
