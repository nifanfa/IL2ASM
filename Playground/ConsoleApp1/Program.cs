﻿namespace ConsoleApp1
{
    public static unsafe class Program
    {
        /*
         * Current Progress:
         *  Only static methods supported.
         *  Only local and static variables supported.
         *  Pointers supported.
         *  SByte, Byte, Short, UShort, Int, UInt, Long, ULong, are all supported.
         *  C# basic things (for, if, etc, return, and more) supported.
         *
         *  Allocation is not yet supported!
         */
        public static void Main()
        {
            Console.Setup();
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.Alphabet();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteAt('0', 0, Console.Height - 1); // Draw at 0, 24 (Bottom left)
        }
    }
}
