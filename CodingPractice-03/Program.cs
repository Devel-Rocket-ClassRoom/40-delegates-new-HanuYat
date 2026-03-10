using System;

// README.md를 읽고 아래에 코드를 작성하세요.

static void GoForward()
{
    Console.WriteLine("직진");
}
static void GoLeft()
{
    Console.WriteLine("좌회전");
}
static void GoRight()
{
    Console.WriteLine("우회전");
}

Action car = GoForward;
car += GoLeft;
car += GoRight;
car();
Console.WriteLine();

Action drive = GoForward;
drive += GoLeft;
drive += delegate ()
{
    Console.WriteLine("우회전");
};
drive();