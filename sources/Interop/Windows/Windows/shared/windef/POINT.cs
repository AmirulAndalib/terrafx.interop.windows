// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='POINT.xml' path='doc/member[@name="POINT"]/*' />
public partial struct POINT
{
    /// <include file='POINT.xml' path='doc/member[@name="POINT.x"]/*' />
    [NativeTypeName("LONG")]
    public int x;

    /// <include file='POINT.xml' path='doc/member[@name="POINT.y"]/*' />
    [NativeTypeName("LONG")]
    public int y;
}
