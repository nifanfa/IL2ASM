﻿namespace ConsoleApp1
{
    public static unsafe class Program
    {
        public static void Main() 
        {
            ulong* index = (ulong*)0xA00000;
            *index = 0;

            PutChar((byte)'H');
            PutChar((byte)'e');
            PutChar((byte)'l');
            PutChar((byte)'l');
            PutChar((byte)'o');
        }

        public static void PutChar(byte chr) 
        {
            ulong* index = (ulong*)0xA00000;
            byte* p = (byte*)(0xb8000 + *index);
            *p = chr;
            *index = *index + 2;
        }

        /*
        public static void ArguTest1(byte b1,byte b2)
        {
            byte* p0 = (byte*)0xb8000;
            *p0 = b1;

            byte* p1 = (byte*)0xb8002;
            *p1 = b2;
        }

        public static void Main()
        {
        Loop:
            Second();
            byte b = ReturnTest();
            byte* p = (byte*)0xb8000;
            *p = b;

            ArguTest(0x42);

            //ArguTest1(0x41, 0x42);

            goto Loop;
        }

        public static void ArguTest(byte b) 
        {
            byte* p = (byte*)0xb8002;
            *p = b;
        }

        public static byte ReturnTest() { return 0x41; }

        public static void Second()
        {
            byte* p = (byte*)0xb8000;

            *p = (byte)'H';
            p += 2;
            *p = (byte)'e';
            p += 2;
            *p = (byte)'l';
            p += 2;
            *p = (byte)'l';
            p += 2;
            *p = (byte)'o';
            p += 2;
            *p = (byte)' ';
            p += 2;
            *p = (byte)'W';
            p += 2;
            *p = (byte)'o';
            p += 2;
            *p = (byte)'r';
            p += 2;
            *p = (byte)'l';
            p += 2;
            *p = (byte)'d';
        }
        */
    }
}
