// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='DWRITE_FLOW_DIRECTION.xml' path='doc/member[@name="DWRITE_FLOW_DIRECTION"]/*' />
public enum DWRITE_FLOW_DIRECTION
{
    /// <include file='DWRITE_FLOW_DIRECTION.xml' path='doc/member[@name="DWRITE_FLOW_DIRECTION.DWRITE_FLOW_DIRECTION_TOP_TO_BOTTOM"]/*' />
    DWRITE_FLOW_DIRECTION_TOP_TO_BOTTOM = 0,

    /// <include file='DWRITE_FLOW_DIRECTION.xml' path='doc/member[@name="DWRITE_FLOW_DIRECTION.DWRITE_FLOW_DIRECTION_BOTTOM_TO_TOP"]/*' />
    DWRITE_FLOW_DIRECTION_BOTTOM_TO_TOP = 1,

    /// <include file='DWRITE_FLOW_DIRECTION.xml' path='doc/member[@name="DWRITE_FLOW_DIRECTION.DWRITE_FLOW_DIRECTION_LEFT_TO_RIGHT"]/*' />
    DWRITE_FLOW_DIRECTION_LEFT_TO_RIGHT = 2,

    /// <include file='DWRITE_FLOW_DIRECTION.xml' path='doc/member[@name="DWRITE_FLOW_DIRECTION.DWRITE_FLOW_DIRECTION_RIGHT_TO_LEFT"]/*' />
    DWRITE_FLOW_DIRECTION_RIGHT_TO_LEFT = 3,
}
