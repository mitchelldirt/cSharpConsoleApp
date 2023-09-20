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


// string permission = "Admin|Manager";
// int level = 55;

// if (permission.Contains("Admin") && level >= 55)
//     Console.WriteLine("Greetings Super Admin!");
// else if (permission.Contains("Admin") && level < 55)
//     Console.WriteLine("Welcome, Admin User");
// else if (permission.Contains("Manager") && level >= 20)
//     Console.WriteLine("Contact an admin for permission");
// else
//     Console.WriteLine("You do not have sufficient privileges.");

// bool flag = true;
// int value = 10;
// if (flag)
// {
//     Console.WriteLine($"Inside of code block {value}");
// }
// code block without braces
// if (flag)
//     Console.WriteLine($"Inside of code block: {value}");

// You can also do a single line if statement, but readability is not so good
// if (flag) Console.WriteLine($"Inside of code block: {value}");


// Console.WriteLine($"Outside of code block: {value}");

// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// int total = 0;

// foreach (int number in numbers)
// {
//     total += number;

//     if (number == 42)
//         Console.WriteLine("Set contains 42");
// }

// Console.WriteLine($"Total: {total}");

// int employeeLevel = 201;
// string employeeName = "John Smith";

// string title = "";

// switch (employeeLevel)
// {
//     case 100:
//         title = "Junior Associate";
//         break;
//     case 200:
//         title = "Senior Associate";
//         break;
//     case 300:
//         title = "Manager";
//         break;
//     case 400:
//         title = "Senior Manager";
//         break;
//     default:
//         title = "Associate";
//         break;
// }

// Console.WriteLine($"{employeeName}, {title}");

// SKU = Stock Keeping Unit. 
// SKU value format: <product #>-<2-letter color code>-<size code>
// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// string type = "";
// string color = "";
// string size = "";

// switch (product[0])
// {
//     case "01":
//         type = "Sweat shirt";
//         break;
//     case "02":
//         type = "T-Shirt";
//         break;
//     case "03":
//         type = "Sweat pants";
//         break;
//     default:
//         type = "Other";
//         break;  
// }

// switch (product[1])
// {
//     case "BL":
//         color = "Black";
//         break;
//     case "MN":
//         color = "Maroon";
//         break;
//     default:
//         color = "White";
//         break;  
// }

// switch (product[2])
// {
//     case "S":
//         size = "Small";
//         break;
//     case "M":
//         size = "Medium";
//         break;
//     case "L":
//         size = "Large";
//         break;
//     default:
//         size = "One Size Fits All";
//         break;  
// }

// Console.WriteLine($"Product: {size} {color} {type}");

// for (int i = 0; i < 10; i+= 3)
// {
//     Console.WriteLine(i);
//     if (i == 6)
//         break;
// }

// string[] names = { "Alex", "Eddie", "David", "Michael" };
// for (int i = names.Length - 1; i >= 0; i--)
// {
//     Console.WriteLine(names[i]);
// }

// Ye old fizzbuzz

// for (int i = 1; i <= 100; i++)
// {
//     if (i % 15 == 0)
//         Console.WriteLine($"{i} - FizzBuzz!");
//     else if (i % 3 == 0)
//         Console.WriteLine($"{i} - Fizz");
//     else if (i % 5 == 0)
//         Console.WriteLine($"{i} - Buzz");
//     else
//         Console.WriteLine($"{i}");
// }

Random random = new Random();
int current = random.Next(1, 11);

/*
do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);
*/

// while (current >= 3)
// {
//     Console.WriteLine(current);
//     current = random.Next(1, 11);
// }
// Console.WriteLine($"Last number: {current}");

// do
// {
//     current = random.Next(1, 11);
//
//     if (current >= 8) continue;
//
//     Console.WriteLine(current);
// } while (current != 7);

// DO WHILE CHALLENGE

// int heroHealth = 10;
// int monsterHealth = 10;
// var die = new Random();
// do
// {
//     int heroRoll = die.Next(1, 11);
//     monsterHealth -= heroRoll;
//     Console.WriteLine($"Monster took {heroRoll} points of damage, it has {monsterHealth} health points left");
//
//     if (monsterHealth <= 0) continue;
//     
//     int monsterRoll = die.Next(1, 11);
//     heroHealth -= monsterRoll;
//     Console.WriteLine($"Hero took {monsterRoll} points of damage. The hero has {heroHealth} health points left");
//     
// } while (heroHealth > 0 && monsterHealth > 0);
//
// Console.WriteLine(heroHealth <= 0 ? "The monster won :(" : "The hero won! :)");

