/// <summary>
/// Основная программа для вычисления числа Фибоначчи.
/// </summary>
int result = Fibonacci(5);
Console.WriteLine(result);

/// <summary>
/// Вычисляет число Фибоначчи для заданного индекса <paramref name="n"/>.
/// </summary>
/// <param name="n">Индекс (нумерация с нуля) в последовательности Фибоначчи.</param>
/// <returns>Число Фибоначчи на позиции <paramref name="n"/>.</returns>
static int Fibonacci(int n)
{
    Console.WriteLine("Выводится результат: ");
    int n1 = 0; // первое число Фибоначчи
    int n2 = 1; // второе число Фибоначчи
    int sum;

    for (int i = 2; i <= n; i++)
    {
        sum = n1 + n2;
        n1 = n2;
        n2 = sum;
    }

    // Возвращаем нужное число Фибоначчи в зависимости от n
    return n == 0 ? n1 : n2;
}