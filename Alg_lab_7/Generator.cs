﻿using System;

namespace Alg_lab_7
{
    public class Generator
    {
        public static Random random = new Random();
        //generate random mark
        public static int MarkGenerator()
        {
            int mark = random.Next(1, 10);

            return mark;
        }
        //generate random name
        public static string NameGenerator()
        {
            string[] name = { "Харитон","Артемий","Елисей","Александр","Дмитрий","Виктор","Изяслав","Ярослав","Ростислав","Фадей","Богдан","Сергей",
        "Пахом","Вадим","Макар","Марк","Митофан","Остап","Потап","Прохор","Радислав","Андрей","Артем","Олег","Валерий","Виталий","Владимир","Влас",
        "Вячеслав","Геннадий","Георгий","Герман","Глеб","Григорий","Давид","Данила","Дементий","Дмитрий","Денис","Евгений","Евдоким","Егор","Евстафий",
        "Елисей","Емельян","Игорь","Игнатий","Захар","Измаил","Илья","Иннокентий","Иосиф","Карл","Кирилл","Константин","Ян","Якуб","Юрий","Фома",
        "Тимофей","Тимур","Тимур","Тихон","Ульян","Федор", "Антон", "Иван"};

            return name[random.Next(name.Length)];
        }
        //generate random surname
        public static string SurnameGenerator()
        {
            string[] name = { "Михеев","Мишин","Моисеев","Молчанов","Морозов","Муравьёв","Мухин","Мышкин","Мясников","Назаров","Наумов","Некрасов",
                "Нестеров","Никитин","Никифоров","Николаев","Никонов","Новиков","Носков","Носов","Овчинников","Одинцов","Орехов","Орлов","Осипов",
                "Павлов","Панов","Панфилов","Пахомов","Пестов","Петров","Петухов","Поляков","Пономарёв","Попов","Потапов","Прохоров","Рогов","Родионов",
                "Рожков","Романов","Русаков","Рыбаков","Рябов","Савельев","Савин","Сазонов","Самойлов","Самсонов","Сафонов","Селезнёв","Селиверстов",
                "Семёнов","Сергеев","Сидоров","Силин","Симонов","Ситников","Соболев","Соколов","Соловьёв","Сорокин","Степанов","Стрелков","Субботин",
                "Суворов","Суханов","Сысоев","Тарасов","Терентьев","Тетерин","Тимофеев","Титов","Тихонов","Третьяков","Трофимов","Туров","Уваров",
                "Устинов","Фадеев","Фёдоров","Федосеев","Федотов","Филатов","Филиппов","Фокин","Фомин","Фомичёв","Фролов","Харитонов","Хохлов","Цветков",
                "Чернов","Шарапов","Шаров","Шашков","Шестаков","Шилов","Ширяев","Шубин","Щербаков","Щукин","Юдин","Яковлев","Якушев", "Смирнов"};
            return name[random.Next(name.Length)];
        }
        //generate random date
        public static DateTime DateGenerator()
        {
            DateTime start = new DateTime(1980, 1, 1);
            int renge = (DateTime.Today - start).Days;
            return start.AddDays(random.Next(renge));
        }
    }
}