using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Bridge
    {
        [ILTransformation(Code.Clt_Un)]
        public static void Clt_Un(BaseArch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Clt_Un is not implemented");
        }
    }
}