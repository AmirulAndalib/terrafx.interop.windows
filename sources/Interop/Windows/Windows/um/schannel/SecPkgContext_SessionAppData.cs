// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/schannel.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SecPkgContext_SessionAppData.xml' path='doc/member[@name="SecPkgContext_SessionAppData"]/*' />
public unsafe partial struct SecPkgContext_SessionAppData
{
    /// <include file='SecPkgContext_SessionAppData.xml' path='doc/member[@name="SecPkgContext_SessionAppData.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='SecPkgContext_SessionAppData.xml' path='doc/member[@name="SecPkgContext_SessionAppData.cbAppData"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbAppData;

    /// <include file='SecPkgContext_SessionAppData.xml' path='doc/member[@name="SecPkgContext_SessionAppData.pbAppData"]/*' />
    [NativeTypeName("PBYTE")]
    public byte* pbAppData;
}
