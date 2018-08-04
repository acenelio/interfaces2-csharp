using Course.Model.Enums;

namespace Course.Model.Entities {
    abstract class Shape {

        public Color Color { get; set; }

        public abstract double Area();
    }
}
