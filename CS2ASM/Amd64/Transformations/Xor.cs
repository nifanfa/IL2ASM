using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Xor)]
        public static void Xor(BaseArch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Xor is not implemented");
        }
    }
}
