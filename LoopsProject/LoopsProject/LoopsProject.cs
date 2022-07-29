
float startZombies = 1;
float bitesPDay = 4;
float invadeTime = 8;
float totalZombies = 0;

Console.WriteLine("PROBLEM #1");
Problem1();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("PROBLEM #2");
Problem2();

// Problem #1
void Problem1()
{
    for (int currentDay = 0; currentDay < invadeTime; currentDay++)
    {
        if (currentDay == 0)
        {
            totalZombies = startZombies + bitesPDay;
        }
        else
        {
            totalZombies = totalZombies * (startZombies + bitesPDay);
        }


        Console.WriteLine($"There are {totalZombies} zombies at the end of Day #{currentDay + 1}.");
    }
}

//Problem #2  NOTE: (&& cDay < 15) left in while statement to prevent infinite loop

void Problem2()
{
    int cDay = 0;
    while (totalZombies <= 1000000 && cDay < 15)
    {
        cDay++;
        if (cDay == 1)
        {
            totalZombies = startZombies + bitesPDay;
        }
        else
        {
            totalZombies = totalZombies * (startZombies + bitesPDay);
        }
        Console.WriteLine($"On day #{cDay}, there are {totalZombies}!");
    }
}