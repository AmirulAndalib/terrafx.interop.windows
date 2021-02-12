// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct SP_ORIGINAL_FILE_INFO_W
    {
        [NativeTypeName("DWORD")]
        public uint cbSize;

        [NativeTypeName("WCHAR [260]")]
        public fixed ushort OriginalInfName[260];

        [NativeTypeName("WCHAR [260]")]
        public fixed ushort OriginalCatalogName[260];
    }
}
