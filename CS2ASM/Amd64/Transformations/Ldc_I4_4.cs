using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Bridge
    {
        [ILTransformation(Code.Ldc_I4_4)]
        public static void Ldc_I4_4(BaseArch arch, Instruction ins, MethodDef def)
        {
            arch.Append($"push {OperandParser.Ldc(ins)}");
        }
    }
}