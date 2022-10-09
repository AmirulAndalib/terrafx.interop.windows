// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SoftPub.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO.xml' path='doc/member[@name="WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO"]/*' />
public unsafe partial struct WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO
{
    /// <include file='WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO.xml' path='doc/member[@name="WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO.Anonymous"]/*' />
    [NativeTypeName("_WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO::(anonymous union at C:/Program Files (x86)/Windows Kits/10/include/10.0.22621.0/um/SoftPub.h:133:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO.xml' path='doc/member[@name="WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO.pChainContext"]/*' />
    [NativeTypeName("PCCERT_CHAIN_CONTEXT")]
    public CERT_CHAIN_CONTEXT* pChainContext;

    /// <include file='WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO.xml' path='doc/member[@name="WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO.dwSignerType"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSignerType;

    /// <include file='WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO.xml' path='doc/member[@name="WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO.pMsgSignerInfo"]/*' />
    [NativeTypeName("PCMSG_SIGNER_INFO")]
    public CMSG_SIGNER_INFO* pMsgSignerInfo;

    /// <include file='WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO.xml' path='doc/member[@name="WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO.dwError"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwError;

    /// <include file='WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO.xml' path='doc/member[@name="WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO.cCounterSigner"]/*' />
    [NativeTypeName("DWORD")]
    public uint cCounterSigner;

    /// <include file='WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO.xml' path='doc/member[@name="WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO.rgpCounterSigner"]/*' />
    [NativeTypeName("PWTD_GENERIC_CHAIN_POLICY_SIGNER_INFO *")]
    public WTD_GENERIC_CHAIN_POLICY_SIGNER_INFO** rgpCounterSigner;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cbStruct"]/*' />
    [UnscopedRef]
    public ref uint cbStruct
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.cbStruct;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cbSize"]/*' />
    [UnscopedRef]
    public ref uint cbSize
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.cbSize;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cbStruct"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint cbStruct;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.cbSize"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint cbSize;
    }
}
