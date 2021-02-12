// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct WIN_SPUB_TRUSTED_PUBLISHER_DATA
    {
        [NativeTypeName("HANDLE")]
        public IntPtr hClientToken;

        [NativeTypeName("LPWIN_CERTIFICATE")]
        public WIN_CERTIFICATE* lpCertificate;
    }
}
