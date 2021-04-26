using GamesDB.BusinessLogicLayer;
using GamesDB.DataAccessLayer.Entities;
using System.Collections.Generic;

namespace GamesForms
{
   public interface IRequestesInDB
    {
        //public delegate TResult Func<T1, TResult>(T1 arg1, T1 arg2);
      //  public delegate TResult Func<TResult>();

        public string Text { get; set; }
        // public delegate ServiseGame func ()
        // public IGamesServise GServise{ get; set; }
        public List<Game> GServise { get; set; }

    }
}
