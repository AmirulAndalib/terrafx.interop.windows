// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct AASHELLMENUITEM
    {
        public void* lpReserved1;

        public int iReserved;

        [NativeTypeName("UINT")]
        public uint uiReserved;

        [NativeTypeName("LPAASHELLMENUFILENAME")]
        public AASHELLMENUFILENAME* lpName;

        [NativeTypeName("LPWSTR")]
        public ushort* psz;
    }
}