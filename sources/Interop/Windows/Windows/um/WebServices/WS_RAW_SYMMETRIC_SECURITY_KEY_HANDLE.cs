// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_RAW_SYMMETRIC_SECURITY_KEY_HANDLE.xml' path='doc/member[@name="WS_RAW_SYMMETRIC_SECURITY_KEY_HANDLE"]/*' />
public partial struct WS_RAW_SYMMETRIC_SECURITY_KEY_HANDLE
{
    /// <include file='WS_RAW_SYMMETRIC_SECURITY_KEY_HANDLE.xml' path='doc/member[@name="WS_RAW_SYMMETRIC_SECURITY_KEY_HANDLE.keyHandle"]/*' />
    public WS_SECURITY_KEY_HANDLE keyHandle;

    /// <include file='WS_RAW_SYMMETRIC_SECURITY_KEY_HANDLE.xml' path='doc/member[@name="WS_RAW_SYMMETRIC_SECURITY_KEY_HANDLE.rawKeyBytes"]/*' />
    public WS_BYTES rawKeyBytes;
}
