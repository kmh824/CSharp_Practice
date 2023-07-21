
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


//Boolean
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

//switch 문
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

//FizzBuzz 과제
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

//do - while
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
do
{
    Console.WriteLine("Enter an integer value between 5 and 10");
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

string permission = "administrator|aanager|user";
string? readResult;
string roleName = "";
bool validEntry = false;
do
{
    Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
    readResult = Console.ReadLine();

    if (readResult != null){
        roleName = readResult;
    }
    
} while (true);
