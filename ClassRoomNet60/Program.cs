using ClassRoomNet60;
using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
     
        Student s1 = new Student( "Kasper",2,7 );
        Student s2 = new Student("Kirstine", 13, 05);
        
        ClassRoom classRoom = new ClassRoom();
        classRoom.ClassName = "3B";
        classRoom.SemesterStart = DateTime.Now;
       
        classRoom.ClassList.Add(s1);
        classRoom.ClassList.Add(s2);
        Console.WriteLine("Klassenavn:" + classRoom.ClassName + "  Semester Start:  " + classRoom.SemesterStart + "  Klasse liste:");
        foreach (Student s in classRoom.ClassList)
      {
           Console.WriteLine(s);
       }




    }
}