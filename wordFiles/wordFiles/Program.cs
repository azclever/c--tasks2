// See https://aka.ms/new-console-template for more information
using System.Reflection.Metadata;

Console.WriteLine("Hello, World!");

int ConvertToSeconds(int minutes)
{
    return minutes * 60;
}

Console.WriteLine(ConvertToSeconds(5));

Console.WriteLine("############## task 2 ################");


int Increment(int number)
{
    return number + 1;
}

Console.WriteLine(Increment(5));


Console.WriteLine("############## task 3 ################");

int GetFirstElement(int[] numbers)
{
    return numbers[0];
}

int[] arr = { 10, 20, 30 };
Console.WriteLine(GetFirstElement(arr));

Console.WriteLine("############## task 4 ################");
double GetTriangleArea(double baseValue, double height)
{
    return 0.5 * baseValue * height;
}

Console.WriteLine(GetTriangleArea(10, 5));

// ############## task 5 ################
int[] EvenNumberEvenIndex(int[] nums)
{
    List<int> result = new List<int>();

    for (int i = 0; i < nums.Length; i += 2)
    {
        if (nums[i] % 2 == 0)
        {
            result.Add(nums[i]);
        }
    }

    return result.ToArray();
}

// ############## task 6 ################
string[] EvenIndexOddLength(string[] strings)
{
    List<string> result = new List<string>();

    for (int i = 0; i < strings.Length; i += 2)
    {
        if (strings[i].Length % 2 != 0)
        {
            result.Add(strings[i]);
        }
    }

    return result.ToArray();
}

// ############## task 7 ################
double[] PowerElementIndex(int[] nums)
{
    double[] result = new double[nums.Length];

    for (int i = 0; i < nums.Length; i++)
    {
        result[i] = Math.Pow(nums[i], i);
    }

    return result;
}

// ############## task 8 ################
int Multiplication2(int a, int b)
{
    int result = 0;

    for (int i = 0; i < b; i++)
    {
        result += a;
    }

    return result;
}

// ############## task 9 ################
int Muti2(int start, int end)
{
    int result = 1;

    for (int i = start; i <= end; i++)
    {
        result *= i;
    }

    return result;
}

// ############## task 10 ################
double AveArray(int[] nums)
{
    int sum = 0;

    for (int i = 0; i < nums.Length; i++)
    {
        sum += nums[i];
    }

    return (double)sum / nums.Length;
}


// flie 2 


// ############## task 1 ################
int GetDays(DateTime date1, DateTime date2)
{
    return Math.Abs((date2 - date1).Days);
}

// ############## task 2 ################
string[] NumInStr(string[] arr)
{
    List<string> result = new List<string>();

    foreach (string s in arr)
    {
        foreach (char c in s)
        {
            if (char.IsDigit(c))
            {
                result.Add(s);
                break;
            }
        }
    }

    return result.ToArray();
}

// ############## task 3 ################
string ReverseOdd(string text)
{
    string[] words = text.Split(' ');

    for (int i = 0; i < words.Length; i++)
    {
        if (words[i].Length % 2 != 0)
        {
            char[] chars = words[i].ToCharArray();
            Array.Reverse(chars);
            words[i] = new string(chars);
        }
    }

    return string.Join(" ", words);
}

// ############## task 4 ################
bool IsPandigital(long number)
{
    string num = number.ToString();

    for (char digit = '0'; digit <= '9'; digit++)
    {
        if (!num.Contains(digit))
        {
            return false;
        }
    }

    return true;
}


// flie 3 


// 1
Func<int, int> Add(int n)
{
    return x => x + n;
}

// 2
string RemoveLeadingTrailing(string n)
{
    return double.Parse(n).ToString();
}

// 3
int SecondLargest(int[] arr)
{
    Array.Sort(arr);
    return arr[arr.Length - 2];
}

// 4
bool IsRepdigit(int num)
{
    if (num < 0) return false;

    string s = num.ToString();
    char first = s[0];

    foreach (char c in s)
        if (c != first) return false;

    return true;
}

