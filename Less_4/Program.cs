// string [,] table = new string [2,5];
// table [1,2] = "слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int colums = 0; colums < 5; colums++)
//     {
//         Console.WriteLine ($"-{table[rows, colums]}-");
//     }
// }


// void PrintArray (int [,] mat)
// {

//     for (int i = 0;  i < mat.GetLength(0); i++)
//     {
//         for (int j = 0; j < mat.GetLength(1); j++)
//         {
//             Console.Write($"{mat[i,j]} ");
//         }
//     Console.WriteLine();
//     }
// }

// void FillArray (int [,] matr)
// {
//     //int
//     for (int i = 0;  i < matr.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr.GetLength(1); j++)
//         {
//             matr[i,j] = new Random().Next(1,10);
//         }
//     Console.WriteLine();
//     }

// }

// int[,] matrix = new int[3,4];
// PrintArray (matrix);
// FillArray (matrix);
// Console.WriteLine();
// PrintArray (matrix);

// double Factorial(int n)
// {
//     if (n==1) return 1;
//     else return n * Factorial(n-1);
// }

// Console.WriteLine(Factorial(3));

// for (int i = 1; i < 40; i++)
// {
//     Console.WriteLine($"{i}! = {Factorial(i)}");
// }

// f(1)=1
// f(2)=1
// f(n)=f(n-1)+f(n-2)

double Fibonacci (int n)
{
    if (n == 1 || n == 2) return 1;
    else return Fibonacci(n - 1) + Fibonacci(n - 2);
}

for (int i = 1; i < 50; i++)
{
    Console.WriteLine($"f{i} = {Fibonacci(i)}");
}
