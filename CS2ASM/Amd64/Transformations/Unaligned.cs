using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Bridge
    {
        [ILTransformation(Code.Unaligned)]
        public static void Unaligned(BaseArch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Unaligned is not implemented");
        }
    }
}