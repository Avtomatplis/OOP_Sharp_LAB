
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;
using System.Security.Cryptography;


namespace lab_1
{
    class UI
    {
        static List<Human> humans = new List<Human>();
        static Regex regextext = new Regex(@"\p{IsCyrillic}", RegexOptions.IgnorePatternWhitespace);
        public static void bannerInfo()
        {
            Console.WriteLine("Лабораторная работа №1" + "\n" + "Бобков и Жигалов - бригада №13" + "\n" +
             "Вариант задания: Человек" + "\n" + "Задание:Реализовать класс, содержащий не менее 7 полей с различными \n" +
             "типами данных:" + " •\tcтрока,•\tцелое, •\tвещественное.\n ");

            mainMenu();
        }

        public static void mainMenu()
        {
            Console.WriteLine("Введите: \n 1 - Создать обьект\n 2 - Изменить обьект\n 3 - Просмотреть список обьектов\n 4 - Вывести всю информацию об обьекте\n" +
                " 5 - Вывести одно поле обьекта\n 6 - Завершить работу");
            string? option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    createNewObject();
                    break;
                case "2":
                    changeObject();
                    break;
                case "3":
                    showList(humans);
                    break;
                case "4":
                    showAllFieldId(humans);
                    break;
                case "5":
                    printOneField(humans);
                    break;
                case "6":
                    Console.WriteLine("Завершение работ. Повторно нажмите enter");
                    break;
                default:
                    Console.WriteLine("Введено неправильное значение");
                    mainMenu();
                    break;
            }
        }

        public static void createNewObject()
        {
            Human human = null;
            Console.WriteLine("Выберите что хотите создать:");
            Console.WriteLine("Введите: \n" +
                "1 - Создать пустой обьект\n" +
                "2 - создать обьект с именем\n" +
                "3 - создать обьект с именем и фамилией\n" +
                "4 - создать обьект со всеми параметрами\n" +
                "5 - отменить создание и выйти в начальное меню выбора");
            string? optionCreate = Console.ReadLine();
            switch (optionCreate)
            {
                case "1":
                    human = new Human();
                    humans.Add(human);
                    Console.WriteLine($"Добавлен пустой обьект 'человек' ID:{human.humanID} ");
                    mainMenu();
                    break;

                case "2":
                    Console.WriteLine("Введите имя");
                    string nameHuman = examinationString(regextext, human);
                    human = new Human(nameHuman);
                    humans.Add(human);
                    Console.WriteLine($"Добавлен обьект человек с именем:{human.name} и ID:{human.humanID}");
                    mainMenu();
                    break;

                case "3":
                    Console.WriteLine("Введите имя");
                    string firstName = examinationString(regextext, human);
                    Console.WriteLine("Введите фамилию");
                    string secondName = examinationString(regextext, human);
                    human = new Human(firstName, secondName);
                    humans.Add(human);
                    Console.WriteLine($"Добавлен обьект человек с именем и фамилией:{human.name}  " +
                        $"{human.secondName} и ID:{human.humanID}");
                    mainMenu();
                    break;

                case "4":
                    Console.WriteLine("Введите следующие значение:");

                    Console.Write("Необходимо указать возраст человека (полное количество лет): ");
                    int newAge = examinationInt(1, 150);

                    Console.Write("Необходимо указать вес человека (кг.гр): ");
                    double newWeight = examinationDouble(1, 200);

                    Console.Write("Необходимо указать имя человека: ");
                    string newName = examinationString(regextext, human);

                    Console.Write("Необходимо указать фамилию человека: ");
                    string newSecondName = examinationString(regextext, human);

                    Console.Write("Необходимо указать количество детей: ");
                    int newNumberOfChildren = examinationInt(0, 10);

                    Console.Write("Необходимо указать город : ");
                    string city = examinationString(regextext, human);

                    Console.Write("Необходимо указать рост человека: ");
                    int newHeight = examinationInt(1, 250);

                    human = new Human(newAge, newWeight, newName, newSecondName, newNumberOfChildren, city, newHeight);
                    humans.Add(human);
                    Console.WriteLine($"Добавлен человек со всеми параметрами и ID:{human.humanID} ");
                    Console.WriteLine(human);
                    mainMenu();
                    break;
                case "5":
                    mainMenu();
                    break;
                default:
                    Console.WriteLine("Введено неправильное значение");
                    createNewObject();
                    break;
            }
        }

