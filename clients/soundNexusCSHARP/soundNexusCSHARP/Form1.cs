using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace soundNexusCSHARP
{
    public partial class Form1 : Form
    {


        void fetchSongs()
        {
            var nexus = new soundnexusdb.soundNexus();
            string songs = nexus.getAllAlbumSongs();
            dynamic val = JsonConvert.DeserializeObject(songs);

            dataGridView1.Rows.Clear();
            if (val == null)
            {
                return;
            }

            foreach (dynamic n in val)
            {
                dataGridView1.Rows.Add(n.title, n.file, n.album);
            }
        }

        void fetchAlbums()
        {

            var nexus = new soundnexusdb.soundNexus();
            string album = nexus.getAllAlbum();
            dynamic val = JsonConvert.DeserializeObject(album);

            comboBox1.Items.Clear();
            if (val == null)
            {
                return;
            }

            foreach (dynamic n in val)
            {
                comboBox1.Items.Add(n.title);
            }
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            fetchSongs();
            fetchAlbums();

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string title = textBox1.Text;
            string file = textBox2.Text;
            string album = comboBox1.Text;

            if (title == string.Empty || file == string.Empty || album == string.Empty)
            {
                MessageBox.Show("Invalid Missing Parameter");
                return;
            }

            var nexus = new soundnexusdb.soundNexus();

            nexus.addAlbumSongs(title, file, album);
            fetchSongs();
            MessageBox.Show("Album Added.");
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.Text = string.Empty;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.form1 = this;
            this.Hide();
            form2.ShowDialog();
            fetchAlbums();
        }
    }
}
