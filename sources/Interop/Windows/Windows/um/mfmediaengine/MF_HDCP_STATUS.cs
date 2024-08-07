// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mfmediaengine.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='MF_HDCP_STATUS.xml' path='doc/member[@name="MF_HDCP_STATUS"]/*' />
public enum MF_HDCP_STATUS
{
    /// <include file='MF_HDCP_STATUS.xml' path='doc/member[@name="MF_HDCP_STATUS.MF_HDCP_STATUS_ON"]/*' />
    MF_HDCP_STATUS_ON = 0,

    /// <include file='MF_HDCP_STATUS.xml' path='doc/member[@name="MF_HDCP_STATUS.MF_HDCP_STATUS_OFF"]/*' />
    MF_HDCP_STATUS_OFF = 1,

    /// <include file='MF_HDCP_STATUS.xml' path='doc/member[@name="MF_HDCP_STATUS.MF_HDCP_STATUS_ON_WITH_TYPE_ENFORCEMENT"]/*' />
    MF_HDCP_STATUS_ON_WITH_TYPE_ENFORCEMENT = 2,
}
