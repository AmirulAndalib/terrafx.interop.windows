// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct ALLOCATOR_PROPERTIES
    {
        [NativeTypeName("long")]
        public int cBuffers;

        [NativeTypeName("long")]
        public int cbBuffer;

        [NativeTypeName("long")]
        public int cbAlign;

        [NativeTypeName("long")]
        public int cbPrefix;
    }
}
