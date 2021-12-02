// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='TRUSTEE_A.xml' path='doc/member[@name="TRUSTEE_A"]/*' />
public unsafe partial struct TRUSTEE_A
{
    /// <include file='TRUSTEE_A.xml' path='doc/member[@name="TRUSTEE_A.pMultipleTrustee"]/*' />
    [NativeTypeName("struct _TRUSTEE_A *")]
    public TRUSTEE_A* pMultipleTrustee;

    /// <include file='TRUSTEE_A.xml' path='doc/member[@name="TRUSTEE_A.MultipleTrusteeOperation"]/*' />
    public MULTIPLE_TRUSTEE_OPERATION MultipleTrusteeOperation;

    /// <include file='TRUSTEE_A.xml' path='doc/member[@name="TRUSTEE_A.TrusteeForm"]/*' />
    public TRUSTEE_FORM TrusteeForm;

    /// <include file='TRUSTEE_A.xml' path='doc/member[@name="TRUSTEE_A.TrusteeType"]/*' />
    public TRUSTEE_TYPE TrusteeType;

    /// <include file='TRUSTEE_A.xml' path='doc/member[@name="TRUSTEE_A.ptstrName"]/*' />
    [NativeTypeName("LPCH")]
    public sbyte* ptstrName;
}
