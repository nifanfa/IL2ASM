using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Bridge
    {
        [ILBridge(Code.Ldelem_I2)]
        public static void Ldelem_I2(Arch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Ldelem_I2 is not implemented");
        }
    }
}