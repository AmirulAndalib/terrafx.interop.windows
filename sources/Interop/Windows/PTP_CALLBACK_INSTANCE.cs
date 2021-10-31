// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public partial struct PTP_CALLBACK_INSTANCE : IEquatable<PTP_CALLBACK_INSTANCE>
    {
        public readonly nint Value;

        public PTP_CALLBACK_INSTANCE(nint value)
        {
            Value = value;
        }

        public static bool operator ==(PTP_CALLBACK_INSTANCE left, PTP_CALLBACK_INSTANCE right) => left.Value == right.Value;

        public static bool operator !=(PTP_CALLBACK_INSTANCE left, PTP_CALLBACK_INSTANCE right) => left.Value != right.Value;

        public static implicit operator PTP_CALLBACK_INSTANCE(nint value) => new PTP_CALLBACK_INSTANCE(value);

        public static implicit operator nint(PTP_CALLBACK_INSTANCE value) => value.Value;

        public override bool Equals(object? obj) => (obj is PTP_CALLBACK_INSTANCE other) && Equals(other);

        public bool Equals(PTP_CALLBACK_INSTANCE other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();
    }
}
