// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SHFILEOPSTRUCTA.xml' path='doc/member[@name="SHFILEOPSTRUCTA"]/*' />
public unsafe partial struct SHFILEOPSTRUCTA
{
    /// <include file='SHFILEOPSTRUCTA.xml' path='doc/member[@name="SHFILEOPSTRUCTA.hwnd"]/*' />
    public HWND hwnd;

    /// <include file='SHFILEOPSTRUCTA.xml' path='doc/member[@name="SHFILEOPSTRUCTA.wFunc"]/*' />
    public uint wFunc;

    /// <include file='SHFILEOPSTRUCTA.xml' path='doc/member[@name="SHFILEOPSTRUCTA.pFrom"]/*' />
    [NativeTypeName("PCZZSTR")]
    public sbyte* pFrom;

    /// <include file='SHFILEOPSTRUCTA.xml' path='doc/member[@name="SHFILEOPSTRUCTA.pTo"]/*' />
    [NativeTypeName("PCZZSTR")]
    public sbyte* pTo;

    /// <include file='SHFILEOPSTRUCTA.xml' path='doc/member[@name="SHFILEOPSTRUCTA.fFlags"]/*' />
    [NativeTypeName("FILEOP_FLAGS")]
    public ushort fFlags;

    /// <include file='SHFILEOPSTRUCTA.xml' path='doc/member[@name="SHFILEOPSTRUCTA.fAnyOperationsAborted"]/*' />
    public BOOL fAnyOperationsAborted;

    /// <include file='SHFILEOPSTRUCTA.xml' path='doc/member[@name="SHFILEOPSTRUCTA.hNameMappings"]/*' />
    [NativeTypeName("LPVOID")]
    public void* hNameMappings;

    /// <include file='SHFILEOPSTRUCTA.xml' path='doc/member[@name="SHFILEOPSTRUCTA.lpszProgressTitle"]/*' />
    [NativeTypeName("PCSTR")]
    public sbyte* lpszProgressTitle;
}
