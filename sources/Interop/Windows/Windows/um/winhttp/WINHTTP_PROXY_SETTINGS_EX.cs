// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winhttp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WINHTTP_PROXY_SETTINGS_EX.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_EX"]/*' />
public unsafe partial struct WINHTTP_PROXY_SETTINGS_EX
{
    /// <include file='WINHTTP_PROXY_SETTINGS_EX.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_EX.ullGenerationId"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ullGenerationId;

    /// <include file='WINHTTP_PROXY_SETTINGS_EX.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_EX.ullFlags"]/*' />
    [NativeTypeName("ULONGLONG")]
    public ulong ullFlags;

    /// <include file='WINHTTP_PROXY_SETTINGS_EX.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_EX.pcwszAutoconfigUrl"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* pcwszAutoconfigUrl;

    /// <include file='WINHTTP_PROXY_SETTINGS_EX.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_EX.pcwszProxy"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* pcwszProxy;

    /// <include file='WINHTTP_PROXY_SETTINGS_EX.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_EX.pcwszSecureProxy"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* pcwszSecureProxy;

    /// <include file='WINHTTP_PROXY_SETTINGS_EX.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_EX.cProxyBypasses"]/*' />
    [NativeTypeName("DWORD")]
    public uint cProxyBypasses;

    /// <include file='WINHTTP_PROXY_SETTINGS_EX.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_EX.rgpcwszProxyBypasses"]/*' />
    [NativeTypeName("PCWSTR *")]
    public char** rgpcwszProxyBypasses;

    /// <include file='WINHTTP_PROXY_SETTINGS_EX.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_EX.dwInterfaceIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwInterfaceIndex;

    /// <include file='WINHTTP_PROXY_SETTINGS_EX.xml' path='doc/member[@name="WINHTTP_PROXY_SETTINGS_EX.pcwszConnectionName"]/*' />
    [NativeTypeName("PCWSTR")]
    public char* pcwszConnectionName;
}
