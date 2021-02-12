// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct STORAGE_DEVICE_NUMBER_EX
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint DeviceType;

        [NativeTypeName("DWORD")]
        public uint DeviceNumber;

        [NativeTypeName("GUID")]
        public Guid DeviceGuid;

        [NativeTypeName("DWORD")]
        public uint PartitionNumber;
    }
}
