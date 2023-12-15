// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinBase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='FILE_RENAME_INFO.xml' path='doc/member[@name="FILE_RENAME_INFO"]/*' />
public partial struct FILE_RENAME_INFO
{
    /// <include file='FILE_RENAME_INFO.xml' path='doc/member[@name="FILE_RENAME_INFO.Anonymous"]/*' />
    [NativeTypeName("__AnonymousRecord_winbase_L8984_C5")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='FILE_RENAME_INFO.xml' path='doc/member[@name="FILE_RENAME_INFO.RootDirectory"]/*' />
    public HANDLE RootDirectory;

    /// <include file='FILE_RENAME_INFO.xml' path='doc/member[@name="FILE_RENAME_INFO.FileNameLength"]/*' />
    [NativeTypeName("DWORD")]
    public uint FileNameLength;

    /// <include file='FILE_RENAME_INFO.xml' path='doc/member[@name="FILE_RENAME_INFO.FileName"]/*' />
    [NativeTypeName("WCHAR[1]")]
    public _FileName_e__FixedBuffer FileName;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ReplaceIfExists"]/*' />
    [UnscopedRef]
    public ref byte ReplaceIfExists
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.ReplaceIfExists;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Flags"]/*' />
    [UnscopedRef]
    public ref uint Flags
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Flags;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.ReplaceIfExists"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("BOOLEAN")]
        public byte ReplaceIfExists;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Flags"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint Flags;
    }

    /// <include file='_FileName_e__FixedBuffer.xml' path='doc/member[@name="_FileName_e__FixedBuffer"]/*' />
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
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
