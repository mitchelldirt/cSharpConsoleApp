// /*
// This code uses a names array and corresponding methods to display
// greeting messages
// */
//
// string[] names = new string[] { "Sophia", "Andrew", "AllGreetings" };
//
// string messageText = "";
//
// foreach (string name in names)
// {
//     if (name == "Sophia")
//         messageText = SophiaMessage();
//     else if (name == "Andrew")
//         messageText = AndrewMessage();
//     else if (name == "AllGreetings")
//     {
//         messageText = SophiaMessage();
//         messageText = messageText + "\n\r" + AndrewMessage();
//     }
//     
//     Console.WriteLine(messageText + "\n\r");
// }
//
// bool pauseCode = true;
// while (pauseCode == true);
//
// static string SophiaMessage()
// {
//     return "Hello, my name is Sophia.";
// }
//
// static string AndrewMessage()
// {
//     return "Hi, my name is Andrew. Good to meet you.";
// }
//
// int productCount = 2000;
// string[,] products = new string[productCount, 2];
//
// LoadProducts(products, productCount);
//
// for (int i = 0; i < productCount; i++)
// {
//     string result;
//     result = Process1(products, i);
//
//     if (result != "obsolete")
//     {
//         result = Process2(products, i);
//     }
// }
//
// bool pauseCode = true;
// while (pauseCode == true) ;
//
// static void LoadProducts(string[,] products, int productCount)
// {
//     Random rand = new Random();
//
//     for (int i = 0; i < productCount; i++)
//     {
//         int num1 = rand.Next(1, 10000) + 10000;
//         int num2 = rand.Next(1, 101);
//
//         string prodID = num1.ToString();
//
//         if (num2 < 91)
//         {
//             products[i, 1] = "existing";
//         }
//         else if (num2 == 91)
//         {
//             products[i, 1] = "new";
//             prodID = prodID + "-n";
//         }
//         else
//         {
//             products[i, 1] = "obsolete";
//             prodID = prodID + "-0";
//         }
//
//         products[i, 0] = prodID;
//     }
// }
//
// static string Process1(string[,] products, int item)
// {
//     Console.WriteLine($"Process1 message - working on {products[item, 1]} product");
//
//     return products[item, 1];
// }
//
// static string Process2(string[,] products, int item)
// {
//     Console.WriteLine($"Process2 message - working on product ID #: {products[item, 0]}");
//     if (products[item, 1] == "new")
//         Process3(products, item);
//
//     return "continue";
// }
//
// static void Process3(string[,] products, int item)
// {
//     Console.WriteLine($"Process3 message - processing product information for 'new' product");
// }

// string? readResult;
// int startIndex = 0;
// bool goodEntry = false;
//
// int[] numbers = { 1, 2, 3, 4, 5 };
//
// // Display the array to the console.
// Console.Clear();
// Console.Write("\n\rThe 'numbers' array contains: { ");
// foreach (int number in numbers)
// {
//     Console.Write($"{number} ");
// }
//
// // To calculate a sum of array elements, 
// //  prompt the user for the starting element number.
// Console.WriteLine($"}}\n\r\n\rTo sum values 'n' through 5, enter a value for 'n':");
// while (goodEntry == false)
// {
//     readResult = Console.ReadLine();
//     goodEntry = int.TryParse(readResult, out startIndex);
//
//     if (startIndex > 5)
//     {
//         goodEntry = false;
//         Console.WriteLine("\n\rEnter an integer value between 1 and 5");
//     }
// }
//
// // Display the sum and then pause.
// Console.WriteLine($"\n\rThe sum of numbers {startIndex} through {numbers.Length} is: {SumValues(numbers, startIndex)}");
//
// Console.WriteLine("press Enter to exit");
// readResult = Console.ReadLine();
//
// // This method returns the sum of elements n through 5
// static int SumValues(int[] numbers, int n)
// {
//     int sum = 0;
//     for (int i = n - 1; i < numbers.Length; i++)
//     {
//         sum += numbers[i];
//     }
//     return sum;
// }

// bool exit = false;
// var rand = new Random();
// int num1 = 5;
// int num2 = 5;
//
// do
// {
//     num1 = rand.Next(1, 11);
//     num2 = num1 + rand.Next(1, 51);
//
// } while (exit == false);

/*
This code instantiates a value and then calls the ChangeValue method
to update the value. The code then prints the updated value to the console.
*/
// int x = 5;
//
// x = ChangeValue();
//
// Console.WriteLine(x);
//
// int ChangeValue() 
// {
//     return 10;
// }

// double float1 = 3000.0;
// double float2 = 0.0;
// int number1 = 3000;
// int number2 = 0;
//
// try
// {
//     Console.WriteLine(float1 / float2);
//     Console.WriteLine(number1 / number2);
// }
// catch (Exception e)
// {
//     Console.WriteLine("An exception has been caught!");
// }
//
// Console.WriteLine("Exit program");
//
// try
// {
//     Process1();
// }
// catch
// {
//     Console.WriteLine("An exception has occurred");
// }
//
// Console.WriteLine("Exit program");
//
// static void Process1()
// {
//     try
//     {
//         WriteMessage();
//     }
//     catch (DivideByZeroException e)
//     {
//         Console.WriteLine($"An exception was caught in process1: {e.Message}");
//     }
// }
//
// static void WriteMessage()
// {
//     double float1 = 3000.0;
//     double float2 = 0.0;
//     int number1 = 3000;
//     int number2 = 0;
//     byte smallNumber;
//
//     try
//     {
//         Console.WriteLine(float1 / float2);
//         Console.WriteLine(number1 / number2);
//     }
//     catch (DivideByZeroException ex)
//     {
//         Console.WriteLine($"Exception caught in WriteMessage: {ex.Message}");
//     }
//     checked
//     {
//         smallNumber = (byte)number1;
//     }
// }
// inputValues is used to store numeric values entered by a user

checked
{
    try
    {
        int num1 = int.MaxValue;
        int num2 = int.MaxValue;
        int result = num1 + num2;
        Console.WriteLine("Result: " + result);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine("Error: The number is too large to be represented as an integer." + ex.Message);
    }
}

try
{
    string str = null;
    int length = str.Length;
    Console.WriteLine("String Length: " + length);
}
catch (NullReferenceException ex)
{
    Console.WriteLine("Error: The reference is null." + ex.Message);
}

try
{
    int[] numbers = new int[5];
    numbers[5] = 10;
    Console.WriteLine("Number at index 5: " + numbers[5]);
}
catch (IndexOutOfRangeException ex)
{
    Console.WriteLine("Error: Index out of range." + ex.Message);
}

try
{
    int num3 = 10;
    int num4 = 0;
    int result2 = num3 / num4;
    Console.WriteLine("Result: " + result2);
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: Cannot divide by zero." + ex.Message);
}


Console.WriteLine("Exiting program.");