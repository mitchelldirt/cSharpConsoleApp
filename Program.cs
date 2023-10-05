// void SayHello()
// {
//     Console.WriteLine("Hello World!");
// }
//
// SayHello();

// int[] a = {1,2,3,4,5};
//
// Console.WriteLine("Contents of Array:");
// PrintArray();
//
// void PrintArray()
// {
//     foreach (var x in a)
//     {
//         Console.WriteLine($"{x}");
//     }
// }    

// void DisplayRandomNumbers()
// {
//     var rand = new Random();
//
//     for (var i = 0; i < 5; i++)
//     {
//         Console.WriteLine(rand.Next(1, 100));
//     }
// }
//
// DisplayRandomNumbers();

// EXERCISE CREATE REUSABLE METHOD TO CLEAN UP DUPLICATED CODE

// using System;
//
// int[] times = {800, 1200, 1600, 2000};
// int diff = 0;
//
// Console.WriteLine("Enter current GMT");
// int currentGMT = Convert.ToInt32(Console.ReadLine());
//
// Console.WriteLine("Current Medicine Schedule:");
// FormatAndDisplayMedicalTimes(times);
//
// Console.WriteLine();
//
// Console.WriteLine("Enter new GMT");
// int newGMT = Convert.ToInt32(Console.ReadLine());
//
// if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
// {
//     Console.WriteLine("Invalid GMT");
// }
// else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
// {
//     diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     AdjustTimes();
// } 
// else 
// {
//     diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//
//     /* Adjust the times by adding the difference, keeping the value within 24 hours */
//     AdjustTimes();
// }
//
// Console.WriteLine("New Medicine Schedule:");
// FormatAndDisplayMedicalTimes(times);
//
// Console.WriteLine();
//
// void FormatAndDisplayMedicalTimes(int[] times)
// {
//     foreach (int val in times)
//     {
//         string time = val.ToString();
//         int len = time.Length;
//
//         if (len >= 3)
//         {
//             time = time.Insert(len - 2, ":");
//         }
//         else if (len == 2)
//         {
//             time = time.Insert(0, "0:");
//         }
//         else
//         {
//             time = time.Insert(0, "0:0");
//         }
//
//         Console.Write($"{time} ");
//     }  
// }
//
// void AdjustTimes()
// {
//     for (int i = 0; i < times.Length; i++) 
//     {
//         times[i] = ((times[i] + diff)) % 2400;
//     }
// }

// string IsValidIPV4(string ip)
// {
//     string[] segments = ip.Split('.', StringSplitOptions.RemoveEmptyEntries);
//
//     if (segments.Length != 4)
//     {
//         return "Invalid IP Address. Needs four segements";
//     }
//
//     foreach (var segment in segments)
//     {
//         if (segment.StartsWith("0") && segment.Length > 1)
//         {
//             return "Invalid IP Address. No leading zeros";
//         }
//         
//         if (int.TryParse(segment, out var number))
//         {
//             if (number < 0 || number > 255)
//             {
//                 return "Invalid IP Address. Segments must be between 0 and 255";
//             }
//         }
//     }
//
//     return $"Yay {ip} is a valid IP Address! :)";
// }
//
// string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
//
// foreach (var test in ipv4Input)
// {
//     Console.WriteLine(IsValidIPV4(test));
// }


// void SpeakFortune()
// {
//     Random random = new Random();
//     int luck = random.Next(100);
//
//     string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
//     string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
//     string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
//     string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};
//
//     Console.WriteLine("A fortune teller whispers the following words:");
//     string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
//     for (int i = 0; i < 4; i++) 
//     {
//         Console.Write($"{text[i]} {fortune[i]} ");
//     }  
// }
//
// SpeakFortune();
// SpeakFortune();

// int[] schedule = {800, 1200, 1600, 2000};
//
// void DisplayAdjustedTimes(int[] times, int currentGMT, int newGMT)
// {
//     int diff = 0;
//
//     if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
//     {
//         Console.WriteLine("Invalid GMT");
//     }
//     else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
//     {
//         diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
//     } 
//     else 
//     {
//         diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
//     }
//
//     for (int i = 0; i < times.Length; i++)
//     {
//         int newTime = (times[i] + diff) % 2400;
//         Console.WriteLine($"{times[i]} -> {newTime}");
//     }
//
// }
//
// DisplayAdjustedTimes(schedule, 6, -6);

