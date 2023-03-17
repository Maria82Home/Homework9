//Homework 9
//Task1. Задайте значение N. Напишите программу, 
//которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


void NatureNumbers(int n)
{
  if (n > 0)
  {
    Console.Write(n + " ");
    NatureNumbers(n - 1);
  }
}

Console.WriteLine("Input N: ");
int number = Convert.ToInt32(Console.ReadLine());
NatureNumbers(number);


//Task2. Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.

/*
int ElementsSum(int m, int n)
{
  if (n > m) { int sum = ElementsSum(m, n - 1) + n; return sum; }
  else if (m > n) { int sum = ElementsSum(m - 1, n) + m; return sum; }
  else return m;
}

Console.WriteLine("Input first number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("The sum of elements is " + ElementsSum(m, n));
*/

//Task3. Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.

/*
int Akkerman(int m, int n)
{
  if (m == 0) return n + 1;
  else if (n == 0 && m > 0)  return Akkerman(m - 1, 1); 
  else if (m > 0 && n > 0)  return Akkerman(m - 1, Akkerman(m, n - 1)); 
  else return -1;
}

Console.WriteLine("Input first number: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Akkerman is "+ Akkerman(m, n));
*/