using System;

namespace FirstLesson
{
    // Базовий клас (демонстрація наслідування)
    public abstract class Shape
    {
        // Інкапсуляція
        protected string name;
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
        // Абстракція і поліморфізм
        public abstract double CalculateArea();
        
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Фігура: {Name}");
            Console.WriteLine($"Площа: {CalculateArea()}");
        }
    }
    
    // Наслідування
    public class Circle : Shape
    {
        // Типи значень (Value Types)
        private double radius;
        
        public double Radius
        {
            get { return radius; }
            set { radius = value > 0 ? value : 0; }
        }
        
        public Circle(string name, double radius)
        {
            Name = name;
            Radius = radius;
        }
        
        // Перевизначення методу (поліморфізм)
        public override double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
    
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        
        public Rectangle(string name, double width, double height)
        {
            Name = name;
            Width = width;
            Height = height;
        }
        
        public override double CalculateArea()
        {
            return Width * Height;
        }
        
        // Демонстрація поліморфізму
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Ширина: {Width}, Висота: {Height}");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            // Типи посилань (Reference Types)
            Circle circle = new Circle("Коло", 5.0);
            Rectangle rectangle = new Rectangle("Прямокутник", 4.0, 6.0);
            
            // Поліморфізм у дії
            Shape[] shapes = new Shape[] { circle, rectangle };
            
            foreach (Shape shape in shapes)
            {
                shape.DisplayInfo();
                Console.WriteLine(new string('-', 30));
            }
            
            // Демонстрація різниці між типами значень і посилань
            int a = 10; // Тип значення
            int b = a;
            a = 20;
            Console.WriteLine($"a = {a}, b = {b}"); // a = 20, b = 10
            
            Circle c1 = new Circle("МоєКоло", 10.0); // Тип посилання
            Circle c2 = c1;
            c1.Radius = 15.0;
            Console.WriteLine($"c1.Radius = {c1.Radius}, c2.Radius = {c2.Radius}"); // c1.Radius = 15, c2.Radius = 15
        }
    }
}