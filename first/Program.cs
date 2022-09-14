// Задайте двумерный массив. Напишите программу, которая упорядочит по 
//убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int [,] ArrayCreation()
{
    int [,] MainMassive = new int[4,4];
    for(int columns = 0; columns<4; columns++)
    {
        for(int rows = 0; rows<4; rows++)
        {
            MainMassive[columns,rows] = new Random().Next(0,10);
            Console.Write($"{MainMassive[columns,rows]}");
        }
        Console.WriteLine();
    }
    return MainMassive;
}

Console.WriteLine("-----------");

int [,] MainMassive = ArrayCreation();

void SwapPlaces(int [,] MainMassive)
{
   for(int i = 0; i<MainMassive.GetLength(0);i++)
   {
    for(int j = 0; j<MainMassive.GetLength(1);j++)
    {
        for(int z = 0; z<MainMassive.GetLength(1)-1; z++)
        {
            int temp = 0;
            if(MainMassive[i,z]<MainMassive[i,z+1])
            {
                temp = MainMassive[i,z];
                MainMassive[i,z] = MainMassive[i,z+1];
                MainMassive[i,z+1] = temp;

            }
        }
    }
   }
}
SwapPlaces(MainMassive);

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
PrintArray(MainMassive);