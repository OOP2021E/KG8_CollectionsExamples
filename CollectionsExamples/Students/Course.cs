using System.Collections.Generic;
using System.Linq;

namespace CollectionsExamples.Students
{
    public class Course
    {
        public Course(string title, params Student[] students )
        {
            Title = title;
            Students = students.ToList();
        }
        public string Title { get; }
        public List<Student> Students { get; } = new List<Student>();
    }

}
