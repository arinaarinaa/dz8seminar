// Задайте две матрицы. Напишите программу, которая 
// будет находить произведение двух матриц.

// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int [,] ArrayCreation()
{
    int [,] MainMassive = new int[2,2];
    for(int columns = 0; columns<2; columns++)
    {
        for(int rows = 0; rows<2; rows++)
        {
            MainMassive[columns,rows] = new Random().Next(0,10);
            Console.Write($"{MainMassive[columns,rows]}  ");
        }
        Console.WriteLine();
    }
    return MainMassive;
}
int [,] Matr1 = ArrayCreation();
Console.WriteLine("---------------------");
int [,] Matr2 = ArrayCreation();


int[,] matrixC = new int[2, 2];

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        for (int k = 0; k < 2; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (Matr1[i, k] * Matr2[k, j]);
        }
        Console.Write($"{matrixC[i,j]} ");
    }
    Console.WriteLine();
}