// string[] students = {"Jenna", "Ayesha", "Carlos", "Viktor"};
// DisplayStudents(students);
// DisplayStudents(new string[] {"Robert", "Mitchell"});
//
//
// void DisplayStudents(string[] students)
// {
//     foreach (var student in students)
//     {
//         Console.Write($"{student}, ");
//     }
//     
//     Console.WriteLine();
// }
//
// const double pi = 3.14159;
// PrintCircleInfo(12);
// PrintCircleInfo(24);
//
// void PrintCircleInfo(int radius) 
// {
//     Console.WriteLine($"Circle with radius {radius}");
//     PrintCircleArea(radius);
//     PrintCircleCircumference(radius);
// }
//
// void PrintCircleArea(int radius)
// {
//     double area = pi * (radius * radius);
//     Console.WriteLine($"Area = {area}");
// }
//
// void PrintCircleCircumference(int radius)
// {
//     double circumference = 2 * pi * radius;
//     Console.WriteLine($"Circumference = {circumference}");}

// int a = 3;
// int b = 5;
// int c = 0;
//
// void Multiply(int a, int b, int c)
// {
//     c = a * b;
//     Console.WriteLine();
// }

// int[] array = {1, 2, 3, 4};

// PrintArray(array);
// Clear(array);
// PrintArray(array);

// string status = "Healthy";
// Console.WriteLine($"Start: {status}");
// SetHealth(status, false);
// Console.WriteLine($"End: {status}");
//
// void PrintArray(int[] array)
// {
//     foreach (int a in array)
//     {
//         Console.Write($"{a}");
//     }
// }
//
// void Clear(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = 0;
//     }
// }
//
// void SetHealth(string status, bool isHealthy)
// {
//     status = (isHealthy ? "Healthy" : "Unhealthy");
//     Console.WriteLine($"Middle: {status}");
// }
//
// string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
// string[] rsvps = new string[10];
// int count = 0;
//
// RSVP("Rebecca");
// RSVP("Nadia", 2, "Nuts");
// RSVP(name: "Linh", partySize: 2, inviteOnly: false);
// RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
// RSVP("Noor", 4, inviteOnly: false);
// RSVP("Jonte", 2, "Stone fruit", false);
// ShowRSVPs();
//
// void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true)
// {
//     if (inviteOnly)
//     {
//         bool found = false;
//         foreach (var guest in guestList)
//         {
//             if (guest.Equals(name))
//             {
//                 found = true;
//                 break;
//             }
//         }
//
//         if (!found)
//         {
//             Console.WriteLine($"Sorry, {name} is not on the guest list");
//             return;
//         }
//     }
//
//     rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//     count++;
// }
//
// void ShowRSVPs()
// {
//     Console.WriteLine("\nTotal RSVPs:");
//     for (int i = 0; i < count; i++)
//     {
//         Console.WriteLine(rsvps[i]);
//     }
// }

// string[,] corporate = 
// {
//     {"Robert", "Bavin"}, {"Simon", "Bright"},
//     {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
//     {"Sarah", "Delucchi"}, {"Sinan", "Ali"}};
//
// string[,] external = 
// {
//     {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
//     {"Shay", "Lawrence"}, {"Daren", "Valdes"}
// };
//
// string externalDomain = "hayworth.com";
//
// for (int i = 0; i < corporate.GetLength(0); i++) 
// {
//     DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
// }
//
// for (int i = 0; i < external.GetLength(0); i++) 
// {
//     DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
// }
//
// void DisplayEmail(string first, string last, string domain = "contoso.com") 
// {
//     string email = first.Substring(0, 2) + last;
//     email = email.ToLower();
//     Console.WriteLine($"{email}@{domain}");
// }

// double total = 0;
// double minimumSpend = 30.00;
//
// double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
// double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};
//
// for (int i = 0; i < items.Length; i++)
// {
//     total += GetDiscountedPrice(i);
// }
//
// if (TotalMeetsMinimum())
// {
//     total -= 5.00;
// }
//
// Console.WriteLine($"Total: ${FormatDecimal(total)}");
//
// double GetDiscountedPrice(int itemIndex)
// {
//     // Calculate the discounted price of the item
//     return items[itemIndex] * (1 - discounts[itemIndex]);
// }
//
// bool TotalMeetsMinimum()
// {
//     return total >= minimumSpend;
// }
//
// string FormatDecimal(double input)
// {
//     // Format the double so only 2 decimal places are displayed
//     return input.ToString().Substring(0, 5);
// }

