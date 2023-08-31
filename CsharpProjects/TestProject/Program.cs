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

// Array.Clear() 및 Array.Resize()
/*
string[] pallets = { "B14", "A11", "B12", "A13" };
Console.WriteLine("");

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine("");
Array.Resize(ref pallets, 3);
Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
*/

// String.Join() 및 Split()
/*
string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
// string result = new string(valueArray);
string result = String.Join(",", valueArray);
Console.WriteLine(result);

string[] items = result.Split(',');
foreach (string item in items)
{
    Console.WriteLine(item);
}
*/

// 문장에서 단어를 되돌리는 과제
/*
string pangram = "The quick brown fox jumps over the lazy dog";

string[] values = pangram.Split(' ');
string[] results = new string[values.Length];
int index = 0;

for (int i = 0; i < values.Length; i ++)
{
    char[] letters = values[i].ToCharArray();
    Array.Reverse(letters);
    results[i] = new string(letters);
}

string result = String.Join(" ", results);
Console.WriteLine(result);
*/
/*
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] results = orderStream.Split(',');
Array.Sort(results);

foreach (var result in results)
{
    if (result.Length != 4)
    {
        Console.WriteLine($"{result}\t\t error");
    }
    else{
        Console.WriteLine(result);
    }
}
*/

// 문자열 서식 지정
/*
int invoiceNumber = 1201;
decimal productShares = 25.4568m;
decimal subtotal = 2750.00m;
decimal taxPercentage = .15825m;
decimal total = 3185.19m;

Console.WriteLine($"Invoice Number: {invoiceNumber}");
Console.WriteLine($"   Shares: {productShares:N3} Product");
Console.WriteLine($"     Sub Total: {subtotal:C}");
Console.WriteLine($"           Tax: {taxPercentage:P2}");
Console.WriteLine($"     Total Billed: {total:C}");
*/
/*
string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
Console.WriteLine(input.PadLeft(12, '-'));
Console.WriteLine(input.PadRight(12, '-'));
*/
/*
string paymentId = "769";
string payeeName = "Mr. Stephen Ortega";
string paymentAmount = "$5,000.00";

var formattedLine = paymentId.PadRight(6);
formattedLine += payeeName.PadRight(24);
formattedLine += paymentAmount.PadLeft(10);

Console.WriteLine("1234567890123456789012345678901234567890");
Console.WriteLine(formattedLine);
*/
/*
string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here

Console.WriteLine($"{customerName},\nAs a customer of our Magic Yield offering we are excited to tell you about a new financial product that would dramatically increase your return.");
Console.WriteLine($"Currently, you own {currentShares:N3} shares at a return of {currentReturn:P2}%.");
Console.WriteLine($"Our new product, Glorious Future offers a return of {newReturn:P2} %.  Given your current volume, your potential profit would be {newProfit:C}.");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

comparisonMessage += currentProduct.PadRight(20);
comparisonMessage += $"{currentReturn:P2}".PadRight(10);
comparisonMessage += $"{currentProfit:C}".PadRight(20);

comparisonMessage += "\n";
comparisonMessage += newProduct.PadRight(20);
comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

// Your logic here
Console.WriteLine(comparisonMessage);
*/

// IndexOf() 및 IndexOfAny()
/*
string message = "What is the value <span>between the tags</span>?";

const string openSpan = "<span>";
const string closeSpan = "</span>";

int openingPosition = message.IndexOf(openSpan);
int closingPosition = message.IndexOf(closeSpan);

openingPosition += openSpan.Length;
int length = closingPosition - openingPosition;
Console.WriteLine(message.Substring(openingPosition, length));
*/
/*
string message = "(What if) I have [different symbols] but every {open symbol} needs a [matching closing symbol]?";

// The IndexOfAny() helper method requires a char array of characters. 
// You want to look for:

char[] openSymbols = { '[', '{', '(' };

// You'll use a slightly different technique for iterating through 
// the characters in the string. This time, use the closing 
// position of the previous iteration as the starting index for the 
//next open symbol. So, you need to initialize the closingPosition 
// variable to zero:

int closingPosition = 0;

while (true)
{
    int openingPosition = message.IndexOfAny(openSymbols, closingPosition);

    if (openingPosition == -1) break;

    string currentSymbol = message.Substring(openingPosition, 1);

    // Now  find the matching closing symbol
    char matchingSymbol = ' ';

    switch (currentSymbol)
    {
        case "[":
            matchingSymbol = ']';
            break;
        case "{":
            matchingSymbol = '}';
            break;
        case "(":
            matchingSymbol = ')';
            break;
    }

    // To find the closingPosition, use an overload of the IndexOf method to specify 
    // that the search for the matchingSymbol should start at the openingPosition in the string. 

    openingPosition += 1;
    closingPosition = message.IndexOf(matchingSymbol, openingPosition);

    // Finally, use the techniques you've already learned to display the sub-string:

    int length = closingPosition - openingPosition;
    Console.WriteLine(message.Substring(openingPosition, length));
}
*/

