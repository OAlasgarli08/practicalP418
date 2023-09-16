//Practical 1

//static void ShowText()
//{
//    Console.WriteLine("Hellow World");
//}
//
// ShowText();

// -------------------------------------------------------------------------

// Practical 2

//static void Sum()
//{
//    int a = 5;
//    int b = 6;
//    int sum = a + b;
//    Console.WriteLine(sum);
//}

//Sum();

// -------------------------------------------------------------------------

// Practical 3


//static void Sum(int numb1)
//{ 
//    Console.WriteLine(numb1);
//}

//Sum(5);

// -------------------------------------------------------------------------

// Practical 4

//static void SumOfNumbs(int a, int b)
//{
//    int sum = a + b;
//    Console.WriteLine(sum);
//}

//int a = 5;
//int b = 5;

//SumOfNumbs(a, b);

// -------------------------------------------------------------------------

// Practical 5

//static void GetNumbsOfArray(int[] numbers)
//{
//    foreach (var number in numbers)
//    {
//        Console.WriteLine(number);
//    }
//}

//int[] numbs = { 1, 2, 3, 4, 5, 6, 7 };

//GetNumbsOfArray(numbs);

// -------------------------------------------------------------------------

// Practical 6

//static void CheckMarried(bool isMarried, int age)
//{
//    if (isMarried)
//    {
//        Console.WriteLine("Married and is" + age);
//    }
//    else 
//    {
//        Console.WriteLine("Not Married and is" + age);
//    }
//}

//bool isMarried = true;


//static void GetAge(int age)
//{
//    bool isMarried = false;

//    CheckMarried(isMarried, age);
//}

//int age = 40;
//GetAge(age);

// -------------------------------------------------------------------------

// Practical 7

//static int GetNumber()
//{
//    int number = 2;
//    return number;
//}

//int result = GetNumber();

//if (result > 10)
//{
//    Console.WriteLine(result);
//}

// -------------------------------------------------------------------------

// Practical 8

//static string GetTemp(int temp)
//{
//    if (temp > 20)
//    {
//        return "Hot";
//    }
//    else
//    {
//        return "Cold";
//    }
//}

//string result = GetTemp(30);
//Console.WriteLine(result);

// -------------------------------------------------------------------------

// Practical 9

//static bool IsSuccess(string employeeName)
//{
//    string[] employees = { "Person A", "Person B", "Person C", "Person D" };

//    foreach (string employee in employees)
//    {
//        if (employee == employeeName) return true;
//    }
//    return false;
//}

//Console.WriteLine("Add emplyee name: ");

//string name = Console.ReadLine();

//bool result = IsSuccess(name);

//if (result)
//{
//    Console.WriteLine(name + " is successfull");
//}
//else
//{
//    Console.WriteLine(name + " isn't succesfull");
//}

// -------------------------------------------------------------------------

// Practical 10

//static int GetSomeOddNumbers(int a, int b)
//{
//    int sum = 0;
//    for (int i = a; i <= b; i++)
//    {
//        if (i%2 != 0)
//        {
//            sum += i;
//        }
//    }
//    return sum;
//}

//int result = GetSomeOddNumbers(5, 10);

//Console.WriteLine(result);

// -------------------------------------------------------------------------

// Practical 11

//static bool Login(string username, string password)
//{
//    if (username == "Omar Alasgarli" && password == "Salam1928")
//    {
//        return true;
//    }
//    return false;
//}

//Console.WriteLine("Add your username: ");
//string username = Console.ReadLine();  

//Console.WriteLine("Add your password:");
//string password = Console.ReadLine();

//if (Login(username, password))
//{
//    Console.WriteLine("Login succesfull");
//}
//else
//{
//    Console.WriteLine("Username or password is wrong");
//}

// -------------------------------------------------------------------------

// Practical 12

//static void Test()
//{
//    bool isTrue = true;
//    if (isTrue)
//    {
//        Console.WriteLine("Person A");
//        return;
//    }
//    Console.WriteLine("false");
//}
//Test();

// -------------------------------------------------------------------------

// Practical 13

//static void FindOddNumbs(int[] numbs)
//{
//    foreach (var item  in numbs)
//    {
//        if(item%2 == 1)
//        {
//            break;
//        }
//    }

//    Console.WriteLine("Hello P418");
//}

//FindOddNumbs(new int[] { 1, 2, 3, 4, 5, 6, });