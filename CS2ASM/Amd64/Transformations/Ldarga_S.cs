using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace CS2ASM
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ldarga_S)]
        public static void Ldarga_S(BaseArch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Ldarga_S is not implemented");
        }
    }
}
