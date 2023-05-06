using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace course_work_FestivalFilmov_Afonin
{
    public partial class FilmForm : Form
    {
        public static string NameFilmForm = "";
        public static string NominationFilmForm = "";
        public static int TicketPriceForm = 0;
        public static string RatingFilmForm = "";
        public FilmForm()
        {
            InitializeComponent();
        }
        private void ButtonCreateFilm_Click(object sender, EventArgs e)
        {
            if (CheckOnCorrectTextBoxNameFilm(TextBoxNameFilm) &&
               CheckOnCorrectComboBoxNominationFilm(ComboBoxNominationFilm) &&
                CheckOnCorrectComboBoxRatingFilm(ComboBoxRatingFilm))
            {
                NameFilmForm = TextBoxNameFilm.Text;
                NominationFilmForm = ComboBoxNominationFilm.SelectedItem as string;
                TicketPriceForm = (int)NumericUpDownTicketPrice.Value;
                RatingFilmForm = ComboBoxRatingFilm.SelectedItem as string;
                Close();
            }
            else
            {
                Exeption.MessageBox(0, "Вы ввели некорректные данные! Пожалуйста, введите данные согласно" +
                    " образцу справа от поля ввода данных!","ошибка", 0);
            }
        }
        bool CheckOnCorrectTextBoxNameFilm(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
              Regex.IsMatch(tb.Text, @"^[^A-Za-z]*$")
           || (tb.BackColor = Color.MistyRose) != Color.MistyRose
           || (labelPrimerNameFilm.Text = "Примеры ввода: Любовь и голуби, Тупой и ещё тупее")
           != "Примеры ввода: Любовь и голуби, Тупой и ещё тупее";

        bool CheckOnCorrectComboBoxNominationFilm(ComboBox cb) => !(cb.SelectedItem is null)
            || (cb.BackColor = Color.MistyRose) != Color.MistyRose
           || (labelHintNominationFilm.Text = "Пожалуйста, выберите одну из номинаций!")
            != "Пожалуйста, выберите одну из номинаций!";
        bool CheckOnCorrectComboBoxRatingFilm(ComboBox cb) => !(cb.SelectedItem is null)
           || (cb.BackColor = Color.MistyRose) != Color.MistyRose
          || (labelHintRatingFilm.Text = "Пожалуйста, поставте фильму оценку!")
           != "Пожалуйста, поставте фильму оценку!";
        private void ButtonCloseFilmForm_Click(object sender, EventArgs e)
        {
            NameFilmForm = "";
            NominationFilmForm = "";
            TicketPriceForm = 0;
            RatingFilmForm = "";
            Close();
        }

        
    }
}
