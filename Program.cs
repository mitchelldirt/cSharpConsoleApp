﻿// Cannot implicitly convert string to int, but can go the other way
// int first = 5;
// string second = "7";
// string result = second + first;
// Console.WriteLine(result);

// int myInt = 3;
// Console.WriteLine($"int: {myInt}");

// this is a 'widening conversion' because decimal can hold more information than int can
// decimal myDecimal = myInt;
// Console.WriteLine($"decimal: {myDecimal}");

// decimal myDecimal = 3.14m;
// Console.WriteLine($"decimal: {myDecimal}");

// Converting a decimal to an int causes it to lose data because int only stores whole numbers
// This is an example of a 'narrowing conversion'
// int myInt = (int)myDecimal;
// Console.WriteLine($"int: {myInt}");

// decimal myDecimal = 1.23456789m;
// This is a narrowing conversion since you'll lose some precision that you had using the float type
// float myFloat = (float)myDecimal;
//
// Console.WriteLine($"Decimal: {myDecimal}");
// Console.WriteLine($"Float  : {myFloat}");

// You can perform data conversion in 3 ways:

//1. Helper method on data type int.TryParse();
//2. Helper method on the variable 5.ToString();
//3. Convert class

// int first = 5;
// int second = 7;
// string message = first.ToString() + second.ToString();
// Console.WriteLine(message);

// string first = "5";
// string second = "7";
// int sum = int.Parse(first) + int.Parse(second);
// Console.WriteLine(sum);

// string value1 = "5";
// string value2 = "7";
//
// int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
// Console.WriteLine(result);


// Why would you use Convert class over the int.TryParse method? The convert class will round up where tryparse just truncates
// everything after the decimal

// int value = (int)1.5m; // 1
// Console.WriteLine(value);
//
// int value2 = Convert.ToInt32(1.5m); // 2
// Console.WriteLine(value2);

// string value = "bad";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }
// if (result > 0)
//     Console.WriteLine($"Measurement (w/ offset): {50 + result}");

// string[] values = { "12.3", "45", "ABC", "11", "DEF" };
//
// decimal total = 0;
// string message = "";
// foreach (var value in values)
// {
//     decimal result = 0;
//     if (decimal.TryParse(value, out result))
//     {
//         total += result;
//     }
//     else
//     {
//         message += value;
//     }
// }
//
// Console.WriteLine($"Message {message}");
// Console.WriteLine($"Total: {total}");

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
int result1 = Convert.ToInt32((decimal)value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");

