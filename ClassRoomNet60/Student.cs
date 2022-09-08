using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class Student
    {
        private string _name;
        private int _birthMonth;
        private int _birthDay;  

        public Student(string name, int birthMonth, int birthDay)
        {
            _name = name;
            _birthMonth = birthMonth;
            _birthDay = birthDay;

        }

        public String Name { get { return _name; } private set { _name = value; } }
        public int BirthMonth { get { return _birthMonth; } private set { _birthMonth = value; } }
        public int BirthDay { get { return _birthDay; } private set { _birthDay = value; } }

        public string Season(Student student)
        {
            string birthseason;
            if(student.BirthMonth == 12 || student.BirthMonth == 1 || student.BirthMonth == 2)
            {
              return  birthseason = "Winter";
            }
            if (student.BirthMonth == 3 || student.BirthMonth == 4 || student.BirthMonth == 5)
            {
               return birthseason = "Spring";
            }
            if (student.BirthMonth == 6 || student.BirthMonth == 7 || student.BirthMonth == 8)
            {
               return birthseason = "Summer";
            }
            if (student.BirthMonth == 9 || student.BirthMonth == 10 || student.BirthMonth == 11)
            {
               return birthseason = "Fall";
            }

            return birthseason = "not a month";
        }
        public override string ToString()
        {
            return $"{nameof(Name)}:{Name},{nameof(BirthDay)}:{BirthDay},{nameof(BirthMonth)}:{BirthMonth}";
        }

    }
}
