using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Stloc_S)]
        public static void Stloc_S(BaseArch arch, Instruction ins, MethodDef def, Context context)
        {
            Stloc(arch, ins, def, context);
        }
    }
}
