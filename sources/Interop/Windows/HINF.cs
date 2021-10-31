// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct HINF : IEquatable<HINF>
    {
        public readonly nint Value;

        public HINF(nint value)
        {
            Value = value;
        }

        public static bool operator ==(HINF left, HINF right) => left.Value == right.Value;

        public static bool operator !=(HINF left, HINF right) => left.Value != right.Value;

        public static implicit operator HINF(nint value) => new HINF(value);

        public static implicit operator nint(HINF value) => value.Value;

        public override bool Equals(object? obj) => (obj is HINF other) && Equals(other);

        public bool Equals(HINF other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
