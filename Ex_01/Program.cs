// Задайте значения M и N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// M = 4; N = 8. -> ""4, 6, 7, 8""

void SequenceNumbers(int m, int n)
{
    if (m < n)
    {
        for (int i = m; i < n; i++)
        {
            Console.Write($"{i}, ");

        }
        Console.WriteLine($"{n}");
    }
    else Console.WriteLine("Промежутка между M и N не существует");
}

int M = 4; int N = 8;
SequenceNumbers(M, N);