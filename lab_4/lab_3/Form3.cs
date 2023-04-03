using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab_4
{
    public partial class LINQWindow : Form
    {
        CollectionType<Human> _humans=new CollectionType<Human>();


        public LINQWindow(Form1 form1)
        {
            InitializeComponent();

            _humans.Add(new Human(17,67,"вася","ибрагимов",0,"пенза",167));
            _humans.Add(new Human(17,89,"петя","ибрагимов",0,"пенза",187));
            _humans.Add(new Human(29,67,"коля","нетт",0,"пенза",182));
            _humans.Add(new Human(33,67,"лена","вангер",0,"пенза",156));
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void PrintCollection_Click(object sender, EventArgs e)
        {
            foreach (Human human in _humans)
            {
                dataGridView1.Rows.Add(human.Name, human.SecondName, human.Age,
                    human.Country, human.Height, human.Weight, human.NumberOfChildren);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SortCollection_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); 
            _humans.Sort();
            foreach (Human human in _humans)
            {
                dataGridView1.Rows.Add(human.Name, human.SecondName, human.Age,
                    human.Country, human.Height, human.Weight, human.NumberOfChildren);
            }
        }

        private async void InsertToFile_Click(object sender, EventArgs e)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var library in _humans)
            {
                stringBuilder.AppendLine(library.ToString());
            }
            using (StreamWriter writer = new StreamWriter(@"E:\Афонин с#\lab_rab\humans.txt", false))
            {
                await writer.WriteLineAsync(stringBuilder.ToString());
            }
        }

        private void LINQ_Click(object sender, EventArgs e)
        {
            Human human1 = _humans.GetList().Where(human=>human.Age>2).Reverse().First();
            label1.Text = human1.Name;

            bool result = _humans.GetList().Skip(2).Take(3).All(human=>human.NumberOfChildren==0);
            label2.Text = result.ToString();

            int count = _humans.GetList().SkipWhile(human => human.Height < 167).TakeWhile(human => human.Age > 0).Count();
            label3.Text= count.ToString();

           int sum = _humans.GetList().OrderBy(human=>human.Name).Take(1).Sum(human=>human.Age);
            label4.Text= sum.ToString();

           bool result2 = _humans.GetList().Where(human=>human.Age > 0).TakeWhile(human=>human.Age<100).Any();
            label5.Text= result2.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
