using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace CS2ASM
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Prefixref)]
        public static void Prefixref(BaseArch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Prefixref is not implemented");
        }
    }
}
