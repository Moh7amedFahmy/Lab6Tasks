using System;
using System.Collections.Generic;


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Question1
//public delegate double MathOperation(double x, double y);


//public static class Calculator
//{
//    public static double Add(double x, double y) => x + y;
//    public static double Subtract(double x, double y) => x - y;
//    public static double Multiply(double x, double y) => x * y;
//    public static double Divide(double x, double y) => x / y;
//}

//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///Question 2 - multicast delegates
//public delegate void NotifyHandler(string message);

//public static class Notifier
//{
//    public static void Email(string message) => Console.WriteLine($"Email: {message}");
//    public static void SMS(string message) => Console.WriteLine($"SMS: {message}");
//    public static void PushNotification(string message) => Console.WriteLine($"LogToFile: {message}");
//}




//////////////////////////////////////////////////////////////////////////////////////////////////////////////////
///Question 3 & 4  -Array Filter Delegates 
//public delegate bool IntFilter(int value);
//public static class ArrayFilter
//{
//    public static int[] Filter(int[] array, IntFilter filter)
//    {
//        List<int> result = new List<int>();
//        foreach (int value in array)
//        {
//            if (filter(value))
//            {
//                result.Add(value);
//            }
//        }
//        return result.ToArray();
//    }
//    public static bool IsEven(int value) => value % 2 == 0;

//    public static bool IsOdd(int value) => value % 2 != 0;

//        public static bool IsGreaterThan(int value) => value > 5;


//}


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
/// Question 5 -  Lambda Expressions 
//public delegate bool NumberFilter(int n);



////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Question  6 - Lambda Sort 
//public class Person
//{
//    public string Name { get; set; }
//    public int Age { get; set; }
//    public string Department { get; set; }
//}


////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//Question  7- Temperature Monitor Events 

//public delegate void TemperatureHandler(string message , double temperature);


////Sensor that makes alert 
//public class TemperatureSensor 
//{

//    public event TemperatureHandler TemperatureChanged; // Object from delegate used as event for adding methods in this delegate (event)

//    public void SetTemperature(double temp)
//    {

//        if(temp>30)
//        {
//            TemperatureChanged?.Invoke("Temp is too high!", temp);

//        }


//    }


//}
////Mointor (Person who listen to event )
//public class TemperatureMonitor 
//{
//    public void OnTempartureHigh(string msg , double temperature)

//    {
//        Console.WriteLine($"ALERT: {msg} Current Temp: {temperature}");
//    }



//}


//////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
// Question 8 
public delegate void ClickHandler(object sender, string buttonName);

//Publisher for event 
public class Button
{
    private string name;
    public Button(string name) => this.name = name;

    public event ClickHandler Click;

    public void PerformClick()
    {
        Click?.Invoke(this, name);
    }
}


//Listner waiting for event happen to run a script 
public class Logger
{
    public void LogClick(object sender, string btnName)
    {
        Console.WriteLine($"Clicked: {btnName}");
    }
}

