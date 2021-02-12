// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum STORAGE_RPMB_COMMAND_TYPE
    {
        StorRpmbProgramAuthKey = 0x00000001,
        StorRpmbQueryWriteCounter = 0x00000002,
        StorRpmbAuthenticatedWrite = 0x00000003,
        StorRpmbAuthenticatedRead = 0x00000004,
        StorRpmbReadResultRequest = 0x00000005,
        StorRpmbAuthenticatedDeviceConfigWrite = 0x00000006,
        StorRpmbAuthenticatedDeviceConfigRead = 0x00000007,
    }
}
