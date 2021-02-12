// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct MEASUREITEMSTRUCT
    {
        [NativeTypeName("UINT")]
        public uint CtlType;

        [NativeTypeName("UINT")]
        public uint CtlID;

        [NativeTypeName("UINT")]
        public uint itemID;

        [NativeTypeName("UINT")]
        public uint itemWidth;

        [NativeTypeName("UINT")]
        public uint itemHeight;

        [NativeTypeName("ULONG_PTR")]
        public nuint itemData;
    }
}
