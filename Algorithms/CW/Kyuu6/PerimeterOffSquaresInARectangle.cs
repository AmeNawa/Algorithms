/****************
Description:

The drawing shows 6 squares the sides of which have a length of 1, 1, 2, 3, 5, 8.
It's easy to see that the sum of the perimeters of these squares is : 4 * (1 + 1 + 2 + 3 + 5 + 8) = 4 * 20 = 80

Say that S(n) is the nth term of the above sum. So

S(0) = 1, S(1) = 1, S(2) = 2, ... , S(5) = 8

Could you give the sum S of the perimeters of all the squares in a rectangle when there are n + 1 squares disposed in the same manner as in the drawing:

S = S(0) + S(1) + ... + S(n) ?

The function perimeter has for parameter n where n + 1 is the number of squares (they are numbered from 0 to n) and returns the total perimeter of all the squares.

perimeter 5   should return 80
perimeter 7   should return 216
****************/
using System;
using System.Numerics;

public class SumFct
{
    public static BigInteger perimeter(BigInteger n)
    {
        BigInteger sumOfFib = 0;

        BigInteger[] arr = new BigInteger[(long)n + 1];
        arr[0] = 1;
        arr[1] = 1;

        for (int i = 2; i < arr.Length; i++)
        {
            arr[i] = arr[i - 2] + arr[i - 1];
        }


        foreach (BigInteger t in arr)
        {
            sumOfFib += t;
        }

        Console.WriteLine("/n---" + sumOfFib);
        return sumOfFib * 4;
    }
}