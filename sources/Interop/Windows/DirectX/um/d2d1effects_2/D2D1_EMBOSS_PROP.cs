// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1effects_2.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D2D1_EMBOSS_PROP.xml' path='doc/member[@name="D2D1_EMBOSS_PROP"]/*' />
public enum D2D1_EMBOSS_PROP
{
    /// <include file='D2D1_EMBOSS_PROP.xml' path='doc/member[@name="D2D1_EMBOSS_PROP.D2D1_EMBOSS_PROP_HEIGHT"]/*' />
    D2D1_EMBOSS_PROP_HEIGHT = 0,

    /// <include file='D2D1_EMBOSS_PROP.xml' path='doc/member[@name="D2D1_EMBOSS_PROP.D2D1_EMBOSS_PROP_DIRECTION"]/*' />
    D2D1_EMBOSS_PROP_DIRECTION = 1,

    /// <include file='D2D1_EMBOSS_PROP.xml' path='doc/member[@name="D2D1_EMBOSS_PROP.D2D1_EMBOSS_PROP_FORCE_DWORD"]/*' />
    D2D1_EMBOSS_PROP_FORCE_DWORD = unchecked((int)(0xffffffff)),
}
