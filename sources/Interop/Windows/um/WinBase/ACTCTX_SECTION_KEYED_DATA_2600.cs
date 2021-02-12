// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct ACTCTX_SECTION_KEYED_DATA_2600
    {
        [NativeTypeName("ULONG")]
        public uint cbSize;

        [NativeTypeName("ULONG")]
        public uint ulDataFormatVersion;

        [NativeTypeName("PVOID")]
        public void* lpData;

        [NativeTypeName("ULONG")]
        public uint ulLength;

        [NativeTypeName("PVOID")]
        public void* lpSectionGlobalData;

        [NativeTypeName("ULONG")]
        public uint ulSectionGlobalDataLength;

        [NativeTypeName("PVOID")]
        public void* lpSectionBase;

        [NativeTypeName("ULONG")]
        public uint ulSectionTotalLength;

        [NativeTypeName("HANDLE")]
        public IntPtr hActCtx;

        [NativeTypeName("ULONG")]
        public uint ulAssemblyRosterIndex;
    }
}
