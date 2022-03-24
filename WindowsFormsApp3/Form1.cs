using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] week = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
            string[] zz = {"Овен", "Телец", "Близнецы", "Рак", "Лев", "Дева", "Весы", "Скорпион", "Стрелец", "Козерог", "Водолей", "Рыбы"};
            comboBox1.Items.AddRange(zz);
            comboBox2.Items.AddRange(week);   
        }
        string[] pogelanie = {"удачу", "важную встречу", "хорошее настроение",
                                 "новое знакомство",
                                 "сложную работу",
                                 "хорошую рабочую неделю",
                                 "запстись терпением",
                                 "важные выбор, который может изменить вашу жизнь",
                                 "поскорее закончить с делами",
                                 "не отвекать на ненужеые дела",
                                 "по больше трудитесь и концу дня вас ждет сюрприз" };
        Random Rnd = new Random();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string vzz = comboBox1.Text;
            string vweek = comboBox2.Text;
            if (vzz.Length > 0 && vweek.Length > 0)
            {
                listBox1.Items.Add(vzz);
                listBox1.Items.Add($"{vweek} передвещает Вам {pogelanie[Rnd.Next(0, pogelanie.Length)]}");
            }
            else if (comboBox1.SelectedIndex == -1)
            {
                listBox1.Items.Add("Ошибка, выберете Гороскоп");
            }
            else if (comboBox2.SelectedIndex == -1)
            { listBox1.Items.Add("Ошибка, выберете День недели"); }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
