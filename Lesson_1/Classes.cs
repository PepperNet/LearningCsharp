using System;

namespace Lesson_1
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
}