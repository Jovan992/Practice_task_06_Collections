namespace Practice_task_06_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** LIST ***");
            Console.WriteLine("\nInitializing List of students");
            var studentsList = new List<Student>
            {
                new Student("John", 2021),
                new Student("Mike", 2022),
            };
            ShowStudents(studentsList);
            Console.WriteLine("\nAdding new student to studentsList");
            studentsList.Add(new Student("Peter", 2023));
            ShowStudents(studentsList);

            Console.WriteLine("\n*** DICTIONARY ***");
            Console.WriteLine("\nInitializing Dictionary of students");
            Dictionary<int, Student> studentsDictionary = new Dictionary<int, Student>()
            {
                { 111, new Student ("John", 1021) },
                { 112, new Student ("Mike", 2022) }
            };
            ShowDictionary(studentsDictionary);
            Console.WriteLine("\nAdding new student to dictionary;");
            studentsDictionary.Add(113, new Student("Peter", 2023));
            ShowDictionary(studentsDictionary);

            Console.WriteLine("\n*** QUEUE ***");
            Console.WriteLine("\nDefining queue of students");
            var studentsQueue = new Queue<Student>();
            Console.WriteLine("\nEnqueuing students to queue");
            studentsQueue.Enqueue(new Student("John", 2021));
            studentsQueue.Enqueue(new Student("Mike", 2022));
            studentsQueue.Enqueue(new Student("Peter", 2023));
            ShowStudents(studentsQueue);
            Console.WriteLine("\nDequeuing first student from queue");
            studentsQueue.Dequeue();
            ShowStudents(studentsQueue);

            Console.WriteLine("\n*** STACK ***");
            Console.WriteLine("\n___Stack of students");
            var studentsStack = new Stack<Student>();
            Console.WriteLine("\nPushing new students to stack");
            studentsStack.Push(new Student("John", 2021));
            studentsStack.Push(new Student("Mike", 2022));
            studentsStack.Push(new Student("Peter", 2023));
            ShowStudents(studentsStack);
            Console.WriteLine("\nPoping last student stack");
            studentsStack.Pop();
            ShowStudents(studentsStack);

            Console.ReadKey();
        }

        public static void ShowStudents(IEnumerable<Student> students)
        {
            foreach (Student s in students)
            {
                Console.WriteLine(s.Name + " " + s.StartingYear);
            }
        }

        public static void ShowDictionary(Dictionary<int, Student> students )
        {
            foreach (KeyValuePair<int, Student> s in students)
            {
                Console.WriteLine(s.Key + " " + s.Value.Name + " " + s.Value.StartingYear);
            }
        }
    }

    public class Student
    {
        private int _startingYear;
        public string Name { get; set; }
        public int StartingYear
        {
            get
            {
                return _startingYear;
            }
            set
            {
                if (value > 1999 && value < 2024)
                {
                    _startingYear = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Starting year must be between 2000 and 2023!");
                }
            }
        }

        public Student(string name, int startingYear)
        {
            Name = name;
            StartingYear = startingYear;
        }
    }
}
