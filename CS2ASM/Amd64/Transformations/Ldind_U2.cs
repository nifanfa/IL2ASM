using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ldind_U2)]
        public static void Ldind_U2(BaseArch arch, Instruction ins, MethodDef def, Context context)
        {
            Ldind_I2(arch, ins, def, context);
        }
    }
}
