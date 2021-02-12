// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct ACTCTX_SECTION_KEYED_DATA_ASSEMBLY_METADATA
    {
        [NativeTypeName("PVOID")]
        public void* lpInformation;

        [NativeTypeName("PVOID")]
        public void* lpSectionBase;

        [NativeTypeName("ULONG")]
        public uint ulSectionLength;

        [NativeTypeName("PVOID")]
        public void* lpSectionGlobalDataBase;

        [NativeTypeName("ULONG")]
        public uint ulSectionGlobalDataLength;
    }
}
