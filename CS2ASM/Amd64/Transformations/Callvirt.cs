using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace CS2ASM
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Callvirt)]
        public static void Callvirt(BaseArch arch, Instruction ins, MethodDef def)
        {
            Call(arch, ins, def);
            //throw new NotImplementedException("Callvirt is not implemented");
        }
    }
}
