// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

public partial struct SID
{
    /// <include file='SID.xml' path='doc/member[@name="SID.Revision"]/*' />
    public byte Revision;

    /// <include file='SID.xml' path='doc/member[@name="SID.SubAuthorityCount"]/*' />
    public byte SubAuthorityCount;

    /// <include file='SID.xml' path='doc/member[@name="SID.IdentifierAuthority"]/*' />
    public SID_IDENTIFIER_AUTHORITY IdentifierAuthority;

    /// <include file='SID.xml' path='doc/member[@name="SID.SubAuthority"]/*' />
    [NativeTypeName("DWORD[1]")]
    public _SubAuthority_e__FixedBuffer SubAuthority;

    /// <include file='_SubAuthority_e__FixedBuffer.xml' path='doc/member[@name="_SubAuthority_e__FixedBuffer"]/*' />
    public partial struct _SubAuthority_e__FixedBuffer
    {
        public uint e0;

        [UnscopedRef]
        public ref uint this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref Unsafe.Add(ref e0, index);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [UnscopedRef]
        public Span<uint> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
    }

    [NativeTypeName("#define SID_REVISION (1)")]
    public const int SID_REVISION = (1);

    [NativeTypeName("#define SID_MAX_SUB_AUTHORITIES (15)")]
    public const int SID_MAX_SUB_AUTHORITIES = (15);

    [NativeTypeName("#define SID_RECOMMENDED_SUB_AUTHORITIES (1)")]
    public const int SID_RECOMMENDED_SUB_AUTHORITIES = (1);

    [NativeTypeName("#define SID_HASH_SIZE 32")]
    public const int SID_HASH_SIZE = 32;
}
