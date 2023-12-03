// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/wtypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='userBITMAP.xml' path='doc/member[@name="userBITMAP"]/*' />
public partial struct userBITMAP
{
    /// <include file='userBITMAP.xml' path='doc/member[@name="userBITMAP.bmType"]/*' />
    [NativeTypeName("LONG")]
    public int bmType;

    /// <include file='userBITMAP.xml' path='doc/member[@name="userBITMAP.bmWidth"]/*' />
    [NativeTypeName("LONG")]
    public int bmWidth;

    /// <include file='userBITMAP.xml' path='doc/member[@name="userBITMAP.bmHeight"]/*' />
    [NativeTypeName("LONG")]
    public int bmHeight;

    /// <include file='userBITMAP.xml' path='doc/member[@name="userBITMAP.bmWidthBytes"]/*' />
    [NativeTypeName("LONG")]
    public int bmWidthBytes;

    /// <include file='userBITMAP.xml' path='doc/member[@name="userBITMAP.bmPlanes"]/*' />
    [NativeTypeName("WORD")]
    public ushort bmPlanes;

    /// <include file='userBITMAP.xml' path='doc/member[@name="userBITMAP.bmBitsPixel"]/*' />
    [NativeTypeName("WORD")]
    public ushort bmBitsPixel;

    /// <include file='userBITMAP.xml' path='doc/member[@name="userBITMAP.cbSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint cbSize;

    /// <include file='userBITMAP.xml' path='doc/member[@name="userBITMAP.pBuffer"]/*' />
    [NativeTypeName("byte[1]")]
    public _pBuffer_e__FixedBuffer pBuffer;

    /// <include file='_pBuffer_e__FixedBuffer.xml' path='doc/member[@name="_pBuffer_e__FixedBuffer"]/*' />
    public partial struct _pBuffer_e__FixedBuffer
    {
        public byte e0;

        [UnscopedRef]
        public ref byte this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<byte> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
