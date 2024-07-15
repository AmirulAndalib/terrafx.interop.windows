// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/thumbcache.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='WTS_ALPHATYPE.xml' path='doc/member[@name="WTS_ALPHATYPE"]/*' />
public enum WTS_ALPHATYPE
{
    /// <include file='WTS_ALPHATYPE.xml' path='doc/member[@name="WTS_ALPHATYPE.WTSAT_UNKNOWN"]/*' />
    WTSAT_UNKNOWN = 0,

    /// <include file='WTS_ALPHATYPE.xml' path='doc/member[@name="WTS_ALPHATYPE.WTSAT_RGB"]/*' />
    WTSAT_RGB = 1,

    /// <include file='WTS_ALPHATYPE.xml' path='doc/member[@name="WTS_ALPHATYPE.WTSAT_ARGB"]/*' />
    WTSAT_ARGB = 2,
}
