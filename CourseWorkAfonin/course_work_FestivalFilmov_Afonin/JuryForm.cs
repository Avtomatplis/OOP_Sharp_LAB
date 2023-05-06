using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work_FestivalFilmov_Afonin
{
    public partial class JuryForm : Form
    {
        public static string NameJuryForm = "";
        public static string LastNameJuryForm = "";
        public static string PostJuryForm = "";
        public JuryForm()
        {
            InitializeComponent();
        }

        private void JuryForm_Load(object sender, EventArgs e)
        {

        }

        private void ButtonCreateJury_Click(object sender, EventArgs e)
        {
            if (CheckOnCorrectTextBoxNameJury(TextBoxNameJury) &&
             CheckOnCorrectTextBoxLastNameJury(TextBoxLastNameJury) &&
              CheckOnCorrectComboBox(ComboBoxPostJury))
            {
                NameJuryForm = TextBoxNameJury.Text;
                LastNameJuryForm = TextBoxLastNameJury.Text;
                PostJuryForm = ComboBoxPostJury.SelectedItem as string;
                Close();
            }
            else
            {
                Exeption.MessageBox(0, "Вы ввели некорректные данные! Пожалуйста, введите данные согласно " +
                     "образцу справа от поля ввода данных!", "ошибка", 0);
            }
        }
        bool CheckOnCorrectTextBoxNameJury(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
            Regex.IsMatch(tb.Text, @"^[А-ЯЁ][а-яё]*([-][А-ЯЁ][а-яё]*)?")
            || (tb.BackColor = Color.MistyRose) != Color.MistyRose
            || (labelPrimerNameJury.Text = "Примеры ввода: Сергей, Настя")
            != "Примеры ввода: Сергей, Настя";
        bool CheckOnCorrectTextBoxLastNameJury(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
            Regex.IsMatch(tb.Text, @"^[А-ЯЁ][а-яё]*([-][А-ЯЁ][а-яё]*)?")
            || (tb.BackColor = Color.MistyRose) != Color.MistyRose
            || (labelPrimerLastNameJury.Text = "Примеры ввода: Седов, Лукашина")
            != "Примеры ввода: Седов, Лукашина";
        bool CheckOnCorrectComboBox(ComboBox cb) => !(cb.SelectedItem is null)
            || (cb.BackColor = Color.MistyRose) != Color.MistyRose
            || (labelHintPostJury.Text = "Пожалуйста, выберите одну из должностей!")
            != "Пожалуйста, выберите одну из должностей!";
        private void ButtonCloseJuryForm_Click(object sender, EventArgs e)
        {
            NameJuryForm = "";
            LastNameJuryForm = "";
            PostJuryForm = "";
            Close();
        }
    }
}
