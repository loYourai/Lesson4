
using System.Reflection;
using System.Security.Cryptography;
/*
int a = 5;
int b = 7;

int MultiplicationOrDivision(int a, int b, bool shouldDivide)
{
    if (shouldDivide)
    {
        return a / b;
    }

    return a * b;
}

bool CanDivideByTwo(int a)
{
    return a % 2 == 0;
}

int SumBetweenNumbers(ref int a, int b)
{
    a = 11;
    int localSum = 0;
    for (int i = a; i < b + 1; i++)
    {
        localSum += i;
    }

    return localSum;
}

//a = 10;
//b = 11;
//Console.WriteLine("a = " + a); 
//int result = SumBetweenNumbers(ref a, b);
//Console.WriteLine(result);

//Console.WriteLine("a = " + a);

//bool TryParseInt(string value, out int parsedValue)
//{
//    var parseResult = int.TryParse(value, out parsedValue);
//    parsedValue = 200;
//    return parseResult;
//}

//string input = "100";
//int result = 0;

//if (TryParseInt(input, out result))
//{
//    Console.WriteLine(result);
//}

//bool TryDvivideByThree(int input, out int divisionResult)
//{
//    divisionResult = input / 3;
//    return input % 3 == 0;
//}

//a = 22;
//int divisionbyThreeResult = 0;
//bool canBeDivided = TryDvivideByThree(a, out divisionbyThreeResult);
//Console.WriteLine(a + " can be divided by three? Answer: " + canBeDivided + " " + divisionbyThreeResult);

// FIBONACCI

a = 6;
int FibonacciSum(int a) // 0,1,1,2,3,5
{
    int previousPreviousNumber = 0;
    int previousNumber = 1;
    int count = 3;
    int fiboSum = previousPreviousNumber + previousNumber;

    while (count <= a)
    {
        fiboSum += previousNumber + previousPreviousNumber;

        int temp = previousNumber;
        previousNumber = previousNumber + previousPreviousNumber;
        previousPreviousNumber = temp;

        count++;
    }

    return fiboSum;
}

//int FibonacciSumRecursively(int a)
//{

//    if (a == 1) return 0;
//    if (a == 2) return 1;

//    if (a == 3) return 
//}

Random random = new Random();

int SumOfGenerateRandomNumbers(int min, int max, int count = 5)
{
    int resultSum = 0;
    for (int i = 0; i < count; i++)
    {
        int randomNumber = random.Next(min, max);
        resultSum += randomNumber;
    }

    return resultSum;
}

Console.Write("Min: ");
int min = int.Parse(Console.ReadLine());

Console.Write("Max: ");
int max = int.Parse(Console.ReadLine());

Console.Write("Count: ");
int count = int.Parse(Console.ReadLine());

int randNumberSum = SumOfGenerateRandomNumbers(min, max);

string result = $"Sum of {count} random numbers: {randNumberSum}. Numbers were generated between {min} and {max}";
Console.WriteLine(result);

//Console.WriteLine("Fibo sum for " + a + " is: " + FibonacciSum(a));

//Console.WriteLine(a + " can be divided by two? Answer: " + CanDivideByTwo(a));
*/
























// Максимальное значение
/*
 int maxValue(int a, int b  )
{
    int result =  Int32.MaxValue;
    return result;
    


}


int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int result = maxValue(a, b);
Console.WriteLine(result);

*/







// Минимальное значение
/*
int minValue(int a, int b)
{
    int result = Int32.MinValue;
    return result;



}


int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());
int result2 = minValue(A, B);
Console.WriteLine(result2);
*/

//true//false

 int TrySumIfOdd(int a, int b)
{
    int result3 = a + b;
    if (result3 % 2 == 0) 
    {
        Console.WriteLine("even number: " + result3);
    }
    else
    {
        Console.WriteLine("odd number: " + result3); 
    }
   
    return result3;

}



int A = int.Parse(Console.ReadLine());
int B = int.Parse(Console.ReadLine());

int result = TrySumIfOdd(A, B);


// Я робив як знав,скорiш за все, це не правильно, я шукав яз це робити але не знайшов

