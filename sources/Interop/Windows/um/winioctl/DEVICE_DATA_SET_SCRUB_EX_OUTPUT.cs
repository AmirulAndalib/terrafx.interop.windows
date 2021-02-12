// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DEVICE_DATA_SET_SCRUB_EX_OUTPUT
    {
        [NativeTypeName("DWORDLONG")]
        public ulong BytesProcessed;

        [NativeTypeName("DWORDLONG")]
        public ulong BytesRepaired;

        [NativeTypeName("DWORDLONG")]
        public ulong BytesFailed;

        [NativeTypeName("DEVICE_DSM_RANGE")]
        public DEVICE_DATA_SET_RANGE ParityExtent;
    }
}
