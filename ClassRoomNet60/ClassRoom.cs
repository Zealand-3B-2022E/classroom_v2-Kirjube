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
        private  List<Student> _classList = new List<Student>();
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


        public override string ToString()
        {
            return $"{nameof(ClassName)}:{ClassName},{nameof(ClassList)}:{ClassList},{nameof(SemesterStart)}:{SemesterStart}";
        }
    }
}
