using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace course_work_FestivalFilmov_Afonin
{
    public class Participants
    {
        public string Name { get; set; }  //имя участника
        public string LastName { get; set; }  //фамилия участника
        public string City { get; set; } //город участника
        public int Age { get; set; } //возраст участника
        public Participants(string name, string lastName, string city, int age)
        {
            Name = name;
            LastName = lastName;
            City = city;
            Age = age;
        }
    }
}
