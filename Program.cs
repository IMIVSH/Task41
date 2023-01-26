// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int GetUserData(string message)
{
    Console.WriteLine(message);
    int userData = int.Parse(Console.ReadLine()!);
    return userData;
}

int[] FillArray(int quantity)
{
    int[] result = new int[quantity];
    for (int i = 0; i < quantity; i++)
    {
        Console.WriteLine("Введите число");
        result [i] = int.Parse(Console.ReadLine()!);
    }
    return result;
}

int CountPositive(int[] result)
{
    int count = 0;
    for (int i = 0; i < result.Length; i++)
    {
        if (result[i] > 0)
        { count += 1; }
    }
    return count;
}

int quantity = GetUserData("Введите количество чисел");
int[] array = FillArray(quantity);
int numberOfPositive = CountPositive(array);
Console.WriteLine($"Количество чисел больше 0 из введённых вами = {numberOfPositive}.");