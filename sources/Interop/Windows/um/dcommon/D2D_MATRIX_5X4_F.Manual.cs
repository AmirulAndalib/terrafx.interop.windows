// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1helper.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public partial struct D2D_MATRIX_5X4_F : IEquatable<D2D_MATRIX_5X4_F>
    {
        public static readonly D2D_MATRIX_5X4_F DEFAULT = new D2D_MATRIX_5X4_F(1.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 0.0f);

        public D2D_MATRIX_5X4_F([NativeTypeName("FLOAT")] float m11, [NativeTypeName("FLOAT")] float m12, [NativeTypeName("FLOAT")] float m13, [NativeTypeName("FLOAT")] float m14, [NativeTypeName("FLOAT")] float m21, [NativeTypeName("FLOAT")] float m22, [NativeTypeName("FLOAT")] float m23, [NativeTypeName("FLOAT")] float m24, [NativeTypeName("FLOAT")] float m31, [NativeTypeName("FLOAT")] float m32, [NativeTypeName("FLOAT")] float m33, [NativeTypeName("FLOAT")] float m34, [NativeTypeName("FLOAT")] float m41, [NativeTypeName("FLOAT")] float m42, [NativeTypeName("FLOAT")] float m43, [NativeTypeName("FLOAT")] float m44, [NativeTypeName("FLOAT")] float m51, [NativeTypeName("FLOAT")] float m52, [NativeTypeName("FLOAT")] float m53, [NativeTypeName("FLOAT")] float m54)
        {
            this = default;

            Anonymous.Anonymous._11 = m11;
            Anonymous.Anonymous._12 = m12;
            Anonymous.Anonymous._13 = m13;
            Anonymous.Anonymous._14 = m14;
            Anonymous.Anonymous._21 = m21;
            Anonymous.Anonymous._22 = m22;
            Anonymous.Anonymous._23 = m23;
            Anonymous.Anonymous._24 = m24;
            Anonymous.Anonymous._31 = m31;
            Anonymous.Anonymous._32 = m32;
            Anonymous.Anonymous._33 = m33;
            Anonymous.Anonymous._34 = m34;
            Anonymous.Anonymous._41 = m41;
            Anonymous.Anonymous._42 = m42;
            Anonymous.Anonymous._43 = m43;
            Anonymous.Anonymous._44 = m44;
            Anonymous.Anonymous._51 = m51;
            Anonymous.Anonymous._52 = m52;
            Anonymous.Anonymous._53 = m53;
            Anonymous.Anonymous._54 = m54;
        }

        public static bool operator ==([NativeTypeName("const D2D1_MATRIX_5X4_F &")] in D2D_MATRIX_5X4_F l, [NativeTypeName("const D2D1_MATRIX_5X4_F &")] in D2D_MATRIX_5X4_F r)
        {
            return l.Anonymous.Anonymous._11 == r.Anonymous.Anonymous._11 && l.Anonymous.Anonymous._12 == r.Anonymous.Anonymous._12 && l.Anonymous.Anonymous._13 == r.Anonymous.Anonymous._13 && l.Anonymous.Anonymous._14 == r.Anonymous.Anonymous._14 && l.Anonymous.Anonymous._21 == r.Anonymous.Anonymous._21 && l.Anonymous.Anonymous._22 == r.Anonymous.Anonymous._22 && l.Anonymous.Anonymous._23 == r.Anonymous.Anonymous._23 && l.Anonymous.Anonymous._24 == r.Anonymous.Anonymous._24 && l.Anonymous.Anonymous._31 == r.Anonymous.Anonymous._31 && l.Anonymous.Anonymous._32 == r.Anonymous.Anonymous._32 && l.Anonymous.Anonymous._33 == r.Anonymous.Anonymous._33 && l.Anonymous.Anonymous._34 == r.Anonymous.Anonymous._34 && l.Anonymous.Anonymous._41 == r.Anonymous.Anonymous._41 && l.Anonymous.Anonymous._42 == r.Anonymous.Anonymous._42 && l.Anonymous.Anonymous._43 == r.Anonymous.Anonymous._43 && l.Anonymous.Anonymous._43 == r.Anonymous.Anonymous._44 && l.Anonymous.Anonymous._51 == r.Anonymous.Anonymous._51 && l.Anonymous.Anonymous._52 == r.Anonymous.Anonymous._52 && l.Anonymous.Anonymous._53 == r.Anonymous.Anonymous._53 && l.Anonymous.Anonymous._53 == r.Anonymous.Anonymous._54;
        }

        public static bool operator !=([NativeTypeName("const D2D1_MATRIX_5X4_F &")] in D2D_MATRIX_5X4_F l, [NativeTypeName("const D2D1_MATRIX_5X4_F &")] in D2D_MATRIX_5X4_F r)
        {
            return !(l == r);
        }

        public bool Equals(D2D_MATRIX_5X4_F other) => this == other;

        public override bool Equals(object? obj) => (obj is D2D_MATRIX_5X4_F other) && this == other;

        public override int GetHashCode()
        {
            var hashCode = new HashCode();
            {
                hashCode.Add(Anonymous.Anonymous._11);
                hashCode.Add(Anonymous.Anonymous._12);
                hashCode.Add(Anonymous.Anonymous._13);
                hashCode.Add(Anonymous.Anonymous._14);
                hashCode.Add(Anonymous.Anonymous._21);
                hashCode.Add(Anonymous.Anonymous._22);
                hashCode.Add(Anonymous.Anonymous._23);
                hashCode.Add(Anonymous.Anonymous._24);
                hashCode.Add(Anonymous.Anonymous._31);
                hashCode.Add(Anonymous.Anonymous._32);
                hashCode.Add(Anonymous.Anonymous._33);
                hashCode.Add(Anonymous.Anonymous._34);
                hashCode.Add(Anonymous.Anonymous._41);
                hashCode.Add(Anonymous.Anonymous._42);
                hashCode.Add(Anonymous.Anonymous._43);
                hashCode.Add(Anonymous.Anonymous._44);
                hashCode.Add(Anonymous.Anonymous._51);
                hashCode.Add(Anonymous.Anonymous._52);
                hashCode.Add(Anonymous.Anonymous._53);
                hashCode.Add(Anonymous.Anonymous._54);
            }
            return hashCode.ToHashCode();
        }
    }
}
