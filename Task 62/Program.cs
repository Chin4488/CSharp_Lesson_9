// Задача 62: Заполните спирально массив 4 на 4
// (массив заполняется по часовой стрелке от периферии к центру).
int[,] array = new int[4,4];
int position = 1;
int i = 0;
int j = 0;
while (position <= 16)
{
    array[i,j] = position;
    if (i<=j+1 && i+j<3)
        j++;
    else 
    if (i<j && i+j>=3)
        i++;
    else
    if (i>=j && i+j>3)
        j--;
    else
        i--;
    position++;
}
for (i=0; i<4; i++)
{
    for (j=0; j<4; j++)
    {
        Console.Write($"{array[i,j]:d2} ");
    }
    Console.WriteLine();
}
Console.WriteLine();