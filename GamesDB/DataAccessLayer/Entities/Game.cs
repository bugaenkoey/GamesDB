using System;

namespace GamesDB.DataAccessLayer.Entities
{
    /*
•	Название игры;
•	Студия или фирма создатель игры;
•	Стиль игры;
•	Дата релиза. 
     */

    /*
     Задание 4: 
Создайте файлы миграции из базы данных предыдущих заданий. Добавьте к информации об игре:
•	Режим игры: однопользовательский, многопользовательский;
•	Количество проданных копий;
Обновите файлы миграций и базу данных. 
     */
    public class Game
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Company { get; set; }
        public string Style { get; set; }
        public DateTime DateRelease { get; set; }

        //------------

 //       public bool multiplayer { get; set; }
 //       public int CopiesSold { get; set; }

    }
}
