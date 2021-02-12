// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct ACTIVATION_CONTEXT_QUERY_INDEX
    {
        [NativeTypeName("DWORD")]
        public uint ulAssemblyIndex;

        [NativeTypeName("DWORD")]
        public uint ulFileIndexInAssembly;
    }
}