// 입력 문자열에서 데이터를 추출, 바꾸기 및 제거하는 과제
/*
const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
int openIndex = input.IndexOf("<span>");
int closeIndex = input.IndexOf('<', openIndex + 1 );
openIndex += 6;

int length = closeIndex - openIndex;
quantity = input.Substring(openIndex, length);

output = input.Replace("&trade;", "&reg;");

openIndex = output.IndexOf("<div>");
closeIndex = output.LastIndexOf('<');
openIndex += 5;

length = closeIndex - openIndex;
output = output.Substring(openIndex, length);

Console.WriteLine($"Quantity: {quantity}");
Console.WriteLine($"Output: {output}");
*/

// 메서드 
/*
using System;

int[] times = { 800, 1200, 1600, 2000 };
int diff = 0;

Console.WriteLine("Enter current GMT");
int currentGMT = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Current Medicine Schedule:");
DisplayTimes();

Console.WriteLine();

Console.WriteLine("Enter new GMT");
int newGMT = Convert.ToInt32(Console.ReadLine());

if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
{
    Console.WriteLine("Invalid GMT");
}
else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
{
    diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    AdjustTimes();
}
else
{
    diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    AdjustTimes();
}

Console.WriteLine("New Medicine Schedule:");
DisplayTimes();

Console.WriteLine();

void DisplayTimes()
{
    // Format and display medicine times
    foreach (int val in times)
    {
        string time = val.ToString();
        int len = time.Length;

        if (len >= 3)
        {
            time = time.Insert(len - 2, ":");
        }
        else if (len == 2)
        {
            time = time.Insert(0, "0:");
        }
        else
        {
            time = time.Insert(0, "0:0");
        }

        Console.Write($"{time} ");
    }
}
void AdjustTimes()
{
    // Adjust the times by adding the difference, keeping the value within 24 hours 
    for (int i = 0; i < times.Length; i++)
    {
        times[i] = ((times[i] + diff)) % 2400;
    }
}
*/
/*
string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
string[] address;
bool validLength = false;
bool validZeroes = false;
bool validRange = false;

foreach (string ip in ipv4Input) 
{
    address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

    ValidateLength(); 
    ValidateZeroes(); 
    ValidateRange();

    if (validLength && validZeroes && validRange) 
    {
        Console.WriteLine($"{ip} is a valid IPv4 address");
    } 
    else 
    {
        Console.WriteLine($"{ip} is an invalid IPv4 address");
    }
}

void ValidateLength() 
{
    validLength = address.Length == 4;
};

void ValidateZeroes() 
{
    foreach (string number in address) 
    {
        if (number.Length > 1 && number.StartsWith("0")) 
        {
            validZeroes = false;
            return;
        }
    }

    validZeroes = true;
}

void ValidateRange() 
{
    foreach (string number in address) 
    {
        if (int.Parse(number) > 255) 
        {
            validRange = false;
            return;
        }
    }
    validRange = true;
}
*/
/*
Random random = new Random();
int luck = random.Next(100);

string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

Console.WriteLine("A fortune teller whispers the following words:");
string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
for (int i = 0; i < 4; i++) 
{
    Console.Write($"{text[i]} {fortune[i]} ");
}
*/
/*
int[] schedule = { 800, 1200, 1600, 2000 };

DisplayAdjustedTimes(schedule, 6, -6);

void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
{
    int diff = 0;
    if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
    {
        Console.WriteLine("Invalid GMT");
    }
    else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
    {
        diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
    }
    else
    {
        diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
    }
    for (int i = 0; i < times.Length; i++)
    {
        int newTime = ((times[i] + diff)) % 2400;
        Console.WriteLine($"{times[i]} -> {newTime}");
    }
}
*/

// RSVP 애플리케이션 만들기
/*
string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
string[] rsvps = new string[10];
int count = 0;

RSVP("Rebecca", 1, "none", true);
RSVP("Nadia", 2, "Nuts", true);
RSVP("Linh", 2, "none", false);
RSVP("Tony", inviteOnly: true, allergies: "Jackfruit",  partySize: 1);
RSVP("Noor", 4, "none", false);
RSVP("Jonte", 2, "Stone fruit", false);
ShowRSVPs();

void RSVP(string name, int partySize, string allergies, bool inviteOnly) 
{
    if (inviteOnly)
{
    bool found = false;
    foreach (string guest in guestList)
    {
        if (guest.Equals(name)) {
            found = true;
            break;
        }
    }
    if (!found)
    {
        Console.WriteLine($"Sorry, {name} is not on the guest list");
        return;
    }
}

    rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
    count++;
}

void ShowRSVPs()
{
    Console.WriteLine("\nTotal RSVPs:");
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(rsvps[i]);
    }
}
*/

