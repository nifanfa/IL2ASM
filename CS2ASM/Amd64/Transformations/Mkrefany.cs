using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Bridge
    {
        [ILTransformation(Code.Mkrefany)]
        public static void Mkrefany(BaseArch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Mkrefany is not implemented");
        }
    }
}