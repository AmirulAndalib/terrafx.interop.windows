// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct EMREXTSELECTCLIPRGN
    {
        public EMR emr;

        [NativeTypeName("DWORD")]
        public uint cbRgnData;

        [NativeTypeName("DWORD")]
        public uint iMode;

        [NativeTypeName("BYTE [1]")]
        public fixed byte RgnData[1];
    }
}
