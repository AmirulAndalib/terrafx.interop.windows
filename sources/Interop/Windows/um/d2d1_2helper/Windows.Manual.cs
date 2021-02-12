// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_2helper.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [return: NativeTypeName("FLOAT")]
        public static float ComputeFlatteningTolerance([NativeTypeName("const D2D1_MATRIX_3X2_F &")] in D2D_MATRIX_3X2_F matrix, [NativeTypeName("FLOAT")] float dpiX = 96.0f, [NativeTypeName("FLOAT")] float dpiY = 96.0f, [NativeTypeName("FLOAT")] float maxZoomFactor = 1.0f)
        {
            D2D_MATRIX_3X2_F dpiDependentTransform = matrix * D2D_MATRIX_3X2_F.Scale(dpiX / 96.0f, dpiY / 96.0f);
            float absMaxZoomFactor = (maxZoomFactor > 0) ? maxZoomFactor : -maxZoomFactor;

            return D2D1_DEFAULT_FLATTENING_TOLERANCE / (absMaxZoomFactor * D2D1ComputeMaximumScaleFactor(&dpiDependentTransform));
        }
    }
}
