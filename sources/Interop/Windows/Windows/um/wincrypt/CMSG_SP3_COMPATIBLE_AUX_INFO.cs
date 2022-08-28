// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CMSG_SP3_COMPATIBLE_AUX_INFO.xml' path='doc/member[@name="CMSG_SP3_COMPATIBLE_AUX_INFO"]/*' />
public partial struct CMSG_SP3_COMPATIBLE_AUX_INFO
{
    /// <include file='CMSG_SP3_COMPATIBLE_AUX_INFO.xml' path='doc/member[@name="CMSG_SP3_COMPATIBLE_AUX_INFO.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CMSG_SP3_COMPATIBLE_AUX_INFO.xml' path='doc/member[@name="CMSG_SP3_COMPATIBLE_AUX_INFO.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;
}
