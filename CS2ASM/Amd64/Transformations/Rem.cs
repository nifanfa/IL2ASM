using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace CS2ASM
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Rem)]
        public static void Rem(BaseArch arch, Instruction ins, MethodDef def)
        {
            arch.Append($"xor rdx,rdx");
            arch.Append($"pop r8");
            arch.Append($"pop rax");
            arch.Append($"idiv r8");
            arch.Append($"push rdx");
        }
    }
}
