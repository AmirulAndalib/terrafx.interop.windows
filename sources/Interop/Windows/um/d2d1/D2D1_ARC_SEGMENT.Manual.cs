// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1helper.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using static TerraFX.Interop.Windows;

namespace TerraFX.Interop
{
    public partial struct D2D1_ARC_SEGMENT
    {
        public D2D1_ARC_SEGMENT([NativeTypeName("const D2D1_POINT_2F &")] in D2D_POINT_2F point, [NativeTypeName("const D2D1_SIZE_F &")] in D2D_SIZE_F size, [NativeTypeName("FLOAT")] float rotationAngle, D2D1_SWEEP_DIRECTION sweepDirection, D2D1_ARC_SIZE arcSize)
        {
            this = ArcSegment(point, size, rotationAngle, sweepDirection, arcSize);
        }
    }
}
