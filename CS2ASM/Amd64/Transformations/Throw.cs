using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Throw)]
        public static void Throw(BaseArch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Throw is not implemented");
        }
    }
}
