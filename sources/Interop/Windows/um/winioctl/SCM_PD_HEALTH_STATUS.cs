// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum SCM_PD_HEALTH_STATUS
    {
        ScmPhysicalDeviceHealth_Unknown = 0,
        ScmPhysicalDeviceHealth_Unhealthy,
        ScmPhysicalDeviceHealth_Warning,
        ScmPhysicalDeviceHealth_Healthy,
        ScmPhysicalDeviceHealth_Max,
    }
}
