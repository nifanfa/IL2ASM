using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Bridge
    {
        [ILBridge(Code.Or)]
        public static void Or(Arch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Or is not implemented");
        }
    }
}