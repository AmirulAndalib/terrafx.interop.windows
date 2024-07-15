// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='POINTS.xml' path='doc/member[@name="POINTS"]/*' />
public partial struct POINTS
{
    /// <include file='POINTS.xml' path='doc/member[@name="POINTS.x"]/*' />
    public short x;

    /// <include file='POINTS.xml' path='doc/member[@name="POINTS.y"]/*' />
    public short y;
}
