namespace csh_iterate_hashsets_hello;

class Program
{
    static void Main(string[] args)
    {
        // Пример использования функции для множества {A, B, C, D}
        //PowerSetGenerator
        List<string> flowers = new List<string> { "A", "B", "C", "D" };
        List<HashSet<string>> powerSet = PowerSetGenerator.PowerSet(flowers);

        // Выводим результат
        Console.WriteLine("Power set:");
        foreach (var subset in powerSet)
        {
            Console.WriteLine("{" + string.Join(", ", subset) + "}");
        }

        // Пример использования функции для множества {A, B, C} с использованием рекурсии
        List<string> items = new List<string> { "A", "B", "C" };
        List<List<string>> powerSetR = RecursivePowerSetGenerator.RecursivePowerSet(items);

        // Выводим результат
        Console.WriteLine("Recursive Power set:");
        foreach (var subset in powerSetR)
        {
            Console.WriteLine("{" + string.Join(", ", subset) + "}");
        }
    }
}
