using System;

namespace IDJ
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            while ( command != "End")
            {
                Student a = new Student(command);
                StudentGroup.studentNames.Add(a.name);

                command = Console.ReadLine();
            }

            StudentGroup.uniqueStudents = StudentGroup.studentNames.Count;
            Console.WriteLine("Unique: " + StudentGroup.uniqueStudents);
        }
    }
}
