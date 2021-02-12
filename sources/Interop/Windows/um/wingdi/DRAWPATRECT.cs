// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DRAWPATRECT
    {
        public POINT ptPosition;

        public POINT ptSize;

        [NativeTypeName("WORD")]
        public ushort wStyle;

        [NativeTypeName("WORD")]
        public ushort wPattern;
    }
}
