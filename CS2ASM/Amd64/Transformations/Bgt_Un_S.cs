using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace CS2ASM
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Bgt_Un_S)]
        public static void Bgt_Un_S(BaseArch arch, Instruction ins, MethodDef def, Context context)
        {
            throw new NotImplementedException("Bgt_Un_S is not implemented");
        }
    }
}
