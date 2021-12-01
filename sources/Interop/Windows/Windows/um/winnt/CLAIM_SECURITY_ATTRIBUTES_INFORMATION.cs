// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;

/// <include file='CLAIM_SECURITY_ATTRIBUTES_INFORMATION.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTES_INFORMATION"]/*' />
[SupportedOSPlatform("windows8.0")]
public partial struct CLAIM_SECURITY_ATTRIBUTES_INFORMATION
{
    /// <include file='CLAIM_SECURITY_ATTRIBUTES_INFORMATION.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTES_INFORMATION.Version"]/*' />
    [NativeTypeName("WORD")]
    public ushort Version;

    /// <include file='CLAIM_SECURITY_ATTRIBUTES_INFORMATION.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTES_INFORMATION.Reserved"]/*' />
    [NativeTypeName("WORD")]
    public ushort Reserved;

    /// <include file='CLAIM_SECURITY_ATTRIBUTES_INFORMATION.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTES_INFORMATION.AttributeCount"]/*' />
    [NativeTypeName("DWORD")]
    public uint AttributeCount;

    /// <include file='CLAIM_SECURITY_ATTRIBUTES_INFORMATION.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTES_INFORMATION.Attribute"]/*' />
    [NativeTypeName("union (anonymous union at C:/Program Files (x86)/Windows Kits/10/Include/10.0.20348.0/um/winnt.h:12264:5)")]
    public _Attribute_e__Union Attribute;

    /// <include file='_Attribute_e__Union.xml' path='doc/member[@name="_Attribute_e__Union"]/*' />
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Attribute_e__Union
    {
        /// <include file='_Attribute_e__Union.xml' path='doc/member[@name="_Attribute_e__Union.pAttributeV1"]/*' />
        [FieldOffset(0)]
        [NativeTypeName("PCLAIM_SECURITY_ATTRIBUTE_V1")]
        public CLAIM_SECURITY_ATTRIBUTE_V1* pAttributeV1;
    }
}
