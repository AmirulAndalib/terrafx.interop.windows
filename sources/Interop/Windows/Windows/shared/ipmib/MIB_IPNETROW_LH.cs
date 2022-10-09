// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/ipmib.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='MIB_IPNETROW_LH.xml' path='doc/member[@name="MIB_IPNETROW_LH"]/*' />
public unsafe partial struct MIB_IPNETROW_LH
{
    /// <include file='MIB_IPNETROW_LH.xml' path='doc/member[@name="MIB_IPNETROW_LH.dwIndex"]/*' />
    [NativeTypeName("IF_INDEX")]
    public uint dwIndex;

    /// <include file='MIB_IPNETROW_LH.xml' path='doc/member[@name="MIB_IPNETROW_LH.dwPhysAddrLen"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwPhysAddrLen;

    /// <include file='MIB_IPNETROW_LH.xml' path='doc/member[@name="MIB_IPNETROW_LH.bPhysAddr"]/*' />
    [NativeTypeName("UCHAR[8]")]
    public fixed byte bPhysAddr[8];

    /// <include file='MIB_IPNETROW_LH.xml' path='doc/member[@name="MIB_IPNETROW_LH.dwAddr"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwAddr;

    /// <include file='MIB_IPNETROW_LH.xml' path='doc/member[@name="MIB_IPNETROW_LH.Anonymous"]/*' />
    [NativeTypeName("_MIB_IPNETROW_LH::(anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/shared/ipmib.h:159:5)")]
    public _Anonymous_e__Union Anonymous;

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwType"]/*' />
    [UnscopedRef]
    public ref uint dwType
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.dwType;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Type"]/*' />
    [UnscopedRef]
    public ref MIB_IPNET_TYPE Type
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.Type;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.dwType"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint dwType;

        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.Type"]/*' />
        [FieldOffset(0)]
        public MIB_IPNET_TYPE Type;
    }
}
