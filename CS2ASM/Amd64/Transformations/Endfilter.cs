using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Bridge
    {
        [ILTransformation(Code.Endfilter)]
        public static void Endfilter(BaseArch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Endfilter is not implemented");
        }
    }
}