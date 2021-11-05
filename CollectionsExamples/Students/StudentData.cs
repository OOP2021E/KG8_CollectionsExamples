using System;
using System.Collections.Generic;
using System.Linq;

namespace CollectionsExamples.Students
{
    class StudentData
    {
        Student Jens = new() { Name = nameof(Jens), StudentId = String.Join("", "20010001".Select(char.ToLower)), Study=Study.DAT };
        Student Hans = new() { Name = nameof(Hans), StudentId = "20010002", Study = Study.SW };
        Student Søren = new() { Name = nameof(Søren), StudentId = "20010003", Study = Study.DAT };
        Student Martin = new() { Name = nameof(Martin), StudentId = "20100003", Study = Study.SW };
        Student Lene = new() { Name = nameof(Lene), StudentId = "20110003", Study = Study.DAT };
        Student Pia = new() { Name = nameof(Pia), StudentId = "20200003", Study = Study.SW };
        Student Mette = new() { Name = nameof(Mette), StudentId = "20040003", Study = Study.DAT };
        Student Lone = new() { Name = nameof(Lone), StudentId = "20050003", Study = Study.SW };
        Student Mogens = new() { Name = nameof(Mogens), StudentId = "20050021", Study = Study.DAT };
        Student Kirsten = new() { Name = nameof(Kirsten), StudentId = "20110202", Study = Study.SW };
        Student Lea = new() { Name = nameof(Lea), StudentId = "20110303", Study = Study.DAT };
        Student Mia = new() { Name = nameof(Mia), StudentId = "20130203", Study = Study.SW };
        Student Peter = new() { Name = nameof(Peter), StudentId = "20140103", Study = Study.DAT };
        Student Poul = new() { Name = nameof(Poul), StudentId = "20210003", Study = Study.SW };
        Student Karsten = new() { Name = nameof(Karsten), StudentId = "20064003", Study = Study.DAT };
        Student Birgit = new() { Name = nameof(Birgit), StudentId = "20072003", Study = Study.SW };

        public List<Student> Students { get; }
        public List<Course> Courses { get; }
        //public StudentData(ICourseSource src)
        //{
        //    IEnumerable<Course> courses = src.GetCourses();
        //    IEnumerable<Student> students = src.GetStudents();
        //    StudentData sd = new StudentData(new FileSource("students.txt", "courses.txt"));
        public StudentData()
        {
            Course oop = new Course("OOP",
                Jens, Hans, Søren, Martin, Lene, Pia, Mette, Lone, Mogens, 
                Kirsten, Lea, Mia, Peter, Poul, Karsten, Birgit);
            Course alg = new Course("Algoritmik", Lene, Pia, Mette, Lone, Mogens, Peter, Poul);
            Course aalg = new Course("Adv. Algoritmik", Birgit, Peter, Mia, Søren, Martin);
            Course mat = new Course("Mat 1", Karsten, Søren, Mia, Lea);
            Courses = new List<Course> { oop, alg, aalg, mat};

            Students = new List<Student>
            {
                Jens,
                 Hans,
                 Søren,
                 Martin,
                 Lene,
                 Pia,
                 Mette,
                 Lone,
                 Mogens,
                 Kirsten,
                 Lea ,
                 Mia ,
                 Peter ,
                 Poul ,
                 Karsten,
                 Birgit

            };
        }

        public static void LiveExample()
        {
            StudentData sd = new StudentData();

            foreach (var item in sd.Students.GroupBy(v=>v.Study))
            {
                Console.WriteLine(item.Key);
                foreach (var s in item)
                {
                    Console.WriteLine(s.Name);
                }
            }

            var result = sd.Students
                .Where(s => s.Study == Study.DAT)
                .Where(v=>v.Year<=2012)
                .Select(v => new { v.Name, v.StudentId });
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

        }
    }

}
