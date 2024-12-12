using System.Reflection;

namespace CourseGradebook {

    public enum Type {
        homework,
        project,
        quiz,
        midterm,
        final
    }

    class Assignment {
        private string title;
        private Type type;
        private float max_points;
        private float scored_points;
        
        public Assignment() {
            this.title = "N/A";
            this.type = Type.homework;
            this.max_points = 0.0F;
            this.scored_points = 0.0F;
        }

        public Assignment(string title, Type type) {
            this.title = title;
            this.type = type;
            this.max_points = 0.0F;
            this.scored_points = 0.0F;
        }

        public Assignment(string title, Type type, float max_points) {
            this.title = title;
            this.type = type;
            this.max_points = max_points;
            this.scored_points = 0.0F;
        }

        public Assignment(string title, Type type, float max_points, float scored_points) {
            this.title = title;
            this.type = type;
            this.max_points = max_points;
            this.scored_points = scored_points;
        }

        public void set_title(string title) {
            this.title = title;
        }

        public string get_title() {
            return this.title;
        }

        public void set_type(Type type) {
            this.type = type;
        }

        public Type get_type() {
            return this.type;
        }

        public void set_max_points(float max_points) {
            this.max_points = max_points;
        }

        public float get_max_points() {
            return this.max_points;
        }

        public void set_scored_points(float scored_points) {
            this.scored_points = scored_points;
        }

        public float get_scored_points() {
            return this.scored_points;
        }

        public override string ToString() {
            string output = string.Format("\nASSIGNMENT -->\n<{0}>: {1}\nScored/Max: {2}/{3}", this.type, this.title, this.scored_points, this.max_points);

            return output; 
        }
    }
}