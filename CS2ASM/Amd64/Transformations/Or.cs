using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Bridge
    {
        [ILTransformation(Code.Or)]
        public static void Or(BaseArch arch, Instruction ins, MethodDef def)
        {
            arch.Append($"pop rdx");
            arch.Append($"pop rax");
            arch.Append($"or rax,rdx");
            arch.Append($"push rax");
        }
    }
}