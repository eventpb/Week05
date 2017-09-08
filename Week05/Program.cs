using System;
public class TryCatch
{
    static void Main(string[] args)
    {
      
        int a = int.MaxValue;
        try
        a *= 2;
        Console.WriteLine(a);
    }
}