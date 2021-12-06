﻿using CS2ASM.AMD64;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Br_S)]
        public static void Br_S(BaseArch arch, Instruction ins, MethodDef def)
        {
            arch.Append($"jmp {Amd64.BrLabelName(ins, def)}");
        }
    }
}
