// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

/// <include file='ENLISTMENT_CRM_INFORMATION.xml' path='doc/member[@name="ENLISTMENT_CRM_INFORMATION"]/*' />
public partial struct ENLISTMENT_CRM_INFORMATION
{
    /// <include file='ENLISTMENT_CRM_INFORMATION.xml' path='doc/member[@name="ENLISTMENT_CRM_INFORMATION.CrmTransactionManagerId"]/*' />
    public Guid CrmTransactionManagerId;

    /// <include file='ENLISTMENT_CRM_INFORMATION.xml' path='doc/member[@name="ENLISTMENT_CRM_INFORMATION.CrmResourceManagerId"]/*' />
    public Guid CrmResourceManagerId;

    /// <include file='ENLISTMENT_CRM_INFORMATION.xml' path='doc/member[@name="ENLISTMENT_CRM_INFORMATION.CrmEnlistmentId"]/*' />
    public Guid CrmEnlistmentId;
}
