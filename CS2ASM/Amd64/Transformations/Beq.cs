using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Beq)]
        public static void Beq(BaseArch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Beq is not implemented");
        }
    }
}
