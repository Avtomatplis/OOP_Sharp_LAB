using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_4
{
    public partial class StringForm : Form
    {
        List<string> listString = new List<string>();
        List<string>[] _lists;


        public StringForm(Form1 form)
        {
            InitializeComponent();
        }

        private void StringForm_Load(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Close();    
        }

        private void PrintStringCollection_Click(object sender, EventArgs e)
        {
            if (_lists==null || _lists.Any(element => element.Count == 0))
            {
                Exception.MessageBox(0, "Массив не был создан!", "Ошибка", 0);
                return;
            }
            for (int i = 0; i < _lists.Length; i++)
            {
                for (int j = 0; j < _lists[i].Count; j++)
                {
                    FillOutputLog($"array line: {i}, linkedList element: {j}, value: {_lists[i].ElementAt(j)}", ConsoleText);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateCollection_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            List<string>[] list = new List<string>[random.Next(1, (int)LengthArray.Value)];
            for (int i = 0; i < list.Length; i++)
            {
                list[i] = new List<string>();
            }
            for (int k = 0; k < list.Length; k++)
            {
                int collectionLength = random.Next(1, (int)LengthCollection.Value);
                for (int i = 0; i < collectionLength; i++)
                {
                    int length = random.Next((int)LengthFrom.Value, (int)LengthTo.Value);
                    StringBuilder stringBuilder = new StringBuilder();
                    for (int j = 0; j < length; j++)
                    {
                        stringBuilder.Append(Convert.ToChar(Convert.ToInt32(Math.Floor(25 * random.NextDouble())) + 65));
                    }
                    list[k].Add(stringBuilder.ToString());
                }
            }
            _lists = list;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        public static void FillOutputLog(string message, TextBox textBox, string fillDivider = null)
        {
            if (message == null)
                return;

            textBox.Text += message + "\r" + "\n";
            if (fillDivider != null)
            {
                textBox.Text += fillDivider + "\r" + "\n";
            }
        }

        private async void ExecuteOperationString_Click(object sender, EventArgs e)
        {
            if (LengthStringForSearch.Text == "")
            {
                Exception.MessageBox(0, "Введите значение для поиска!", "Ошибка", 0);
                return;
            }
            if (_lists == null || _lists.Any((element => element.Count == 0)))
            {
                Exception.MessageBox(0, "Массив не был создан!", "Ошибка", 0);
                return;
            }
         
            //string.IsNullOrEmpty(LengthStringForSearch.Text)
            ConsoleText.Clear();

            FillOutputLog("1) СОХРАНЕНИЕ В ФАЙЛ", ConsoleText);
            StringBuilder stringBuilder = new StringBuilder();
            for (int i = 0; i < _lists.Length; i++)
            {
                for (int j = 0; j < _lists[i].Count; j++)
                {
                    stringBuilder.Append($"array line: {i}, linkedList element: {j}, value: {_lists[i].ElementAt(j)}");
                }
            }
            using (StreamWriter writer = new StreamWriter(@"E:\Афонин с#\lab_rab\strings.txt", false))
            {
                await writer.WriteLineAsync(stringBuilder.ToString());
            }
            FillOutputLog("Сохранение в файл произошло успешно", ConsoleText);

            FillOutputLog("2) ПОИСК СТРОК ПО ЗНАЧЕНИЮ", ConsoleText);
            FillOutputLog($"По значению {LengthStringForSearch.Text} найдено:", ConsoleText);
            for (int i = 0; i < _lists.Length; i++)
            {
                for (int j = 0; j < _lists[i].Count; j++)
                {
                    if (_lists[i].ElementAt(j).Contains(LengthStringForSearch.Text))
                    {
                        FillOutputLog($"array line: {i}, linkedList element: {j}, value: " +
                            $"{_lists[i].ElementAt(j)}", ConsoleText);
                    }
                }
            }

            FillOutputLog("3) ПОИСК СТРОК ПО ДЛИНЕ", ConsoleText);
            int length = (int)LengthN.Value;
            int count = 0;
            foreach (var item in _lists)
            {
                count += item.Where(str => str.Length == length).Count();
            }
            FillOutputLog($"По длине {LengthN.Value} найдено: {count} строк", ConsoleText);
            int collectionsLength = _lists.Count(list => list.Count == (int)LengthCollectionN.Value);
            FillOutputLog($"Количество коллекций длины n: {collectionsLength}", ConsoleText);
            int max = _lists.Max(list => list.Count);
            FillOutputLog($"Максимальная длина коллекции: {max}", ConsoleText);
            int min = _lists.Min(list => list.Count);
            FillOutputLog($"Минимальная длина коллекции: {min}", ConsoleText);


            FillOutputLog("4) СОРТИРОВКА В ВОЗРАСТАЮЩЕМ ПОРЯДКЕ", ConsoleText);
            foreach (var item in _lists)
            {
                item.OrderBy(str => str);
            }
            for (int i = 0; i < _lists.Length; i++)
            {
                for (int j = 0; j < _lists[i].Count; j++)
                {
                    FillOutputLog($"array line: {i}, linkedList element: {j}, value: {_lists[i].ElementAt(j)}", ConsoleText);
                }
            }

            FillOutputLog("5) СОРТИРОВКА В УБЫВАЮЩЕМ ПОРЯДКЕ", ConsoleText);
            foreach (var item in _lists)
            {
                item.OrderByDescending(str => str);
            }
            for (int i = 0; i < _lists.Length; i++)
            {
                for (int j = 0; j < _lists[i].Count; j++)
                {
                    FillOutputLog($"array line: {i}, linkedList element: {j}, value: {_lists[i].ElementAt(j)}", ConsoleText);
                }
            }

            FillOutputLog("======================================", ConsoleText);
        }
    }
}
