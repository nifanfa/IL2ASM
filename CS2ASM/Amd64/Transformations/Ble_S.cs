using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Bridge
    {
        [ILTransformation(Code.Ble_S)]
        public static void Ble_S(BaseArch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Ble_S is not implemented");
        }
    }
}