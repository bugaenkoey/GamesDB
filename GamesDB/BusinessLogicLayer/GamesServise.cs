using GamesDB.DataAccessLayer;
using GamesDB.DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
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
    public class GamesServise : IGamesServise
    {
        public readonly GamesContext _context;
        
        public GamesServise()
        {
          
        }

        public GamesServise(GamesContext context)
        {
            _context = context;
        }

        public IEnumerable<Game> AfterDate(DateTime dateTime)
        {
            return _context.Games.Where(_ => _.DateRelease < dateTime).ToList();
        }

       
        public IEnumerable<Game> All()
        {
            return _context.Games.ToList();
        }

        public IEnumerable<Game> Company(string company)
        {
            return _context.Games.Where(_ => _.Company == company).ToList();
        }

        public IEnumerable<Game> Style(string style)
        {
            return _context.Games.Where(_ => _.Style == style).ToList();
        }
    }

}
