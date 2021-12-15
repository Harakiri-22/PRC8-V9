using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRC8_V9
{//класс мужчина
    class Male
    {
        public string FirstName { get; set; } //имя
        public string Surname { get; set; } //фамилия
        public string Patronymic { get; set; } //отчество

        public Male(string firstname, string surname, string patronymic)
        {
            FirstName = firstname;
            Surname = surname;
            Patronymic = patronymic;
        }

        public string ShowMaleInfo() //информация о мужчине
        {
            return $"{Surname} {FirstName} {Patronymic}";
        }

        public string GetReaction()
        {
            return "Я встречал этого человека";
        }
    }
}
