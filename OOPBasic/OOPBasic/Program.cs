// See https://aka.ms/new-console-template for more information
using System;
using System.IO;
using System.Reflection;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

//Console.WriteLine("Hello, World!");

public class Car {

    public int Year { get; set; }
    public string Type { get; set; }
    public string Model { get; set; }
    public int Price { get; set; }
    public int PalletNo { get; set; }
    public string Color { get; set; }

    public Car(int year, string type, string model, int price, int palleNo, string color) { 
   
        this.Year = year;
        this.Type = type;
        this.Model = model;
        this.Price = price;
        this.PalletNo = palleNo;
        this.Color = color;
    }

    public void start() {
        Console.WriteLine("Engine Started");
    }

    public void stop()
    {
        Console.WriteLine("Engine Stoped");
    }

    public override string ToString() => $" Type : {Type}, Model: {Model}, year : {Year}  ";

    static void Main(string[] args)
    {
        Car carone = new Car(2026, "toyota", "camry", 20000, 325243, "red");

        Console.WriteLine(carone.ToString());
        Console.WriteLine(args.Length);
        test.create();

       Console.WriteLine( MathUtilities.squareRoot(40));


        Console.WriteLine("Enter 2 numbers");
        try { 
        int one = Console.Read();
        int two = Console.Read();
            Claculator clac = new Claculator();
        Console.WriteLine(clac.add(one, two));
        
        }catch(Exception e) { Console.WriteLine(e.ToString()); }


        try {

            File.AppendAllText("data.txt", "\nNew Line");


           string[] lines = File.ReadAllLines("data.txt");
            
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }

        } catch (Exception e) { Console.WriteLine(e.ToString());}

        try
        {

            string[] lines = File.ReadAllLines("data.txt");

            int charCount = 0;
            int wordCount = 0;
            foreach (String li in lines)
            {
                foreach (char c in li)
                {

                    if (c != ' ' && c != '\n' && c != '\r')
                    {
                        charCount++;
                    }
                    else
                    {
                        wordCount++;
                    }

                }
            }

            Console.WriteLine("Number of characters: " + charCount);
            Console.WriteLine("Number of Word: " + wordCount);
        }
        catch (Exception e) { Console.WriteLine(e.ToString()); }

    }

}

public class test {

    public static void create() {
        Car car2 = new Car(2026, "honda", "civic", 30000, 322345, "black");
        Console.WriteLine(car2.ToString());

        Student person2 = new Student();
        person2.Name = "abd";
        person2.Age = 30;

        person2.greet();
        Console.WriteLine(person2);
    }

}


public class Person { 
    public string Name { get; set; }
    private int age;

    public int Age
    {
        get { return age; }
        set { age = value; }
    
    }

    public override string ToString() => $" Name : {Name}, Age: {Age}";
}

class Student : Person {

    public void greet() {
        Console.WriteLine($"Hello {Name}");
    }
}



// OOP 2 Tasks 

public static class MathUtilities {

     public static int square(int num) { 
        return num * num;
    }

    public static float squareRoot(float num) {

        if (num <= 0) return num;
        float left = 1;
        float right = num;

        //float mid = (left + right) / 2;
        //float square = mid * mid;

        while (left <= right) {

           float mid = (left + right) / 2;
            float square = mid * mid;

            if (square == num)
            {
                return mid;
            }
            else if (square < num)
            {
                left = mid + 1;
            }
            else { 
                right= mid -1;
            }
        }

        return right;
    }

    public static int maximum(int num, int num2) { 
        return num > num2 ? num : num2;
    }

    public static int add(int num, int num2)
    {
        return num + num2;
    }

    public static int add(int num, int num2, int num3)
    {
        return num + num2 + num3;
    }

}

class VisitorCounter {

static int counter = 0;

   String name;

    public VisitorCounter(String name) { 
        this.name = name;
        counter++;
    }
}


class Company
{

    static String comName = "tech";

    String name;

    public Company (String name)
    {
        this.name = name;
    }

    public override string ToString() => $" Name : {name}, At: {comName}";
}

// ###################    OOP Principles #######################

class animal {
    public virtual void speak() {
        Console.WriteLine("hello");
    }
    
}
class cat : animal {

    public override void speak()
    {
        Console.WriteLine("meu meu ");
    }

}
class dog : animal
{

    public override void speak()
    {
        Console.WriteLine("hou hou ");
    }

}


abstract class Shape()
{
    abstract public double GetArea(float height , float width);


}

class Rectangle:Shape {

   
     override public double GetArea( float height, float width) { 
        return 0.5 * width * height;
    }

}

class Calculator { 
    public int add(int num, int num2) { return num + num2; }
    public int add(int num, int num2, int num3) { return num + num2 + num3; }

    public float add(float num, float num2, float num3) { return num + num2 + num3; }


}


abstract class Appliance {

    abstract public void turnOn();
    abstract public void turnOff();

    public string Brand;
}

class WashingMachine : Appliance {


    public override void turnOn() { 
        Console.WriteLine("Washing on");
    }

    public override void turnOff() { 
        Console.WriteLine("Washing off");
    }
}

class AirConditioner : Appliance
{


    public override void turnOn()
    {
        Console.WriteLine("AC on");
    }

    public override void turnOff()
    {
        Console.WriteLine("AC off");
    }
}



class BankAccount {
    private int Balance;

    public int deposit() {
        return Balance;
    }

    public void withdraw(int val) {
        if (val > Balance) {
            return;
        }

        Balance -= val;
    }

}

abstract class Employee {
    public String name;

    abstract public float CalculateSalary(); 
    
}

class FullTimeEmployee : Employee {

    float salary;
    public override float CalculateSalary()
    {
        return salary;
    }
}
class PartTimeEmployee : Employee
{

    float price;
    float hours;
    public override float CalculateSalary()
    {
        return price * hours ;
    }
}




// ###################    OOP interface #######################

interface Icalculator {

    public int add(int a, int b);
}

class Claculator: Icalculator {

    public int add(int a, int b) { 
        return a + b;
    }

}





