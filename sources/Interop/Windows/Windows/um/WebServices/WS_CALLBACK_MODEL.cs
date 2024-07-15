// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WS_CALLBACK_MODEL.xml' path='doc/member[@name="WS_CALLBACK_MODEL"]/*' />
public enum WS_CALLBACK_MODEL
{
    /// <include file='WS_CALLBACK_MODEL.xml' path='doc/member[@name="WS_CALLBACK_MODEL.WS_SHORT_CALLBACK"]/*' />
    WS_SHORT_CALLBACK = 0,

    /// <include file='WS_CALLBACK_MODEL.xml' path='doc/member[@name="WS_CALLBACK_MODEL.WS_LONG_CALLBACK"]/*' />
    WS_LONG_CALLBACK = 1,
}