        public static void changeObject()
        {
            Console.WriteLine("У вас есть ID?");
            Console.WriteLine("1 - да\n2 - нет");
            string Key = Console.ReadLine();
            switch (Key)
            {
                case "1":
                    Console.WriteLine("Введите ID:");
                    string thisId = Console.ReadLine();
                    bool isFindID = false;
                    foreach (Human human in humans)
                    {
                        if (human.humanID == thisId)
                        {
                            isFindID = true;
                            changeObjectField(human);
                            break;
                        }
                    }
                    if (!isFindID)
                    {
                        Console.WriteLine("Нет человека с таким ID. Введите ID заново");
                        changeObject();
                    }
                    break;
                case "2":
                    Console.WriteLine("Создайте обьект");
                    mainMenu();
                    break;
                default:
                    Console.WriteLine("Неизвестное поле!");
                    changeObject();
                    break;
            }
        }

        public static void changeObjectField(Human human)
        {
            Console.WriteLine("Выберите что хотите изменить:");
            Console.WriteLine("Введите: \n" +
                "1 - Возраст\n" +
                "2 - Вес\n" +
                "3 - Имя\n" +
                "4 - Фамилию\n" +
                "5 - Количество детей\n" +
                "6 - Место жительства\n" +
                "7 - Рост\n" +
                "8 - Вернуться на главную\n");
            string? variant = Console.ReadLine();
            switch (variant)
            {
                case "1":
                    Console.Write("Необходимо указать возраст человека (полное количество лет): ");
                    int changeAge = examinationInt(1, 150);
                    human.age = changeAge;
                    Console.WriteLine("Изменение успешно произведено");
                    Console.WriteLine(human);
                    changeObjectField(human);
                    break;

                case "2":
                    Console.Write("Необходимо указать вес человека (кг.гр): ");
                    double changeWeight = examinationInt(1, 200);
                    human.weight = changeWeight;
                    Console.WriteLine("Изменение успешно произведено");
                    Console.WriteLine(human);
                    changeObjectField(human);
                    break;

                case "3":
                    Console.Write($"Введите новое имя: ");
                    string firstName = examinationString(regextext, human);
                    human.name= firstName;
                    Console.WriteLine("Имя изменено!");
                    Console.WriteLine(human);
                    changeObjectField(human);
                    break;

                case "4":
                    Console.Write($"Введите новую фамилию: ");
                    string secondName = examinationString(regextext, human);
                    human.secondName = secondName;
                    Console.WriteLine("Фамилия изменена!");
                    Console.WriteLine(human);
                    changeObjectField(human);
                    break;

                case "5":
                    Console.Write("Необходимо указать количество детей (шт): ");
                    int changeNumberOfChildren = examinationInt(0, 10);
                    human.numberOfChildren = changeNumberOfChildren;
                    Console.WriteLine("Изменение успешно произведено");
                    Console.WriteLine(human);
                    changeObjectField(human);
                    break;

                case "6":
                    Console.Write($"Введите новое место жительства: ");
                    string city = examinationString(regextext, human);
                    human.country = city;
                    Console.WriteLine("Место жительства изменено!");
                    Console.WriteLine(human);
                    changeObjectField(human);
                    break;

                case "7":
                    Console.Write("Необходимо указать рост человека (см): ");
                    int changeHeight = examinationInt(1, 250);
                    human.height = changeHeight;
                    Console.WriteLine("Изменение успешно произведено");
                    Console.WriteLine(human);
                    changeObjectField(human);
                    break;
                case "8":
                    mainMenu();
                    break;
                default:
                    Console.WriteLine("Неизвестное поле!");
                    changeObjectField(human);
                    break;
            }
        }

        public static void showList(List<Human> humans)
        {
            if (humans.Count == 0)
            {
                Console.WriteLine("Пустой список обьектов");
                mainMenu();
            }
            else
            {
                foreach (Human item in humans)
                {
                    Console.WriteLine($"id {item.humanID} , имя {item.name}");
                }
            }
        }

