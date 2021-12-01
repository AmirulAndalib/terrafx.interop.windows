// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DbgHelp.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD64.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD64"]/*' />
public unsafe partial struct IMAGEHLP_DEFERRED_SYMBOL_LOAD64
{
    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD64.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD64.SizeOfStruct"]/*' />
    [NativeTypeName("DWORD")]
    public uint SizeOfStruct;

    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD64.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD64.BaseOfImage"]/*' />
    [NativeTypeName("DWORD64")]
    public ulong BaseOfImage;

    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD64.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD64.CheckSum"]/*' />
    [NativeTypeName("DWORD")]
    public uint CheckSum;

    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD64.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD64.TimeDateStamp"]/*' />
    [NativeTypeName("DWORD")]
    public uint TimeDateStamp;

    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD64.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD64.FileName"]/*' />
    [NativeTypeName("CHAR [260]")]
    public fixed sbyte FileName[260];

    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD64.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD64.Reparse"]/*' />
    [NativeTypeName("BOOLEAN")]
    public byte Reparse;

    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD64.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD64.hFile"]/*' />
    public HANDLE hFile;

    /// <include file='IMAGEHLP_DEFERRED_SYMBOL_LOAD64.xml' path='doc/member[@name="IMAGEHLP_DEFERRED_SYMBOL_LOAD64.Flags"]/*' />
    [NativeTypeName("DWORD")]
    public uint Flags;
}
