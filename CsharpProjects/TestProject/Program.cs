// 리터럴 및 변수 값을 사용하여 데이터 저장 및 검색
/*
var Name = "Bob";
var Integer = 3;
var Float = 34.4;

Console.WriteLine($"Hello, {Name}! You have {Integer} in your inbox. The temperature is {Float} celsius");
 */

// 문자 이스케이프 시퀀스를 사용하여 출력 형식 지정
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

// 리터럴 문자열과 변수 연결
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

// 오버로드된 메서드
/*
Random dice = new Random(); //클래스 인스턴스 만들기

int Roll1 = dice.Next();
int Roll2 = dice.Next(11);
int Roll3 = dice.Next(1, 11);

Console.WriteLine($"first number is {Roll1}");
Console.WriteLine($"second number is {Roll2}");
Console.WriteLine($"third number is {Roll3}");
*/

// 더 큰 수 찾기
/*
int firstValue = 500;
int secondValue = 600;
int largerValue;

largerValue = Math.Max(firstValue, secondValue);
Console.WriteLine(largerValue);
*/

// 주사위 게임
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

// foreach문
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


/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
/*
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}
*/


/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */
/*
string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");
*/


// Boolean
/*
Console.WriteLine("a" == "A");
Console.WriteLine("a" == "a");
Console.WriteLine(1 == 2);

string myValue1 = "a";
Console.WriteLine(myValue1 == "a");
*/
/*
Console.WriteLine("a" != "a");
Console.WriteLine("a" != "A");
Console.WriteLine(1 != 2);

string myValue2 = "a";
Console.WriteLine(myValue2 != "a");

Console.WriteLine(1 > 2);
Console.WriteLine(1 < 2);
Console.WriteLine(1 >= 1);
Console.WriteLine(1 <= 1);
*/
/*
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));

int saleAmount = 1001;
Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "heard" : "tails");
*/
/*
string permission = "Admin|Manager";
int level = 56 ;

if (permission.Contains("Admin"))
{
    if (level > 55) Console.WriteLine("Welcome, Super Admin user.");
    else Console.WriteLine("Welcome, Admin user.");
}
else if (permission.Contains("Manager"))
{
    if (level >= 20) Console.WriteLine("Contact an Admin for access.");
    else Console.WriteLine("You do not have sufficient privileges.");
}
else Console.WriteLine("You do not have sufficient privileges.");
*/

// switch 문
/*
int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");
*/
/*
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
    case "01": 
        type = "Sweat shirt";
        break;
    case "02": 
        type = "T-Shirt";
        break;
    case "03": 
        type = "Sweat pants";
        break;
    default: 
        type = "Other";
        break;
}
switch (product[1])
{
    case "BL":
        color = "Black";
        break;
    case "MN":
        color = "Maroon";
        break;
    default:
        color = "White";
        break;
}
switch (product[2])
{
    case "S":
        size = "Small";
        break;
    case "M":
        size = "Medium";
        break;
    case "L":
        size = "Large";
        break;
    default:
        size = "One Size Fits All";
        break;
}
Console.WriteLine($"Product: {size} {color} {type}");
*/

// FizzBuzz 과제
/*
for (int i = 1; i <= 100; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
    {
        Console.WriteLine($"{i} - FizzBuzz");
    }
    else if (i % 3 == 0)
    {
        Console.WriteLine($"{i} - Fizz");
    }
    else if (i % 5 == 0)
    {
        Console.WriteLine($"{i} - Buzz");
    }
    
    else Console.WriteLine(i);
}
*/

// do - while
/*
Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/
/*
int hero = 10, monster = 10;
int heroAttack = 0;
int monsterAttack = 0;
Random attack = new Random();

do
{
    heroAttack = attack.Next(1, 11);
    monster -= heroAttack;
    Console.WriteLine("The hero attacks the monster!");
    Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monster} health.\n");
    
    if (monster <= 0) continue;

    monsterAttack = attack.Next(1, 11);
    hero -= monsterAttack;
    Console.WriteLine("The monster attacks the hero!");
    Console.WriteLine($"hero was damaged and lost {monsterAttack} health and now has {hero} health.\n");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero Wins!" : "Monster Wins!");
*/
/*
string? readResult;
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");
do
{
    readResult = Console.ReadLine();

    if (readResult != null)
    {
        valueEntered = readResult;
    }

    if (int.TryParse(valueEntered, out numValue))
    {
        numValue = int.Parse(valueEntered);
        if (numValue > 5 && numValue < 10)
        {
            validNumber = true;
            continue;
        }
        else Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
    }

    else Console.WriteLine("Sorry, you entered an invalid number, please try again");

} while (validNumber == false);
Console.WriteLine($"Your input value ({numValue}) has been accepted.");
*/
/*
string? readResult;
string roleName = "";
bool validEntry = false;

do
{                
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();
    if (readResult != null) 
    {
        roleName = readResult.Trim();
    }

    if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
    {
        validEntry = true;
    }
    else
    {
        Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
    }

} while (validEntry == false);

Console.WriteLine($"Your input value ({roleName}) has been accepted.");
readResult = Console.ReadLine();
*/
/*
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation = 0;
string myString;


for (int i = 0; i < myStrings.Length; i++)
{
    myString = myStrings[i];
    periodLocation = myString.IndexOf(".");

    string mySentence;

    while (periodLocation != -1)
    {
        mySentence = myString.Remove(periodLocation);

        myString = myString.Substring(periodLocation + 1);

        myString = myString.TrimStart();

        periodLocation = myString.IndexOf(".");

        Console.WriteLine(mySentence);
    } 
    mySentence = myString.Trim();
    Console.WriteLine(mySentence);
}
*/

// 데이터 형식 캐스팅
/*
decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");
*/
/*
int first = 1;
int second = 2;
string message = first.ToString() + second.ToString();

Console.WriteLine(message);
*/
/*
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);

int result = Convert.ToInt32(first) * Convert.ToInt32(second);
Console.WriteLine(result);
*/
/*
string value = "102";
int result = 0;
if (int.TryParse(value, out result))
{
    Console.WriteLine($"Measurement: {result}");
}
else
{
    Console.WriteLine("Unable to report the measurement.");
}
Console.WriteLine($"Measurement (w/ offset): {50 + result}");
*/

// 문자열 배열 값을 문자열 및 정수로 결합하는 과제
/*
string[] values = { "12.3", "45", "ABC", "11", "DEF" };

decimal total = 0;
string message = "";

foreach (var value in values)
{
    decimal number;
    if (decimal.TryParse(value, out number))
    {
        total += number;
    }
    else 
    {
        message += value;
    }
}

Console.WriteLine($"{total}\n{message}");
*/

// 수학 연산을 특정 숫자 형식으로 출력하는 과제
/*
int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
decimal result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
*/

// 부호 있는 정수 형식 / 부호 없는 정수 형식
/*
Console.WriteLine("Signed integral types:");

Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Unsigned integral types:");

Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

Console.WriteLine("");
Console.WriteLine("Floating point types:");
Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
*/

// Array.Sort() 및 Array.Reversse()
/*
string[] pallets = { "B14", "A11", "B12", "A13" };

Console.WriteLine("Sorted...");
Array.Sort(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Console.WriteLine("Reversed...");
Array.Reverse(pallets);
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}