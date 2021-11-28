using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace IL2ASM
{
    public static unsafe partial class Amd64Bridge
    {
        [ILBridge(Code.Ble_S)]
        public static void Ble_S(Arch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Ble_S is not implemented");
        }
    }
}