// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='CMINVOKECOMMANDINFOEX_REMOTE.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX_REMOTE"]/*' />
public unsafe partial struct CMINVOKECOMMANDINFOEX_REMOTE
{
    /// <include file='CMINVOKECOMMANDINFOEX_REMOTE.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX_REMOTE.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CMINVOKECOMMANDINFOEX_REMOTE.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX_REMOTE.fMask"]/*' />
    [NativeTypeName("DWORD")]
    public uint fMask;

    /// <include file='CMINVOKECOMMANDINFOEX_REMOTE.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX_REMOTE.hwnd"]/*' />
    public HWND hwnd;

    /// <include file='CMINVOKECOMMANDINFOEX_REMOTE.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX_REMOTE.lpVerbString"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* lpVerbString;

    /// <include file='CMINVOKECOMMANDINFOEX_REMOTE.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX_REMOTE.lpParameters"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* lpParameters;

    /// <include file='CMINVOKECOMMANDINFOEX_REMOTE.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX_REMOTE.lpDirectory"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* lpDirectory;

    /// <include file='CMINVOKECOMMANDINFOEX_REMOTE.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX_REMOTE.nShow"]/*' />
    public int nShow;

    /// <include file='CMINVOKECOMMANDINFOEX_REMOTE.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX_REMOTE.dwHotKey"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwHotKey;

    /// <include file='CMINVOKECOMMANDINFOEX_REMOTE.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX_REMOTE.lpTitle"]/*' />
    [NativeTypeName("LPCSTR")]
    public sbyte* lpTitle;

    /// <include file='CMINVOKECOMMANDINFOEX_REMOTE.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX_REMOTE.lpVerbWString"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* lpVerbWString;

    /// <include file='CMINVOKECOMMANDINFOEX_REMOTE.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX_REMOTE.lpParametersW"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* lpParametersW;

    /// <include file='CMINVOKECOMMANDINFOEX_REMOTE.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX_REMOTE.lpDirectoryW"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* lpDirectoryW;

    /// <include file='CMINVOKECOMMANDINFOEX_REMOTE.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX_REMOTE.lpTitleW"]/*' />
    [NativeTypeName("LPCWSTR")]
    public char* lpTitleW;

    /// <include file='CMINVOKECOMMANDINFOEX_REMOTE.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX_REMOTE.ptInvoke"]/*' />
    public POINT ptInvoke;

    /// <include file='CMINVOKECOMMANDINFOEX_REMOTE.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX_REMOTE.lpVerbInt"]/*' />
    public uint lpVerbInt;

    /// <include file='CMINVOKECOMMANDINFOEX_REMOTE.xml' path='doc/member[@name="CMINVOKECOMMANDINFOEX_REMOTE.lpVerbWInt"]/*' />
    public uint lpVerbWInt;
}
