Console.Title = "Character Sheet";
Console.WindowHeight = 40;
Console.WindowWidth = 100;
Console.SetBufferSize(100,40);

// Decaring variables
string characterFirstName;
string characterLastName;
string characterSpecies;
int characterAge;
float characterHeightMeters;
string characterBackStory;

// Assigning variables
characterAge = 31;
characterHeightMeters = 1.67f;

// Defining variables
char characterMiddleInitial = 'W';
int characterAbility = 14;
int characterKnowledge = 19;
int characterStreetSmarts = 13;
int characterWit = 13;

// Accepting input
Console.WriteLine("What is your character's first name?");
characterFirstName = Console.ReadLine();
Console.WriteLine("What is your character's last name?");
characterLastName = Console.ReadLine();
Console.WriteLine("What is your characters species?");
characterSpecies = Console.ReadLine();
Console.Clear();
characterBackStory = $"{characterFirstName} {characterMiddleInitial} {characterLastName} is a {characterSpecies} and is an agent of chaos. Standing at just over {characterHeightMeters}, and {characterAge} years\nof age, they have gotten pretty good at sowing chaos around them. With {characterWit} years of wit gained\nover {characterKnowledge} years of focused knowledge, talking his way into and out of any situation is now a breeze.\nTheir {characterStreetSmarts} years of street smarts are just an added bonus. Even though relatively young in {characterSpecies},\nthe {characterSpecies} Lord rates their overall ability at creating chaos at a {characterAbility} out of 20.";


// String interpolation
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("+CHARACTER SHEET***********************************************************************************+");
Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine($"Name: \t\t{characterFirstName} {characterLastName}");
Console.WriteLine($"Age: \t\t{characterAge}");
Console.WriteLine($"Height: \t{characterHeightMeters}");
Console.WriteLine($"Wit: \t\t{characterWit}");
Console.WriteLine($"Ability: \t{characterAbility}");
Console.WriteLine($"Knowledge: \t{characterKnowledge}");
Console.WriteLine($"Street Smarts: \t{characterStreetSmarts}");
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("+**************************************************************************************************+");
Console.WriteLine();
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("BACK STORY");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine(characterBackStory);
Console.ForegroundColor = ConsoleColor.White;

