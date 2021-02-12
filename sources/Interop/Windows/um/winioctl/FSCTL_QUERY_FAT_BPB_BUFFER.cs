// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct FSCTL_QUERY_FAT_BPB_BUFFER
    {
        [NativeTypeName("BYTE [36]")]
        public fixed byte First0x24BytesOfBootSector[36];
    }
}
