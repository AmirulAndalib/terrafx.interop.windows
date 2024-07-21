// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='DCOM_CALL_STATE.xml' path='doc/member[@name="DCOM_CALL_STATE"]/*' />
public enum DCOM_CALL_STATE
{
    /// <include file='DCOM_CALL_STATE.xml' path='doc/member[@name="DCOM_CALL_STATE.DCOM_NONE"]/*' />
    DCOM_NONE = 0,

    /// <include file='DCOM_CALL_STATE.xml' path='doc/member[@name="DCOM_CALL_STATE.DCOM_CALL_COMPLETE"]/*' />
    DCOM_CALL_COMPLETE = 0x1,

    /// <include file='DCOM_CALL_STATE.xml' path='doc/member[@name="DCOM_CALL_STATE.DCOM_CALL_CANCELED"]/*' />
    DCOM_CALL_CANCELED = 0x2,
}
