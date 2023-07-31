// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.


// int[,] ReverseArrey(int[,] arrey)
// {
//     int[,] collumsToRows = new int[arrey.GetLength(0), arrey.GetLength(1)];
//     for (int j = 0; j < arrey.GetLength(1); j++)
//     {
//         for (int i = 0; i < arrey.GetLength(0); i++)
//         {
//             collumsToRows[j, i]  = arrey[i, j]; 
//         }
//     }
//     return collumsToRows;
// }

// без массива с буффером.

int[,] ReverseArrey(int[,] arrey)
{
    int count = 1;
    for (int j = 0; j < arrey.GetLength(1); j++)
    {
        for (int i = count; i < arrey.GetLength(0); i++)
        {
            int bufer = arrey[j, i];
            arrey[j, i] = arrey[i, j];
            arrey[i, j] = bufer;
        }
        count++;
    }
    return arrey;
}


int[,] Generate2DArray(int rows, int collums, int startValue, int finishValue)
{
    int[,] arrey = new int[rows, collums];
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            arrey[i, j] = new Random().Next(startValue, finishValue + 1);
        }
    }
    return arrey;
}

void Print2DArray(int[,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            Console.Write(String.Format("{0, 3}", arrey[i, j]));
            Console.Write("\t", -5);
        }
        Console.WriteLine();
    }
}

int[,] arrey = Generate2DArray(4, 4, 1, 10);
Print2DArray(arrey);
int[,] reverseArrey = ReverseArrey(arrey);
Console.WriteLine();
Print2DArray(reverseArrey);
