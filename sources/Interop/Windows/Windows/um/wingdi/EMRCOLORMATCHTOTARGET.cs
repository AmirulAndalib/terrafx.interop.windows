// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='EMRCOLORMATCHTOTARGET.xml' path='doc/member[@name="EMRCOLORMATCHTOTARGET"]/*' />
public partial struct EMRCOLORMATCHTOTARGET
{
    /// <include file='EMRCOLORMATCHTOTARGET.xml' path='doc/member[@name="EMRCOLORMATCHTOTARGET.emr"]/*' />
    public EMR emr;

    /// <include file='EMRCOLORMATCHTOTARGET.xml' path='doc/member[@name="EMRCOLORMATCHTOTARGET.dwAction"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAction;

    /// <include file='EMRCOLORMATCHTOTARGET.xml' path='doc/member[@name="EMRCOLORMATCHTOTARGET.dwFlags"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwFlags;

    /// <include file='EMRCOLORMATCHTOTARGET.xml' path='doc/member[@name="EMRCOLORMATCHTOTARGET.cbName"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbName;

    /// <include file='EMRCOLORMATCHTOTARGET.xml' path='doc/member[@name="EMRCOLORMATCHTOTARGET.cbData"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbData;

    /// <include file='EMRCOLORMATCHTOTARGET.xml' path='doc/member[@name="EMRCOLORMATCHTOTARGET.Data"]/*' />
    [NativeTypeName("BYTE[1]")]
    public _Data_e__FixedBuffer Data;

    /// <include file='_Data_e__FixedBuffer.xml' path='doc/member[@name="_Data_e__FixedBuffer"]/*' />
    public partial struct _Data_e__FixedBuffer
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
