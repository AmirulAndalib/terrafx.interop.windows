// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='USERNAME_TARGET_CREDENTIAL_INFO.xml' path='doc/member[@name="USERNAME_TARGET_CREDENTIAL_INFO"]/*' />
public unsafe partial struct USERNAME_TARGET_CREDENTIAL_INFO
{
    /// <include file='USERNAME_TARGET_CREDENTIAL_INFO.xml' path='doc/member[@name="USERNAME_TARGET_CREDENTIAL_INFO.UserName"]/*' />
    [NativeTypeName("LPWSTR")]
    public ushort* UserName;
}
