// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='EMRCREATEPEN.xml' path='doc/member[@name="EMRCREATEPEN"]/*' />
public partial struct EMRCREATEPEN
{
    /// <include file='EMRCREATEPEN.xml' path='doc/member[@name="EMRCREATEPEN.emr"]/*' />
    public EMR emr;

    /// <include file='EMRCREATEPEN.xml' path='doc/member[@name="EMRCREATEPEN.ihPen"]/*' />
    [NativeTypeName("DWORD")]
    public uint ihPen;

    /// <include file='EMRCREATEPEN.xml' path='doc/member[@name="EMRCREATEPEN.lopn"]/*' />
    public LOGPEN lopn;
}
