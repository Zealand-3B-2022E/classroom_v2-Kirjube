using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassRoomNet60
{
    internal class ClassRoom
    {
        private String _className;
        private List<Student> _classList;
        private DateTime _semesterStart;

      public ClassRoom()
        {
            _className = "Ikke valgt";
            _classList = new List<Student>();
            _semesterStart = DateTime.Now;

        }
        public String ClassName { get { return _className; } set { _className = value; } }
        public List<Student> ClassList { get { return _classList; } set { _classList = value; } }
        public DateTime SemesterStart { get { return _semesterStart; } set { _semesterStart = value; } }

        public void countBirthdaysPerSeason(List<Student> classList)
        {
            int springCount = 0;
            int summerCount = 0;
            int fallCount = 0;
            int WinterCount = 0;
            foreach (Student student in classList)
            {

                if (student.BirthMonth > 2 && student.BirthMonth < 6)
                {
                    springCount++;
                }
                if (student.BirthMonth > 5 && student.BirthMonth < 9)
                {
                    summerCount++;
                }
                if (student.BirthMonth > 8 && student.BirthMonth < 12)
                {
                    fallCount++;
                }
                if (student.BirthMonth == 1 || student.BirthMonth == 2 || student.BirthMonth == 12)
                {
                    WinterCount++;
                }
            }
            Console.WriteLine("Bday in winter " + WinterCount + " Bday in Spring " + springCount + " Bday in Summer " + summerCount + " Bday in Fall " + fallCount);
        }
        
        public override string ToString()
        {
            return $"{nameof(ClassName)}:{ClassName},{nameof(ClassList)}:{ClassList},{nameof(SemesterStart)}:{SemesterStart}";
        }
    }
}
