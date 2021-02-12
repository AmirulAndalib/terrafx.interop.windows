// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PARTITION_INFORMATION_GPT
    {
        [NativeTypeName("GUID")]
        public Guid PartitionType;

        [NativeTypeName("GUID")]
        public Guid PartitionId;

        [NativeTypeName("DWORD64")]
        public ulong Attributes;

        [NativeTypeName("WCHAR [36]")]
        public fixed ushort Name[36];
    }
}
