using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace lab_1
{
    /// <summary>
    /// Класс, реализующий интерфейс человека
    /// </summary>
    class Human
    {
        public string humanID { get; set; } //ID
        public int age { get; set; } //возраст   
        public double weight { get; set; }  //вес
        public string name { get; set; }  //имя
        public string secondName { get; set; }  //фамилия
        public int numberOfChildren { get; set; }  //год рождения
        public string country { get; set; }  //город проживания
        public int height { get; set; }  //рост

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Human()
        {
            humanID = idGenerator(humanID);
            name = "Отсутствует";
        }

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
            humanID = idGenerator(humanID);
            this.age = age;
            this.weight = weight;
            this.name = name;
            this.secondName = secondName;
            this.numberOfChildren = numberOfChildren;
            this.country = country;
            this.height = height;
        }

        /// <summary>
        /// Конструктор с одним параметром
        /// </summary>
        /// <param name="name">Имя человека</param>
        public Human(string name)
        {
            humanID = idGenerator(humanID);
            this.name = name;
        }

        /// <summary>
        /// Конструктор с двумя параметром
        /// </summary>
        /// <param name="name">Имя человека</param>
        /// /// <param name="secondName">Имя человека</param>
        public Human(string name, string secondName)
        {
            humanID = idGenerator(humanID);
            this.name = name;
            this.secondName = secondName;
        }

        public override string ToString()
        {
            return ($" Возраст: {age} \n Вес: {weight}  кг\n Имя: {name} \n Фамилия: {secondName} \n Количество детей: {numberOfChildren}\n " +
                 $"Страна проживания: {country}\n Рост {height} см\n ID: {humanID}");
        }

        /// <summary>
        /// Генерирует id, затем конвертирует его в 16-ричное представление
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