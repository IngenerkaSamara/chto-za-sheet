using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            Filters.FillPersons();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person form2 = new Person();
            form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clans form3 = new Clans();
            form3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Spravka form8 = new Spravka();
            form8.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Filters form8 = new Filters();
            form8.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TEAM f = new TEAM();
            f.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
