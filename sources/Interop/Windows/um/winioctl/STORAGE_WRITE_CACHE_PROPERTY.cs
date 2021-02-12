// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct STORAGE_WRITE_CACHE_PROPERTY
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        public WRITE_CACHE_TYPE WriteCacheType;

        public WRITE_CACHE_ENABLE WriteCacheEnabled;

        public WRITE_CACHE_CHANGE WriteCacheChangeable;

        public WRITE_THROUGH WriteThroughSupported;

        [NativeTypeName("BOOLEAN")]
        public byte FlushCacheSupported;

        [NativeTypeName("BOOLEAN")]
        public byte UserDefinedPowerProtection;

        [NativeTypeName("BOOLEAN")]
        public byte NVCacheEnabled;
    }
}
