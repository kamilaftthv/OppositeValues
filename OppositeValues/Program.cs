class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        if (n < 1 || n > 100)
        {
            Console.WriteLine("Массив должен быть больше или равен 0 и меньше или равен 100");
            return;
        }
        int[] array = new int[n];
        for (int i = 0; i < n; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (array[i] + array[j] == 0)
                {
                    Console.WriteLine($"{i + 1} {j + 1}");
                    return;
                }
            }
        }
        Console.WriteLine("Противоположные числа не найдены");
    }
}