// double usd = 23.73;
// int vnd = UsdToVnd(usd);
//
// Console.WriteLine($"${usd} USD = ${vnd} VND");
// Console.WriteLine($"${vnd} VND = ${VndToUsd(vnd)} USD");
//
// int UsdToVnd(double usd)
// {
//     int rate = 23500;
//     return (int)(rate * usd);
// }
//
// double VndToUsd(int vnd)
// {
//     double rate = 23500;
//     return vnd / rate;
// }

// string ReverseWord(string word)
// {
//     string result = "";
//     for (int i = word.Length - 1; i >= 0; i--) 
//     {
//         result += word[i];
//     }
//     return result;
// }
//
// string ReverseSentece(string input)
// {
//     string result = "";
//     string[] words = input.Split(" ");
//
//     foreach (var word in words)
//     {
//         result += ReverseWord(word) + " ";
//     }
//
//     return result;
// }
//
// Console.WriteLine(ReverseSentece("The lazy brown dog jumps over the speedy fox"));

// string[] words = {"racecar" ,"talented", "deified", "tent", "tenet"};
//
// Console.WriteLine("Is it a palindrome?");
// foreach (string word in words) 
// {
//     Console.WriteLine($"{word}: {IsPalindrome(word)}");
// }
//
// bool IsPalindrome(string word)
// {
//     var charArray = word.ToCharArray();
//     Array.Reverse(charArray);
//     var reversed = new string(charArray);
//
//     return word == reversed ? true : false;
// }

// int[,] TwoCoins(int[] coins, int target) 
// {
//     int[,] result = {{-1,-1},{-1,-1},{-1,-1},{-1,-1},{-1,-1}};
//     int count = 0;
//
//     for (int curr = 0; curr < coins.Length; curr++) 
//     {
//         for (int next = curr + 1; next < coins.Length; next++) 
//         {    
//             if (coins[curr] + coins[next] == target) 
//             {
//                 result[count, 0] = curr;
//                 result[count, 1] = next;
//                 count++;
//             }
//             if (count == result.GetLength(0)) 
//             {
//                 return result;
//             }
//         }
//     }
//     return (count == 0) ? new int[0,0] : result;
// }
//
// int target = 30;
// int[] coins = new int[] {5, 5, 50, 25, 25, 10, 5};
// int[,] result = TwoCoins(coins, target);
//
// if (result.Length == 0) 
// {
//     Console.WriteLine("No two coins make change");
// } 
// else 
// {
//     Console.WriteLine("Change found at positions:");
//     for (int i = 0; i < result.GetLength(0); i++) 
//     {
//         if (result[i,0] == -1) 
//         {
//             break;
//         }
//         Console.WriteLine($"{result[i,0]},{result[i,1]}");
//     }
// }
//
// Random random = new Random();
//
// Console.WriteLine("Would you like to play? (Y/N)");
// if (ShouldPlay()) 
// {
//     PlayGame();
// }
//
// void PlayGame() 
// {
//     var play = true;
//     var die = new Random();
//
//     while (play)
//     {
//         var target = die.Next(1, 6);
//         var roll = die.Next(1, 7);
//
//         Console.WriteLine($"Roll a number greater than {target} to win!");
//         Console.WriteLine($"You rolled a {roll}");
//         Console.WriteLine(WinOrLose(target, roll));
//         Console.WriteLine("\nPlay again? (Y/N)");
//
//         play = ShouldPlay();
//     }
// }
//
// bool ShouldPlay()
// {
//     var playerInput = Console.ReadLine();
//
//     return (playerInput != null && playerInput.ToUpper() == "Y");
// }
//
// string WinOrLose(int target, int roll)
// {
//     return roll > target ? "You win!" : "You lose!";
// }
//
//
// using System;
//
// string[] pettingZoo = 
// {
//     "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
//     "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
//     "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
// };
//
// void PlanSchoolVisit(string schoolName, int groups = 6)
// {
//     RandomizeAnimals();
//     string[,] group = AssignGroup(groups);
//     Console.WriteLine(schoolName);
//     PrintGroup(group);
//     Console.WriteLine();
// }
//
// PlanSchoolVisit("School A");
// PlanSchoolVisit("School B", 3);
// PlanSchoolVisit("School C", 2);
//
// void RandomizeAnimals() 
// {
//     Random random = new Random();
//
//     for (int i = 0; i < pettingZoo.Length; i++) 
//     {
//         int r = random.Next(i, pettingZoo.Length);
//
//         string temp = pettingZoo[r];
//         pettingZoo[r] = pettingZoo[i];
//         pettingZoo[i] = temp;
//     }
// }
//
// string[,] AssignGroup(int groups = 6)
// {
//     string[,] result = new string[groups, pettingZoo.Length/groups];
//     
//     int start = 0;
//
//     for (int i = 0; i < groups; i++) 
//     {
//         for (int j = 0; j < result.GetLength(1); j++) 
//         {
//             result[i,j] = pettingZoo[start++];
//         }
//     }
//
//     return result;
// }
//
// void PrintGroup(string[,] group)
// {
//     for (int i = 0; i < group.GetLength(0); i++)
//     {
//         Console.Write($"Group {i + 1}: ");
//         for (int j = 0; j < group.GetLength(1); j++)
//         {
//            Console.Write($"{group[i,j]} "); 
//         }
//         Console.WriteLine();
//     }
//     
//     
// }
using System;

