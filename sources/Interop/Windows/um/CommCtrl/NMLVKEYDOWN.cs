// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/CommCtrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct NMLVKEYDOWN
    {
        public NMHDR hdr;

        [NativeTypeName("WORD")]
        public ushort wVKey;

        [NativeTypeName("UINT")]
        public uint flags;
    }
}