// 3 PROJECTS TO LEARN LOOPS BETTER
// PROJECT 1

// Console.WriteLine("Please provide a number between 5 and 10");
// string? readResult = Console.ReadLine();
// int num;
// bool validNumber = false;
//
// bool isNumber = int.TryParse(readResult, out num);
//
// do
// {
//     if (isNumber && (num >= 5 && num <= 10))
//     {
//         validNumber = true;
//         continue;
//     }
//     
//     Console.WriteLine($"Sorry, your number {num} was invalid. Please enter a valid number");
//     readResult = Console.ReadLine();
//     isNumber = int.TryParse(readResult, out num);
// } while (validNumber == false);
//
// Console.WriteLine($"Your input value {num} has been accepted :)");

// PROJECT 2

// Console.WriteLine("Please provide one of the three role names (Administrator, Manager, User)");
// string[] validRoles = { "administrator", "manager", "user" };
// string? userProvidedRole = Console.ReadLine();
// bool validRole = false;
//
// do
// {
//     if (userProvidedRole == null)
//     {
//         Console.WriteLine("Please enter a role");
//         userProvidedRole = Console.ReadLine();
//         continue;
//     }   
//     
//     if (validRoles.Contains(userProvidedRole.Trim().ToLower()))
//     {
//         validRole = true;
//         continue;
//     }
//     
//     Console.WriteLine("Please enter a valid role");
//     userProvidedRole = Console.ReadLine();
//     
// } while (validRole == false);
//     
// Console.WriteLine($"Thank you for enter valid role: {userProvidedRole}");

// PROJECT 3

// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
// foreach (string myString in myStrings)
// {
//     int periodLocation = myString.IndexOf(".");
//     if (periodLocation == -1)
//     {
//         Console.WriteLine(myString);
//         continue;
//     }
//     
//     string currentString = myString;
//
//     
//     do
//     {
//         Console.WriteLine(currentString.Substring(0, periodLocation));
//         currentString = currentString.Remove(0, periodLocation + 1).TrimStart();
//         periodLocation = currentString.IndexOf(".");
//     } while (periodLocation != -1);
//     
//     Console.WriteLine(currentString);
// }

// BIG PROJECT

// the ourAnimals array will store the following: 

string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];

