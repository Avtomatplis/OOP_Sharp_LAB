using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work_FestivalFilmov_Afonin
{
    public partial class JuryFestivalForm : Form
    {
        const string FileJury = "Jury.json";

        int numbersJury = 0;
        int countJury = 0;
        public JuryFestivalForm()
        {
            Task.Run(() => File.Open(FileJury, FileMode.OpenOrCreate).Close());
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

        //чтение из файла json
        async Task<List<T>> ReadFromFile<T>(string FILE_NAME)
        {
            using (var streamReader = new StreamReader(FILE_NAME))
            {
                return await Task.Run(async () =>
                JsonConvert.DeserializeObject<List<T>>(await streamReader.ReadToEndAsync())
                ?? new List<T>());
            }
        }
        async private void ButtonCreateJury_Click(object sender, EventArgs e)
        {
            JuryForm formJury = new JuryForm();
            formJury.ShowDialog();
            string nameJuryForm = JuryForm.NameJuryForm;
            string lastNameJuryForm = JuryForm.LastNameJuryForm;
            string postJuryForm = JuryForm.PostJuryForm;

            Jury newJury = new Jury(nameJuryForm, lastNameJuryForm, postJuryForm);

            if (!string.IsNullOrEmpty(nameJuryForm) &&
                !string.IsNullOrEmpty(lastNameJuryForm) &&
                !string.IsNullOrEmpty(postJuryForm))
            {
                var jurys = await ReadFromFile<Jury>(FileJury);

                if (!jurys.Contains(newJury))
                {
                    foreach (var twoJury in jurys)
                    {
                        if (twoJury.NameJury == nameJuryForm &&
                            twoJury.LastNameJury == lastNameJuryForm &&
                            twoJury.PostJury == postJuryForm)
                        {
                            MessageBox.Show($"Жюри {twoJury.NameJury} уже занесён в базу " +
                                $"Фестиваль фильмов. ", "Добавление жюри", 0,
                                MessageBoxIcon.Information);
                            return;
                        }
                    }

                    jurys.Add(newJury);
                    countJury = jurys.Count;
                    TextBoxCountJury.Text = Convert.ToString(countJury);


                    await WriteToFile(jurys, FileJury);

                    dataGridViewJuryTable.Rows.Add(nameJuryForm, lastNameJuryForm, postJuryForm);
                }
                else
                {
                    MessageBox.Show($"Этот член жюри был занесён в базу фестиваль фильмов ранее",
                        "Добавление жюри", 0,
                        MessageBoxIcon.Information);
                    return;
                }
            }
        }
        async private void JuryFestivalForm_Load(object sender, EventArgs e)
        {
            if (File.Exists(FileJury))
            {
                var tableOfJury = await ReadFromFile<Jury>(FileJury);
                numbersJury = 0;
                countJury = tableOfJury.Count;
                TextBoxCountJury.Text = Convert.ToString(countJury);

                if (tableOfJury != null)

                    foreach (var jurys in tableOfJury)
                    {
                        dataGridViewJuryTable.Rows.Add();
                        dataGridViewJuryTable.Rows[numbersJury].Cells[0].Value = jurys.NameJury;
                        dataGridViewJuryTable.Rows[numbersJury].Cells[1].Value = jurys.LastNameJury;
                        dataGridViewJuryTable.Rows[numbersJury].Cells[2].Value = jurys.PostJury;
                        numbersJury++;
                    }
            }
        }

        async private void ButtonAllDeleteJury_Click(object sender, EventArgs e)
        {
            var jurys = await ReadFromFile<Jury>(FileJury);
            countJury = jurys.Count;
            if (countJury == 0)
            {
                MessageBox.Show("Нет ни одного члена жюри!", "Удалить всех членов жюри", 0,
                    MessageBoxIcon.Information);
                return;
            }
            else
            {
                jurys.Clear();
                TextBoxCountJury.Text = jurys.Count.ToString();
                dataGridViewJuryTable.Rows.Clear();
                numbersJury = 0;
                MessageBox.Show("Данные всех членов жюри удалены!", "Удалить всех членов жюри", 0,
                    MessageBoxIcon.Information);
            }
            await WriteToFile(jurys, FileJury);
        }

        private void ButtonCloseJuryTable_Click(object sender, EventArgs e)
        {
            Close();
        }

        async private void ButtonDeleteJury_Click(object sender, EventArgs e)
        {
            int selectCount = dataGridViewJuryTable.CurrentCell.RowIndex;

            if (selectCount >= 0 && dataGridViewJuryTable.CurrentCell.Value != null )
            {
                var jurys = await ReadFromFile<Jury>(FileJury);
                string nameJury = dataGridViewJuryTable.SelectedCells[0].Value.ToString();
                string lastNameJury = dataGridViewJuryTable.SelectedCells[1].Value.ToString();
                string postJury = dataGridViewJuryTable.SelectedCells[2].Value.ToString();

                foreach (var twoJury in jurys)
                {
                    if (nameJury == twoJury.NameJury && lastNameJury == twoJury.LastNameJury
                        && postJury == twoJury.PostJury)
                    {
                        jurys.Remove(twoJury);
                        TextBoxCountJury.Text = Convert.ToString(jurys.Count);
                        dataGridViewJuryTable.Rows.Remove(dataGridViewJuryTable.CurrentRow);
                        MessageBox.Show($"Член жюри {twoJury.NameJury}  удалён!", "Удаление одного члена жюри",
                            0, MessageBoxIcon.Information);
                        break;
                    }
                }
                await WriteToFile(jurys, FileJury);
            }
            else
            {
                MessageBox.Show("Нет ни одного члена жюри или вы не выбрали члена жюри для удаления!",
                    "Удаление", 0, MessageBoxIcon.Information);
                return;
            }
        }
    }
}
