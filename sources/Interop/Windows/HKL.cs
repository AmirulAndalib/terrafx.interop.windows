// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HKL : IEquatable<HKL>
    {
        public readonly nint Value;

        public static HKL NULL => (HKL)(0);

        public HKL(int value)
        {
            Value = ((nint)(value));
        }

        public HKL(uint value)
        {
            Value = ((nint)(value));
        }

        public HKL(nint value)
        {
            Value = ((nint)(value));
        }

        public HKL(nuint value)
        {
            Value = ((nint)(value));
        }

        public HKL(void* value)
        {
            Value = ((nint)(value));
        }

        public HKL(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(HKL left, HKL right) => left.Value == right.Value;

        public static bool operator !=(HKL left, HKL right) => left.Value != right.Value;

        public static explicit operator HKL(int value) => new HKL(value);

        public static explicit operator HKL(uint value) => new HKL(value);

        public static explicit operator HKL(nint value) => new HKL(value);

        public static explicit operator HKL(nuint value) => new HKL(value);

        public static explicit operator HKL(void* value) => new HKL(value);

        public static explicit operator HKL(HANDLE value) => new HKL(value);

        public static explicit operator int(HKL value) => (int)(value.Value);

        public static explicit operator uint(HKL value) => (uint)(value.Value);

        public static implicit operator nint(HKL value) => (nint)(value.Value);

        public static implicit operator nuint(HKL value) => (nuint)(value.Value);

        public static implicit operator void*(HKL value) => (void*)(value.Value);

        public static implicit operator HANDLE(HKL value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is HKL other) && Equals(other);

        public bool Equals(HKL other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
