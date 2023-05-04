

int a = 5;
int b = 7;

int MultiplicationOrDivision(int a, int b, bool shhouldDivide)
{
    if (shhouldDivide)
    { 
    return a / b;
        
    }
    return a * b;
}

bool CanDivideByTwo(int a)
{
   
    return a % 2 == 0;
}

int SumBetweenNumbers(ref int  a, int b)
{
    a = 11;
    int localSum = 0;
    for (int i = a; i < b +1; i++)
    {
        localSum += i;
    }
    
    return localSum;
    
}
/*
a = 10;
b = 11;
Console.WriteLine("a = " + a);
int result = SumBetweenNumbers(ref a, b);

Console.WriteLine(result);

Console.WriteLine("a = " + a);
*/

bool TryParseInt(string value, out int parsedValue);
{
    var parseResult = int.TryParse(ValueTask)
}

string input = "100";
int result = 0;
if (int.TryParse(input, out result));
{
    Console.WriteLine(result);
}




//Console.WriteLine(a + " can  be divided by two? Answer: " + CanDivideByTwo(a));



