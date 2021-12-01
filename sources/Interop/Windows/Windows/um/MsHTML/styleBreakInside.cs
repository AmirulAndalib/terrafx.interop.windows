// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='styleBreakInside.xml' path='doc/member[@name="styleBreakInside"]/*' />
public enum styleBreakInside
{
    /// <include file='styleBreakInside.xml' path='doc/member[@name="styleBreakInside.styleBreakInsideNotSet"]/*' />
    styleBreakInsideNotSet = 0,

    /// <include file='styleBreakInside.xml' path='doc/member[@name="styleBreakInside.styleBreakInsideAuto"]/*' />
    styleBreakInsideAuto = 1,

    /// <include file='styleBreakInside.xml' path='doc/member[@name="styleBreakInside.styleBreakInsideAvoid"]/*' />
    styleBreakInsideAvoid = 2,

    /// <include file='styleBreakInside.xml' path='doc/member[@name="styleBreakInside.styleBreakInsideAvoidPage"]/*' />
    styleBreakInsideAvoidPage = 3,

    /// <include file='styleBreakInside.xml' path='doc/member[@name="styleBreakInside.styleBreakInsideAvoidColumn"]/*' />
    styleBreakInsideAvoidColumn = 4,

    /// <include file='styleBreakInside.xml' path='doc/member[@name="styleBreakInside.styleBreakInside_Max"]/*' />
    styleBreakInside_Max = 2147483647,
}