// 5
string ReverseWords(string text)
{
    string[] words = text.Trim().Split(' ');
    Array.Reverse(words);
    return string.Join(" ", words);
}

// 6
string SevenBoom(int[] arr)
{
    foreach (int num in arr)
        if (num.ToString().Contains("7"))
            return "Boom!";

    return "there is no 7 in the array";
}

// 7
string InsertWhitespace(string s)
{
    return System.Text.RegularExpressions.Regex.Replace(s, "([a-z])([A-Z])", "$1 $2");
}

// 8
int CountTrue(bool[] arr)
{
    int count = 0;

    foreach (bool b in arr)
        if (b) count++;

    return count;
}

// 9
string CapToFront(string s)
{
    string caps = "";
    string lower = "";

    foreach (char c in s)
    {
        if (char.IsUpper(c)) caps += c;
        else lower += c;
    }

    return caps + lower;
}

// 10
bool MatchLastItem(string[] arr)
{
    string last = arr[arr.Length - 1];
    string combined = "";

    for (int i = 0; i < arr.Length - 1; i++)
        combined += arr[i];

    return combined == last;
}

// 11
int FindNaN(double[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        if (double.IsNaN(arr[i]))
            return i;

    return -1;
}

// 12
object[] RemoveDups(object[] arr)
{
    List<object> result = new List<object>();

    foreach (var item in arr)
        if (!result.Contains(item))
            result.Add(item);

    return result.ToArray();
}

// 13
string ConvertTime(string time)
{
    DateTime dt = DateTime.Parse(time);
    return dt.ToString("HH:mm:ss");
}

// 14
string RemoveLastVowel(string sentence)
{
    string[] words = sentence.Split(' ');

    for (int i = 0; i < words.Length; i++)
    {
        for (int j = words[i].Length - 1; j >= 0; j--)
        {
            if ("aeiouAEIOU".Contains(words[i][j]))
            {
                words[i] = words[i].Remove(j, 1);
                break;
            }
        }
    }

    return string.Join(" ", words);
}

// 15
int SumOfCubes(int[] arr)
{
    int sum = 0;

    foreach (int n in arr)
        sum += n * n * n;

    return sum;
}



// file 4 




{
    
    {
        // ============================
        // 1. Display the smaller of two integers
        // ============================
        int a = 10, b = 25;
        Console.WriteLine("1. Smaller number is: " + Math.Min(a, b));


        // ============================
        // 2. Find the sign of a number
        // ============================
        int num = -7;
        if (num > 0)
            Console.WriteLine("2. The sign is +");
        else if (num < 0)
            Console.WriteLine("2. The sign is -");
        else
            Console.WriteLine("2. The number is zero");


        // ============================
        // 3. Sort three numbers ascending
        // ============================
        int x = 0, y = -1, z = 4;

        int[] arr1 = { x, y, z };
        Array.Sort(arr1);

        Console.WriteLine("3. Ascending order: " + string.Join(", ", arr));
        // Note: Output will be -1, 0, 4


        // ============================
        // 4. Find max of five numbers
        // ============================
        int[] nums = { -5, -2, -6, 0, -1 };

        int max = nums[0];
        foreach (int n in nums)
        {
            if (n > max)
                max = n;
        }

        Console.WriteLine("4. Maximum number is: " + max);


        // ============================
        // 5. Convert KM/H to MPH
        // ============================
        double kmh = 15;
        double mph = kmh * 0.621371;

        Console.WriteLine("5. " + mph + " miles per hour");


        // ============================
        // 6. Convert hours and minutes to total minutes
        // ============================
        int hours = 5;
        int minutes = 37;

        int totalMinutes = (hours * 60) + minutes;

        Console.WriteLine("6. Total minutes: " + totalMinutes);


        // ============================
        // 7. Convert minutes to hours and minutes
        // ============================
        int inputMinutes = 546;

        int h = inputMinutes / 60;
        int m = inputMinutes % 60;

        Console.WriteLine("7. " + h + " Hours, " + m + " Minutes");


        // ============================
        // 8. Array of 5 sentences with fixed length
        // ============================
        string[] sentences =
        {
            "Hello world",
            "C# programming is fun",
            "Short",
            "This is a longer sentence",
            "AI"
        };

        Console.WriteLine("8. Fixed length output:");
        foreach (string s in sentences)
        {
            Console.WriteLine(s.PadRight(30, '.'));
        }


        // ============================
        // 9. Reverse words with odd length only
        // ============================
        Console.WriteLine("9. Reverse odd-length words:");

        string input1 = "Bananas";
        string input2 = "One two three four";

        Console.WriteLine(ReverseOddWords(input1));
        Console.WriteLine(ReverseOddWords(input2));
    }


    static string ReverseOddWords(string text)
    {
        string[] words = text.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length % 2 != 0)
            {
                char[] chars = words[i].ToCharArray();
                Array.Reverse(chars);
                words[i] = new string(chars);
            }
        }

        return string.Join(" ", words);
    }
}


