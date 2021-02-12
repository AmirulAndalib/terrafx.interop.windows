// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct DEVICE_MANAGE_DATA_SET_ATTRIBUTES
    {
        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DEVICE_DSM_ACTION")]
        public uint Action;

        [NativeTypeName("DWORD")]
        public uint Flags;

        [NativeTypeName("DWORD")]
        public uint ParameterBlockOffset;

        [NativeTypeName("DWORD")]
        public uint ParameterBlockLength;

        [NativeTypeName("DWORD")]
        public uint DataSetRangesOffset;

        [NativeTypeName("DWORD")]
        public uint DataSetRangesLength;
    }
}
