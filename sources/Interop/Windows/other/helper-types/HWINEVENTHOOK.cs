// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HWINEVENTHOOK : IComparable, IComparable<HWINEVENTHOOK>, IEquatable<HWINEVENTHOOK>, IFormattable
    {
        public readonly nint Value;

        public HWINEVENTHOOK(nint value)
        {
            Value = value;
        }

        public static HWINEVENTHOOK INVALID_VALUE => new HWINEVENTHOOK(-1);

        public static HWINEVENTHOOK NULL => new HWINEVENTHOOK(0);

        public static bool operator ==(HWINEVENTHOOK left, HWINEVENTHOOK right) => left.Value == right.Value;

        public static bool operator !=(HWINEVENTHOOK left, HWINEVENTHOOK right) => left.Value != right.Value;

        public static bool operator <(HWINEVENTHOOK left, HWINEVENTHOOK right) => left.Value < right.Value;

        public static bool operator <=(HWINEVENTHOOK left, HWINEVENTHOOK right) => left.Value <= right.Value;

        public static bool operator >(HWINEVENTHOOK left, HWINEVENTHOOK right) => left.Value > right.Value;

        public static bool operator >=(HWINEVENTHOOK left, HWINEVENTHOOK right) => left.Value >= right.Value;

        public static explicit operator HWINEVENTHOOK(void* value) => new HWINEVENTHOOK((nint)(value));

        public static implicit operator void*(HWINEVENTHOOK value) => (void*)(value.Value);

        public static explicit operator HWINEVENTHOOK(HANDLE value) => new HWINEVENTHOOK(value);

        public static implicit operator HANDLE(HWINEVENTHOOK value) => new HANDLE(value.Value);

        public static explicit operator HWINEVENTHOOK(byte value) => new HWINEVENTHOOK((nint)(value));

        public static explicit operator byte(HWINEVENTHOOK value) => (byte)(value.Value);

        public static explicit operator HWINEVENTHOOK(short value) => new HWINEVENTHOOK((nint)(value));

        public static explicit operator short(HWINEVENTHOOK value) => (short)(value.Value);

        public static explicit operator HWINEVENTHOOK(int value) => new HWINEVENTHOOK((nint)(value));

        public static explicit operator int(HWINEVENTHOOK value) => (int)(value.Value);

        public static explicit operator HWINEVENTHOOK(long value) => new HWINEVENTHOOK((nint)(value));

        public static implicit operator long(HWINEVENTHOOK value) => value.Value;

        public static explicit operator HWINEVENTHOOK(nint value) => new HWINEVENTHOOK((nint)(value));

        public static implicit operator nint(HWINEVENTHOOK value) => value.Value;

        public static explicit operator HWINEVENTHOOK(sbyte value) => new HWINEVENTHOOK((nint)(value));

        public static explicit operator sbyte(HWINEVENTHOOK value) => (sbyte)(value.Value);

        public static explicit operator HWINEVENTHOOK(ushort value) => new HWINEVENTHOOK((nint)(value));

        public static explicit operator ushort(HWINEVENTHOOK value) => (ushort)(value.Value);

        public static explicit operator HWINEVENTHOOK(uint value) => new HWINEVENTHOOK((nint)(value));

        public static explicit operator uint(HWINEVENTHOOK value) => (uint)(value.Value);

        public static explicit operator HWINEVENTHOOK(ulong value) => new HWINEVENTHOOK((nint)(value));

        public static explicit operator ulong(HWINEVENTHOOK value) => (ulong)(value.Value);

        public static explicit operator HWINEVENTHOOK(nuint value) => new HWINEVENTHOOK((nint)(value));

        public static explicit operator nuint(HWINEVENTHOOK value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HWINEVENTHOOK other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HWINEVENTHOOK.");
        }

        public int CompareTo(HWINEVENTHOOK other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HWINEVENTHOOK other) && Equals(other);

        public bool Equals(HWINEVENTHOOK other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
