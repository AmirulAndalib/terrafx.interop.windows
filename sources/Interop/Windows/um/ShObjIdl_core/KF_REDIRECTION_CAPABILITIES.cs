// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum KF_REDIRECTION_CAPABILITIES
    {
        KF_REDIRECTION_CAPABILITIES_ALLOW_ALL = 0xff,
        KF_REDIRECTION_CAPABILITIES_REDIRECTABLE = 0x1,
        KF_REDIRECTION_CAPABILITIES_DENY_ALL = 0xfff00,
        KF_REDIRECTION_CAPABILITIES_DENY_POLICY_REDIRECTED = 0x100,
        KF_REDIRECTION_CAPABILITIES_DENY_POLICY = 0x200,
        KF_REDIRECTION_CAPABILITIES_DENY_PERMISSIONS = 0x400,
    }
}
