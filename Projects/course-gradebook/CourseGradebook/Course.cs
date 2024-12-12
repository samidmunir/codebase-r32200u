namespace CourseGradebook {
    class Course {
        private string title;
        private List<Assignment> assignments;
        private List<Student> students;

        public Course() {
            this.title = "N/A";
            this.assignments = new List<Assignment>();
            this.students = new List<Student>();
        }

        public Course(string title) {
            this.title = title;
            this.assignments = new List<Assignment>();
            this.students = new List<Student>();
        }

        public Course(string title, List<Assignment> assignments) {
            this.title = title;
            this.assignments = assignments;
            this.students = new List<Student>();
        }

        public Course(string title, List<Assignment> assignments, List<Student> students) {
            this.title = title;
            this.assignments = assignments;
            this.students = students;
        }

        public void set_title(string title) {
            this.title = title;
        }

        public string get_title() {
            return this.title;
        }

        public void set_assignments(List<Assignment> assignments) {
            this.assignments = assignments;
        }

        public List<Assignment> get_assignments() {
            return this.assignments;
        }

        public void set_students(List<Student> students) {
            this.students = students;
        }

        public List<Student> get_students() {
            return this.students;
        }

        public override string ToString() {
            string output = string.Format("\nCOURSE -->\n<{0}>\n\t# of assignments: {1}\n\t# of students: {2}", this.title, this.assignments.Count, this.students.Count);

            return output;
        }
    }
}