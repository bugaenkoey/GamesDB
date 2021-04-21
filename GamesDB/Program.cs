using GamesDB.DataAccessLayer;
using GamesDB.DataAccessLayer.Entities;
using System;
 

namespace GamesDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            using GamesContext db = new GamesContext();


            Game game1 = new Game();
            db.SaveChanges();
        }
    }
}
