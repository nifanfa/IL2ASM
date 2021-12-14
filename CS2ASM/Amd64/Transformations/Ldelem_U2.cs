using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace CS2ASM
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ldelem_U2)]
        public static void Ldelem_U2(BaseArch arch, Instruction ins, MethodDef def)
        {
            Ldelem(arch, ins, def);
        }
    }
}