Random random = new Random();
Console.CursorVisible = false;
int height = Console.WindowHeight - 1;
int width = Console.WindowWidth - 5;
bool shouldExit = false;

// Console position of the player
int playerX = 0;
int playerY = 0;
int playerSpeed = 1;

// Console position of the food
int foodX = 0;
int foodY = 0;

// Available player and food strings
string[] states = {"('-')", "(^-^)", "(X_X)"};
string[] foods = {"@@@@@", "$$$$$", "#####"};

// Current player string displayed in the Console
string player = states[0];

// Index of the current food
int food = 0;

InitializeGame();
while (!shouldExit) 
{
    Move(playerSpeed);

    if (TerminalResized())
    {
        Console.WriteLine("Console was resized. Program exiting.");
        shouldExit = true;
    }

    if (GotFood())
    {
        ChangePlayer();
        ShowFood();
    }
    
    if (IsPlayerStateBad())
        FreezePlayer();

    playerSpeed = IsPlayerStateGood() ? 3 : 1;
}

// Returns true if the Terminal was resized 
bool TerminalResized() 
{
    return height != Console.WindowHeight - 1 || width != Console.WindowWidth - 5;
}

// Displays random food at a random location
void ShowFood() 
{
    // Update food to a random index
    food = random.Next(0, foods.Length);

    // Update food position to a random location
    foodX = random.Next(0, width - player.Length);
    foodY = random.Next(0, height - 1);

    // Display the food at the location
    Console.SetCursorPosition(foodX, foodY);
    Console.Write(foods[food]);
}

// Changes the player to match the food consumed
void ChangePlayer() 
{
    player = states[food];
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Returns true if the player location matches the food location
bool GotFood() 
{
    return playerY == foodY && playerX == foodX;
}

bool IsPlayerStateBad()
{
    return player == states[2];
}

bool IsPlayerStateGood()
{
    return player == states[1];
}

// Temporarily stops the player from moving
void FreezePlayer()
{
    var frozenPlayerPosition = new int[] { playerX, playerY };
    System.Threading.Thread.Sleep(1000);
    player = states[0];
    Console.SetCursorPosition(frozenPlayerPosition[0], frozenPlayerPosition[1]);
}

// Reads directional input from the Console and moves the player
void Move(int speed = 1) 
{
    int lastX = playerX;
    int lastY = playerY;
    
    switch (Console.ReadKey(true).Key) 
    {
        case ConsoleKey.UpArrow:
            playerY--; 
            break;
		case ConsoleKey.DownArrow: 
            playerY++; 
            break;
		case ConsoleKey.LeftArrow:  
            playerX -= speed; 
            break;
		case ConsoleKey.RightArrow: 
            playerX += speed; 
            break;
		case ConsoleKey.Escape:     
            shouldExit = true; 
            break;
    }

    // Clear the characters at the previous position
    Console.SetCursorPosition(lastX, lastY);
    for (int i = 0; i < player.Length; i++) 
    {
        Console.Write(" ");
    }

    // Keep player position within the bounds of the Terminal window
    playerX = (playerX < 0) ? 0 : (playerX >= width ? width : playerX);
    playerY = (playerY < 0) ? 0 : (playerY >= height ? height : playerY);

    // Draw the player at the new location
    Console.SetCursorPosition(playerX, playerY);
    Console.Write(player);
}

// Clears the console, displays the food and player
void InitializeGame() 
{
    Console.Clear();
    ShowFood();
    Console.SetCursorPosition(0, 0);
    Console.Write(player);
}