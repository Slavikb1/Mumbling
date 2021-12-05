using System;

namespace Mumbling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a string!");
            string Accum = Console.ReadLine();
            char[] breakeDown = Accum.ToCharArray();

            for (int i = 0; i < breakeDown.Length; i++)
            {
                for (int j = 0; j < i+1; j++)
                {
                   if (j==0 && i==0)
                    {
                        Console.Write(breakeDown[i].ToString().ToUpper());
                    }
                   else if (j == 0)
                    {
                        Console.Write(breakeDown[i].ToString().ToUpper());
                    }
                    else
                    {
                        Console.Write((breakeDown[i]).ToString().ToLower());
                    }
                }
                if (i!= breakeDown.Length-1)
                {
                    Console.Write("-");
                }
            }
        }
    }
}
