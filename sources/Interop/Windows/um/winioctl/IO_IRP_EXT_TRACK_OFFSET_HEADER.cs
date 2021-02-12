// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct IO_IRP_EXT_TRACK_OFFSET_HEADER
    {
        [NativeTypeName("WORD")]
        public ushort Validation;

        [NativeTypeName("WORD")]
        public ushort Flags;

        [NativeTypeName("PIO_IRP_EXT_PROCESS_TRACKED_OFFSET_CALLBACK")]
        public delegate* unmanaged<IO_IRP_EXT_TRACK_OFFSET_HEADER*, IO_IRP_EXT_TRACK_OFFSET_HEADER*, long, void> TrackedOffsetCallback;
    }
}
