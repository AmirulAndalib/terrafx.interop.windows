// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/httpserv.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='REQUEST_NOTIFICATION_STATUS.xml' path='doc/member[@name="REQUEST_NOTIFICATION_STATUS"]/*' />
public enum REQUEST_NOTIFICATION_STATUS
{
    /// <include file='REQUEST_NOTIFICATION_STATUS.xml' path='doc/member[@name="REQUEST_NOTIFICATION_STATUS.RQ_NOTIFICATION_CONTINUE"]/*' />
    RQ_NOTIFICATION_CONTINUE,

    /// <include file='REQUEST_NOTIFICATION_STATUS.xml' path='doc/member[@name="REQUEST_NOTIFICATION_STATUS.RQ_NOTIFICATION_PENDING"]/*' />
    RQ_NOTIFICATION_PENDING,

    /// <include file='REQUEST_NOTIFICATION_STATUS.xml' path='doc/member[@name="REQUEST_NOTIFICATION_STATUS.RQ_NOTIFICATION_FINISH_REQUEST"]/*' />
    RQ_NOTIFICATION_FINISH_REQUEST,
}
