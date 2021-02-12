// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct CSV_QUERY_MDS_PATH_V2
    {
        [NativeTypeName("LONGLONG")]
        public long Version;

        [NativeTypeName("DWORD")]
        public uint RequiredSize;

        [NativeTypeName("DWORD")]
        public uint MdsNodeId;

        [NativeTypeName("DWORD")]
        public uint DsNodeId;

        [NativeTypeName("DWORD")]
        public uint Flags;

        public CSVFS_DISK_CONNECTIVITY DiskConnectivity;

        [NativeTypeName("GUID")]
        public Guid VolumeId;

        [NativeTypeName("DWORD")]
        public uint IpAddressOffset;

        [NativeTypeName("DWORD")]
        public uint IpAddressLength;

        [NativeTypeName("DWORD")]
        public uint PathOffset;

        [NativeTypeName("DWORD")]
        public uint PathLength;
    }
}
