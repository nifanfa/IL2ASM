﻿using System;
using dnlib.DotNet;
using dnlib.DotNet.Emit;

namespace $NAMESPACE$
{
    public static unsafe partial class $CLASSNAME$
    {
        [ILBridge(Code.$OPCODENAME$)]
        public static void $OPCODENAME$(BaseArch arch, Instruction ins, MethodDef def, Context context)
        {
            $EXCEPTION$
        }
    }
}
