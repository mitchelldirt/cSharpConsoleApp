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

string[,] corporate = 
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}};

string[,] external = 
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++) 
{
    DisplayEmail(first: corporate[i,0], last: corporate[i,1]);
}

for (int i = 0; i < external.GetLength(0); i++) 
{
    DisplayEmail(first: external[i,0], last: external[i,1], domain: externalDomain);
}

void DisplayEmail(string first, string last, string domain = "contoso.com") 
{
    string email = first.Substring(0, 2) + last;
    email = email.ToLower();
    Console.WriteLine($"{email}@{domain}");
}


