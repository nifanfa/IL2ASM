using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace IL2ASM
{
    public static unsafe partial class Amd64Bridge
    {
        [ILBridge(Code.Bne_Un)]
        public static void Bne_Un(Arch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Bne_Un is not implemented");
        }
    }
}