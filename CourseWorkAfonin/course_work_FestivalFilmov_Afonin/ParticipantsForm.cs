using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace course_work_FestivalFilmov_Afonin
{
    public partial class ParticipantsForm : Form
    {
        public static string NameParticipantsForm = "";
        public static string LastNameParticipantsForm = "";
        public static int AgeParticipantsForm = 0;
        public static string CityParticipantsForm = "";
        public ParticipantsForm()
        {
            InitializeComponent();
        }

        private void ButtonCreateParticipants_Click(object sender, EventArgs e)
        {
            if (CheckOnCorrectTextBoxName(TextBoxNameParticipants) &&
                CheckOnCorrectTextBoxLastName(TextBoxLastNameParticipants) &&
                CheckOnCorrectTextBoxCity(TextBoxCityParticipants))
            {
                NameParticipantsForm = TextBoxNameParticipants.Text;
                LastNameParticipantsForm = TextBoxLastNameParticipants.Text;
                CityParticipantsForm = TextBoxCityParticipants.Text;
                AgeParticipantsForm = (int)NumericUpDownAgeParticipants.Value;

                Close();
            }
            else
            {
                Exeption.MessageBox(0, "Вы ввели некорректные данные! Пожалуйста, введите данные согласно " +
                    "образцу справа от поля ввода данных!", "ошибка", 0);
            }

        }
        bool CheckOnCorrectTextBoxName(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
            Regex.IsMatch(tb.Text, @"^[А-ЯЁ][а-яё]*([-][А-ЯЁ][а-яё]*)?")
            || (tb.BackColor = Color.MistyRose) != Color.MistyRose
            || (labelPrimerNameParticipants.Text = "Примеры ввода: Максим, Кирилл") != "Примеры ввода:" +
            " Максим, Кирилл";

        bool CheckOnCorrectTextBoxLastName(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
            Regex.IsMatch(tb.Text, @"^[А-ЯЁ][а-яё]*([-][А-ЯЁ][а-яё]*)?")
            || (tb.BackColor = Color.MistyRose) != Color.MistyRose
            || (labelPrimerLastNameParticipants.Text = "Примеры ввода: Сидоров, Иванов") != "Примеры ввода:" +
            " Сидоров, Иванов";
        bool CheckOnCorrectTextBoxCity(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
           Regex.IsMatch(tb.Text, @"^[А-ЯЁ][а-яё]*([-][А-ЯЁ][а-яё]*)?")
           || (tb.BackColor = Color.MistyRose) != Color.MistyRose
           || (labelPrimerCityParticipants.Text = "Примеры ввода: Москва, Сочи") != "Примеры ввода:" +
           " Москва, Сочи";

        private void ButtonCloseParticipantsForm_Click(object sender, EventArgs e)
        {
            NameParticipantsForm = "";
            LastNameParticipantsForm = "";
            AgeParticipantsForm = 0;
            CityParticipantsForm = "";

            Close();
        }
    }
}
