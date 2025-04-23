static class EX_nullable
{
	static void RunExample()
	{
		// Функція, яка може повертати null
		int? FindNumber(int[] array, int target)
		{
			for (int i = 0; i < array.Length; i++)
			{
				if (array[i] == target)
					return i; // Повертаємо індекс, якщо знайдено
			}
			return null; // Повертаємо null, якщо не знайдено
		}

		// Використання
		int[] numbers = { 10, 20, 30, 40, 50 };
		int? indexOfThirty = FindNumber(numbers, 30);
		int? indexOfSixty = FindNumber(numbers, 60);

		// Перевірка результатів
		if (indexOfThirty.HasValue)
		{
			Console.WriteLine($"Число 30 знаходиться на позиції {indexOfThirty.Value}");
		}

		if (indexOfSixty.HasValue)
		{
			Console.WriteLine($"Число 60 знаходиться на позиції {indexOfSixty.Value}");
		}
		else
		{
			Console.WriteLine("Число 60 не знайдено в масиві");
		}
	}
}

#region Result
// Результат:
// Число 30 знаходиться на позиції 2
// Число 60 не знайдено в масиві
#endregion