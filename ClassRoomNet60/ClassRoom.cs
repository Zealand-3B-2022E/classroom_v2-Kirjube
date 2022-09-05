using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassRoomNet60
{
    internal class ClassRoom
    {
        private String _className;
        private  List<Student> _classList;
        private DateTime _semesterStart;

        ClassRoom()
        {
            _className = "Ikke valgt";
            _classList = new List<Student>();
            _semesterStart = DateTime.Now;

        }


    }
}
