using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Bridge
    {
        [ILBridge(Code.Stelem_Ref)]
        public static void Stelem_Ref(Arch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Stelem_Ref is not implemented");
        }
    }
}