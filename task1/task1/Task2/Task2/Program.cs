using System;

int x = 1, y = 2, z = 3;
if (x < y && x < z)
{
    Console.WriteLine("X is the minimum number");
}
else if (y < z && y < x)
{
    Console.WriteLine("Y is the minimum number");
}
else if (z < y && z < x)
{
    Console.WriteLine("Z is the minimum number");
}
else if (x == y == z)
{
    Console.WriteLine("All the numbers are the same");
}
