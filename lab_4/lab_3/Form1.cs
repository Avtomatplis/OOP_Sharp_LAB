using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Diagnostics;

namespace lab_4
{
    public partial class Form1 : Form
    {
        string idiotName = "gfgf";
        Human temp;
        public Form1()
        {
            InitializeComponent();
            listView1.Items.Add("Последовательная");
            listView1.Items.Add("Случайная");

        }
        
        public static void NewObjectClear(object sender, EventArgs e)
        {
            MessageBox.Show("вы удалили все обьекты");
        }

        private void CreateObject_Click(object sender, EventArgs e)
        {
            string name = NewName.Text;
            string secondName = SecondName.Text;
            string country = Country.Text;
            int age = (int)Age.Value;
            int height = (int)Height.Value;
            int numberOfChildren = (int)NumberOfChildren.Value;
            double weight = (double)Weight.Value;
            if (exeminationString(name)&&exeminationString(secondName)&&exeminationString(country))
            {
               
                myStack.Push(new Human(age, weight, name, secondName, numberOfChildren, country, height));
            ChangeComboBox1();
               
                NumberOfObjects.Text = "Добавлено обьектов: " + Human.ObjectsCount;
            }
            else
            {
                Exception.MessageBox(0, "Введите корректные значения.Имя, фамилия и город должны быть символами Кириллицы!",
                       "Ошибка!", 0);
            }
            
        }

        private void CloseProject_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChangeComboBox1()
        {
            if (myStack.Count() == 0)
            {
                comboBox1.Items.Clear();
                NumberOfObjects.Text = " ";
                comboBox1.Text = " ";
            }
            else
            {
                int selected = comboBox1.SelectedIndex;
                comboBox1.Items.Clear();
                foreach (var number in myStack.humanStack())
                    comboBox1.Items.Add(number.Name);
                comboBox1.SelectedIndex = comboBox1.Items.IndexOf(selected);
            }
        }

        private void Change_Click(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem as string;
            if (selected == null) return;
            else if (exeminationString(NewName.Text) && exeminationString(SecondName.Text) && exeminationString(Country.Text))
            {
                Human human = myStack.FirstOrDefault(selected);
                human.Name = NewName.Text;
                human.SecondName = SecondName.Text;
                human.Country = Country.Text;
                human.Age = (int)Age.Value;
                human.Height = (int)Height.Value;
                human.NumberOfChildren = (int)NumberOfChildren.Value;
                human.Weight = (double)Weight.Value;
                label8.Text = (human).ToString();
                ChangeComboBox1();
            }
            else
            {
                Exception.MessageBox(0, "Недопустимое значение имени, фамилии или города.", "Ошибка!", 0);
                return;
            }
        }

