using System;
using System.Collections.Generic;
using System.Text;
using GamesDB.BusinessLogicLayer;
using GamesDB.DataAccessLayer.Entities;

namespace GamesForms
{
    public class RequestesInDB : IRequestesInDB
    {
        public string Text { get; set; }
        // public GamesServise GServise { get; set ; }
        public List<Game> GServise { get; set; }
        public Func<IEnumerable<Game>> funcAll;
        public Func<string, IEnumerable<Game>> funcStyle;
        public Func<string, IEnumerable<Game>> funcCompany;
        public Func<DateTime, IEnumerable<Game>> funcAfterDate;
     /*   public IEnumerable<Game> AllExecute()
        {
           // if (funcAll != null) return funcAll?.Invoke();
            if (funcStyle != null) return funcStyle?.Invoke("шутера от первого");
            else if (funcCompany != null) return funcCompany?.Invoke("Ocean Software");
            else if (funcAfterDate != null) return funcAfterDate?.Invoke(new DateTime());
            return funcAll?.Invoke();
        }*/
    }
}
