using System;

// README.md를 읽고 코드를 작성하세요.

Console.WriteLine("=== 사칙연산 대리자 ===");
MathOp add = Add;
MathOp sub = Subtract;
MathOp multiply = Multiply;
MathOp divide = Divide;
Console.WriteLine();

Console.WriteLine("[덧셈]");
Console.WriteLine($"20 + 4 = {add(20, 4)}");
Console.WriteLine();

Console.WriteLine("[뺄셈]");
Console.WriteLine($"20 - 4 = {sub(20, 4)}");
Console.WriteLine();

Console.WriteLine("[곱셈]");
Console.WriteLine($"20 * 4 = {multiply(20, 4)}");
Console.WriteLine();

Console.WriteLine("[나눗셈]");
Console.WriteLine($"20 / 4 = {divide(20, 4)}");

static int Add(int x, int y)
{
    return x + y;
}
static int Subtract(int x, int y)
{
    return x - y;
}
static int Multiply(int x, int y)
{
    return x * y;
}
static int Divide(int x, int y)
{
    return x / y;
}

delegate int MathOp(int x, int y);