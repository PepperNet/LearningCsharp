static class EX_static
{
	public static void RunExample()
	{
		// Використання
		Console.WriteLine($"Початкова кількість операцій: {MathUtility.OperationCount}");

		double circleArea = MathUtility.CalculateCircleArea(5); // Статичний метод

		MathUtility calculator1 = new MathUtility();
		calculator1.CalculationType = "Геометричний";
		double rect1Area = calculator1.CalculateRectangleArea(4, 5);

		MathUtility calculator2 = new MathUtility();
		calculator2.CalculationType = "Архітектурний";
		double rect2Area = calculator2.CalculateRectangleArea(2, 3);

		Console.WriteLine($"Площа кола: {circleArea}");
		Console.WriteLine($"Площа прямокутника 1: {rect1Area} (Тип: {calculator1.CalculationType})");
		Console.WriteLine($"Площа прямокутника 2: {rect2Area} (Тип: {calculator2.CalculationType})");
		Console.WriteLine($"Загальна кількість операцій: {MathUtility.OperationCount}");
	}

	public class MathUtility
	{
		// Статичне поле - спільне для всіх екземплярів
		public static int OperationCount = 0;
		
		// Статичний метод
		public static double CalculateCircleArea(double radius)
		{
			OperationCount++;
			return Math.PI * radius * radius;
		}
		
		// Нестатичне поле - унікальне для кожного екземпляра
		public string CalculationType;
		
		// Нестатичний метод
		public double CalculateRectangleArea(double width, double height)
		{
			OperationCount++;
			return width * height;
		}
	}
}

#region Result
// Результат:
// Початкова кількість операцій: 0
// Площа кола: 78.53981633974483
// Площа прямокутника 1: 20 (Тип: Геометричний)
// Площа прямокутника 2: 6 (Тип: Архітектурний)
// Загальна кількість операцій: 3
#endregion

