﻿using static System.Runtime.Intrinsic;

namespace System.Platform.Amd64
{
    public class SSE
    {
        static SSE() 
        {
            asm("mov eax, cr0");
            asm("and ax, 0xFFFB");
            asm("or ax, 0x2");
            asm("mov cr0, eax");
            asm("mov eax, cr4");
            asm("or ax, 3 << 9");
            asm("mov cr4, eax");
        }
    }
}
