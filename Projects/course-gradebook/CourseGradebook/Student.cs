namespace CourseGradebook {
    class Student {
        private string first_name;
        private string last_name;
        private string email;
        private int age;
        private string dob;
        private List<Course> courses;
        private List<Assignment> assignments;

        public Student() {
            this.first_name = "N/A";
            this.last_name = "N/A";
            this.email = "N/A";
            this.age = 18;
            this.dob = "01-01-2001";
            this.courses = new List<Course>();
            this.assignments = new List<Assignment>();
        }

        public Student(string first_name, string last_name) {
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = "N/A";
            this.age = 18;
            this.dob = "01-01-2001";
            this.courses = new List<Course>();
            this.assignments = new List<Assignment>();
        }

        public Student(string first_name, string last_name, string email) {
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.age = 18;
            this.dob = "01-01-2001";
            this.courses = new List<Course>();
            this.assignments = new List<Assignment>();
        }

        public Student(string first_name, string last_name, string email, int age, string dob) {
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.age = age;
            this.dob = dob;
            this.courses = new List<Course>();
            this.assignments = new List<Assignment>();
        }

        public Student(string first_name, string last_name, string email, int age, string dob, List<Course> courses) {
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.age = age;
            this.dob = dob;
            this.courses = courses;
            this.assignments = new List<Assignment>();
        }

        public Student(string first_name, string last_name, string email, int age, string dob, List<Course> courses, List<Assignment> assignments) {
            this.first_name = first_name;
            this.last_name = last_name;
            this.email = email;
            this.age = age;
            this.dob = dob;
            this.courses = courses;
            this.assignments = assignments;
        }

        public void set_first_name(string first_name) {
            this.first_name = first_name;
        }

        public string get_first_name() {
            return this.first_name;
        }

        public void set_last_name(string last_name) {
            this.last_name = last_name;
        }

        public string get_last_name() {
            return this.last_name;
        }

        public void set_email(string email) {
            this.email = email;
        }

        public string get_email() {
            return this.email;
        }

        public void set_age(int age) {
            this.age = age;
        }

        public int get_age() {
            return this.age;
        }

        public void set_dob(string dob) {
            this.dob = dob;
        }

        public string get_dob() {
            return this.dob;
        }

        public void set_courses(List<Course> courses) {
            this.courses = courses;
        }

        public List<Course> get_courses() {
            return this.courses;
        }

        public void set_assignments(List<Assignment> assignments) {
            this.assignments = assignments;
        }

        public List<Assignment> get_assignments() {
            return this.assignments;
        }

        public override string ToString() {
            string output = string.Format("\nSTUDENT -->\n{0}, {1} | {2} | {3}\n{4}\n\t# of courses: {5}\n\t# of assignments: {6}", this.last_name, this.first_name, this.dob, this.age, this.email, this.courses.Count, this.assignments.Count);

            return output;
        }
    }
}