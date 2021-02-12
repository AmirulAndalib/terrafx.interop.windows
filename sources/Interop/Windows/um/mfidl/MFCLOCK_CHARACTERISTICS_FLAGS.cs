// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MFCLOCK_CHARACTERISTICS_FLAGS
    {
        MFCLOCK_CHARACTERISTICS_FLAG_FREQUENCY_10MHZ = 0x2,
        MFCLOCK_CHARACTERISTICS_FLAG_ALWAYS_RUNNING = 0x4,
        MFCLOCK_CHARACTERISTICS_FLAG_IS_SYSTEM_CLOCK = 0x8,
    }
}
