// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum REFS_SMR_VOLUME_GC_ACTION
    {
        SmrGcActionStart = 1,
        SmrGcActionStartFullSpeed = 2,
        SmrGcActionPause = 3,
        SmrGcActionStop = 4,
    }
}
