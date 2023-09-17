// string pangram = "The lazy brown fox jumps over quick dog";
// Console.WriteLine(pangram.Contains("fox"));
// Console.WriteLine(pangram.Contains("cow"));

// int saleAmount = 1000;
// int discount = saleAmount > 1000 ? 100 : 50;
// Console.WriteLine($"Discount: {discount}");

// COIN FLIP CHALLENGE
// var coinFlipper = new Random();
// string result = coinFlipper.Next(0, 2) == 0 ? "Heads" : "Tails";
// Console.WriteLine($"Coin flipping... {result}!");


string permission = "Admin|Manager";
int level = 55;

if (permission.Contains("Admin") && level >= 55)
    Console.WriteLine("Greetings Super Admin!");
else if (permission.Contains("Admin") && level < 55)
    Console.WriteLine("Welcome, Admin User");
else if (permission.Contains("Manager") && level >= 20)
    Console.WriteLine("Contact an admin for permission");
else
    Console.WriteLine("You do not have sufficient privileges.");