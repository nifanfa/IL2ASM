using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Bridge
    {
        [ILTransformation(Code.Bgt_Un)]
        public static void Bgt_Un(BaseArch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Bgt_Un is not implemented");
        }
    }
}