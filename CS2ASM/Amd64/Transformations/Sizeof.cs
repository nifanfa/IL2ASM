using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Bridge
    {
        [ILTransformation(Code.Sizeof)]
        public static void Sizeof(BaseArch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Sizeof is not implemented");
        }
    }
}