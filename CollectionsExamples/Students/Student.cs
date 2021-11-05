namespace CollectionsExamples.Students
{
    public class Student
    {
        public string StudentId { get; init; }
        public string Name { get; init; }
        public int Year => int.Parse(StudentId.Substring(0, 4));
        public Study Study { get; init; }


    }

}