// TODO: Convert the if-elseif-else construct to a switch statement

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++)
{
    switch (i)
    {
        case 0:
            animalSpecies = "dog";
            animalID = "d1";
            animalAge = "2";
            animalPhysicalDescription =
                "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
            animalPersonalityDescription =
                "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
            animalNickname = "lola";
            break;
        case 1:
            animalSpecies = "dog";
            animalID = "d2";
            animalAge = "9";
            animalPhysicalDescription =
                "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
            animalPersonalityDescription =
                "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
            animalNickname = "loki";
            break;
        case 2:
            animalSpecies = "cat";
            animalID = "c3";
            animalAge = "1";
            animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
            animalPersonalityDescription = "friendly";
            animalNickname = "Puss";
            break;
        case 3:
            animalSpecies = "cat";
            animalID = "c4";
            animalAge = "?";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
        default:
            animalSpecies = "";
            animalID = "";
            animalAge = "";
            animalPhysicalDescription = "";
            animalPersonalityDescription = "";
            animalNickname = "";
            break;
    }

    ourAnimals[i, 0] = "ID #: " + animalID;
    ourAnimals[i, 1] = "Species: " + animalSpecies;
    ourAnimals[i, 2] = "Age: " + animalAge;
    ourAnimals[i, 3] = "Nickname: " + animalNickname;
    ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
    ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

do
{
// display the top-level menu options

    Console.Clear();

    Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
    Console.WriteLine(" 1. List all of our current pet information");
    Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
    Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
    Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
    Console.WriteLine(" 5. Edit an animal’s age");
    Console.WriteLine(" 6. Edit an animal’s personality description");
    Console.WriteLine(" 7. Display all cats with a specified characteristic");
    Console.WriteLine(" 8. Display all dogs with a specified characteristic");
    Console.WriteLine();
    Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

    readResult = Console.ReadLine();
    if (readResult != null)
    {
        menuSelection = readResult.ToLower();
    }

// Console.WriteLine($"You selected menu option {menuSelection}.");
// Console.WriteLine("Press the Enter key to continue");
//
// pause code execution
// readResult = Console.ReadLine();

    switch (menuSelection)
    {
        case "1":
            // List all of our current pet information
            for (var i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    for (var j = 0; j < 6; j++)
                    {
                        Console.WriteLine(ourAnimals[i, j]);
                    }

                    Console.WriteLine("\n\n");
                }
            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "2":
            // List all of our current pet information
            var anotherPet = "y";
            var petCount = 0;

            for (var i = 0; i < maxPets; i++)
            {
                if (ourAnimals[i, 0] != "ID #: ")
                {
                    petCount += 1;
                }
            }

            if (petCount < maxPets)
                Console.WriteLine(
                    $"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");

            bool validEntry = false;

            do
            {
                Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
                readResult = Console.ReadLine();

                if (readResult != null)
                {
                    animalSpecies = readResult.ToLower();

                    if (animalSpecies != "dog" && animalSpecies != "cat")
                    {
                        validEntry = false;
                    }
                    else
                    {
                        validEntry = true;
                    }
                }
            } while (validEntry == false);
            
            // build the animal the ID number - for example C1, C2, D3 (for Cat 1, Cat 2, Dog 3)
            animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();
            
            // get the pet's age. can be ? at initial entry.
            do
            {
                int petAge;
                Console.WriteLine("Enter the pet's age or enter ? if unknown");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    animalAge = readResult;
                    if (animalAge != "?")
                    {
                        validEntry = int.TryParse(animalAge, out petAge);
                    }
                    else
                    {
                        validEntry = true;
                    }
                }
            } while (validEntry == false);
            
            // get a description of the pet's physical appearance/condition - animalPhysicalDescription can be blank.
            do
            {
                Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    animalPhysicalDescription = readResult.ToLower();
                    if (animalPhysicalDescription == "")
                    {
                        animalPhysicalDescription = "tbd";
                    }
                }
            } while (animalPhysicalDescription == "");
            
            // get a description of the pet's personality - animalPersonalityDescription can be blank.
            do
            {
                Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    animalPersonalityDescription = readResult.ToLower();
                    if (animalPersonalityDescription == "")
                    {
                        animalPersonalityDescription = "tbd";
                    }
                }
            } while (animalPersonalityDescription == "");
            
            // get the pet's nickname. animalNickname can be blank.
            do
            {
                Console.WriteLine("Enter a nickname for the pet");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    animalNickname = readResult.ToLower();
                    if (animalNickname == "")
                    {
                        animalNickname = "tbd";
                    }
                }
            } while (animalNickname == "");
            
            // store the pet information in the ourAnimals array (zero based)
            ourAnimals[petCount, 0] = "ID #: " + animalID;
            ourAnimals[petCount, 1] = "Species: " + animalSpecies;
            ourAnimals[petCount, 2] = "Age: " + animalAge;
            ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
            ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
            ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

        {
            // increment petCount (the array is zero-based, so we increment the counter after adding to the array)
            petCount = petCount + 1;

            // check maxPet limit
            if (petCount < maxPets)
            {
                // another pet?
                Console.WriteLine("Do you want to enter info for another pet (y/n)");
                do
                {
                    readResult = Console.ReadLine();
                    if (readResult != null)
                    {
                        anotherPet = readResult.ToLower();
                    }
                } while (anotherPet != "y" && anotherPet != "n");
            }
        }

            if (petCount >= maxPets)
            {
                Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
                Console.WriteLine("Press the Enter key to continue.");
                readResult = Console.ReadLine();
            }

            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        case "3":
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "4":
            Console.WriteLine("Challenge Project - please check back soon to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "5":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "6":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "7":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;

        case "8":
            Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
            Console.WriteLine("Press the Enter key to continue.");
            readResult = Console.ReadLine();
            break;
        default:
            break;
    }
} while (menuSelection != "exit");