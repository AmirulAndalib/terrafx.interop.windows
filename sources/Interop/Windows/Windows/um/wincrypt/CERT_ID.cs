// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='CERT_ID.xml' path='doc/member[@name="CERT_ID"]/*' />
public partial struct CERT_ID
{
    /// <include file='CERT_ID.xml' path='doc/member[@name="CERT_ID.dwIdChoice"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwIdChoice;

    /// <include file='CERT_ID.xml' path='doc/member[@name="CERT_ID.Anonymous"]/*' />
    [NativeTypeName("_CERT_ID::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.22000.0/um/wincrypt.h:6665:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.IssuerSerialNumber"]/*' />
    [UnscopedRef]
    public ref CERT_ISSUER_SERIAL_NUMBER IssuerSerialNumber
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.IssuerSerialNumber;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.KeyId"]/*' />
    [UnscopedRef]
    public ref CRYPT_DATA_BLOB KeyId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.KeyId;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.HashId"]/*' />
    [UnscopedRef]
    public ref CRYPT_DATA_BLOB HashId
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.HashId;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.IssuerSerialNumber"]/*' />
        [FieldOffset(0)]
        public CERT_ISSUER_SERIAL_NUMBER IssuerSerialNumber;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.KeyId"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("CRYPT_HASH_BLOB")]
        public CRYPT_DATA_BLOB KeyId;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.HashId"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("CRYPT_HASH_BLOB")]
        public CRYPT_DATA_BLOB HashId;
    }
}
