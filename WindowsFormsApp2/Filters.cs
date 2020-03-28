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
    public struct Per
    {
        public string name;
        public string sost;
        public int age;
        public Label b;
        public PictureBox pix;
        
        public Per(string name1, string sost1, int age1)
        {
            name = name1;
            age = age1;
            sost = sost1;
            b = new Label();
            pix = new PictureBox();
        }
    }

    public partial class Filters : Form
    {
        public static Per[] persons = new Per[18];
        public static List<Per> team = new List<Per>();

        public static void FillPersons()
        {
            persons[0] = new Per("Цзинь Гуанъяо", "Мертв", 500);
            persons[1] = new Per("Цзинь Гуань Шань", "Мертв", 500);
            persons[2] = new Per("Цзинь Лин", "Жив", 15);
            persons[3] = new Per("Цзинь Цзы Сюань", "Мертв", 500);
            persons[4] = new Per("Цзян Фэн Мянь", "Мертв", 500);
            persons[5] = new Per("Цзян Чэн", "Жив", 34);
            persons[6] = new Per("Вей Усянь", "Мертв", 35);
            persons[7] = new Per("Цзян Янь Ли", "Мертв", 500);
            persons[8] = new Per("Лань Ван Цзы", "Жив", 35);
            persons[9] = new Per("Лань Сичень", "Жив", 38);
            persons[10] = new Per("Лань Сычжуй и Лань Цзинъи", "Жив", 15 - 16);
            persons[11] = new Per("Лань Цижэнь", "Мертв", 500);
            persons[12] = new Per("Вэнь Жо Хань", "Мертв", 500);
            persons[13] = new Per("Вэнь Нин", "Мертв", 34);
            persons[14] = new Per("Вэнь Цин", "Мертв", 500);
            persons[15] = new Per("Вэнь Чжао", "Мертв", 500);
            persons[16] = new Per("Не Хуай Сан", "Жив", 34);
            persons[17] = new Per("Не Мин Цзюэ", "Мертв", 500);

            int x = 10;
            int y = 200;
            for (int i = 0; i < persons.Length; i = i + 1)
            {
                persons[i].pix.Location = new Point(x, y);
                persons[i].pix.Size = new Size(100, 100);
                persons[i].pix.Text = persons[i].name;
                persons[i].pix.SizeMode = PictureBoxSizeMode.Zoom;
                persons[i].pix.Click += new EventHandler(button2_Click);
                persons[i].pix.Load("../../Pictures/Persons/" + persons[i].name + ".jpg");
            

                persons[i].b.Location = new Point(x, y + 100);
                persons[i].b.Size = new Size(100, 30);
                persons[i].b.Text = persons[i].name;

                x = x + 100;
                if (x + 100 > 500)
                {
                    x = 10;
                    y = y + 150;
                }
            }
        }

        
        public Filters()
        {
            InitializeComponent(); 

            
            int x = 10;
            int y = 200;
            for (int i = 0; i < persons.Length; i = i + 1)
            {
                persons[i].pix.Location = new Point(x, y);
                Controls.Add(persons[i].pix);
                
                persons[i].b.Location = new Point(x, y + 100);
                Controls.Add(persons[i].b);

                x = x + 100;
                if (x + 100 > Width)
                {
                    x = 10;
                    y = y + 150;
                }
            }
        }

        private void Filters_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 10;
            int y = 200;
            for (int i = 0; i < persons.Length; i = i + 1)
            {
                persons[i].b.Visible = false;
                persons[i].pix.Visible = false;
                bool show = true;



                if (nameBox1.Text != "" && persons[i].name != nameBox1.Text)
                {
                    show = false;
                }

                else if (sostBox2.Text != "" && persons[i].sost != sostBox2.Text)
                {
                    show = false;
                }
                
                else if (ageBox3.Text != "" && persons[i].age > Convert.ToInt32(ageBox3.Text))
                {
                    show = false;
                }


                if (show)
                {
                    persons[i].pix.Visible = true;
                    persons[i].pix.Location = new Point(x, y);
                    persons[i].b.Visible = true;
                    persons[i].b.Location = new Point(x, y + 100);
                    x = x + 100;
                    if (x + 100 > Width)
                    {
                        x = 10;
                        y = y + 150;
                    }
                }
            }
        }
        
        public static void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < persons.Length; i = i + 1)
            {
                if (((PictureBox)sender).Image == persons[i].pix.Image)
                {
                    prsn f = new prsn(persons[i]);
                    f.Show();
                }
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
