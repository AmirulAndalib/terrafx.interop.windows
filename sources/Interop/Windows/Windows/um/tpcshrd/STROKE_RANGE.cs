// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/tpcshrd.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Windows;

/// <include file='STROKE_RANGE.xml' path='doc/member[@name="STROKE_RANGE"]/*' />
public partial struct STROKE_RANGE
{
    /// <include file='STROKE_RANGE.xml' path='doc/member[@name="STROKE_RANGE.iStrokeBegin"]/*' />
    [NativeTypeName("ULONG")]
    public uint iStrokeBegin;

    /// <include file='STROKE_RANGE.xml' path='doc/member[@name="STROKE_RANGE.iStrokeEnd"]/*' />
    [NativeTypeName("ULONG")]
    public uint iStrokeEnd;
}
