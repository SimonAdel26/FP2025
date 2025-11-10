#region Game

Coins();

static void Coins()
{
    int stake;
    int goal;
    int times = 10000;
    int wins = 0, losses = 0;


    Random rnd = new Random();

    for (int i = 1; i <= times; i++)
    {
        stake = 70;
        goal = 100;

        while (!(stake == 0 || goal == stake))
            if (rnd.Next(2) == 0)
                stake++;
            else
                stake--;

        if (stake == 0)
            losses++;
        else if (stake == goal)
            wins++;
    }

    Console.WriteLine($"Wins: {wins}, Losses: {losses}");
}
#endregion


#region DateTime
DateTime azi = DateTime.Now;
DateTime maine = azi.AddDays(1);
Console.WriteLine(azi);
Console.WriteLine(azi.Hour);
Console.WriteLine(azi.AddHours(42));
Console.WriteLine(azi.ToShortDateString());
Console.WriteLine(azi.ToShortTimeString());
Console.WriteLine(maine.Subtract(azi).TotalHours);
Console.WriteLine(maine.Subtract(azi).TotalMinutes);




int a1 = 2025, l1 = 11, z1 = 4;
int a2 = 2006, l2 = 7, z2 = 6;

Console.WriteLine($"Numarul de zile dintre cele doua date este {DaysDiff((a1, l1, z1), (a2, l2, z2))}");

int DaysDiff((int a, int l, int z) date1, (int a, int l, int z) date2)
{
    int result = 0;

    while (!(date1.a == date2.a && date1.l == date2.l && date1.z == date2.z))
    {
        result++;
        // scad o zi din date1
        if (date1.z > 1)
            date1.z--;
        else
        {
            switch (date1.l)
            {
                case 2:
                case 4:
                case 6:
                case 8:
                case 9:
                case 11:
                    date1.z = 31;
                    date1.l--;
                    break;
                case 1:
                    date1.z = 31;
                    date1.l = 12;
                    date1.a--;
                    break;
                case 3:
                    date1.z = 28;
                    if (bisect(date1.a))
                        date1.z++;
                    date1.l--;
                    break;
                case 5:
                case 7:
                case 10:
                case 12:
                    date1.z = 30;
                    date1.l--;
                    break;
            }
        }
    }


    return result;
}

bool bisect(int a)
{
    return (a % 4 == 0 && a % 100 != 0) || (a % 400 == 0);
}
#endregion

