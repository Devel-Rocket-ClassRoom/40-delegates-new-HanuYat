using System;
using System.Linq;

// README.md를 읽고 코드를 작성하세요.

Console.WriteLine("=== 문자열 가공기 ===\n");

string original = "Hello World";
Console.WriteLine($"원본: {original}");
Console.WriteLine();

Console.WriteLine("[대문자 변환]");
ProcessAndPrint(original, ToUpperCase);
Console.WriteLine();

Console.WriteLine("[소문자 변환]");
ProcessAndPrint(original, ToLowerCase);
Console.WriteLine();

Console.WriteLine("[괄호 추가]");
ProcessAndPrint(original, AddBrackets);
Console.WriteLine();

Console.WriteLine("[문자열 뒤집기]");
ProcessAndPrint(original, Reverse);
Console.WriteLine();

string ToUpperCase(string s)
{
    return s.ToUpper();
}
string ToLowerCase(string s)
{
    return s.ToLower();
}
string AddBrackets(string s)
{
    return $"[{s}]";
}
string Reverse(string s)
{
    char[] chars = s.ToCharArray();
    Array.Reverse(chars);
    string reverse = new string(chars);
    return reverse;
}

void ProcessAndPrint(string input, StringProcessor processor)
{
    Console.WriteLine($"결과: {processor(input)}");
}

delegate string StringProcessor(string s);