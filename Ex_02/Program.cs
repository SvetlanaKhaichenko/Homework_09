// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int m, int n)
{
    int count = 0;
        for (int i = m; i <= n; i++)
        {
            count = count + i;
        }
    
    return count;
}

int M = 4; int N = 8;
if (M<N) Console.WriteLine(SumNumbers(M, N));
else System.Console.Write("Промежутка между M и N не существует ");