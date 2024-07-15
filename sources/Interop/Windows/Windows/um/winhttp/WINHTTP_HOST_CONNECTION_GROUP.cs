// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WINHTTP_HOST_CONNECTION_GROUP.xml' path='doc/member[@name="WINHTTP_HOST_CONNECTION_GROUP"]/*' />
public unsafe partial struct WINHTTP_HOST_CONNECTION_GROUP
{
    /// <include file='WINHTTP_HOST_CONNECTION_GROUP.xml' path='doc/member[@name="WINHTTP_HOST_CONNECTION_GROUP.pwszHost"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* pwszHost;

    /// <include file='WINHTTP_HOST_CONNECTION_GROUP.xml' path='doc/member[@name="WINHTTP_HOST_CONNECTION_GROUP.cConnectionGroups"]/*' />
    [NativeTypeName("ULONG")]
    public uint cConnectionGroups;

    /// <include file='WINHTTP_HOST_CONNECTION_GROUP.xml' path='doc/member[@name="WINHTTP_HOST_CONNECTION_GROUP.pConnectionGroups"]/*' />
    [NativeTypeName("PWINHTTP_CONNECTION_GROUP")]
    public WINHTTP_CONNECTION_GROUP* pConnectionGroups;
}
