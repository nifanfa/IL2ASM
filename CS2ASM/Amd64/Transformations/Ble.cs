using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ble)]
        public static void Ble(BaseArch arch, Instruction ins, MethodDef def)
        {
            throw new NotImplementedException("Ble is not implemented");
        }
    }
}
