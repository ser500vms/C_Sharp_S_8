// Задача 53: Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.


// int[,] ReverseArrey(int[,] arrey)
// {
//     for (int i = 0; i < arrey.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrey.GetLength(1); j++)
//         {
//             int buff = arrey[i, j];
//             arrey[i, j] = arrey[arrey.GetLength(0) - 1, j];
//             arrey[arrey.GetLength(0) - 1, j] = buff;
//         }
//         break;
//     }
//     return arrey;
// }

int[,] ReverseArrey(int[,] arrey)
{
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        int bufer = arrey[0, i];
        arrey[0, i] = arrey[arrey.GetLength(0) - 1, i];
        arrey[arrey.GetLength(0) - 1, i] = bufer;
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

int[,] arrey = Generate2DArray(3, 3, 1, 10);
Print2DArray(arrey);
int[,] reverseArrey = ReverseArrey(arrey);
Console.WriteLine();
Print2DArray(reverseArrey);
