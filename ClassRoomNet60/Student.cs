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

        public String Name { get; set; }
        public int BirthMonth { get; set; }
        public int BirthDay { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
