using System.Collections.Generic;

namespace CollectionsExamples.Students
{
    public interface ICourseSource
    {
        IEnumerable<Course> GetCourses();
        IEnumerable<Student> GetStudents();
    }
}