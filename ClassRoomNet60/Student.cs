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

        public String Name { get { return _name; } set { _name = value; } }
        public int BirthMonth { get { return _birthMonth; } set { _birthMonth = value; } }
        public int BirthDay { get { return _birthDay; } set { _birthDay = value; } }
        public override string ToString()
        {
            return $"{nameof(Name)}:{Name},{nameof(BirthDay)}:{BirthDay},{nameof(BirthMonth)}:{BirthMonth}";
        }
    }
}
