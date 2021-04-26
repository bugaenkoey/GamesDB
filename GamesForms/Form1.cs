using GamesDB.BusinessLogicLayer;
using GamesDB.DataAccessLayer;
using System;
using System.Windows.Forms;

namespace GamesForms
{
    public partial class Form1 : Form
    {
        public string[] select;
        public IGamesServise gServis;
        public Form1()
        {
            InitializeComponent();
            gServis = new GamesServise(new GamesContext());
            SetSelect();
        }

        private void SetSelect()
        {
            select = new string[]
            {
                new string(" Информации о всех играх "),
                new string(" Информации о играх позже определенной даты "),
                new string(" Информации об ихрах определенного стиля "),
                new string(" Информации об ихрах определенной студии (компании)")
            };
            foreach (var item in select)
            {
                RequestesComboBox.Items.Add(item);
            }
           
        }


        private void RequestesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            var index = RequestesComboBox.SelectedIndex;

           switch(select[index])
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
