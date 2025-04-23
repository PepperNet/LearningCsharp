static class EX_for_foreach
{
    public static void RunExample()
    {
        // Створюємо масив чисел
        int[] numbers = [1, 2, 3, 4, 5];

        // Використання циклу for
        Console.WriteLine("Результати циклу for:");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] *= 2;
        }

        // Використання циклу foreach для виведення
        Console.WriteLine("Елементи масиву після множення на 2:");
        foreach (int num in numbers)
        {
            Console.WriteLine(num);
        }
    }

    #region Result
    // Результат: 2 4 6 8 10
    #endregion
}