﻿using static System.Runtime.Intrinsic;

namespace System.Platform.Amd64
{
    public static class X64
    {
        public static void Hlt()
        {
            asm("hlt");
        }

        public static byte In8(ushort port)
        {
            byte data = 0;
            asm("mov rdx,{port}");
            asm("xor rax,rax");
            asm("in al,dx");
            asm("mov qword {data},rax");
            return data;
        }

        public static void Out8(ushort port, byte value)
        {
            asm("mov rdx,{port}");
            asm("mov rax,{value}");
            asm("out dx,al");
        }

        public static void Out16(ushort port, ushort value)
        {
            asm("mov rdx,{port}");
            asm("mov rax,{value}");
            asm("out dx,ax");
        }
    }
}