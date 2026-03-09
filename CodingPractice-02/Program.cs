using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Calculator calc = new Calculator();
Transformer t = calc.Multiply;
Console.WriteLine(t(5));
Console.WriteLine();

static void GoForward() => Console.WriteLine("직진");
static void GoLeft() => Console.WriteLine("좌회전");
static void GoRight() => Console.WriteLine("우회전");

CarDriver driver = GoForward;
driver += GoLeft;
driver += GoRight;
driver();
Console.WriteLine();

driver -= GoLeft;
driver();
Console.WriteLine();

static void Transform(int[] values, Transformer t)
{
    for (int i = 0; i < values.Length; i++)
    {
        values[i] = t(values[i]);
    }
}

static void PrintArray(int[] arr)
{
    Console.WriteLine(string.Join(", ", arr));
}

static int Square(int x) => x * x;
static int Cube(int x) => x * x * x;

int[] numbers = { 1, 2, 3, 4, 5 };

Transform(numbers, Square);
PrintArray(numbers);

numbers = new int[] { 1, 2, 3, 4, 5 };

Transform(numbers, Cube);
PrintArray(numbers);

delegate int Transformer(int x);
delegate void CarDriver();