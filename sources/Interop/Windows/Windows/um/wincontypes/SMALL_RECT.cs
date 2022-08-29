// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincontypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='SMALL_RECT.xml' path='doc/member[@name="SMALL_RECT"]/*' />
public partial struct SMALL_RECT
{
    /// <include file='SMALL_RECT.xml' path='doc/member[@name="SMALL_RECT.Left"]/*' />
    public short Left;

    /// <include file='SMALL_RECT.xml' path='doc/member[@name="SMALL_RECT.Top"]/*' />
    public short Top;

    /// <include file='SMALL_RECT.xml' path='doc/member[@name="SMALL_RECT.Right"]/*' />
    public short Right;

    /// <include file='SMALL_RECT.xml' path='doc/member[@name="SMALL_RECT.Bottom"]/*' />
    public short Bottom;
}
