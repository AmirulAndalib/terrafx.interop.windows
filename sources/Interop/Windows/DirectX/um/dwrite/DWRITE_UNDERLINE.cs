// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='DWRITE_UNDERLINE.xml' path='doc/member[@name="DWRITE_UNDERLINE"]/*' />
public unsafe partial struct DWRITE_UNDERLINE
{
    /// <include file='DWRITE_UNDERLINE.xml' path='doc/member[@name="DWRITE_UNDERLINE.width"]/*' />
    public float width;

    /// <include file='DWRITE_UNDERLINE.xml' path='doc/member[@name="DWRITE_UNDERLINE.thickness"]/*' />
    public float thickness;

    /// <include file='DWRITE_UNDERLINE.xml' path='doc/member[@name="DWRITE_UNDERLINE.offset"]/*' />
    public float offset;

    /// <include file='DWRITE_UNDERLINE.xml' path='doc/member[@name="DWRITE_UNDERLINE.runHeight"]/*' />
    public float runHeight;

    /// <include file='DWRITE_UNDERLINE.xml' path='doc/member[@name="DWRITE_UNDERLINE.readingDirection"]/*' />
    public DWRITE_READING_DIRECTION readingDirection;

    /// <include file='DWRITE_UNDERLINE.xml' path='doc/member[@name="DWRITE_UNDERLINE.flowDirection"]/*' />
    public DWRITE_FLOW_DIRECTION flowDirection;

    /// <include file='DWRITE_UNDERLINE.xml' path='doc/member[@name="DWRITE_UNDERLINE.localeName"]/*' />
    [NativeTypeName("const WCHAR *")]
    public ushort* localeName;

    /// <include file='DWRITE_UNDERLINE.xml' path='doc/member[@name="DWRITE_UNDERLINE.measuringMode"]/*' />
    public DWRITE_MEASURING_MODE measuringMode;
}
