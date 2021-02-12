// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum MFNetAuthenticationFlags
    {
        MFNET_AUTHENTICATION_PROXY = 0x1,
        MFNET_AUTHENTICATION_CLEAR_TEXT = 0x2,
        MFNET_AUTHENTICATION_LOGGED_ON_USER = 0x4,
    }
}
