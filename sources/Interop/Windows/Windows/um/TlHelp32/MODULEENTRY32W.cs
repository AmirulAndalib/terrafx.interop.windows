// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/TlHelp32.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='MODULEENTRY32W.xml' path='doc/member[@name="MODULEENTRY32W"]/*' />
public unsafe partial struct MODULEENTRY32W
{
    /// <include file='MODULEENTRY32W.xml' path='doc/member[@name="MODULEENTRY32W.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='MODULEENTRY32W.xml' path='doc/member[@name="MODULEENTRY32W.th32ModuleID"]/*' />
    [NativeTypeName("DWORD")]
    public uint th32ModuleID;

    /// <include file='MODULEENTRY32W.xml' path='doc/member[@name="MODULEENTRY32W.th32ProcessID"]/*' />
    [NativeTypeName("DWORD")]
    public uint th32ProcessID;

    /// <include file='MODULEENTRY32W.xml' path='doc/member[@name="MODULEENTRY32W.GlblcntUsage"]/*' />
    [NativeTypeName("DWORD")]
    public uint GlblcntUsage;

    /// <include file='MODULEENTRY32W.xml' path='doc/member[@name="MODULEENTRY32W.ProccntUsage"]/*' />
    [NativeTypeName("DWORD")]
    public uint ProccntUsage;

    /// <include file='MODULEENTRY32W.xml' path='doc/member[@name="MODULEENTRY32W.modBaseAddr"]/*' />
    public byte* modBaseAddr;

    /// <include file='MODULEENTRY32W.xml' path='doc/member[@name="MODULEENTRY32W.modBaseSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint modBaseSize;

    /// <include file='MODULEENTRY32W.xml' path='doc/member[@name="MODULEENTRY32W.hModule"]/*' />
    public HMODULE hModule;

    /// <include file='MODULEENTRY32W.xml' path='doc/member[@name="MODULEENTRY32W.szModule"]/*' />
    [NativeTypeName("WCHAR[256]")]
    public _szModule_e__FixedBuffer szModule;

    /// <include file='MODULEENTRY32W.xml' path='doc/member[@name="MODULEENTRY32W.szExePath"]/*' />
    [NativeTypeName("WCHAR[260]")]
    public _szExePath_e__FixedBuffer szExePath;

    /// <include file='_szModule_e__FixedBuffer.xml' path='doc/member[@name="_szModule_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    public partial struct _szModule_e__FixedBuffer
    {
        public char e0;
    }

    /// <include file='_szExePath_e__FixedBuffer.xml' path='doc/member[@name="_szExePath_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    public partial struct _szExePath_e__FixedBuffer
    {
        public char e0;
    }
}
