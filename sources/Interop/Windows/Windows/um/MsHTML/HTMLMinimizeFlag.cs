// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='HTMLMinimizeFlag.xml' path='doc/member[@name="HTMLMinimizeFlag"]/*' />
public enum HTMLMinimizeFlag
{
    /// <include file='HTMLMinimizeFlag.xml' path='doc/member[@name="HTMLMinimizeFlag.HTMLMinimizeFlagNo"]/*' />
    HTMLMinimizeFlagNo = 0,

    /// <include file='HTMLMinimizeFlag.xml' path='doc/member[@name="HTMLMinimizeFlag.HTMLMinimizeFlagYes"]/*' />
    HTMLMinimizeFlagYes = 0x20000,

    /// <include file='HTMLMinimizeFlag.xml' path='doc/member[@name="HTMLMinimizeFlag.HTMLMinimizeFlag_Max"]/*' />
    HTMLMinimizeFlag_Max = 2147483647,
}
