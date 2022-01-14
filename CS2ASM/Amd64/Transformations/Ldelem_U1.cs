using dnlib.DotNet;
using dnlib.DotNet.Emit;
using System;

namespace CS2ASM
{
    public static unsafe partial class Amd64Transformation
    {
        [ILTransformation(Code.Ldelem_U1)]
        public static void Ldelem_U1(Context context)
        {
            DoLdelem(context, 1);
        }
    }
}
