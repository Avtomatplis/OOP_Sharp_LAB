using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_6
{
    public partial class Form1 : Form
    {
        const string fileTrain = "trainSchedule.json";
        static string patternString = @"^[A-Za-zА-Яа-я]+$";

        public Form1()
        {
            Task.Run(() => File.Open(fileTrain, FileMode.OpenOrCreate).Close());
            InitializeComponent();
        }

        private void ButtonCloseForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        async private void ButtonCreateTrain_Click(object sender, EventArgs e)
        {
            if (IsString(textBoxCity.Text))
            {
                int findID = (int)numericFindID.Value;
                TrainInfo trainInfo = new TrainInfo((int)numericID.Value,textBoxCity.Text,(int)numericPlatform.Value);
                var trains = await ReadFromFile<TrainInfo>(fileTrain);
                trains.Add(trainInfo);
                await WriteToFile(trains, fileTrain);
                MessageBox.Show("успешно добавлен");
            }
            else
            {
                Exception.MessageBox(0, "Неверно введены значения", "Ошибка", 0);
            }
        }

        private bool IsString(string input)
        {
            Match match = Regex.Match(input, patternString);
            return match.Success;
        }

        async private void ButtonGetInfoTrain_Click(object sender, EventArgs e)
        {
            int findID = (int)numericFindID.Value;
            var trains = await ReadFromFile<TrainInfo>(fileTrain);
            if (trains.Count == 0)
            {
                Exception.MessageBox(0, "пустое расписание", "ошибка", 0);
            }
            else
            {
                foreach (var train in trains)
                {
                    if (train.Id == (int)numericFindID.Value)
                    {
                        ITrainSchedule trainSchedule = new TrainScheduleProxy();
                        TrainInfo trainInfo = trainSchedule.GetTrainInfo(findID);
                        MessageBox.Show(trainInfo.ToString());
                        break;
                    }
                    else
                    {
                        Exception.MessageBox(0, $"поезда с таким id: {findID} не существует",
                            "ошибка", 0);
                        break;
                    }
                }
            }
        }

        //запись в файл json
        async Task WriteToFile<T>(List<T> data, string FILE_NAME)
        {
            using (var streamWriter = new StreamWriter(FILE_NAME, false))
            {
                await streamWriter.WriteAsync(await Task.Run(() => JsonConvert.SerializeObject(data)));
            }
        }

        //чтение из файла json
        async Task<List<T>> ReadFromFile<T>(string FILE_NAME)
        {
            using (var streamReader = new StreamReader(FILE_NAME))
            {
                return await Task.Run(async () =>
                JsonConvert.DeserializeObject<List<T>>(await streamReader.ReadToEndAsync()) ?? new List<T>());
            }
        }

        async private void ButtonClearJson_Click(object sender, EventArgs e)
        {
            var pattiens = await ReadFromFile<TrainInfo>(fileTrain);
            pattiens.Clear();
            await WriteToFile(pattiens, fileTrain);
            MessageBox.Show("Очередь очищена");
        }

      async private void Form1_Load(object sender, EventArgs e)
        {
            var pattiens = await ReadFromFile<TrainInfo>(fileTrain);
            pattiens.Clear();
            await WriteToFile(pattiens, fileTrain);
        }
    }
}
