// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.


void FrequencyDictionary(List<int> arrey)
{
    List<int> frequencyDictionary = new ();
    int count = 0;
    while(arrey.Count > 0)
    {
        for ( int i = 0; i < arrey.Count; i++ )
        {
            if (arrey[0] != arrey[i])
            {
                frequencyDictionary.Add(arrey[i]);
                count++;
            }
        }
        Console.WriteLine($"Число {arrey[0]} встречается {arrey.Count - count} раз");
        arrey = frequencyDictionary;
        frequencyDictionary = new();
        count = 0;
    }
}

List<int> Convert2DArrayToDynamic(int[,] arrey)
{
    List<int> convert2DArrayToDynamic = new List<int>();
    for ( int i = 0; i < arrey.GetLength(0); i++)
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            convert2DArrayToDynamic.Add(arrey[i, j]);
        }
    return convert2DArrayToDynamic;
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
List<int> convert2DArrayToDynamic = Convert2DArrayToDynamic(arrey);
FrequencyDictionary(convert2DArrayToDynamic);
