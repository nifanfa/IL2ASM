using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Bridge
    {
        [ILTransformation(Code.Stind_R8)]
        public static void Stind_R8(BaseArch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Stind_R8 is not implemented");
        }
    }
}