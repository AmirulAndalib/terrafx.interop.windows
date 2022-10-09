// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='CMSG_CTRL_DECRYPT_PARA.xml' path='doc/member[@name="CMSG_CTRL_DECRYPT_PARA"]/*' />
public partial struct CMSG_CTRL_DECRYPT_PARA
{
    /// <include file='CMSG_CTRL_DECRYPT_PARA.xml' path='doc/member[@name="CMSG_CTRL_DECRYPT_PARA.cbSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint cbSize;

    /// <include file='CMSG_CTRL_DECRYPT_PARA.xml' path='doc/member[@name="CMSG_CTRL_DECRYPT_PARA.Anonymous"]/*' />
    [NativeTypeName("_CMSG_CTRL_DECRYPT_PARA::(anonymous union at C:/Program Files (x86)/Windows Kits/10/include/10.0.22621.0/um/wincrypt.h:8016:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='CMSG_CTRL_DECRYPT_PARA.xml' path='doc/member[@name="CMSG_CTRL_DECRYPT_PARA.dwKeySpec"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwKeySpec;

    /// <include file='CMSG_CTRL_DECRYPT_PARA.xml' path='doc/member[@name="CMSG_CTRL_DECRYPT_PARA.dwRecipientIndex"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwRecipientIndex;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hCryptProv"]/*' />
    [UnscopedRef]
    public ref HCRYPTPROV hCryptProv
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.hCryptProv;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hNCryptKey"]/*' />
    [UnscopedRef]
    public ref nuint hNCryptKey
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.hNCryptKey;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hCryptProv"]/*' />
        [FieldOffset(0)]
        public HCRYPTPROV hCryptProv;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.hNCryptKey"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("NCRYPT_KEY_HANDLE")]
        public nuint hNCryptKey;
    }
}
