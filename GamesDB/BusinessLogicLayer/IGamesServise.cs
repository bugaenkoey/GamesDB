using GamesDB.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

/*
Задание 2: 
Внутри проекта, отвечающего за логику приложения опишите и реализуйте интерфейс для получения:
•	Информации о всех играх
•	Информации о играх позже определенной даты
•	Информации об ихрах определенного стиля
•	Информации об ихрах определенной студии
 */
namespace GamesDB.BusinessLogicLayer
{

    public interface IGamesServise
    {


        IEnumerable<Game> All();
        IEnumerable<Game> AfterDate(DateTime dateTime);
        IEnumerable<Game> Style(string style);
        IEnumerable<Game> Company(string studio);
    }
}
