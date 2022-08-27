// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='ACTIVATION_CONTEXT_COMPATIBILITY_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_COMPATIBILITY_INFORMATION"]/*' />
public partial struct ACTIVATION_CONTEXT_COMPATIBILITY_INFORMATION
{
    /// <include file='ACTIVATION_CONTEXT_COMPATIBILITY_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_COMPATIBILITY_INFORMATION.ElementCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint ElementCount;

    /// <include file='ACTIVATION_CONTEXT_COMPATIBILITY_INFORMATION.xml' path='doc/member[@name="ACTIVATION_CONTEXT_COMPATIBILITY_INFORMATION.Elements"]/*' />
    [NativeTypeName("COMPATIBILITY_CONTEXT_ELEMENT[]")]
    public _Elements_e__FixedBuffer Elements;

    /// <include file='_Elements_e__FixedBuffer.xml' path='doc/member[@name="_Elements_e__FixedBuffer"]/*' />
    public partial struct _Elements_e__FixedBuffer
    {
        public COMPATIBILITY_CONTEXT_ELEMENT e0;

        public ref COMPATIBILITY_CONTEXT_ELEMENT this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan(int.MaxValue)[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<COMPATIBILITY_CONTEXT_ELEMENT> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }
}
