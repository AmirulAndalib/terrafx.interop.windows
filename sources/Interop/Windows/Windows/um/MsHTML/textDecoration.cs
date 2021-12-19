// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='textDecoration.xml' path='doc/member[@name="textDecoration"]/*' />
public enum textDecoration
{
    /// <include file='textDecoration.xml' path='doc/member[@name="textDecoration.textDecorationNone"]/*' />
    textDecorationNone = 0,

    /// <include file='textDecoration.xml' path='doc/member[@name="textDecoration.textDecorationUnderline"]/*' />
    textDecorationUnderline = 1,

    /// <include file='textDecoration.xml' path='doc/member[@name="textDecoration.textDecorationOverline"]/*' />
    textDecorationOverline = 2,

    /// <include file='textDecoration.xml' path='doc/member[@name="textDecoration.textDecorationLineThrough"]/*' />
    textDecorationLineThrough = 3,

    /// <include file='textDecoration.xml' path='doc/member[@name="textDecoration.textDecorationBlink"]/*' />
    textDecorationBlink = 4,

    /// <include file='textDecoration.xml' path='doc/member[@name="textDecoration.textDecoration_Max"]/*' />
    textDecoration_Max = 2147483647,
}
