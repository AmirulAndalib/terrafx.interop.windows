// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/OAIdl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public unsafe partial struct VARDESC
    {
        [NativeTypeName("MEMBERID")]
        public int memid;

        [NativeTypeName("LPOLESTR")]
        public ushort* lpstrSchema;

        [NativeTypeName("tagVARDESC::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/OAIdl.h:872:36)")]
        public _Anonymous_e__Union Anonymous;

        public ref uint oInst
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref Anonymous.oInst, 1));
            }
        }

        public ref VARIANT* lpvarValue
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                fixed (_Anonymous_e__Union* pField = &Anonymous)
                {
                    return ref pField->lpvarValue;
                }
            }
        }

        public ELEMDESC elemdescVar;

        [NativeTypeName("WORD")]
        public ushort wVarFlags;

        public VARKIND varkind;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Anonymous_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("ULONG")]
            public uint oInst;

            [FieldOffset(0)]
            [NativeTypeName("VARIANT *")]
            public VARIANT* lpvarValue;
        }
    }
}
