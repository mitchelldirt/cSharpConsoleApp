Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int score = roll1 + roll2 + roll3;

if ((roll1 == roll2) && (roll1 == roll3))
{
    Console.WriteLine("Triples... WHOA! +6 points");
    score += 6;
}
else if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 points");
    score += 2;
}

Console.WriteLine($"The total score is from your rolls ({roll1}, {roll2}, {roll3}) is: {score}");

if (score >= 16)
{
    Console.WriteLine("You win... a new car! 🎉");
}
else if (score >= 10)
{
    Console.WriteLine("Heck yeah, new laptop for you 😎");
}
else if (score >= 7)
{
    Console.WriteLine("Nice, you get a new VACATION 🏖️");
}
else
{
    Console.WriteLine("You get a new kitten 🐈");
}