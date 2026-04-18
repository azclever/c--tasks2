// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] numbers = {10, 15, 22, 7, 8, 13, 30};
int sum = 0;
float avg =0;
int odd =0;
int even =0;
int max = 0;
for (int i = 0; i < numbers.Length; i++) { 

    sum += numbers[i];
    if (numbers[i] % 2 == 0)
    {
        even++;
    }
    else { 
        odd++;
    }


}

avg = (sum / numbers.Length);
int[] greater = new int[numbers.Length];
int index = 0;


for (int i = 0; i < numbers.Length; i++)
{

    if (numbers[i] > avg)
    {
        greater[index++] = numbers[i];
    }

    if (numbers[i] > max)
    {
        max = numbers[i];
    }

}
Array.Resize(ref greater, index);


Console.WriteLine("the number of event numbers: "+ even);
Console.WriteLine("the number of odd numbers: " + odd);
Console.WriteLine("the total some is: " + sum);
Console.WriteLine("the avg is: " + avg);
Console.WriteLine("the new array is: ");


foreach (int num in greater)
{
    Console.WriteLine(num);
}


Console.WriteLine("the max is: " + max);


Console.WriteLine("the even numbers are: ");

for (int i = 1; i <= 10; i++) {
    if (i % 2 == 0) { 
        Console.WriteLine(i);
    }

}

string name;
int age =0;
double height =0;
bool isEmployed = false;

Console.WriteLine("enter name");
 name = Console.ReadLine();

Console.WriteLine("enter age");
try
{
    age = Convert.ToInt32(Console.ReadLine());
}
catch (Exception ex) {
    Console.WriteLine(ex);
}

Console.WriteLine("enter height");
try
{
    height = Convert.ToDouble(Console.ReadLine());
}
catch (Exception ex)
{
    Console.WriteLine(ex);
}

Console.WriteLine("enter is employed");
try
{
    isEmployed = Convert.ToBoolean(Console.ReadLine());
}
catch (Exception ex)
{ 
    Console.WriteLine(ex);
}


Console.WriteLine(" your proflie ");
Console.WriteLine(" your name " + name);
Console.WriteLine(" your age ", age);
Console.WriteLine(" your height " + height);
Console.WriteLine(" is employed " + isEmployed);





Console.WriteLine(name.ToUpper());
Console.WriteLine(name.ToLower());

Console.WriteLine(" your name " + name);
Console.WriteLine(" your age ", age);

Console.WriteLine( $"name: {name}");
Console.WriteLine( $"age: {age}");

Console.WriteLine( name[0]);