// 이메일 주소를 표시하는 메서드
/*
string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string corporateDomain = "contoso.com";
string externalDomain = "hayworth.com";
string domainDomain = "";
string email = "";

emailAdress(corporate);
emailAdress(external);

void emailAdress(string[,] domain)
{
    domainDomain = (domain == corporate ? corporateDomain : externalDomain);
    for (int i = 0; i < domain.GetLength(0); i++)
    {
        email = domain[i, 0].Substring(0, 2).ToLower() + domain[i, 1].ToLower() + "@" + domainDomain;
        Console.WriteLine(email);
    }
}
*/

// 총 구매 가격 계산
/*
double total = 0;
double minimumSpend = 30.00;

double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

for (int i = 0; i < items.Length; i++)
{
    total += GetDiscountedPrice(i);
}

total -= TotalMeetsMinimum() ? 5.00 : 0.00;

Console.WriteLine($"Total: ${FormatDecimal(total)}");

double GetDiscountedPrice(int itemIndex)
{
    return items[itemIndex] * (1 - discounts[itemIndex]);
}

bool TotalMeetsMinimum()
{
    return total >= minimumSpend;
}

string FormatDecimal(double input)
{
    return input.ToString().Substring(0, 5);
}
*/

// 가격과 일치하는 코인 조합 구하기
/*
int target = 60;
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
int[] result = TwoCoins(coins, target);

if (result.Length == 0) 
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine($"Change found at positions {result[0]} and {result[1]}");
}

int[] TwoCoins(int[] coins, int target) 
{
    for (int curr = 0; curr < coins.Length; curr++) 
{
    for (int next = curr + 1; next < coins.Length; next++) 
    {
        if (coins[curr] + coins[next] == target) 
        {
            return new int[]{curr, next};
        }

    }
}
    return  new int[0];
}
*/
/*
int target = 30;
int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
int[,] result = TwoCoins(coins, target);

if (result.Length == 0) 
{
    Console.WriteLine("No two coins make change");
} 
else 
{
    Console.WriteLine("Change found at positions:");
    for (int i = 0; i < result.GetLength(0); i++) 
    {
        if (result[i,0] == -1) 
        {
            break;
        }
        Console.WriteLine($"{result[i,0]},{result[i,1]}");
    }
}

int[,] TwoCoins(int[] coins, int target) 
{
    int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
    int count = 0;

    for (int curr = 0; curr < coins.Length; curr++) 
    {
        for (int next = curr + 1; next < coins.Length; next++) 
        {
            if (coins[curr] + coins[next] == target) 
            {
                result[count, 0] = curr;
                result[count, 1] = next;
                count++;
            }
            if (count == result.GetLength(0)) 
            {
                return result;
            }
        }
    }
    return (count == 0) ? new int[0,0] : result;
}
*/

// 주사위 미니 게임 과제
/*
using System.Reflection.Metadata.Ecma335;
using System.Runtime;

Random random = new Random();

Console.WriteLine("Would you like to play? (Y/N)");
if (ShouldPlay())
{
    PlayGame();
}

void PlayGame()
{
    var play = true;

    while (play)
    {
        int target = random.Next(1, 6);
        int roll = random.Next(1, 7);

        Console.WriteLine($"Roll a number greater than {target} to win!");
        Console.WriteLine($"You rolled a {roll}");
        Console.WriteLine(WinOrLose(target, roll));
        Console.WriteLine("\nPlay again? (Y/N)");

        play = ShouldPlay();
    }
}

bool ShouldPlay() 
{
    string response = Console.ReadLine();
    return response.ToLower().Equals("y");
}

string WinOrLose(int target, int roll)
{
    return (target > roll ? "you lose" : "you win!");
}
*/

// 동물원 학교 그룹 별 동물 관람 방식 지정
/*
using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);

void PlanSchoolVisit(string schoolName, int groups = 6) 
{
    RandomizeAnimals(); 
    string[,] group1 = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group1);
}

void RandomizeAnimals() 
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++) 
    {
        int r = random.Next(i, pettingZoo.Length);

        string temp = pettingZoo[r];
        pettingZoo[r] = pettingZoo[i];
        pettingZoo[i] = temp;
    }
}

string[,] AssignGroup(int groups = 6) 
{
    string[,] result = new string[groups, pettingZoo.Length/groups];
    int start = 0;

    for (int i = 0; i < groups; i++) 
    {
        for (int j = 0; j < result.GetLength(1); j++) 
        {
            result[i,j] = pettingZoo[start++];
        }
    }

    return result;
}

void PrintGroup(string[,] groups) 
{
    for (int i = 0; i < groups.GetLength(0); i++) 
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < groups.GetLength(1); j++) 
        {
            Console.Write($"{groups[i,j]}  ");
        }
        Console.WriteLine();
    }
}
*/

