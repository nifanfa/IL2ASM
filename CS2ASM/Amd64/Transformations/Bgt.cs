using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Bridge
    {
        [ILTransformation(Code.Bgt)]
        public static void Bgt(BaseArch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Bgt is not implemented");
        }
    }
}