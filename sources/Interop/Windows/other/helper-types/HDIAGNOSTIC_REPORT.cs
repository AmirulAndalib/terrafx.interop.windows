// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDIAGNOSTIC_REPORT : IComparable, IComparable<HDIAGNOSTIC_REPORT>, IEquatable<HDIAGNOSTIC_REPORT>, IFormattable
    {
        public readonly nint Value;

        public HDIAGNOSTIC_REPORT(nint value)
        {
            Value = value;
        }

        public static HDIAGNOSTIC_REPORT INVALID_VALUE => new HDIAGNOSTIC_REPORT(-1);

        public static HDIAGNOSTIC_REPORT NULL => new HDIAGNOSTIC_REPORT(0);

        public static bool operator ==(HDIAGNOSTIC_REPORT left, HDIAGNOSTIC_REPORT right) => left.Value == right.Value;

        public static bool operator !=(HDIAGNOSTIC_REPORT left, HDIAGNOSTIC_REPORT right) => left.Value != right.Value;

        public static bool operator <(HDIAGNOSTIC_REPORT left, HDIAGNOSTIC_REPORT right) => left.Value < right.Value;

        public static bool operator <=(HDIAGNOSTIC_REPORT left, HDIAGNOSTIC_REPORT right) => left.Value <= right.Value;

        public static bool operator >(HDIAGNOSTIC_REPORT left, HDIAGNOSTIC_REPORT right) => left.Value > right.Value;

        public static bool operator >=(HDIAGNOSTIC_REPORT left, HDIAGNOSTIC_REPORT right) => left.Value >= right.Value;

        public static explicit operator HDIAGNOSTIC_REPORT(void* value) => new HDIAGNOSTIC_REPORT((nint)(value));

        public static implicit operator void*(HDIAGNOSTIC_REPORT value) => (void*)(value.Value);

        public static explicit operator HDIAGNOSTIC_REPORT(HANDLE value) => new HDIAGNOSTIC_REPORT(value);

        public static implicit operator HANDLE(HDIAGNOSTIC_REPORT value) => new HANDLE(value.Value);

        public static explicit operator HDIAGNOSTIC_REPORT(byte value) => new HDIAGNOSTIC_REPORT((nint)(value));

        public static explicit operator byte(HDIAGNOSTIC_REPORT value) => (byte)(value.Value);

        public static explicit operator HDIAGNOSTIC_REPORT(short value) => new HDIAGNOSTIC_REPORT((nint)(value));

        public static explicit operator short(HDIAGNOSTIC_REPORT value) => (short)(value.Value);

        public static explicit operator HDIAGNOSTIC_REPORT(int value) => new HDIAGNOSTIC_REPORT((nint)(value));

        public static explicit operator int(HDIAGNOSTIC_REPORT value) => (int)(value.Value);

        public static explicit operator HDIAGNOSTIC_REPORT(long value) => new HDIAGNOSTIC_REPORT((nint)(value));

        public static implicit operator long(HDIAGNOSTIC_REPORT value) => value.Value;

        public static explicit operator HDIAGNOSTIC_REPORT(nint value) => new HDIAGNOSTIC_REPORT((nint)(value));

        public static implicit operator nint(HDIAGNOSTIC_REPORT value) => value.Value;

        public static explicit operator HDIAGNOSTIC_REPORT(sbyte value) => new HDIAGNOSTIC_REPORT((nint)(value));

        public static explicit operator sbyte(HDIAGNOSTIC_REPORT value) => (sbyte)(value.Value);

        public static explicit operator HDIAGNOSTIC_REPORT(ushort value) => new HDIAGNOSTIC_REPORT((nint)(value));

        public static explicit operator ushort(HDIAGNOSTIC_REPORT value) => (ushort)(value.Value);

        public static explicit operator HDIAGNOSTIC_REPORT(uint value) => new HDIAGNOSTIC_REPORT((nint)(value));

        public static explicit operator uint(HDIAGNOSTIC_REPORT value) => (uint)(value.Value);

        public static explicit operator HDIAGNOSTIC_REPORT(ulong value) => new HDIAGNOSTIC_REPORT((nint)(value));

        public static explicit operator ulong(HDIAGNOSTIC_REPORT value) => (ulong)(value.Value);

        public static explicit operator HDIAGNOSTIC_REPORT(nuint value) => new HDIAGNOSTIC_REPORT((nint)(value));

        public static explicit operator nuint(HDIAGNOSTIC_REPORT value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HDIAGNOSTIC_REPORT other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HDIAGNOSTIC_REPORT.");
        }

        public int CompareTo(HDIAGNOSTIC_REPORT other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is HDIAGNOSTIC_REPORT other) && Equals(other);

        public bool Equals(HDIAGNOSTIC_REPORT other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);

    }
}
