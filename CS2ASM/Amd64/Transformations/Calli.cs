using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Bridge
    {
        [ILTransformation(Code.Calli)]
        public static void Calli(BaseArch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Calli is not implemented");
        }
    }
}