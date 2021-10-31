// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HGLRC : IEquatable<HGLRC>
    {
        public readonly nint Value;

        public HGLRC(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HGLRC left, HGLRC right) => left.Value == right.Value;

        public static bool operator !=(HGLRC left, HGLRC right) => left.Value != right.Value;

        public static implicit operator HGLRC(nint value) => new HGLRC(value);

        public static implicit operator nint(HGLRC value) => value.Value;

        public override bool Equals(object? obj) => (obj is HGLRC other) && Equals(other);

        public bool Equals(HGLRC other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
