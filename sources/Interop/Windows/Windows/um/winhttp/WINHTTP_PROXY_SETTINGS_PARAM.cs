// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WINHTTP_PROXY_SETTINGS_PARAM.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_PARAM"]/*' />
public unsafe partial struct WINHTTP_PROXY_SETTINGS_PARAM
{
    /// <include file='WINHTTP_PROXY_SETTINGS_PARAM.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_PARAM.ullFlags"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ullFlags;

    /// <include file='WINHTTP_PROXY_SETTINGS_PARAM.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_PARAM.pcwszConnectionName"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* pcwszConnectionName;

    /// <include file='WINHTTP_PROXY_SETTINGS_PARAM.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_PARAM.pcwszProbeHost"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* pcwszProbeHost;
}
