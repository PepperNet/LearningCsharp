using Lesson_1;

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