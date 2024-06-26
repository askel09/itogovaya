// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в
// промежутке от M до N. Использовать рекурсию, не использовать циклы.
// M = 1; N = 5 => 1,2,3,4,5
// M = 4; N = 8 => 4,5,6,7,8
// M = 8; N = 4 =>8,7,6,5,4



void Print(int M, int N)
{
    
    if(M == N) return;
    if(M < N)
    {
        Console.Write($"{M}, ");
        Print(M+1, N);
    }
    else
    {
        Console.Write($"{M}, ");
        Print(M-1, N);
    }
    
    
}

Console.WriteLine("Введите число M: ");
int M1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int N1 = Convert.ToInt32(Console.ReadLine());

//Print(M1, N1);  

// Задача 2:
//Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 29



//int Akkerman(int N, int M)
//{
//if (N == 0)
//{
   // return M + 1;
//}
//else if(M == 0)
//{
    ////return Akkerman(N - 1, 1);
//}
//else
//{
 //   return Akkerman(N - 1, Akkerman(N, M - 1));
//}
//}



//Console.WriteLine("Введите число N: ");
//int N1 = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Введите число M: ");
//int M1 = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine(Akkerman(N1, M1));

// Задача 3:
// Задайте произвольный массив. Выведете
//его элементы, начиная с конца. Использовать
//рекурсию, не использовать циклы.
//[1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 


//int[] array = { 5, 15, 8, 7, 26 };
//PrintArrayReverse(array);

//void PrintArrayReverse(int[] arr, int index = 0)
//{
   // if (index < arr.Length)
   // {
        //PrintArrayReverse(arr, index + 1);
       // Console.Write(arr[index] + " ");
   // }
//}