public class FormHandler
{
    public void OnClick(object sender, string btnName)
    {
        Console.WriteLine($"FormHandler: {btnName} clicked");
    }
}
class Program
    {

    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //Question 1 - Test 


    //    static void Main(string[] args)
    //    {
    //        MathOperation add = Calculator.Add;
    //    Console.WriteLine(add(5, 3)); // Output: 8
    //    MathOperation subtract = Calculator.Subtract;
    //    Console.WriteLine(subtract(5, 3)); // Output: 2
    //    MathOperation multiply = Calculator.Multiply;
    //    Console.WriteLine(multiply(5, 3)); // Output: 15
    //    MathOperation divide = Calculator.Divide;
    //    Console.WriteLine(divide(5, 3)); // Output: 1.66666666666667

    //}

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // Question 2 -Test 
    //

    //    static void Main(string[] args)
    //{
    //    NotifyHandler notify = Notifier.Email;
    //    notify += Notifier.SMS;
    //    notify += Notifier.PushNotification;

    //    notify("Order confirmed!");


    //    notify-= Notifier.SMS;
    //    Console.WriteLine("\nAfter removing SMS notification email and log only will be called:\n");
    //    notify("Order shipped!");
    //}
    /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///Question 3 - Test 
    ///


    //static void Main(string[] args)
    //{
    //    int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    //    var evenNumbers = ArrayFilter.Filter(numbers, ArrayFilter.IsEven);
    //    Console.WriteLine(string.Join(",", evenNumbers)); // 2,4,6,8,10


    //    var oddNumbers = ArrayFilter.Filter(numbers, ArrayFilter.IsOdd);
    //    Console.WriteLine(string.Join(",", oddNumbers)); // 1,3,5,7,9



    //}

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //Question 4 - Anonymous Methods - Test

    //static void Main(string[] args)
    //{
    //   int [] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

    //    int[] evens = ArrayFilter.Filter(array,delegate(int value) { return value % 2 == 0; });

    //    Console.WriteLine(string.Join(",", evens));


    //}


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    /// Question 5 - Lambda Expressions - Test

    //static void Main(string[] args)
    //{
    //NumberFilter isEven = n => n % 2 == 0; // Lambda expression to check if a number is even 
    //    Console.WriteLine(isEven(4)); // Output: True
    //    List<int>numbers = new List<int> { 1, 2, 3, 4, 5, 6 , 7 ,8, 9, 10 };
    //    var evenNumbers = numbers.FindAll(n => n % 2 == 0); // Using lambda expression with List.FindAll to filter even numbers
    //    int first = numbers.Find(n => n > 5);                 // 6 (first number greater than 5)
    //    List<int> evens = numbers.FindAll(n => n % 2 == 0);   // 2,4,6,8,10 (all even numbers)
    //    bool hasNeg = numbers.Exists(n => n < 0);             // false (there are no negative numbers in the list)

    //    Console.WriteLine(first);
    //    Console.WriteLine(string.Join(",", evens));
    //    Console.WriteLine(hasNeg);
    //}




    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///Question 6 - Lambda Sort - Test 
    //static void Main()
    //{
    //    var people = new List<Person>
    //    {
    //        new Person { Name="Ahmed", Age=30, Department="IT" },
    //        new Person { Name="Sara", Age=25, Department="HR" },
    //        new Person { Name="Omar", Age=35, Department="IT" },
    //        new Person { Name="Aya", Age=25, Department="IT" },
    //    };
    //    //Applying different sorting criteria using lambda expressions on the List 
    //    // Age ascending
    //    people.Sort((a, b) => a.Age.CompareTo(b.Age));

    //    // Age descending
    //    people.Sort((a, b) => b.Age.CompareTo(a.Age));

    //    // Name
    //    people.Sort((a, b) => a.Name.CompareTo(b.Name));

    //    // Department then Name
    //    people.Sort((a, b) =>
    //    {
    //        int r = a.Department.CompareTo(b.Department);
    //        if (r != 0) return r; // If departments are same and when they are same they will return 0 , and then sort by name 
    //        return a.Name.CompareTo(b.Name);
    //    });

    //    foreach (var p in people)
    //        Console.WriteLine($"{p.Department} - {p.Name} - {p.Age}");
    //}


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //Question  7- Temperature Monitor Events 


    //static void Main()
    //{
    //    //Object from sensor 
    //    TemperatureSensor sensor = new TemperatureSensor();
    //    //object from monitor 
    //    TemperatureMonitor monitor = new TemperatureMonitor();

    //    sensor.TemperatureChanged += monitor.OnTempartureHigh; //when temp increase the event will work 

    //    Console.WriteLine("No thing happen when temp is 25 ");
    //    sensor.SetTemperature(25);

    //    sensor.SetTemperature(35);

    //}


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    //Question  8- Button Events 

    static void Main()
    {
        var button = new Button("Save");
        var handler = new FormHandler();
        var logger = new Logger();

        button.Click += handler.OnClick; 
        button.Click += logger.LogClick; 
        button.Click += (sender, name) => Console.WriteLine($"Lambda: {name}");

        button.PerformClick(); //Run the delegate event 
    }


}
