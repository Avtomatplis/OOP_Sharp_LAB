using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work_FestivalFilmov_Afonin
{
    public partial class ParticipantsFestivalForm : Form
    {
        const string FileParticipants = "Participants.json";
        //const string FileFilm = "Film.json";

        int numberParticipants = 0;
        int countParticipants = 0;

        public ParticipantsFestivalForm()
        {
            Task.Run(() => File.Open(FileParticipants, FileMode.OpenOrCreate).Close());
            //  Task.Run(() => File.Open(FileFilm, FileMode.OpenOrCreate).Close());
            InitializeComponent();
        }
        //запись в файл json
        async Task WriteToFile<T>(List<T> data, string FILE_NAME)
        {
            using (var streamWriter = new StreamWriter(FILE_NAME, false))
            {
                await streamWriter.WriteAsync(await Task.Run(() => JsonConvert.SerializeObject(data)));
            }
        }

        //  чтение из файла json
        async Task<List<T>> ReadFromFile<T>(string FILE_NAME)
        {
            using (var streamReader = new StreamReader(FILE_NAME))
            {
                return await Task.Run(async () =>
                JsonConvert.DeserializeObject<List<T>>(await streamReader.ReadToEndAsync()) ?? new List<T>());
            }
        }

        async private void ButtonCreateParticipants_Click(object sender, EventArgs e)
        {

            ParticipantsForm formParticipants = new ParticipantsForm();
            formParticipants.ShowDialog();

            string nameParticipantsForm = ParticipantsForm.NameParticipantsForm;
            string lastNameParticipantsForm = ParticipantsForm.LastNameParticipantsForm;
            string cityParticipantsForm = ParticipantsForm.CityParticipantsForm;
            int ageParticipantsForm = ParticipantsForm.AgeParticipantsForm;

            Participants newParticipants = new Participants(nameParticipantsForm, lastNameParticipantsForm,
                cityParticipantsForm, ageParticipantsForm);
            if (!string.IsNullOrEmpty(nameParticipantsForm) &&
                (ageParticipantsForm > 0) &&
                !string.IsNullOrEmpty(lastNameParticipantsForm) &&
                !string.IsNullOrEmpty(cityParticipantsForm)) 
            {
                var participants = await ReadFromFile<Participants>(FileParticipants);

                if (!participants.Contains(newParticipants))
                {
                    foreach (var twoparticipants in participants)
                    {
                        if (twoparticipants.Name == nameParticipantsForm &&
                            twoparticipants.LastName == lastNameParticipantsForm &&
                            twoparticipants.City == cityParticipantsForm &&
                             twoparticipants.Age == ageParticipantsForm)
                        {
                            MessageBox.Show($"Участника {twoparticipants.Name} уже занесён" +
                                $" в базу Фестиваль фильмов. ", "Добавление участника",
                                0, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    participants.Add(newParticipants);
                    countParticipants = participants.Count;
                    TextBoxCountParticipants.Text = Convert.ToString(countParticipants);


                    await WriteToFile(participants, FileParticipants);

                    dataGridViewParticipantsTable.Rows.Add(nameParticipantsForm, lastNameParticipantsForm,
                       cityParticipantsForm , ageParticipantsForm);
                }
                else
                {
                    MessageBox.Show($"Этот участник был занесён в базу Фестиваль фильмов ранее",
                        "Добавление участника", 0,MessageBoxIcon.Information);
                    return;
                }
            }
        }
        async private void ParticipantsFestivalForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(FileParticipants))
            {

                var tableOfParticipants = await ReadFromFile<Participants>(FileParticipants);

                countParticipants = tableOfParticipants.Count;
                TextBoxCountParticipants.Text = Convert.ToString(countParticipants);

                if (tableOfParticipants != null)

                    foreach (var participants in tableOfParticipants)
                    {
                        dataGridViewParticipantsTable.Rows.Add();
                        dataGridViewParticipantsTable.Rows[numberParticipants].Cells[0].Value = participants.Name;
                        dataGridViewParticipantsTable.Rows[numberParticipants].Cells[1].Value = participants.LastName;
                        dataGridViewParticipantsTable.Rows[numberParticipants].Cells[2].Value = participants.City;
                        dataGridViewParticipantsTable.Rows[numberParticipants].Cells[3].Value = participants.Age;
                        numberParticipants++;
                    }
            }
        }
        async  private void ButtonDeleteParticipants_Click(object sender, EventArgs e)
        {
            int selectCount = dataGridViewParticipantsTable.CurrentCell.RowIndex;

            if (selectCount >= 0 && dataGridViewParticipantsTable.CurrentCell.Value != null)
            {
                var participants = await ReadFromFile<Participants>(FileParticipants);

                string name = dataGridViewParticipantsTable.SelectedCells[0].Value.ToString();
                string lastName = dataGridViewParticipantsTable.SelectedCells[1].Value.ToString();
                string city = dataGridViewParticipantsTable.SelectedCells[2].Value.ToString();
                int age = Convert.ToInt32(dataGridViewParticipantsTable.SelectedCells[3].Value.ToString());

                foreach (var twoparticipants in participants)
                {
                    if (name == twoparticipants.Name && lastName == twoparticipants.LastName && city == twoparticipants.City
                        && age == twoparticipants.Age)
                    {
                        participants.Remove(twoparticipants);
                        TextBoxCountParticipants.Text = Convert.ToString(participants.Count);
                        dataGridViewParticipantsTable.Rows.Remove(dataGridViewParticipantsTable.CurrentRow);
                        dataGridViewParticipantsTable.Refresh();
                        MessageBox.Show($"Участник  {twoparticipants.Name}  удалён!", "Удаление одного" +
                            " участника", 0,MessageBoxIcon.Information);
                        break;
                    }
                }
                await WriteToFile(participants, FileParticipants);
            }
            else
            {
                MessageBox.Show("Нет ни одного участника или вы не выбрали участника для удаления!",
                    "Удаление", 0, MessageBoxIcon.Information);
                return;
            }
        }
       async private void ButtonAllDeleteParticipants_Click(object sender, EventArgs e)
        {
            var participants = await ReadFromFile<Participants>(FileParticipants);
            countParticipants = participants.Count;
            if (countParticipants == 0)
            {
                MessageBox.Show("Нет ни одного участника!", "Удалить всех участников", 0, 
                    MessageBoxIcon.Information);
                return;
            }
            else
            {
                participants.Clear();
                TextBoxCountParticipants.Text = participants.Count.ToString();
                dataGridViewParticipantsTable.Rows.Clear();
                numberParticipants = 0;
                MessageBox.Show("Данные всех участников удалены!", "Удалить всех участников", 
                    0, MessageBoxIcon.Information);
            }
            await WriteToFile(participants, FileParticipants);
        }
        private void ButtonCloseFilmTable_Click(object sender, EventArgs e)
        {
            Close();

        }

    }
}
