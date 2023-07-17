
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
/*
String greeting = "hello";
String firstName = "Bob";
Console.WriteLine(greeting + " " + firstName + "!");

//string interpolation
String message = $"{greeting} {firstName}!";
Console.WriteLine(message);

int version = 11;
String updateText = "update to Windows";
Console.WriteLine($"{updateText} {version}");

//축자 리터럴 및 string interpolation 결합
string projectName = "ACME";
Console.WriteLine($@"View English output:
    c:\Exercise\{projectName}\data.txt");
*/

//오버로드된 메서드
/*
Random dice = new Random(); //클래스 인스턴스 만들기

int Roll1 = dice.Next();
int Roll2 = dice.Next(11);
int Roll3 = dice.Next(1, 11);

Console.WriteLine($"first number is {Roll1}");
Console.WriteLine($"second number is {Roll2}");
Console.WriteLine($"third number is {Roll3}");
*/

//더 큰 수 찾기
/*
int firstValue = 500;
int secondValue = 600;
int largerValue;

largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);
*/

//주사위 게임
/*
Random dice = new Random();
int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)){
    total += 2;
    Console.WriteLine(@$"You rolled doubles! +2 bonus to total!
current score: {total}");
}
else if ((roll1 == roll2) && (roll2 == roll3)){
    total += 6;
    Console.WriteLine(@$"You rolled triples! +6 bonus to total!
current score: {total}");
}
if (total >= 15) Console.WriteLine("You win!");
else Console.WriteLine("Sorry, You lose.");
*/

//foreach문
/*
String[] orderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

foreach(String orderID in orderIDs)
{
    if(orderID.StartsWith('B'))
    {
        Console.WriteLine(orderID);
    }
}
*/

Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}