using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace CS2ASM
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Conv_R4)]
        public static void Conv_R4(BaseArch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Conv_R4 is not implemented");
        }
    }
}
