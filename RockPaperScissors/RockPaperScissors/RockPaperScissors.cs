Random rand = new Random();

int playerPoints = 0;
int computerPoints = 0;

PlayRound();
Console.WriteLine($"Current score is PC: {computerPoints} to Player: {playerPoints}");
Console.WriteLine();
PlayRound();
Console.WriteLine($"Current score is PC: {computerPoints} to Player: {playerPoints}");
Console.WriteLine();
PlayRound();
DetermineWinner();


//computerPick
string GetRandomPick()
{
    int roll = rand.Next(3);
    string computerPick = String.Empty;
    if (roll == 0)
    {
        computerPick = "rock";
    }
    else if (roll == 1)
    {
        computerPick = "paper";
    }
    else if (roll == 2)
    {
        computerPick = "scissors";
    }
    return computerPick;

}

//Player input validation
bool ValidatePick(string playerPick)
{
    if (playerPick == "rock" || playerPick == "paper" || playerPick == "scissors")
    {
        return true;
    }
    else
    {
        return false;
    }
}

//playerPick
string GetPlayerPick()
{
    Console.Write("Pick rock, paper, or scissors: ");
    string userInput = Console.ReadLine();
    string playerPick = userInput.ToLower();
    if (ValidatePick(playerPick) == false)
    {
        Console.WriteLine("Exiting. Please restart and type, \"rock\", \"paper\", or, \"scissors\".");
        Environment.Exit(1);
    }

    return playerPick;
}

//Display each pick
void DisplayPicks(string playerChoice, string computerChoice)
{
    Console.WriteLine($"Player chose {playerChoice}.");
    Console.WriteLine($"PC chose {computerChoice}.");
}

//Scoring system 3
void UpdateScore(string playerChoice, string computerChoice)
{
    computerChoice = computerChoice.ToLower();
    playerChoice = playerChoice.ToLower();


    if (computerChoice == playerChoice)
    {
        Console.WriteLine("Tie. No points awarded.");
    }
    else if ((computerChoice != playerChoice) && (computerChoice == "paper" && playerChoice == "rock"))
    {
        Console.WriteLine("Paper covers rock. Point for PC.");
        computerPoints++;
    }
    else if ((computerChoice != playerChoice) && (computerChoice == "scissors" && playerChoice == "rock"))
    {
        Console.WriteLine("Rock smashes scissors. Point for player.");
        playerPoints++;
    }
    else if ((computerChoice != playerChoice) && (computerChoice == "scissors" && playerChoice == "paper"))
    {
        Console.WriteLine("Scissors cut paper. Point for PC.");
        computerPoints++;
    }
    else if ((computerChoice != playerChoice) && (computerChoice == "rock" && playerChoice == "paper"))
    {
        Console.WriteLine("Paper covers rock. Point for player.");
        playerPoints++;
    }
    else if ((computerChoice != playerChoice) && (computerChoice == "paper" && playerChoice == "scissors"))
    {
        Console.WriteLine("Scissors cut paper. Point for player.");
        playerPoints++;
    }
    else if ((computerChoice != playerChoice) && (computerChoice == "rock" && playerChoice == "scissors"))
    {
        Console.WriteLine("Rock smashes scissors. Point for PC.");
        computerPoints++;
    }

}

void PlayRound()
{
    string computerChoice = GetRandomPick();
    string playerChoice = GetPlayerPick();
    Console.WriteLine();
    DisplayPicks(playerChoice, computerChoice);
    UpdateScore(playerChoice, computerChoice);
    Console.WriteLine();
}

void DetermineWinner()
{
    Console.WriteLine("FINAL SCORE");
    Console.WriteLine($"Player Points: {playerPoints}");
    Console.WriteLine($"Computer Points: {computerPoints}");

    if (playerPoints > computerPoints)
    {
        Console.WriteLine("PLAYER WINS!");
    }
    else if (playerPoints < computerPoints)
    {
        Console.WriteLine("PC WINS!");
    }
    else if (playerPoints == computerPoints)
    {
        Console.WriteLine("PLAYER AND PC HAVE TIED.");
    }
}