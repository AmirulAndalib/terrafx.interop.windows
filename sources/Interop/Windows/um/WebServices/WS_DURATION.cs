// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct WS_DURATION
    {
        [NativeTypeName("BOOL")]
        public int negative;

        [NativeTypeName("ULONG")]
        public uint years;

        [NativeTypeName("ULONG")]
        public uint months;

        [NativeTypeName("ULONG")]
        public uint days;

        [NativeTypeName("ULONG")]
        public uint hours;

        [NativeTypeName("ULONG")]
        public uint minutes;

        [NativeTypeName("ULONG")]
        public uint seconds;

        [NativeTypeName("ULONG")]
        public uint milliseconds;

        [NativeTypeName("ULONG")]
        public uint ticks;
    }
}
