// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct MT_ARBITRARY_HEADER
    {
        [NativeTypeName("GUID")]
        public Guid majortype;

        [NativeTypeName("GUID")]
        public Guid subtype;

        [NativeTypeName("BOOL")]
        public int bFixedSizeSamples;

        [NativeTypeName("BOOL")]
        public int bTemporalCompression;

        [NativeTypeName("ULONG")]
        public uint lSampleSize;

        [NativeTypeName("GUID")]
        public Guid formattype;
    }
}
