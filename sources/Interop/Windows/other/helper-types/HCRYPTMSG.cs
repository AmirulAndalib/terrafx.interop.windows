// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCRYPTMSG : IComparable, IComparable<HCRYPTMSG>, IEquatable<HCRYPTMSG>, IFormattable
    {
        public readonly nint Value;

        public HCRYPTMSG(nint value)
        {
            Value = value;
        }

        public static HCRYPTMSG INVALID_VALUE => new HCRYPTMSG(-1);

        public static HCRYPTMSG NULL => new HCRYPTMSG(0);

        public static bool operator ==(HCRYPTMSG left, HCRYPTMSG right) => left.Value == right.Value;

        public static bool operator !=(HCRYPTMSG left, HCRYPTMSG right) => left.Value != right.Value;

        public static bool operator <(HCRYPTMSG left, HCRYPTMSG right) => left.Value < right.Value;

        public static bool operator <=(HCRYPTMSG left, HCRYPTMSG right) => left.Value <= right.Value;

        public static bool operator >(HCRYPTMSG left, HCRYPTMSG right) => left.Value > right.Value;

        public static bool operator >=(HCRYPTMSG left, HCRYPTMSG right) => left.Value >= right.Value;

        public static explicit operator HCRYPTMSG(void* value) => new HCRYPTMSG((nint)(value));

        public static implicit operator void*(HCRYPTMSG value) => (void*)(value.Value);

        public static explicit operator HCRYPTMSG(HANDLE value) => new HCRYPTMSG(value);

        public static implicit operator HANDLE(HCRYPTMSG value) => new HANDLE(value.Value);

        public static explicit operator HCRYPTMSG(byte value) => new HCRYPTMSG((nint)(value));

        public static explicit operator byte(HCRYPTMSG value) => (byte)(value.Value);

        public static explicit operator HCRYPTMSG(short value) => new HCRYPTMSG((nint)(value));

        public static explicit operator short(HCRYPTMSG value) => (short)(value.Value);

        public static explicit operator HCRYPTMSG(int value) => new HCRYPTMSG((nint)(value));

        public static explicit operator int(HCRYPTMSG value) => (int)(value.Value);

        public static explicit operator HCRYPTMSG(long value) => new HCRYPTMSG((nint)(value));

        public static implicit operator long(HCRYPTMSG value) => value.Value;

        public static explicit operator HCRYPTMSG(nint value) => new HCRYPTMSG((nint)(value));

        public static implicit operator nint(HCRYPTMSG value) => value.Value;

        public static explicit operator HCRYPTMSG(sbyte value) => new HCRYPTMSG((nint)(value));

        public static explicit operator sbyte(HCRYPTMSG value) => (sbyte)(value.Value);

        public static explicit operator HCRYPTMSG(ushort value) => new HCRYPTMSG((nint)(value));

        public static explicit operator ushort(HCRYPTMSG value) => (ushort)(value.Value);

        public static explicit operator HCRYPTMSG(uint value) => new HCRYPTMSG((nint)(value));

        public static explicit operator uint(HCRYPTMSG value) => (uint)(value.Value);

        public static explicit operator HCRYPTMSG(ulong value) => new HCRYPTMSG((nint)(value));

        public static explicit operator ulong(HCRYPTMSG value) => (ulong)(value.Value);

        public static explicit operator HCRYPTMSG(nuint value) => new HCRYPTMSG((nint)(value));

        public static explicit operator nuint(HCRYPTMSG value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HCRYPTMSG other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HCRYPTMSG.");
        }

        public int CompareTo(HCRYPTMSG other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HCRYPTMSG other) && Equals(other);

        public bool Equals(HCRYPTMSG other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
