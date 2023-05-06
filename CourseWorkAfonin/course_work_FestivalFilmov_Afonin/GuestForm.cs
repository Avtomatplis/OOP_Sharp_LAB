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
    public partial class GuestForm : Form
    {
        public static string NameGuestForm = "";
        public static string LastNameGuestForm = "";
        public static int SeatNumberGuestForm = 0;
        public static string EmailGuestForm = "";
        public GuestForm()
        {
            InitializeComponent();
        }

        private void ButtonCreateGuest_Click(object sender, EventArgs e)
        {
            if (CheckOnCorrectTextBoxNameGuest(TextBoxNameGuest) &&
              CheckOnCorrectTextBoxLastNameGuest(TextBoxLastNameGuest) &&
              CheckOnCorrectTextBoxEmailGuest(TextBoxEmailGuest))
            {
                NameGuestForm = TextBoxNameGuest.Text;
                LastNameGuestForm = TextBoxLastNameGuest.Text;
                SeatNumberGuestForm = (int)NumericUpDownSeatNumberGuest.Value;
                EmailGuestForm = TextBoxEmailGuest.Text;
                Close();
            }
            else
            {
                Exeption.MessageBox(0, "некорректные данные, только символы кириллицы", "ошибка", 0);
            }
        }
        bool CheckOnCorrectTextBoxNameGuest(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
           Regex.IsMatch(tb.Text, @"^[А-ЯЁ][а-яё]*([-][А-ЯЁ][а-яё]*)?")
           || (tb.BackColor = Color.MistyRose) != Color.MistyRose
           || (labelPrimerNameGuest.Text = "Примеры ввода: Костя, Екатерина")
           != "Примеры ввода: Костя, Екатерина";
        bool CheckOnCorrectTextBoxLastNameGuest(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$") &&
        Regex.IsMatch(tb.Text, @"^[А-ЯЁ][а-яё]*([-][А-ЯЁ][а-яё]*)?")
        || (tb.BackColor = Color.MistyRose) != Color.MistyRose
        || (labelPrimerLastNameGuest.Text = "Примеры ввода: Курков, Вахромеев")
        != "Примеры ввода: Курков, Вахромеев";
        bool CheckOnCorrectTextBoxEmailGuest(TextBox tb) => !Regex.IsMatch(tb.Text, @"^\s*$")&&
            Regex.IsMatch(tb.Text, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$")
             || (tb.BackColor = Color.MistyRose) != Color.MistyRose
             || (labelPrimerEmailGuest.Text = "Примеры ввода: zhig@inbox.ru, patrik@gmail.com")
        != "Примеры ввода: zhig@inbox.ru, patrik@gmail.com";

        private void ButtonCloseGuestForm_Click(object sender, EventArgs e)
        {
            NameGuestForm = "";
            LastNameGuestForm = "";
            SeatNumberGuestForm = 0;
            EmailGuestForm = "";
            Close();
        }
    }
}
