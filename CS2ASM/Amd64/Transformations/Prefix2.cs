using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Bridge
    {
        [ILTransformation(Code.Prefix2)]
        public static void Prefix2(BaseArch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Prefix2 is not implemented");
        }
    }
}