// Задача 61: Вывести первые N строк треугольника Паскаля. 
// Сделать вывод в виде равнобедренного треугольника

    void Main(int rows)
    {
        for (int i = 0; i < rows; i++)
        {
            int number = 1;
            Console.Write(new string(' ', rows - i));

            for (int j = 0; j <= i; j++)
            {
                Console.Write("{0,3}", number);
                number = number * (i - j) / (j + 1);
            }
            Console.WriteLine();
        }
    }
Main(15);