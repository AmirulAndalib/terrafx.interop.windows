// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Gdiplus;

/// <include file='GpPathData.xml' path='doc/member[@name="GpPathData"]/*' />
public unsafe partial struct GpPathData
{
    /// <include file='GpPathData.xml' path='doc/member[@name="GpPathData.Count"]/*' />
    public int Count;

    /// <include file='GpPathData.xml' path='doc/member[@name="GpPathData.Points"]/*' />
    [NativeTypeName("Gdiplus::PointF *")]
    public GpPointF* Points;

    /// <include file='GpPathData.xml' path='doc/member[@name="GpPathData.Types"]/*' />
    public byte* Types;

    public GpPathData()
    {
        Count = 0;
        Points = null;
        Types = null;
    }
}
