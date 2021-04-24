using GamesDB.BusinessLogicLayer;
using GamesDB.DataAccessLayer;
using GamesDB.DataAccessLayer.Entities;
using System;
 

namespace GamesDB
{
    /*
27.04.2021

«Платформа Microsoft .NET и язык программирования C#»
Тема: Entity Framework Core
Предусловие: 
Для реализации заданий используйте подход Code first (создание базы данных на основе классов). Желательная структура решения (solution), с использованием многослойного подхода:
•	Data access layer – Библиотека классов для хранения Entity Framework контекста, сущностей с которыми он работает и их настроек (пример)
•	Business logic layer – Библиотека классов для реализации основного функционала приложения
•	Presentation layer – приложение для работы с пользователем (оконное или консольное)
Задание 1: 
Внутри проекта, отвечающего за работу с данными:
1.	создайте класс (сущность) для хранения информации об играх. В классе необходимо хранить:
•	Название игры;
•	Студия или фирма создатель игры;
•	Стиль игры;
•	Дата релиза. 
2.	Создайте класс-наследник от DbContext
3.	Создайте DbSet в котором вы будете хранить объекты
4.	Настройте сущность – добавьте описание первичного ключа, Not Null и прочие требования к свойствам.
5.	Настройте и выполните подключение к базе данных.
Задание 2: 
Внутри проекта, отвечающего за логику приложения опишите и реализуйте интерфейс для получения:
•	Информации о всех играх
•	Информации о играх позже определенной даты
•	Информации об ихрах определенного стиля
•	Информации об ихрах определенной студии
Задание 3: 
В приложении, отвечающем за взаимодействие с пользователем предоставьте возможность выбора и отображения информации из задания 2.
Задание 4: 
Создайте файлы миграции из базы данных предыдущих заданий. Добавьте к информации об игре:
•	Режим игры: однопользовательский, многопользовательский;
•	Количество проданных копий;
Обновите файлы миграций и базу данных. 

     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using GamesContext db = new GamesContext();
            /*
                        db.Add(new Game() { Name = "DOOM", DateRelease = new DateTime(1993,1,1),Company = "id Software" , Style = "шутера от первого" });
                        db.Add(new Game() { Name = "DOOM2", DateRelease = new DateTime(1994, 1, 1), Company = "id Software", Style = "шутера от первого" });
                        db.Add(new Game() { Name = "Civilization II", DateRelease = new DateTime(1994, 1, 1), Company = "MicroProse", Style = "пошаговая стратегия" });
                        db.Add(new Game() { Name = "F29 Retaliator", DateRelease = new DateTime(1989, 1, 1), Company = "Ocean Software", Style = "авиасимулятор" });
            */
            //  db.SaveChanges();

          /*  var gs = new GamesServise(db);
            var allGames = gs.All();
            foreach (var item in allGames)
            {
                Console.WriteLine(item);
            }*/
            
        }
    }
}
