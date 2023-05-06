using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace lab_5
{
    public partial class Form1 : Form
    {
        static List<TrainStation> trainStations = new List<TrainStation>();

        public Form1()
        {
            InitializeComponent();
        }

        private void CloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CreateObject_Click(object sender, EventArgs e)
        {
            string name = StationName.Text;
            int employees = (int)ValueEmployees.Value;
            int trains = (int)ValueTrains.Value;
            string directorName = NameDirector.Text;
            if (ExeminationString(name) && ExeminationString(directorName))
            {
                trainStations.Add(new TrainStation(name,employees,trains,directorName));
                ChangeComboBox1();
                NumberOfObjects.Text = "Добавлено обьектов: " +TrainStation.TrainStationCount;
            }
            else
            {
                Exception.MessageBox(0, "Введите корректные значения.Название станции и имя директора должны быть символами Кириллицы!",
                       "Ошибка!", 0);
            }
        }

        private bool IsString(string input)
        {
            string pattern = @"^[A-Za-zА-Яа-я]+$";
            Match match = Regex.Match(input, pattern);
            return match.Success;
        }

        bool ExeminationString(string newString)
        {
            bool flag = true;
            if (!(newString == ""))
            {
                if (!(IsString(newString)))
                {
                    flag = false;
                    Exception.MessageBox(0, "Введено некорректное поле.", "Ошибка!", 0);
                }
            }
            return flag;
        }

        private void ChangeComboBox1()
        {
            if (trainStations.Count == 0)
                NumberOfObjects.Text = "";
            else
            {
                int selected = TrainsBox.SelectedIndex;
                TrainsBox.Items.Clear();
                foreach (var number in trainStations)
                    TrainsBox.Items.Add(number.Name);
                TrainsBox.SelectedIndex = TrainsBox.Items.IndexOf(selected);
            }
        }

        private void CloneObject_Click(object sender, EventArgs e)
        {
            int selected = TrainsBox.SelectedIndex;
            if (selected == -1) return;

            TrainStation clone = trainStations[selected].Clone() as TrainStation;
            trainStations.Add(clone);

            ChangeComboBox1();
            NumberOfObjects.Text = "Добавлено обьектов: " + TrainStation.TrainStationCount;
        }

        private void SeeObject_Click_1(object sender, EventArgs e)
        {
            int selected = TrainsBox.SelectedIndex;
            if (selected == -1) return;
            labelTrainStations.Text = trainStations[selected].GetInfo().ToString();
            ChangeComboBox1();
           
        }

        private void ChangeObject_Click(object sender, EventArgs e)
        {
            int selected = TrainsBox.SelectedIndex;
            if (selected == -1) return;
            else if (ExeminationString(StationName.Text) && ExeminationString(NameDirector.Text))
            {
                TrainStation changeObject = trainStations[selected];

                changeObject.Name = StationName.Text;
                changeObject.EmployeesInStation = (int)ValueEmployees.Value;
                changeObject.NumberOfTrains = (int)ValueTrains.Value;
                changeObject.DirectorName = NameDirector.Text;
                labelTrainStations.Text = changeObject.GetInfo().ToString();

                ChangeComboBox1();
            }
            else
            {
                Exception.MessageBox(0, "Недопустимое значение имени, фамилии или города.", "Ошибка!", 0);
                return;
            }
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            trainStations.Clear();
            TrainStation.TrainStationCount = 0;
            ChangeComboBox1();
            NumberOfObjects.Text = "Добавлено обьектов: " + TrainStation.TrainStationCount;
            TrainsBox.Text = " ";
            labelTrainStations.Text = " ";
            TrainsBox.DataSource = null;
            TrainsBox.Items.Clear();
            TrainsBox.ResetText();
        }

        private void ButtonGetDirectorInfo_Click(object sender, EventArgs e)
        {

        }
    }
}
