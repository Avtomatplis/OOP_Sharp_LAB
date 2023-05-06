using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work_FestivalFilmov_Afonin
{
    public class Film
    {
        public string NameFilm { get; set; }  //название фильма
        public string NominationFilm { get; set; }  //номинация фильма(самый романтичный, смешной)
        public int TicketPrice { get; set; } //цена билета на фестиваль
        public string RatingFilm { get; set; } //рейтинг фильма

        public Film(string nameFilm, string nominationFilm, int ticketPrice, string ratingFilm)
        {
            NameFilm = nameFilm;
            NominationFilm = nominationFilm;
            TicketPrice = ticketPrice;
            RatingFilm = ratingFilm;
        }
    }
}
