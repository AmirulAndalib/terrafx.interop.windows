// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/heapapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct HEAP_SUMMARY
    {
        [NativeTypeName("DWORD")]
        public uint cb;

        [NativeTypeName("SIZE_T")]
        public nuint cbAllocated;

        [NativeTypeName("SIZE_T")]
        public nuint cbCommitted;

        [NativeTypeName("SIZE_T")]
        public nuint cbReserved;

        [NativeTypeName("SIZE_T")]
        public nuint cbMaxReserve;
    }
}
