namespace CourseGradebook {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("\nGradebook\n");

            Assignment assignment_i = new Assignment("House Price Predictor", Type.project);
            Console.WriteLine(assignment_i);

            Course course_i = new Course("CS105");
            Console.WriteLine(course_i);

            Student student_i = new Student("Sami", "Munir", "sm2246@email.edu", 23, "10-11-2001");
            Console.WriteLine(student_i);
        }
    }
}