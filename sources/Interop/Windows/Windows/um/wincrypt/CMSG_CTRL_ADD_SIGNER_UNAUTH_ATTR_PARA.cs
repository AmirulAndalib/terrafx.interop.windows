// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CMSG_CTRL_ADD_SIGNER_UNAUTH_ATTR_PARA.xml' path='doc/member[@name="CMSG_CTRL_ADD_SIGNER_UNAUTH_ATTR_PARA"]/*' />
public partial struct CMSG_CTRL_ADD_SIGNER_UNAUTH_ATTR_PARA
{
    /// <include file='CMSG_CTRL_ADD_SIGNER_UNAUTH_ATTR_PARA.xml' path='doc/member[@name="CMSG_CTRL_ADD_SIGNER_UNAUTH_ATTR_PARA.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CMSG_CTRL_ADD_SIGNER_UNAUTH_ATTR_PARA.xml' path='doc/member[@name="CMSG_CTRL_ADD_SIGNER_UNAUTH_ATTR_PARA.dwSignerIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSignerIndex;

    /// <include file='CMSG_CTRL_ADD_SIGNER_UNAUTH_ATTR_PARA.xml' path='doc/member[@name="CMSG_CTRL_ADD_SIGNER_UNAUTH_ATTR_PARA.blob"]/*' />
    public CRYPT_DATA_BLOB blob;
}
