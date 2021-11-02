// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HUIANODE : IComparable, IComparable<HUIANODE>, IEquatable<HUIANODE>, IFormattable
    {
        public readonly nint Value;

        public HUIANODE(nint value)
        {
            Value = value;
        }

        public static HUIANODE INVALID_VALUE => new HUIANODE(-1);

        public static HUIANODE NULL => new HUIANODE(0);

        public static bool operator ==(HUIANODE left, HUIANODE right) => left.Value == right.Value;

        public static bool operator !=(HUIANODE left, HUIANODE right) => left.Value != right.Value;

        public static bool operator <(HUIANODE left, HUIANODE right) => left.Value < right.Value;

        public static bool operator <=(HUIANODE left, HUIANODE right) => left.Value <= right.Value;

        public static bool operator >(HUIANODE left, HUIANODE right) => left.Value > right.Value;

        public static bool operator >=(HUIANODE left, HUIANODE right) => left.Value >= right.Value;

        public static explicit operator HUIANODE(void* value) => new HUIANODE((nint)(value));

        public static implicit operator void*(HUIANODE value) => (void*)(value.Value);

        public static explicit operator HUIANODE(HANDLE value) => new HUIANODE(value);

        public static implicit operator HANDLE(HUIANODE value) => new HANDLE(value.Value);

        public static explicit operator HUIANODE(byte value) => new HUIANODE((nint)(value));

        public static explicit operator byte(HUIANODE value) => (byte)(value.Value);

        public static explicit operator HUIANODE(short value) => new HUIANODE((nint)(value));

        public static explicit operator short(HUIANODE value) => (short)(value.Value);

        public static explicit operator HUIANODE(int value) => new HUIANODE((nint)(value));

        public static explicit operator int(HUIANODE value) => (int)(value.Value);

        public static explicit operator HUIANODE(long value) => new HUIANODE((nint)(value));

        public static implicit operator long(HUIANODE value) => value.Value;

        public static explicit operator HUIANODE(nint value) => new HUIANODE((nint)(value));

        public static implicit operator nint(HUIANODE value) => value.Value;

        public static explicit operator HUIANODE(sbyte value) => new HUIANODE((nint)(value));

        public static explicit operator sbyte(HUIANODE value) => (sbyte)(value.Value);

        public static explicit operator HUIANODE(ushort value) => new HUIANODE((nint)(value));

        public static explicit operator ushort(HUIANODE value) => (ushort)(value.Value);

        public static explicit operator HUIANODE(uint value) => new HUIANODE((nint)(value));

        public static explicit operator uint(HUIANODE value) => (uint)(value.Value);

        public static explicit operator HUIANODE(ulong value) => new HUIANODE((nint)(value));

        public static explicit operator ulong(HUIANODE value) => (ulong)(value.Value);

        public static explicit operator HUIANODE(nuint value) => new HUIANODE((nint)(value));

        public static explicit operator nuint(HUIANODE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HUIANODE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HUIANODE.");
        }

        public int CompareTo(HUIANODE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HUIANODE other) && Equals(other);

        public bool Equals(HUIANODE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
