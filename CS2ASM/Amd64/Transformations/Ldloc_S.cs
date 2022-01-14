using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ldloc_S)]
        public static void Ldloc_S(BaseArch arch, Instruction ins, MethodDef def, Context context)
        {
            Ldloc(arch, ins, def, context);
        }
    }
}
