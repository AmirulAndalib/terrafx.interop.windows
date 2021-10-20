// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct CM_COLUMNINFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("DWORD")]
        public uint dwMask;

        [NativeTypeName("DWORD")]
        public uint dwState;

        [NativeTypeName("UINT")]
        public uint uWidth;

        [NativeTypeName("UINT")]
        public uint uDefaultWidth;

        [NativeTypeName("UINT")]
        public uint uIdealWidth;

        [NativeTypeName("WCHAR [80]")]
        public fixed ushort wszName[80];
    }
}