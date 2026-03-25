using System;

class ArrayExample
{
    /// <summary>
    /// Точка входа в программу.
    /// Создаёт массив букв, формирует строку имени и заполняет массив чисел.
    /// Затем вызывает метод SendMessage для каждого элемента.
    /// </summary>
    static void Main()
    {
        // Массив букв
        char[] letters = { 'f', 'r', 'e', 'd', ' ', 's', 'm', 'i', 't', 'h' };
        // Строка для имени
        string name = "";
        // Массив целых чисел длиной 10
        int[] a = new int[10];

        // Цикл по всем буквам массива
        for (int i = 0; i < letters.Length; i++)
        {
            // Добавляем текущий символ к имени
            name += letters[i];
            // Заполняем массив числами от 1 до 10
            a[i] = i + 1;
            // Вызываем метод для вывода сообщения
            SendMessage(name, a[i]);
        }
        // Ожидание нажатия клавиши, чтобы окно не закрывалось
        Console.ReadKey();
    }

    /// <summary>
    /// Выводит сообщение с именем и числом.
    /// </summary>
    /// <param name="name">Имя, сформированное из массива букв.</param>
    /// <param name="msg">Число, передаваемое в сообщение.</param>
    static void SendMessage(string name, int msg)
    {
        Console.WriteLine("Hello, " + name + "! Count to " + msg);
    }
}