        private void CreateException_Click(object sender, EventArgs e)
        {
            try
            {
                OutOfMemoryException();
            }
            catch (StackOverflowException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OutOfMemoryException()
        {
            throw new StackOverflowException("Ты вызвал OutOfMemoryException");
        }

        private void SeeObject_Click(object sender, EventArgs e)
        {
            string selectedObject = comboBox1.SelectedItem as string;
            if (selectedObject != null)
            {
                Human human = myStack.FirstOrDefault(selectedObject);
                label8.Text=(human).ToString();
            }
        }

        private bool isString(string input)
        {
            string pattern = @"^[A-Za-zА-Яа-я]+$";
            Match match = Regex.Match(input, pattern);
            return match.Success;
        }

        bool exeminationString(string newString)
        {
            bool flag = true;
            if (!(newString == ""))
            {
                if (!(isString(newString)))
                {
                    flag = false;
                    Exception.MessageBox(0, "Введено некорректное поле.", "Ошибка!", 0);
                }
            }
            return flag;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void deleteObject_Click(object sender, EventArgs e)
        {
            string selectedObject = comboBox1.SelectedItem as string;
            if (selectedObject != null)
            {
                myStack.Pop(selectedObject);
                ChangeComboBox1();
                NumberOfObjects.Text = "Добавлено обьектов: " + Human.ObjectsCount;
                comboBox1.Text = "";
                label8.Text = "";
            }
        }

        private void PrintAll_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2(this);
            newForm.Show();
        }

        private void ShowTime_Click(object sender, EventArgs e)
        {
            ListViewItem lv1 = new ListViewItem();
            ListViewItem lv2 = new ListViewItem();
            lv1.Text = "Последовательная";
            lv2.Text = "Случайная";
            Random random = new Random();
            const int N = 10000;
            Human[] array = new Human [N];

            for (int i = 0; i < N; i++)
            {
                myStack.Push(new Human());
                array[i] = new Human();
            }

            Stopwatch TimeArraySuccessively = new Stopwatch();
            Stopwatch TimeStackSuccessively = new Stopwatch();

            TimeStackSuccessively.Start();
           foreach (Human human in myStack.humanStack()) 
            {
                human.Name = idiotName;
                temp = human; 
            }
            TimeStackSuccessively.Stop();

            TimeArraySuccessively.Start();
            foreach (Human human in array) 
            {
                human.Name = idiotName;
                temp = human;
            }
            TimeArraySuccessively.Stop();

            Stopwatch TimeArrayRandom = new Stopwatch();
            Stopwatch TimeStackRandom = new Stopwatch();

            TimeStackRandom.Start();
            foreach (Human human in myStack.humanStack())
            { 
                temp = myStack.humanStack().ElementAt(random.Next(0, N)); 
            }
            TimeStackRandom.Stop();

            TimeArrayRandom.Start();
            for (int i = 0; i < N; i++)
            {
                int index = random.Next(0, N);
                temp = array[index];
                array[index].Name = idiotName;
            }
            TimeArrayRandom.Stop();

            myStack.Clear();
            Array.Clear(array, 0, array.Length);
            lv1.SubItems.Add(TimeStackSuccessively.ElapsedTicks.ToString());
            lv1.SubItems.Add(TimeArraySuccessively.ElapsedTicks.ToString());
            lv2.SubItems.Add(TimeStackRandom.ElapsedTicks.ToString());
            lv2.SubItems.Add(TimeArrayRandom.ElapsedTicks.ToString());
            listView1.Items[0] = lv1;
            listView1.Items[1] = lv2;
        }

        private void GenerateObject_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            Random rnd2 = new Random();
            int N = rnd2.Next(100, 200);
            for (int i = 0; i < N; i++)
            {
                string name = stringNameConvertor();
                string secondName = stringSecondNameConvertor();
                string country = stringCountryConvertor();
                int age = rnd.Next(1, 100);
                int height = rnd.Next(1, 300);
                int numberOfChildren = rnd.Next(0, 100);
                double weight = rnd.Next(1, 200);
                myStack.Push(new Human(age, weight, name, secondName, numberOfChildren, country, height));
                ChangeComboBox1();
                NumberOfObjects.Text = "Добавлено обьектов: " + Human.ObjectsCount;

            }
        }
        private string stringNameConvertor()
        {
            string[] names = { "Иван", "Пётр", "Мария", "Екатерина", "Александра",
            "Максим", "Михаил", "Олеся", "Анастасия", "Вероника","Кирилл", "Владимир", "Никита", 
                "Елизавета", "Татьяна"};
            Random randomize = new Random();
            string name = names[randomize.Next(names.Length)];
            return name;
        }
        private string stringSecondNameConvertor()
        {
            string[] secondnames = { "Ерёмин", "Петров", "Сидоров", "Котельникова", "Иванова",
            "Брюзгина", "Ахметова", "Карлин", "Копылов", "Карамышев","Демидова", "Фомина", "Аитова", 
                "Пронин", "Дырко"};
            Random randomize = new Random();
            string secondname = secondnames[randomize.Next(secondnames.Length)];
            return secondname;
        }
        private string stringCountryConvertor()
        {
            string[] country = { "Пенза", "Москва", "Санкт-Петербург", "Самара", "Волгоград", "Саратов",
            "Астрахань","Нижневартовск","Кузнецк","Сыктывкар","Краснодар","Калуга","Омск",
                "Нижний новгород","Воркута",};
            Random randomize = new Random();
            string countrys = country[randomize.Next(country.Length)];
            return countrys;
        }
        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Weight_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myStack.Clear();
            ChangeComboBox1();
            NumberOfObjects.Text = "Добавлено обьектов: " + Human.ObjectsCount;
            comboBox1.Text = " ";
            label8.Text = " ";
            
            myStack.objectAllClear += NewObjectClear;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LinqForm_Click(object sender, EventArgs e)
        {
            LINQWindow LinqForm = new LINQWindow (this);
            LinqForm.Show();
        }

        private void StringForm_Click(object sender, EventArgs e)
        {
            StringForm stringForm = new StringForm (this);
            stringForm.Show();
        }
    }
}
