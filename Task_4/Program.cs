/* 
Задача 59: Задайте двумерный массив из целых чисел. 
Напишите программу, которая удалит строку и столбец, 
на пересечении которых расположен наименьший элемент 
массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Наименьший элемент - 1, на выходе получим 
следующий массив:
9 4 2
2 2 6
3 4 7
*/

int[,] DeleteMinRowString(int[,] arrey, List<int> minRowStringIndex)
{
    int[,] arrey2 = new int[arrey.GetLength(0) - 1, arrey.GetLength(1) - 1];
    int minRow = minRowStringIndex[0];
    int minString = minRowStringIndex[1];
    int k = 0;
    int l = 0;
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            if (i != minRow & j != minString)
            {
                arrey2[k, l] = arrey[i, j];
                l++;
                if (l == arrey2.GetLength(1))
                {
                    l = 0;
                    k++;
                }
            }
        } 
                           l = 0;
                    k++;
    }
    return arrey2;
}

List<int> FindMinimumIndex(int[,] arrey)
{
    List<int> findMinimumIndex = new List<int>();
    int minimum = arrey[0, 0];
    int minRow = 0;
    int minColl = 0;
    for (int i = 0; i < arrey.GetLength(0); i++)
    {
        for (int j = 0; j < arrey.GetLength(1); j++)
        {
            if (minimum > arrey[i, j])
            {
                minimum = arrey[i, j];
                minColl = j;
                minRow = i;
            }
        }
    }
    findMinimumIndex.Add(minRow); findMinimumIndex.Add(minColl);
    return findMinimumIndex;
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

int[,] arrey = Generate2DArray(2, 3, 1, 10);
Print2DArray(arrey);

List<int> findMinimumIndex = FindMinimumIndex(arrey);
Console.WriteLine(string.Join(", ", findMinimumIndex));
int[,] arrey2 = DeleteMinRowString(arrey, findMinimumIndex);
Console.WriteLine();
Print2DArray(arrey2);