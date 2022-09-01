int Factorial(int value)
{
    if (value == 1) return 1;
    return value * Factorial(value - 1);
}
Console.WriteLine(Factorial(3));