// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinUser.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct ALTTABINFO
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        public int cItems;

        public int cColumns;

        public int cRows;

        public int iColFocus;

        public int iRowFocus;

        public int cxItem;

        public int cyItem;

        public POINT ptStart;
    }
}
