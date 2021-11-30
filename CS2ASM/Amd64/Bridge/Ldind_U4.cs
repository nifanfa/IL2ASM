using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Bridge
    {
        [ILBridge(Code.Ldind_U4)]
        public static void Ldind_U4(Arch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Ldind_U4 is not implemented");
        }
    }
}