//리터럴 및 변수 값을 사용하여 데이터 저장 및 검색
/*
var Name = "Bob";
var Integer = 3;
var Float = 34.4;

Console.WriteLine($"Hello, {Name}! You have {Integer} in your inbox. The temperature is {Float} celsius");
 */

//문자 이스케이프 시퀀스를 사용하여 출력 형식 지정
/*
Console.WriteLine("Generating invoices for customer \"Contoso Corp\" ...\n");
Console.WriteLine("Invoice: 1021\t\tComplete!");
Console.WriteLine("Invoice: 1022\t\tComplete!");
Console.WriteLine("\nOutput Directory:\t");

//축자 문자열 리터럴
Console.Write(@"c:\invoices");

//유니코드 이스케이프 문자를 사용하여 출력 형식 지정
// To generate Japanese invoices:
// Nihon no seikyū-sho o seisei suru ni wa:
Console.Write("\n\n\u65e5\u672c\u306e\u8acb\u6c42\u66f8\u3092\u751f\u6210\u3059\u308b\u306b\u306f\uff1a\n");
// User command to run an application
Console.Write(@"c:\invoices\app.exe -j");
*/

//리터럴 문자열과 변수 연결

String greeting = "hello";
String firstName = "Bob";
Console.WriteLine(greeting + " " + firstName + "!");

//string interpolation
String message = $"{greeting} {firstName}!";
Console.WriteLine(message);

int version = 11;
String updateText = "update to Windows";
Console.WriteLine($"{updateText} {version}");
/*
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

Random dice = new Random();

int Roll1 = dice.Next();
int Roll2 = dice.Next(11);
int Roll3 = dice.Next(1, 11);

Console.WriteLine($"first number is {Roll1}");
Console.WriteLine($"second number is {Roll2}");
Console.WriteLine($"third number is {Roll3}");
*/