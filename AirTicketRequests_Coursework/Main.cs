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

        private void AddTicket(object sender, EventArgs e)
        {
            var addForm = new AddTicket();
            addForm.ShowDialog();
            Renovation();
        }

        private void DeleteTicket(object sender, EventArgs e)
        {
            string text;
            string Ticket = $"{dataGridView[0, dataGridView.CurrentRow.Index].Value} {dataGridView[1, dataGridView.CurrentRow.Index].Value} {dataGridView[2, dataGridView.CurrentRow.Index].Value} {dataGridView[3, dataGridView.CurrentRow.Index].Value}";
            string path = "Tickets.txt";
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
            Renovation();
        }

        private void Renovation()
        {
            dataGridView.Rows.Clear();
            string path = "Tickets.txt";
            using (StreamReader reader = new StreamReader(path))
            {
                string @string;
                while ((@string = reader.ReadLine()) != null)
                {
                    string[] words = @string.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    if (words.Length > 0)
                    {
                        dataGridView.Rows.Add(words[0], words[1], words[2], words[3]);
                    }
                }
            }
        }

        private void ClearDataGridView(object sender, EventArgs e)
        {
            Renovation();
        }

        private void FindFlightNumber(object sender, EventArgs e)
        {
            bool find = false;
            string path = "Tickets.txt";
            dataGridView.Rows.Clear();
            using (StreamReader reader = new StreamReader(path))
            {
                string @string;
                while ((@string = reader.ReadLine()) != null)
                {
                    string[] words = @string.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    if (words.Length > 0)
                    {
                        if (words[0] == textBox1.Text)
                        {
                            dataGridView.Rows.Add(words[0], words[1], words[2], words[3]);
                            find = true;
                        }
                    }
                }
                if (!find)
                {
                    ErrorMessage();
                }
            }
        }

        private void FindDate(object sender, EventArgs e)
        {
            bool find = false;
            string path = "Tickets.txt";
            dataGridView.Rows.Clear();
            using (StreamReader reader = new StreamReader(path))
            {
                string @string;
                while ((@string = reader.ReadLine()) != null)
                {
                    string[] words = @string.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                    if (words.Length > 0)
                    {
                        if (words[2] == dateTimePicker1.Value.ToShortDateString())
                        {
                            dataGridView.Rows.Add(words[0], words[1], words[2], words[3]);
                            find = true;
                        }
                    }
                }
                if (!find)
                {
                    ErrorMessage();
                }
            }
        }
        private void ErrorMessage()
        {
            MessageBox.Show("Ничего не найдено!", "Ошибка!", MessageBoxButtons.OK);
        }
    }
}
