namespace Functions
{
    public class ClassRoom
    {
        private List<Student> students = new List<Student>();

        public void Add(Student student) => students.Add(student);
        public int Count { get => students.Count; }
        public double AverageAge() => students.Average(x => x.Age);

        public List<Student> FindStudentsByName(string name) => students.Where(s => s.Name.Contains(name)).ToList();

    }

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
