// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MSV1_0_IUM_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_IUM_SUPPLEMENTAL_CREDENTIAL"]/*' />
public partial struct MSV1_0_IUM_SUPPLEMENTAL_CREDENTIAL
{
    /// <include file='MSV1_0_IUM_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_IUM_SUPPLEMENTAL_CREDENTIAL.Version"]/*' />
    [NativeTypeName("ULONG")]
    public uint Version;

    /// <include file='MSV1_0_IUM_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_IUM_SUPPLEMENTAL_CREDENTIAL.EncryptedCredsSize"]/*' />
    [NativeTypeName("ULONG")]
    public uint EncryptedCredsSize;

    /// <include file='MSV1_0_IUM_SUPPLEMENTAL_CREDENTIAL.xml' path='doc/member[@name="MSV1_0_IUM_SUPPLEMENTAL_CREDENTIAL.EncryptedCreds"]/*' />
    [NativeTypeName("UCHAR[1]")]
    public _EncryptedCreds_e__FixedBuffer EncryptedCreds;

    /// <include file='_EncryptedCreds_e__FixedBuffer.xml' path='doc/member[@name="_EncryptedCreds_e__FixedBuffer"]/*' />
    public partial struct _EncryptedCreds_e__FixedBuffer
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