// flie 6 



{
    static void Main()
    {
        // =====================================================
        // 1. Corrected syntax errors (fixed arrays)
        // =====================================================
        string[] ARR = { "1", "7", "9", "45" };
        string[] arr2 = { "Str", "alex", "moh" };
        string[] arr3 = { "the", "fox", "over", "lazy", "dog" };

        Console.WriteLine("1. Corrected arrays created successfully.\n");


        // =====================================================
        // 2. Index of "Banana" and "Tomato"
        // =====================================================
        string[] fruits = { "Tomato", "Banana", "Watermelon" };

        Console.WriteLine("2. Index of Tomato: " + Array.IndexOf(fruits, "Tomato"));
        Console.WriteLine("2. Index of Banana: " + Array.IndexOf(fruits, "Banana"));
        Console.WriteLine();


        // =====================================================
        // 3. Favorite Food, Sport, Movie arrays
        // =====================================================
        string[] food = { "Pizza", "Burger", "Pasta", "Rice", "Chicken" };
        string[] sport = { "Football", "Basketball", "Tennis" };
        string[] movie = { "Inception", "Titanic", "Avatar", "Interstellar" };

        Console.WriteLine("3. Favorite Food:");
        foreach (string f in food)
            Console.WriteLine(f);

        Console.WriteLine("\n3. Favorite Sport:");
        foreach (string s in sport)
            Console.WriteLine(s);

        Console.WriteLine("\n3. Favorite Movie:");
        foreach (string m in movie)
            Console.WriteLine(m);

        Console.WriteLine();


        // =====================================================
        // 4. Sum of three numbers (comma-separated input)
        // =====================================================
        Console.Write("4. Input three numbers separated by comma: ");
        string input = Console.ReadLine();

        string[] numbers = input.Split(',');
        int sum = 0;

        foreach (string numm in numbers)
            sum += int.Parse(numm);

        Console.WriteLine("4. The sum of three numbers: " + sum);
        Console.WriteLine();


        // =====================================================
        // 5. Odd numbers (1 to 100) and their sum
        // =====================================================
        int oddSum = 0;

        Console.WriteLine("5. Odd numbers from 1 to 100:");

        for (int i = 1; i <= 100; i += 2)
        {
            Console.Write(i + " ");
            oddSum += i;
        }

        Console.WriteLine("\n5. The Sum of odd Numbers is: " + oddSum);
        Console.WriteLine();


        // =====================================================
        // 6. Right angle triangle using asterisks
        // =====================================================
        Console.WriteLine("6. Asterisk Triangle:");

        int rows = 3;

        for (int i = 1; i <= rows; i++)
        {
            for (int j = i; j < rows; j++)
                Console.Write(" ");

            for (int k = 1; k <= i; k++)
                Console.Write("*");

            Console.WriteLine();
        }

        Console.WriteLine();


        // =====================================================
        // 7. Number triangle pattern
        // =====================================================
        Console.WriteLine("7. Number Triangle:");

        int num = 1;

        for (int i = 1; i <= 4; i++)
        {
            for (int j = i; j < 4; j++)
                Console.Write(" ");

            for (int k = 1; k <= i; k++)
            {
                Console.Write(num + " ");
                num++;
            }

            Console.WriteLine();
        }
    }
}

