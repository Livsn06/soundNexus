using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soundNexusCSHARP
{
    public partial class Form2 : Form
    {

        public Form1 form1 { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var nexus = new soundnexusdb.soundNexus();

            string title = textBox1.Text;
            string artist = textBox2.Text;
            string genre = comboBox1.Text;
            DateTime datetime = DateTime.Parse(dateTimePicker1.Value.ToString("yyyy-MM-dd"));

            if (title == string.Empty || artist == string.Empty || genre == string.Empty || datetime == null)
            {
                MessageBox.Show("Invalid album.");
                return;
            }

            nexus.addAlbums(title, artist, genre, datetime);
            MessageBox.Show("Album Added.");
            form1.Show();
            this.Close();

        }
    }
}
