// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.Gdiplus;

public partial struct PointF
{
    public static PointF operator+(in PointF self, in PointF point)
    {
        return new PointF(
            self.X + point.X,
            self.Y + point.Y
        );
    }

    public static PointF operator -(in PointF self, in PointF point)
    {
        return new PointF(
            self.X - point.X,
            self.Y - point.Y
        );
    }
}