// file 7 




{
    static void Main()
    {
        // =====================================================
        // 1. Sum and Average of 10 numbers
        // =====================================================
        SumAndAverage();


        // =====================================================
        // 2. Cube of numbers up to N
        // =====================================================
        CubeNumbers(5);


        // =====================================================
        // 3. Years greater than 1950
        // =====================================================
        int[] years = { 1763, 1972, 1925, 1916, 1984, 1124, 1950, 2020 };
        GetYears(years);


        // =====================================================
        // 4. Age in days
        // =====================================================
        Console.WriteLine("4. Age in days: " + AgeInDays(20));


        // =====================================================
        // 5. Animal legs counter
        // =====================================================
        Console.WriteLine("5. Total legs: " + Animals(2, 3, 5));


        // =====================================================
        // 6. Login function
        // =====================================================
        Console.WriteLine("6. Login result: " + Login("admin", "1234"));


        // =====================================================
        // 7. Power function
        // =====================================================
        Console.WriteLine("7. Power result: " + Power(2, 3));


        // =====================================================
        // 8. Leap year check
        // =====================================================
        Console.WriteLine("8. Leap year: " + IsLeapYear(2024));


        // =====================================================
        // 9. Prime number check
        // =====================================================
        Console.WriteLine("9. Is Prime: " + IsPrime(29));


        // =====================================================
        // 10. Word count in sentence
        // =====================================================
        Console.WriteLine("10. Word count: " + CountWords("Hello my name is John"));
    }


    // =====================================================
    // 1. Sum and Average of 10 numbers (METHOD)
    // =====================================================
    static void SumAndAverage()
    {
        int sum = 0;

        Console.WriteLine("1. Enter 10 numbers:");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Number-" + i + ": ");
            int num = int.Parse(Console.ReadLine());
            sum += num;
        }

        double avg = sum / 10.0;

        Console.WriteLine("The sum of 10 no is: " + sum);
        Console.WriteLine("The Average is: " + avg);
        Console.WriteLine();
    }


    // =====================================================
    // 2. Cube of numbers
    // =====================================================
    static void CubeNumbers(int n)
    {
        Console.WriteLine("2. Cube of numbers:");

        for (int i = 1; i <= n; i++)
        {
            Console.WriteLine($"Number is : {i} and cube of the {i} is : {i * i * i}");
        }

        Console.WriteLine();
    }


    // =====================================================
    // 3. Return years > 1950
    // =====================================================
    static void GetYears(int[] years)
    {
        Console.WriteLine("3. Years greater than 1950:");

        foreach (int y in years)
        {
            if (y > 1950)
                Console.WriteLine(y);
        }

        Console.WriteLine();
    }


    // =====================================================
    // 4. Age to days
    // =====================================================
    static int AgeInDays(int age)
    {
        return age * 365;
    }


    // =====================================================
    // 5. Animals legs (validation: no negative numbers)
    // =====================================================
    static int Animals(int chickens, int cows, int pigs)
    {
        if (chickens < 0 || cows < 0 || pigs < 0)
            return -1;

        return (chickens * 2) + (cows * 4) + (pigs * 4);
    }


    // =====================================================
    // 6. Login function (predefined users)
    // =====================================================
    static string Login(string username, string password)
    {
        string[,] users = {
            { "admin", "1234" },
            { "user", "1111" },
            { "test", "2222" }
        };

        for (int i = 0; i < users.GetLength(0); i++)
        {
            if (users[i, 0] == username && users[i, 1] == password)
                return "pass";
        }

        return "failed";
    }


    // =====================================================
    // 7. Power function
    // =====================================================
    static int Power(int baseNum, int exp)
    {
        int result = 1;

        for (int i = 0; i < exp; i++)
        {
            result *= baseNum;
        }

        return result;
    }


    // =====================================================
    // 8. Leap year
    // =====================================================
    static bool IsLeapYear(int year)
    {
        if (year < 1900 || year > 2024)
            return false;

        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }


    // =====================================================
    // 9. Prime number check
    // =====================================================
    static bool IsPrime(int num)
    {
        if (num <= 1) return false;

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }

        return true;
    }


    // =====================================================
    // 10. Word counter (no Count method)
    // =====================================================
    static int CountWords(string sentence)
    {
        if (string.IsNullOrWhiteSpace(sentence))
            return 0;

        int count = 1;

        for (int i = 0; i < sentence.Length; i++)
        {
            if (sentence[i] == ' ')
                count++;
        }

        return count;
    }
}



