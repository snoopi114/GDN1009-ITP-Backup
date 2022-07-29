
//Title line
Console.WriteLine("CONDITIONALS PROJECT");
Console.WriteLine();


// Problem #1: Baking Converter
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Problem #1: Baking Converter");
Console.ForegroundColor= ConsoleColor.White;


string unit = "oz";
float amount = 210f;

if (unit.ToLower() == "g")
{
    float convertedAmount = amount * 28.349523f;
    Console.WriteLine($"The weight is {convertedAmount} {unit}.");
}
else
{
    float convertedAmount = amount / 28.349523f;
    Console.WriteLine($"The weight is {convertedAmount} {unit}.");
}


// End of problem 1, double line spacer
Console.WriteLine();
Console.WriteLine();



// Problem #2: Pizza Party
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Problem #2: Pizza Party");
Console.ForegroundColor = ConsoleColor.White;

int pizzaorder = 18;
int slicespizza = 6;
int numguest = 24;
int sliceguesteat = 4;


int totalslices = pizzaorder * slicespizza;
int neededslices = numguest * sliceguesteat;

if (totalslices >= neededslices)
{
    int leftoverslices = totalslices - neededslices;
    Console.WriteLine($"Yes, you have enough pizza for your {numguest} guests with {leftoverslices} slices left over.");

}
else
{
    int moreslices = neededslices - totalslices;
    Console.WriteLine($"No, you need at least {moreslices} more slices of pizza. You should order more.");
}

//end of Problem 2, double line spacer
Console.WriteLine();
Console.WriteLine();


// Problem #3: Discount Double Check

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Problem #3: Discount Double Check");
Console.ForegroundColor = ConsoleColor.White;

float item1 = 48.58f;
float item2 = 24.00f;
float item3 = 14.84f;

float discount10 = 0.10f;
float discount5 = 0.05f;

float totalcost = item1 + item2 + item3;

if (totalcost >= 100)
{
    float discountAmount = totalcost * discount10;
    float totalWithDiscount = totalcost - discountAmount;

    Console.WriteLine($"Your total purchase is {totalWithDiscount:C}, which includes your 10% discount.");
}
else if (totalcost >= 50 && totalcost <= 100)
{
    float discountAmount = totalcost * discount5;
    float totalWithDiscount = totalcost - discountAmount;

    Console.WriteLine($"Your total purchase is {totalWithDiscount:C}, which includes your 5% discount.");
}
else
{
    Console.WriteLine($"Your total purchase is {totalcost:C}.");
}

// End of Problem 3
Console.WriteLine();
Console.WriteLine();

// Problem #4: Logical Operators: Movie Ticket Price

Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Problem #4: Logical Operators: Movie Ticket Price");
Console.ForegroundColor = ConsoleColor.White;

float ticketPrice = 12f;
float discountPrice = 7f;
int viewerAge = 7;
int time = 1530;

if (viewerAge < 10 || viewerAge >= 55)
{
    Console.WriteLine($"Your ticket price is {discountPrice:C}");
}
else if(time >= 1500 && time <= 1700)
{
    Console.WriteLine($"Your ticket price is {discountPrice:C}");
}
else 
{
    Console.WriteLine($"Your ticket price is {ticketPrice:C}");
};