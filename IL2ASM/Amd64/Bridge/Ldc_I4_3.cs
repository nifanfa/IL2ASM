using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace IL2ASM
{
    public static unsafe partial class Amd64Bridge
    {
        [ILBridge(Code.Ldc_I4_3)]
        public static void Ldc_I4_3(Arch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Ldc_I4_3 is not implemented");
        }
    }
}