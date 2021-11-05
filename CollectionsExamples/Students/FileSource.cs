using System.Collections.Generic;
using System.IO;

namespace CollectionsExamples.Students
{
    class FileSource : ICourseSource
    {
        List<Course> courses = new List<Course>();
        List<Student> studs = new List<Student>();
        public FileSource(string studentFilename, string coursefilename)
        {
            var studentNames = File.ReadAllLines(studentFilename);
            foreach (var studentName in studentNames)
            {
                studs.Add(new Student { Name = studentName });
            }
        }


        public IEnumerable<Course> GetCourses()
        {
            return courses;
        }

        public IEnumerable<Student> GetStudents()
        {
            return studs;
        }
    }

}
