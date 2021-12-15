using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRC8_V9
{//класс женщина
    class Female : Male, IComparable, ICloneable, IPerson
    {
        public Female(string firstname, string surname, string patronymic) : base(firstname, surname, patronymic)
        {
            FirstName = firstname;
            Surname = surname;
            Patronymic = patronymic;
        }

        public int CompareTo(object obj) //сравнение по количеству символов
        {
            Female surnameMale = (Female)obj;
            return Surname.Length > surnameMale.Surname.Length ? 1 : Surname.Length < surnameMale.Surname.Length ? -1 : 0; //с помощью подсказок
        }

        public Female ShallowClone()
        {
            return (Female)MemberwiseClone();
        }

        public object Clone()
        {
            return new Female(FirstName, Surname, Patronymic); //информация о женщине
        }

        public string ShowInfo()
        {
            return ShowMaleInfo();
        }
    }
}
