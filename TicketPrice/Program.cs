string price = Console.ReadLine();

if (price == "student")
{
    Console.WriteLine("$1.00");
}
else if (price == "regular")
{
    Console.WriteLine("$1.60");
}
else
{
    Console.WriteLine("Invalid ticket type!");
}