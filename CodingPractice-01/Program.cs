using System;

// README.md를 읽고 아래에 코드를 작성하세요.

static void Hello()
{
    Console.WriteLine("Hello Delegate");
}

SayDelegate say = Hello;

say();
say.Invoke();
Console.WriteLine();

static void Hi() => Console.WriteLine("안녕하세요.");
SayDelegate hi = Hi;
hi();
var hi2 = new SayDelegate(Hi);
hi2();
Console.WriteLine();

static double GetArea(int radius) => 3.14 * radius * radius;
GetAreaDelegate area = GetArea;

Console.WriteLine(area(10));
Console.WriteLine(area.Invoke(10));
Console.WriteLine();

MathOperation op = Math.Pow;
Console.WriteLine(op(2, 10));
Console.WriteLine();

Transformer t = Calculator.Square;
Console.WriteLine(t(5));
Console.WriteLine();

static void WriteToConsole(int i)
{
    Console.WriteLine($"진행률: {i}%");
}

static void WriteToFile(int i)
{
    Console.WriteLine($"[파일 기록] {i}%");
}

ProgressReporter reporter = WriteToConsole;
reporter += WriteToFile;
for (int i = 0; i <= 100; i += 25)
{
    reporter(i);
    Console.WriteLine();
}
Console.WriteLine();

static void Go() => Console.WriteLine("직진");
static void Back() => Console.WriteLine("후진");
static void RunnerCall(Runner runner)
{
    Console.WriteLine("=== 실행 시작 ===");
    runner();
    Console.WriteLine("=== 실행 종료 ===");
}

RunnerCall(Go);
Console.WriteLine();
RunnerCall(Back);
Console.WriteLine();

Action greet = () => Console.WriteLine("안녕하세요!");
greet();
Action<string> print = (msg) => Console.WriteLine(msg);
print("Hello, Action!");
Action<string, int> printRepeat = (msg, count) =>
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(msg);
    }
};
printRepeat("반복", 3);
Console.WriteLine();

Func<int> re = () => 42;
Console.WriteLine(re());
Func<int, int> square1 = (x) => x * x;
Console.WriteLine(square1(5));
Func<int, int, int> sum = (x, y) => x + y;
Console.WriteLine(sum(2, 8));
Func<int, int, string> output = (a, b) => (a + b).ToString();
Console.WriteLine(output(1, 7));
Console.WriteLine();

Predicate<int> isEven = (x) => x % 2 == 0;
Predicate<int> isPositive = (x) => x > 0;

Console.WriteLine(isEven(4));
Console.WriteLine(isEven(7));
Console.WriteLine(isPositive(5));
Console.WriteLine(isPositive(-3));
Console.WriteLine();

SayDelegate say1 = delegate ()
{
    Console.WriteLine("반갑습니다.");
};
say1();

delegate void SayDelegate();
delegate double GetAreaDelegate(int i);
delegate double MathOperation(double x, double y);
delegate int Transformer(int i);
delegate void ProgressReporter(int i);
delegate void Runner();