// file 8


{
    static void Main()
    {
        // =====================================================
        // 1. Simple class display message
        // =====================================================
        MyClass obj1 = new MyClass();


        // =====================================================
        // 2. Greeting with argument
        // =====================================================
        IntroClass obj2 = new IntroClass();
        obj2.Greet("Scott");


        // =====================================================
        // 3. Factorial class
        // =====================================================
        FactorialClass fact = new FactorialClass();
        Console.WriteLine("3. Factorial of 5 = " + fact.CalculateFactorial(5));


        // =====================================================
        // 4. Sorting array using class
        // =====================================================
        SortClass sorter = new SortClass();
        sorter.SortArray();


        // =====================================================
        // 5. Date difference class
        // =====================================================
        DateDifference diff = new DateDifference();
        diff.CalculateDifference();


        // =====================================================
        // 6. String to Date conversion class
        // =====================================================
        DateConverter converter = new DateConverter();
        converter.ConvertDate("12-08-2004");
    }
}


// =====================================================
// 1. Simple class message
// =====================================================
class MyClass
{
    public MyClass()
    {
        Console.WriteLine("1. MyClass class has initialized!");
    }
}


// =====================================================
// 2. Intro message with parameter
// =====================================================
class IntroClass
{
    public void Greet(string name)
    {
        Console.WriteLine($"2. Hello All, I am {name}");
    }
}


// =====================================================
// 3. Factorial class
// =====================================================
class FactorialClass
{
    public int CalculateFactorial(int n)
    {
        int result = 1;

        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }

        return result;
    }
}


// =====================================================
// 4. Sorting array class
// =====================================================
class SortClass
{
    public void SortArray()
    {
        int[] array = { 11, -2, 4, 35, 0, 8, -9 };

        Array.Sort(array);

        Console.WriteLine("4. Sorted array: { " + string.Join(", ", array) + " }");
    }
}


// =====================================================
// 5. Date difference class (years, months, days approx)
// =====================================================
class DateDifference
{
    public void CalculateDifference()
    {
        DateTime date1 = new DateTime(1981, 11, 03);
        DateTime date2 = new DateTime(2013, 09, 04);

        int years = date2.Year - date1.Year;
        int months = date2.Month - date1.Month;
        int days = date2.Day - date1.Day;

        if (days < 0)
        {
            months--;
            days += 30;
        }

        if (months < 0)
        {
            years--;
            months += 12;
        }

        Console.WriteLine($"5. Difference: {years} years, {months} months, {days} days");
    }
}


// =====================================================
// 6. String to DateTime converter class
// =====================================================
class DateConverter
{
    public void ConvertDate(string dateString)
    {
        DateTime date = DateTime.ParseExact(dateString, "dd-MM-yyyy", null);

        Console.WriteLine("6. Converted Date: " + date.ToString("yyyy-MM-dd"));
    }
}