using CS2ASM.AMD64;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace CS2ASM
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Stsfld)]
        public static void Stsfld(BaseArch arch, Instruction ins, MethodDef def, Context context)
        {
            context.Append($"pop rax");
            context.Append($"mov [{Utility.SafeFieldName(((FieldDef)ins.Operand).DeclaringType, (FieldDef)ins.Operand)}],rax");
        }
    }
}
