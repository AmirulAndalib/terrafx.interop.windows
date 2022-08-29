// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTMLWindowState.xml' path='doc/member[@name="HTMLWindowState"]/*' />
public enum HTMLWindowState
{
    /// <include file='HTMLWindowState.xml' path='doc/member[@name="HTMLWindowState.HTMLWindowStateNormal"]/*' />
    HTMLWindowStateNormal = 1,

    /// <include file='HTMLWindowState.xml' path='doc/member[@name="HTMLWindowState.HTMLWindowStateMaximize"]/*' />
    HTMLWindowStateMaximize = 3,

    /// <include file='HTMLWindowState.xml' path='doc/member[@name="HTMLWindowState.HTMLWindowStateMinimize"]/*' />
    HTMLWindowStateMinimize = 6,

    /// <include file='HTMLWindowState.xml' path='doc/member[@name="HTMLWindowState.HTMLWindowState_Max"]/*' />
    HTMLWindowState_Max = 2147483647,
}
