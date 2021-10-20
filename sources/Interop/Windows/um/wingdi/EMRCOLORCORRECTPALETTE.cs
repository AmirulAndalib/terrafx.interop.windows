// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct EMRCOLORCORRECTPALETTE
    {
        public EMR emr;

        [NativeTypeName("DWORD")]
        public uint ihPalette;

        [NativeTypeName("DWORD")]
        public uint nFirstEntry;

        [NativeTypeName("DWORD")]
        public uint nPalEntries;

        [NativeTypeName("DWORD")]
        public uint nReserved;
    }
}