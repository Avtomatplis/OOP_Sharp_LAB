using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_3
{
    /// <summary>
    /// Класс, реализующий интерфейс человека
    /// </summary>
    class Human
    {
        public string HumanID { get; set; } //ID
        public int Age { get; set; } //возраст   
        public double Weight { get; set; }  //вес
        public string Name { get; set; }  //имя
        public string SecondName { get; set; }  //фамилия
        public int NumberOfChildren { get; set; }  //год рождения
        public string Country { get; set; }  //город проживания
        public int Height { get; set; }  //рост

        /// <summary>
        /// Статическое поле числа созданных объектов
        /// </summary>
        public static int ObjectsCount;
        
        /// <summary>
        /// Конструктор со всеми параметрами
        /// </summary>
        /// <param name="age">Возраст человека</param>
        /// <param name="weight">Вес человека</param>
        /// <param name="name">Имя человека</param>
        /// <param name="secondName">Фамилия человека</param>
        /// <param name="numberOfChildren">Количество детей у человека</param>
        /// <param name="country">Место жительства человека</param>
        /// <param name="height">Рост человека</param>
        public Human(int age, double weight, string name, string secondName, int numberOfChildren, string country, int height)
        {
            HumanID = idGenerator(HumanID);
            this.Age = age;
            this.Weight = weight;
            this.Name = name;
            this.SecondName = secondName;
            this.NumberOfChildren = numberOfChildren;
            this.Country = country;
            this.Height = height;
            ObjectsCount++;
        }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Human()
        {
            HumanID = idGenerator(HumanID);
            Name = "Отсутствует";
        }

        public override string ToString()
        {
            return ($" Возраст: {Age} \n Вес: {Weight}  кг\n Имя: {Name} \n Фамилия: {SecondName} \n Количество детей: {NumberOfChildren}\n " +
                 $"Страна проживания: {Country}\n Рост {Height} см\n ID: {HumanID}");
        }

        /// <summary>
        /// Генерирует id
        /// </summary>
        /// <param name="humanID"></param>
        /// <returns>Сгенерированный id</returns>
        private String idGenerator(String humanID)
        {
            Random random = new Random();
            humanID = random.Next(1, 129).ToString();
            return humanID;
        }

        
    }
}