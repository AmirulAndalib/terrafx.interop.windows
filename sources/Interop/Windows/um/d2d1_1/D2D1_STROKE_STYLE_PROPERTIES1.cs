// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct D2D1_STROKE_STYLE_PROPERTIES1
    {
        public D2D1_CAP_STYLE startCap;

        public D2D1_CAP_STYLE endCap;

        public D2D1_CAP_STYLE dashCap;

        public D2D1_LINE_JOIN lineJoin;

        [NativeTypeName("FLOAT")]
        public float miterLimit;

        public D2D1_DASH_STYLE dashStyle;

        [NativeTypeName("FLOAT")]
        public float dashOffset;

        public D2D1_STROKE_TRANSFORM_TYPE transformType;
    }
}
