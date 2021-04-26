
using GamesDB.BusinessLogicLayer;
using GamesDB.DataAccessLayer;
using System;
using System.Reflection;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GamesForms
{
    public partial class Form1 : Form
    {
        //  public IRequestesInDB requestes;
        public RequestesInDB[] requestes;
        // public IGamesServise  gamesServise;
        public IGamesServise gServis;
        public Form1()
        {
            InitializeComponent();
            //  var requestes = GetRequestes();
            //  gamesServise = new GamesServise();
             gServis = new GamesServise(new GamesContext());
            requestes = GetRequestes1();


            foreach (var item in requestes)
            {
                RequestesComboBox.Items.Add(item.Text);
            };
        }

        public RequestesInDB[] GetRequestes1()
        {
            

            requestes = new RequestesInDB[]
            {
              new RequestesInDB{Text = " Информации о всех играх " ,funcAll = gServis.All },//GServise = gServis},
              new RequestesInDB{Text = " Информации о играх позже определенной даты ", funcAfterDate = gServis.AfterDate },//(IGamesServise)gServis.AfterDate(new DateTime( 1993))},
              new RequestesInDB{Text = " Информации об ихрах определенного стиля " ,funcStyle = gServis.Style },//(IGamesServise)gServis.Style("пошаговая стратегия")},
              new RequestesInDB{Text = " Информации об ихрах определенной студии (компании)", funcCompany = gServis.Company } //(IGamesServise)gServis.Company("id Software")}
            };

            return requestes;
        }
/*
        private IEnumerable<object> GetRequestes()
        {
            return new string[]{ " Информации о всех играх " ,
                    " Информации о играх позже определенной даты " ,
                    " Информации об ихрах определенного стиля " ,
                    " Информации об ихрах определенной студии "};


        }*/

        private void RequestesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

          var index = RequestesComboBox.SelectedIndex;


            switch (requestes[index].Text)
            {
                case " Информации о всех играх ":
                    GamesDataGridView.DataSource = gServis.All();
                    break;
                case " Информации о играх позже определенной даты ":
                    GamesDataGridView.DataSource = gServis.AfterDate(InputAfterDate());
                    break;
                case " Информации об ихрах определенного стиля ":
                    GamesDataGridView.DataSource = gServis.Style(InputStyle());

                    break;
                case " Информации об ихрах определенной студии (компании)":
                    GamesDataGridView.DataSource = gServis.Company(InputCompany());
                    break;
                    //   default: GamesDataGridView.DataSource = gServis.All();
                    //     break;
            }
        }

        private string InputCompany()
        {
            FormInputCompany formInputCompany = new FormInputCompany();
            formInputCompany.ShowDialog();
            return formInputCompany.Company;
        }

        private string InputStyle()
        {
            FormInputStyle formInputStyle = new FormInputStyle();
            formInputStyle.ShowDialog();
            return formInputStyle.Style;
        }

        private DateTime InputAfterDate()
        {
            FormInputAfterDate formInputAfterDate = new FormInputAfterDate();
            formInputAfterDate.ShowDialog();
            return formInputAfterDate.AfterDate;
        }

        private void buttonAll_Click(object sender, EventArgs e)
        {
            GamesDataGridView.DataSource = gServis.All();
        }

        private void buttonAfterDate_Click(object sender, EventArgs e)
        {
            GamesDataGridView.DataSource = gServis.AfterDate(InputAfterDate());
        }

        private void buttonStyle_Click(object sender, EventArgs e)
        {
            GamesDataGridView.DataSource = gServis.Style(InputStyle());
        }

        private void buttonCompany_Click(object sender, EventArgs e)
        {
            GamesDataGridView.DataSource = gServis.Company(InputCompany());
        }
    }
}
