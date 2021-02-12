// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct CLAIM_SECURITY_ATTRIBUTES_INFORMATION
    {
        [NativeTypeName("WORD")]
        public ushort Version;

        [NativeTypeName("WORD")]
        public ushort Reserved;

        [NativeTypeName("DWORD")]
        public uint AttributeCount;

        [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.19041.0/um/winnt.h:11285:5)")]
        public _Attribute_e__Union Attribute;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _Attribute_e__Union
        {
            [FieldOffset(0)]
            [NativeTypeName("PCLAIM_SECURITY_ATTRIBUTE_V1")]
            public CLAIM_SECURITY_ATTRIBUTE_V1* pAttributeV1;
        }
    }
}
