int firstSide = int.Parse(Console.ReadLine());
int secondSide = int.Parse(Console.ReadLine());
int thirdSide = int.Parse(Console.ReadLine());

//i need to add one more thing to work, mby tomorrow

if (firstSide == secondSide + thirdSide)
{
    Console.WriteLine("Valid Triangle");
}
else if (secondSide == firstSide + thirdSide)
{
    Console.WriteLine("Valid Triangle");
}
else if (thirdSide == secondSide + firstSide)
{
    Console.WriteLine("Valid Triangle");
}
else
{
    Console.WriteLine("Invalid Triangle");
}