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

        }

        private void DeleteTicket(object sender, EventArgs e)
        {

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
    }
}
