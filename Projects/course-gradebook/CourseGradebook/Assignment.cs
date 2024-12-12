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
    }
}