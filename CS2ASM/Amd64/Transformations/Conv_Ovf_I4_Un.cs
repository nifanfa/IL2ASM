using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Bridge
    {
        [ILTransformation(Code.Conv_Ovf_I4_Un)]
        public static void Conv_Ovf_I4_Un(BaseArch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Conv_Ovf_I4_Un is not implemented");
        }
    }
}