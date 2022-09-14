// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Программа считает сумму элементов в каждой строке и выдаёт 
// номер строки с наименьшей суммой элементов: 1 строка

int [,] ArrayCreation()
{
    int [,] MainMassive = new int[2,4];
    for(int columns = 0; columns<2; columns++)
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
int [,] MainMassive = ArrayCreation();
Console.WriteLine("-----------");
int sum1 = 0;
int sum2 = 0;
void MinSum(int [,] MainMassive)
{
   
   
        for(int j = 0; j<MainMassive.GetLength(1);j++)
        {
            sum1 = sum1+MainMassive[0,j];
            sum2 = sum2+MainMassive[1,j];
        }
        if(sum1>sum2)
        {
            Console.WriteLine("первая строчка");
        }
        else
        {
            Console.WriteLine("2 strochka");
        }
    
    
}
MinSum(MainMassive);