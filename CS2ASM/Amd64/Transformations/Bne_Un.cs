using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace CS2ASM
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Bne_Un)]
        public static void Bne_Un(BaseArch arch, Instruction ins, MethodDef def, Context context)
        {
            context.Append($"pop rdx");
            context.Append($"pop rax");
            context.Append($"cmp rax,rdx");
            context.Append($"jne {Utility.BrLabelName(ins, def)}");
        }
    }
}
