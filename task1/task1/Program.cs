﻿using System;

int n = 33;
if (n % 2 == 0 && n % 4 == 0)
{
    Console.WriteLine("N is even and it can be divided to 4 and 8");
}
else if (n % 2 != 0 && n % 21 == 0)
{
    Console.WriteLine("N is not even and it can be divided to 3 and 7");
}
else
{
    Console.WriteLine(n);
}