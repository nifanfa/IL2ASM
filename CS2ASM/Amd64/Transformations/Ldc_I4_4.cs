using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ldc_I4_4)]
        public static void Ldc_I4_4(BaseArch arch, Instruction ins, MethodDef def, Context context)
        {
            Ldc_I4(arch, ins, def, context);
        }
    }
}
