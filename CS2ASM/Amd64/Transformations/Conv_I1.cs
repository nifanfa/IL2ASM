using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Conv_I1)]
        public static void Conv_I1(BaseArch arch, Instruction ins, MethodDef def)
        {
        }
    }
}
