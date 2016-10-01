/****************
Description:

Middle Earth is about to go to war. The forces of good will have many battles with the forces of evil.
Different races will certainly be involved. Each race has a certain 'worth' when battling against others.
On the side of good we have the following races, with their associated worth:

    Hobbits - 1
    Men - 2
    Elves - 3
    Dwarves - 3
    Eagles - 4
    Wizards - 10

On the side of evil we have:

    Orcs - 1
    Men - 2
    Wargs - 2
    Goblins - 2
    Uruk Hai - 3
    Trolls - 5
    Wizards - 10

Although weather, location, supplies and valor play a part in any battle,
if you add up the worth of the side of good and compare it with the worth of the side of evil,
the side with the larger worth will tend to win.

Thus, given the count of each of the races on the side of good,
followed by the count of each of the races on the side of evil,determine which side wins.
Input:

The function will be given two parameters. Each parameter will be a string separated by a single space.
Each string will contain the count of each race on the side of good and evil.

The first parameter will contain the count of each race on the side of good in the following order:

    Hobbits, Men, Elves, Dwarves, Eagles, Wizards.

The second parameter will contain the count of each race on the side of evil in the following order:

    Orcs, Men, Wargs, Goblins, Uruk Hai, Trolls, Wizards.

All values are non-negative integers. The resulting sum of the worth for each side will not exceed the limit of a 32-bit integer.
Output:

Return ""Battle Result: Good triumphs over Evil" if good wins, "Battle Result: Evil eradicates all trace of Good"
if evil wins, or "Battle Result: No victor on this battle field" if it ends in a tie.
****************/
using System;

public partial class Kata
{

    public static int Power(int[] arr, int side)
    {
        int power = 0;

        if (side == 0)
        {
            power +=
            arr[0] * 1 + arr[1] * 2 + arr[2] * 3 +
            arr[3] * 3 + arr[4] * 4 + arr[5] * 10;
            return power;
        }

        if (side == 1)
        {
            power +=
            arr[0] * 1 + arr[1] * 2 + arr[2] * 2 +
            arr[3] * 2 + arr[4] * 3 + arr[5] * 5 + arr[6] * 10;
            return power;
        }

        else return -1;
    }


    public static string GoodVsEvil(string good, string evil)
    {
        var gWin = "Battle Result: Good triumphs over Evil";
        var eWin = "Battle Result: Evil eradicates all trace of Good";
        var draw = "Battle Result: No victor on this battle field";

        var gStr = good.Split(' ');
        var eStr = evil.Split(' ');

        var gUnits = Array.ConvertAll(gStr, int.Parse);
        var eUnits = Array.ConvertAll(eStr, int.Parse);

        foreach (string s in gStr) Console.WriteLine(s);

        var gPower = Power(gUnits, 0);
        var ePower = Power(eUnits, 1);

        Console.WriteLine(string.Format("\n {0} --- {1}"), gPower, ePower);

        if (gPower == ePower)
        {
            return draw;
        }
        return gPower > ePower ? gWin : eWin;
    }
}