// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_EXCEPTION_CODE.xml' path='doc/member[@name="WS_EXCEPTION_CODE"]/*' />
public enum WS_EXCEPTION_CODE
{
    /// <include file='WS_EXCEPTION_CODE.xml' path='doc/member[@name="WS_EXCEPTION_CODE.WS_EXCEPTION_CODE_USAGE_FAILURE"]/*' />
    WS_EXCEPTION_CODE_USAGE_FAILURE = unchecked((int)(0xC03D0000)),

    /// <include file='WS_EXCEPTION_CODE.xml' path='doc/member[@name="WS_EXCEPTION_CODE.WS_EXCEPTION_CODE_INTERNAL_FAILURE"]/*' />
    WS_EXCEPTION_CODE_INTERNAL_FAILURE = unchecked((int)(0xc03d0001)),
}