        public static void showAllFieldId(List<Human> humans)
        {
            Console.WriteLine("У вас есть ID?");
            Console.WriteLine("1 - да\n2 - нет");
            string firstKey = Console.ReadLine();
            switch (firstKey)
            {
                case "1":
                    Console.WriteLine("Введите ID:");
                    string thisId = Console.ReadLine();
                    bool isFindID = false;
                    foreach (Human human in humans)
                    {
                        if (human.humanID == thisId)
                        {
                            isFindID = true;
                            Console.WriteLine(human);
                            mainMenu();
                            break;
                        }
                    }
                    if (!isFindID)
                    {
                        Console.WriteLine("Нет человека с таким ID. Введите ID заново");
                        showAllFieldId(humans);
                    }
                    break;
                case "2":
                    Console.WriteLine("Создайте обьект");
                    mainMenu();
                    break;
                default:
                    Console.WriteLine("Неизвестное поле!");
                    showAllFieldId(humans);
                    break;
            }
        }

        public static void printOneField(List<Human> humans)
        {
            Console.WriteLine("У вас есть ID?");
            Console.WriteLine("1 - да\n2 - нет");
            string firstKey = Console.ReadLine();
            switch (firstKey)
            {
                case "1":
                    Console.WriteLine("Введите ID:");
                    string thisId = Console.ReadLine();
                    bool isFindID = false;
                    foreach (Human human in humans)
                    {
                        if (human.humanID == thisId)
                        {
                            isFindID = true;
                            chooseOneField(human);
                            break;
                        }
                    }
                    if (!isFindID)
                    {
                        Console.WriteLine("Нет человека с таким ID. Введите ID заново");
                        showAllFieldId(humans);
                    }
                    break;
                case "2":
                    Console.WriteLine("Создайте обьект");
                    mainMenu();
                    break;
                default:
                    Console.WriteLine("Неизвестное поле!");
                    printOneField(humans);
                    return;
            }
        }
        public static void chooseOneField(Human human)
        {
            Console.WriteLine("Выберите что хотите посмотреть:");
            Console.WriteLine("Введите: \n" +
                "1 - Возраст\n" +
                "2 - Вес\n" +
                "3 - Имя\n" +
                "4 - Фамилию\n" +
                "5 - Количество детей\n" +
                "6 - Место жительства\n" +
                "7 - Рост\n" +
                "8 - Id\n" +
                "9 - Вернуться на главную\n");
            string? variant = Console.ReadLine();
            switch (variant)
            {
                case "1":
                    Console.WriteLine(human.age);
                    break;
                case "2":
                    Console.WriteLine(human.weight);
                    break;
                case "3":
                    Console.WriteLine(human.name);
                    break;
                case "4":
                    Console.WriteLine(human.secondName);
                    break;
                case "5":
                    Console.WriteLine(human.numberOfChildren);
                    break;
                case "6":
                    Console.WriteLine(human.country);
                    break;
                case "7":
                    Console.WriteLine(human.height);
                    break;
                case "8":
                    Console.WriteLine(human.humanID);
                    break;
                case "9":
                    mainMenu();
                    break;
                default:
                    Console.WriteLine("Неизвестное поле!");
                    chooseOneField(human);
                    return;
            }
        }
        public static int examinationInt(int minValue, int maxValue)
        {
            bool flag = true;
            int newCount = 0;
            while (flag)
            {
                object newCountHuman = Console.ReadLine();
                try
                {
                    newCount = Convert.ToInt32(newCountHuman);
                    if (newCount < minValue || newCount > maxValue)
                    {
                        Console.WriteLine($"Введите корректные данные (от {minValue} до {maxValue})");
                    }
                    else
                    {
                        flag = false;
                    }
                }
                catch
                {
                    Console.WriteLine("неверно введенное значение");
                }
            }
            return newCount;
        }

        public static double examinationDouble(double minValue, double maxValue)
        {
            bool flag = true;
            double newCount = 0;
            while (flag)
            {
                object newCountHuman = Console.ReadLine();
                try
                {
                    newCount = Convert.ToDouble(newCountHuman);
                    if (newCount < 1 || newCount > 200)
                    {
                        Console.WriteLine($"Введите корректные данные (от {minValue} до {maxValue})");
                    }
                    else
                    {
                        flag = false;
                    }
                }
                catch
                {
                    Console.WriteLine("неверно введенное значение");
                }
            }
            return newCount;
        }
        public static string examinationString(Regex regextext, Human human)
        {
            bool flag = true;
            string stringHuman="";
            while (flag)
            {
                stringHuman = Console.ReadLine();
                try
                {
                    if (!regextext.IsMatch(stringHuman))
                    {
                        Console.WriteLine("Можно только символы Кириллицы");
                    }
                    else
                    {
                        flag = false;
                    }
                }
                catch
                {
                    Console.WriteLine("неверно введенное значение");
                }
            }
            return stringHuman;
        }
    
    }
}