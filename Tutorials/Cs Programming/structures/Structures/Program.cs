namespace Structures {
    class Program {
        struct Student {
            public string name;
            public int age;
        }
        static void Main(string[] args) {
            Console.WriteLine("\nStructures\n");

            Student student_i;
            student_i.name = "Sami Munir";
            student_i.age = 23;

            Console.ReadLine();
        }
    }
}