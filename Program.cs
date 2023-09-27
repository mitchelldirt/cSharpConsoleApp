// string[] pallets = {"B14", "A11", "B12", "A13"};
//
// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
//
// Console.WriteLine("");
// Console.WriteLine("Reversed...");
// Array.Reverse(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string[] pallets = { "B14", "A11", "B12", "A13" };
// Console.WriteLine("");
//
// Array.Clear(pallets, 0, 2);
// Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
//
// Console.WriteLine("");
// Array.Resize(ref pallets, 6);
// Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");
//
// pallets[4] = "C01";
// pallets[5] = "C02";
//
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }
//
// Console.WriteLine("");
// Array.Resize(ref pallets, 3);
// Console.WriteLine($"Resizing 3 ... count: {pallets.Length}");
//
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// string value = "abc123";
// char[] valueArray = value.ToCharArray();
// Array.Reverse(valueArray);
// // string result = new string(valueArray);
// string result = String.Join(",", valueArray);
// Console.WriteLine(result);
//
// string[] items = result.Split(',');
// foreach (string item in items)
// {
//     Console.WriteLine(item);
// }

// string result = "";
// string pangram = "The quick brown fox jumps over the lazy dog";
// string[] splitPangram = pangram.Split(" ");
// foreach (var word in splitPangram)
// {
//    char[] wordArray = word.ToCharArray();
//    Array.Reverse(wordArray);
//    result += new string(wordArray) + " ";
// }
//
// Console.WriteLine(result);

// string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
//
// string[] orderIds = orderStream.Split(",");
// Array.Sort(orderIds);
// foreach (var orderId in orderIds)
// {
//     if (orderId.Length == 4)
//     {
//         Console.WriteLine(orderId);
//     }
//     else
//     {
//         Console.WriteLine($"{orderId}\t- Error");
//     }
// }

// string first = "Hello";
// string second = "World";
// Console.WriteLine("{1} {0}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first, second);

// string first = "Hello";
// string second = "World";
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");

// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// decimal measurment = 123456.789122222222m;
// Console.WriteLine($"Measurement: {measurment:N8} units");
//
// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");

// decimal price = 67.55m;
// decimal salePrice = 59.99m;
//
// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
// string yourDiscount2 = $"You saved {(price - salePrice):C2} off the regular {price:C2} price. ";
//
// yourDiscount2 += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
//
//
// Console.WriteLine(yourDiscount2);

// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;
//
// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"Shares: {productShares:N3} Product");
// Console.WriteLine($"\tSub Total: {subtotal:C2}");
// Console.WriteLine($"\t\tTax: {taxPercentage:P2}");
// Console.WriteLine($"\tTotal Billed: {total:C2}");

// string input = "Pad this";
// Console.WriteLine(input.PadRight(12, '-'));

// string paymentId = "769C";
// string payeeName = "Mr. Stephen Ortega";
// string paymentAmount = $"{5000:C2}";
//
// var formattedLine = paymentId.PadRight(6);
// formattedLine += payeeName.PadRight(24);
// formattedLine += paymentAmount.PadLeft(10);
//
// Console.WriteLine("1234567890123456789012345678901234567890");
// Console.WriteLine(formattedLine);

string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;

// Your logic here
Console.WriteLine($"Dear {customerName}");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Give your current volume, your potential profit would be {newProfit:C2}.\n");
Console.WriteLine("Here's a quick comparison:\n");

var currentProductF = currentProduct.PadRight(24);
var newProductF = newProduct.PadRight(24);

var currentReturnF = $"{currentReturn:P2}".PadRight(10);
var newReturnF = $"{newReturn:P2}".PadRight(10);

Console.WriteLine($"{currentProductF}{currentReturnF}{currentProfit:C2}");
Console.WriteLine($"{newProductF}{newReturnF}{newProfit:C2}");

string comparisonMessage = "";

// Your logic here

Console.WriteLine(comparisonMessage);