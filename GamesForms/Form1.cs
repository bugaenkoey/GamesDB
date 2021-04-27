using GamesDB.BusinessLogicLayer;
using GamesDB.DataAccessLayer;
using System;
using System.Windows.Forms;

namespace GamesForms
{
    /*
27.04.2021

«Платформа Microsoft .NET и язык программирования C#»
Тема: Entity Framework Core
Предусловие: 
Для реализации заданий используйте подход Code first (создание базы данных на основе классов).
    Желательная структура решения (solution), с использованием многослойного подхода:
•	Data access layer – Библиотека классов для хранения Entity Framework контекста, 
    сущностей с которыми он работает и их настроек (пример)
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
