// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct CO_MTA_USAGE_COOKIE : IComparable, IComparable<CO_MTA_USAGE_COOKIE>, IEquatable<CO_MTA_USAGE_COOKIE>, IFormattable
    {
        public readonly nint Value;

        public CO_MTA_USAGE_COOKIE(nint value)
        {
            Value = value;
        }

        public static CO_MTA_USAGE_COOKIE INVALID_VALUE => new CO_MTA_USAGE_COOKIE(-1);

        public static CO_MTA_USAGE_COOKIE NULL => new CO_MTA_USAGE_COOKIE(0);

        public static bool operator ==(CO_MTA_USAGE_COOKIE left, CO_MTA_USAGE_COOKIE right) => left.Value == right.Value;

        public static bool operator !=(CO_MTA_USAGE_COOKIE left, CO_MTA_USAGE_COOKIE right) => left.Value != right.Value;

        public static bool operator <(CO_MTA_USAGE_COOKIE left, CO_MTA_USAGE_COOKIE right) => left.Value < right.Value;

        public static bool operator <=(CO_MTA_USAGE_COOKIE left, CO_MTA_USAGE_COOKIE right) => left.Value <= right.Value;

        public static bool operator >(CO_MTA_USAGE_COOKIE left, CO_MTA_USAGE_COOKIE right) => left.Value > right.Value;

        public static bool operator >=(CO_MTA_USAGE_COOKIE left, CO_MTA_USAGE_COOKIE right) => left.Value >= right.Value;

        public static explicit operator CO_MTA_USAGE_COOKIE(void* value) => new CO_MTA_USAGE_COOKIE((nint)(value));

        public static implicit operator void*(CO_MTA_USAGE_COOKIE value) => (void*)(value.Value);

        public static explicit operator CO_MTA_USAGE_COOKIE(HANDLE value) => new CO_MTA_USAGE_COOKIE(value);

        public static implicit operator HANDLE(CO_MTA_USAGE_COOKIE value) => new HANDLE(value.Value);

        public static explicit operator CO_MTA_USAGE_COOKIE(byte value) => new CO_MTA_USAGE_COOKIE((nint)(value));

        public static explicit operator byte(CO_MTA_USAGE_COOKIE value) => (byte)(value.Value);

        public static explicit operator CO_MTA_USAGE_COOKIE(short value) => new CO_MTA_USAGE_COOKIE((nint)(value));

        public static explicit operator short(CO_MTA_USAGE_COOKIE value) => (short)(value.Value);

        public static explicit operator CO_MTA_USAGE_COOKIE(int value) => new CO_MTA_USAGE_COOKIE((nint)(value));

        public static explicit operator int(CO_MTA_USAGE_COOKIE value) => (int)(value.Value);

        public static explicit operator CO_MTA_USAGE_COOKIE(long value) => new CO_MTA_USAGE_COOKIE((nint)(value));

        public static implicit operator long(CO_MTA_USAGE_COOKIE value) => value.Value;

        public static explicit operator CO_MTA_USAGE_COOKIE(nint value) => new CO_MTA_USAGE_COOKIE((nint)(value));

        public static implicit operator nint(CO_MTA_USAGE_COOKIE value) => value.Value;

        public static explicit operator CO_MTA_USAGE_COOKIE(sbyte value) => new CO_MTA_USAGE_COOKIE((nint)(value));

        public static explicit operator sbyte(CO_MTA_USAGE_COOKIE value) => (sbyte)(value.Value);

        public static explicit operator CO_MTA_USAGE_COOKIE(ushort value) => new CO_MTA_USAGE_COOKIE((nint)(value));

        public static explicit operator ushort(CO_MTA_USAGE_COOKIE value) => (ushort)(value.Value);

        public static explicit operator CO_MTA_USAGE_COOKIE(uint value) => new CO_MTA_USAGE_COOKIE((nint)(value));

        public static explicit operator uint(CO_MTA_USAGE_COOKIE value) => (uint)(value.Value);

        public static explicit operator CO_MTA_USAGE_COOKIE(ulong value) => new CO_MTA_USAGE_COOKIE((nint)(value));

        public static explicit operator ulong(CO_MTA_USAGE_COOKIE value) => (ulong)(value.Value);

        public static explicit operator CO_MTA_USAGE_COOKIE(nuint value) => new CO_MTA_USAGE_COOKIE((nint)(value));

        public static explicit operator nuint(CO_MTA_USAGE_COOKIE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is CO_MTA_USAGE_COOKIE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of CO_MTA_USAGE_COOKIE.");
        }

        public int CompareTo(CO_MTA_USAGE_COOKIE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is CO_MTA_USAGE_COOKIE other) && Equals(other);

        public bool Equals(CO_MTA_USAGE_COOKIE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
