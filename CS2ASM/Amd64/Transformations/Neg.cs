using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Bridge
    {
        [ILTransformation(Code.Neg)]
        public static void Neg(BaseArch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Neg is not implemented");
        }
    }
}