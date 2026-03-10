using System;

// README.md를 읽고 아래에 코드를 작성하세요.

Console.WriteLine("=== 문자열 처리 파이프라인 ===\n");

Console.WriteLine("--- 단계 1: 원본 출력만 ---");
Action<string> pipe = PrintOriginal;
pipe("Hello World");
Console.WriteLine();

Console.WriteLine("--- 단계 2: 대문자 추가 ---");
pipe += PrintUpper;
pipe("Hello World");
Console.WriteLine();

Console.WriteLine("--- 단계 3: 소문자, 길이 추가 ---");
pipe += PrintLower;
pipe += PrintLength;
pipe("Hello World");
Console.WriteLine();

Console.WriteLine("--- 단계 4: 대문자 제거 ---");
pipe -= PrintUpper;
pipe("Hello World");

void PrintOriginal(string s)
{
    Console.WriteLine($"원본: {s}");
}
void PrintUpper(string s)
{
    Console.WriteLine($"대문자: {s.ToUpper()}");
}
void PrintLower(string s)
{
    Console.WriteLine($"소문자: {s.ToLower()}");
}
void PrintLength(string s)
{
    Console.WriteLine($"길이: {s.Length}");
}