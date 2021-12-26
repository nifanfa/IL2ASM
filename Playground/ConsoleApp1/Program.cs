﻿using System;
using System.Platform.Amd64;
using System.Runtime;
using System.Runtime.CompilerServices;
using static System.Runtime.Intrinsic;

namespace ConsoleApp1
{
    public static unsafe class Program
    {
        public static void Main()
        {
            x64.Out8(0x60, 0x00);
            Banner();

            ulong[] array = new ulong[2];
            array[0] = 123456789;
            array[1] = 54321;

            Console.WriteLine("Welcome to the CS2ASM demo!");
            Console.WriteLine("Owner: nifanfa");
            Console.WriteLine("Contributors: LeonTheDev");

            Console.WriteLine($"array:");
            Console.WriteLine($"Size:");
            Console.WriteLine(array.Size.ToString());
            Console.WriteLine($"Length:");
            Console.WriteLine(((ulong)array.Length).ToString());
            Console.WriteLine($"Value:");
            Console.WriteLine(array[0].ToString());
            Console.WriteLine(array[1].ToString());

            string s = "Hello World";
            ulong p = Unsafe.AddressOf(s);
            Console.WriteLine("Address of s:");
            Console.WriteLine(p.ToString());
            Console.WriteLine(s);
            s.Dispose();

            Console.Write("Boot Time:");
            Console.Write(((ulong)RTC.Year).ToString());
            Console.Write('/');
            Console.Write(((ulong)RTC.Month).ToString());
            Console.Write('/');
            Console.Write(((ulong)RTC.Day).ToString());
            Console.Write(' ');
            Console.Write(((ulong)RTC.Hour).ToString());
            Console.Write(':');
            Console.Write(((ulong)RTC.Minute).ToString());
            Console.WriteLine();

            Console.WriteLine("Current Allocation:");

            for (; ; ) 
            {
                ulong CursorX = Console.CursorX;
                ulong CursorY = Console.CursorY;

                Console.WriteLine(GC.Allocation.ToString());

                Console.CursorX = CursorX;
                Console.CursorY = CursorY;

                x64.Pause();
            }
        }

        public static void Banner()
        {
            Console.BackgroundColor = ConsoleColor.Purple;
            Console.ForegroundColor = ConsoleColor.White;
            for (byte y = 9; y < 16; y++)
            {
                for (byte x = 34; x < 46; x++)
                {
                    Console.WriteAt(' ', x, y);
                }
            }
            Console.WriteAt('.', 38, 12);
            Console.WriteAt('N', 39, 12);
            Console.WriteAt('E', 40, 12);
            Console.WriteAt('T', 41, 12);
            Console.ResetColor();
        }
    }
}
