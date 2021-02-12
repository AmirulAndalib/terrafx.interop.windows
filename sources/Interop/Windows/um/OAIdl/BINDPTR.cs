// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct BINDPTR
    {
        [FieldOffset(0)]
        [NativeTypeName("FUNCDESC *")]
        public FUNCDESC* lpfuncdesc;

        [FieldOffset(0)]
        [NativeTypeName("VARDESC *")]
        public VARDESC* lpvardesc;

        [FieldOffset(0)]
        [NativeTypeName("ITypeComp *")]
        public ITypeComp* lptcomp;
    }
}
