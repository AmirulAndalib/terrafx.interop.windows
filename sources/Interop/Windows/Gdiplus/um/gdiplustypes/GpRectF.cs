// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.Gdiplus;

/// <include file='GpRectF.xml' path='doc/member[@name="GpRectF"]/*' />
public unsafe partial struct GpRectF
{
    /// <include file='GpRectF.xml' path='doc/member[@name="GpRectF.X"]/*' />
    [NativeTypeName("Gdiplus::REAL")]
    public float X;

    /// <include file='GpRectF.xml' path='doc/member[@name="GpRectF.Y"]/*' />
    [NativeTypeName("Gdiplus::REAL")]
    public float Y;

    /// <include file='GpRectF.xml' path='doc/member[@name="GpRectF.Width"]/*' />
    [NativeTypeName("Gdiplus::REAL")]
    public float Width;

    /// <include file='GpRectF.xml' path='doc/member[@name="GpRectF.Height"]/*' />
    [NativeTypeName("Gdiplus::REAL")]
    public float Height;

    public GpRectF()
    {
        X = Y = Width = Height = 0.0f;
    }

    public GpRectF([NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y, [NativeTypeName("Gdiplus::REAL")] float width, [NativeTypeName("Gdiplus::REAL")] float height)
    {
        X = x;
        Y = y;
        Width = width;
        Height = height;
    }

    public GpRectF([NativeTypeName("const PointF &")] GpPointF* location, [NativeTypeName("const SizeF &")] GpSizeF* size)
    {
        X = location->X;
        Y = location->Y;
        Width = size->Width;
        Height = size->Height;
    }

    public readonly void GetLocation([NativeTypeName("Gdiplus::PointF *")] GpPointF* point)
    {
        point->X = X;
        point->Y = Y;
    }

    public readonly void GetSize([NativeTypeName("Gdiplus::SizeF *")] GpSizeF* size)
    {
        size->Width = Width;
        size->Height = Height;
    }

    public readonly void GetBounds([NativeTypeName("Gdiplus::RectF *")] GpRectF* rect)
    {
        rect->X = X;
        rect->Y = Y;
        rect->Width = Width;
        rect->Height = Height;
    }

    [return: NativeTypeName("Gdiplus::REAL")]
    public readonly float GetLeft()
    {
        return X;
    }

    [return: NativeTypeName("Gdiplus::REAL")]
    public readonly float GetTop()
    {
        return Y;
    }

    [return: NativeTypeName("Gdiplus::REAL")]
    public readonly float GetRight()
    {
        return X + Width;
    }

    [return: NativeTypeName("Gdiplus::REAL")]
    public readonly float GetBottom()
    {
        return Y + Height;
    }

    public readonly BOOL IsEmptyArea()
    {
        return ((Width <= 1.192092896e-07F) || (Height <= 1.192092896e-07F)) ? 1 : 0;
    }

    public readonly BOOL Equals([NativeTypeName("const RectF &")] GpRectF* rect)
    {
        return (X == rect->X && Y == rect->Y && Width == rect->Width && Height == rect->Height) ? 1 : 0;
    }

    public readonly BOOL Contains([NativeTypeName("Gdiplus::REAL")] float x, [NativeTypeName("Gdiplus::REAL")] float y)
    {
        return (x >= X && x < X + Width && y >= Y && y < Y + Height) ? 1 : 0;
    }

    public readonly BOOL Contains([NativeTypeName("const PointF &")] GpPointF* pt)
    {
        return Contains(pt->X, pt->Y);
    }

    public readonly BOOL Contains([NativeTypeName("const RectF &")] GpRectF* rect)
    {
        return ((X <= rect->X) && (rect->GetRight() <= GetRight()) && (Y <= rect->Y) && (rect->GetBottom() <= GetBottom())) ? 1 : 0;
    }

    public void Inflate([NativeTypeName("Gdiplus::REAL")] float dx, [NativeTypeName("Gdiplus::REAL")] float dy)
    {
        X -= dx;
        Y -= dy;
        Width += 2 * dx;
        Height += 2 * dy;
    }

    public void Inflate([NativeTypeName("const PointF &")] GpPointF* point)
    {
        Inflate(point->X, point->Y);
    }

    public static BOOL Intersect([NativeTypeName("Gdiplus::RectF &")] GpRectF* c, [NativeTypeName("const RectF &")] GpRectF* a, [NativeTypeName("const RectF &")] GpRectF* b)
    {
        float right = (((a->GetRight()) < (b->GetRight())) ? (a->GetRight()) : (b->GetRight()));
        float bottom = (((a->GetBottom()) < (b->GetBottom())) ? (a->GetBottom()) : (b->GetBottom()));
        float left = (((a->GetLeft()) > (b->GetLeft())) ? (a->GetLeft()) : (b->GetLeft()));
        float top = (((a->GetTop()) > (b->GetTop())) ? (a->GetTop()) : (b->GetTop()));

        c->X = left;
        c->Y = top;
        c->Width = right - left;
        c->Height = bottom - top;
        return (c->IsEmptyArea() == 0) ? 1 : 0;
    }

    public readonly BOOL IntersectsWith([NativeTypeName("const RectF &")] GpRectF* rect)
    {
        return (GetLeft() < rect->GetRight() && GetTop() < rect->GetBottom() && GetRight() > rect->GetLeft() && GetBottom() > rect->GetTop()) ? 1 : 0;
    }

    public static BOOL Union([NativeTypeName("Gdiplus::RectF &")] GpRectF* c, [NativeTypeName("const RectF &")] GpRectF* a, [NativeTypeName("const RectF &")] GpRectF* b)
    {
        float right = (((a->GetRight()) > (b->GetRight())) ? (a->GetRight()) : (b->GetRight()));
        float bottom = (((a->GetBottom()) > (b->GetBottom())) ? (a->GetBottom()) : (b->GetBottom()));
        float left = (((a->GetLeft()) < (b->GetLeft())) ? (a->GetLeft()) : (b->GetLeft()));
        float top = (((a->GetTop()) < (b->GetTop())) ? (a->GetTop()) : (b->GetTop()));

        c->X = left;
        c->Y = top;
        c->Width = right - left;
        c->Height = bottom - top;
        return (c->IsEmptyArea() == 0) ? 1 : 0;
    }

    public void Offset([NativeTypeName("const PointF &")] GpPointF* point)
    {
        Offset(point->X, point->Y);
    }

    public void Offset([NativeTypeName("Gdiplus::REAL")] float dx, [NativeTypeName("Gdiplus::REAL")] float dy)
    {
        X += dx;
        Y += dy;
    }
}
