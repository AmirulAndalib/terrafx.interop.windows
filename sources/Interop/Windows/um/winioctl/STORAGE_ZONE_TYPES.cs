// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum STORAGE_ZONE_TYPES
    {
        ZoneTypeUnknown = 0,
        ZoneTypeConventional = 1,
        ZoneTypeSequentialWriteRequired = 2,
        ZoneTypeSequentialWritePreferred = 3,
        ZoneTypeMax,
    }
}
