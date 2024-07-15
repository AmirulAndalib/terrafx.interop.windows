// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY.xml' path='doc/member[@name="TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY"]/*' />
public partial struct TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY
{
    /// <include file='TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY.xml' path='doc/member[@name="TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY.Offset"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong Offset;

    /// <include file='TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY.xml' path='doc/member[@name="TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY.NameFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint NameFlags;

    /// <include file='TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY.xml' path='doc/member[@name="TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY.FileId"]/*' />
    [NativeTypeName("LONGLONG")]
    public long FileId;

    /// <include file='TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY.xml' path='doc/member[@name="TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY.Reserved1"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved1;

    /// <include file='TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY.xml' path='doc/member[@name="TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY.Reserved2"]/*' />
    [NativeTypeName("DWORD")]
    public uint Reserved2;

    /// <include file='TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY.xml' path='doc/member[@name="TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY.Reserved3"]/*' />
    [NativeTypeName("LONGLONG")]
    public long Reserved3;

    /// <include file='TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY.xml' path='doc/member[@name="TXFS_LIST_TRANSACTION_LOCKED_FILES_ENTRY.FileName"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public _FileName_e__FixedBuffer FileName;

    /// <include file='_FileName_e__FixedBuffer.xml' path='doc/member[@name="_FileName_e__FixedBuffer"]/*' />
    public partial struct _FileName_e__FixedBuffer
    {
        public char e0;

        [UnscopedRef]
        public ref char this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<char> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
