using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace IL2ASM
{
    public static unsafe partial class Amd64Bridge
    {
        [ILBridge(Code.Break)]
        public static void Break(Arch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Break is not implemented");
        }
    }
}