// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct SPPHRASERULEHANDLE : IComparable, IComparable<SPPHRASERULEHANDLE>, IEquatable<SPPHRASERULEHANDLE>, IFormattable
    {
        public readonly nint Value;

        public SPPHRASERULEHANDLE(nint value)
        {
            Value = value;
        }

        public static SPPHRASERULEHANDLE INVALID_VALUE => new SPPHRASERULEHANDLE(-1);

        public static SPPHRASERULEHANDLE NULL => new SPPHRASERULEHANDLE(0);

        public static bool operator ==(SPPHRASERULEHANDLE left, SPPHRASERULEHANDLE right) => left.Value == right.Value;

        public static bool operator !=(SPPHRASERULEHANDLE left, SPPHRASERULEHANDLE right) => left.Value != right.Value;

        public static bool operator <(SPPHRASERULEHANDLE left, SPPHRASERULEHANDLE right) => left.Value < right.Value;

        public static bool operator <=(SPPHRASERULEHANDLE left, SPPHRASERULEHANDLE right) => left.Value <= right.Value;

        public static bool operator >(SPPHRASERULEHANDLE left, SPPHRASERULEHANDLE right) => left.Value > right.Value;

        public static bool operator >=(SPPHRASERULEHANDLE left, SPPHRASERULEHANDLE right) => left.Value >= right.Value;

        public static explicit operator SPPHRASERULEHANDLE(void* value) => new SPPHRASERULEHANDLE((nint)(value));

        public static implicit operator void*(SPPHRASERULEHANDLE value) => (void*)(value.Value);

        public static explicit operator SPPHRASERULEHANDLE(HANDLE value) => new SPPHRASERULEHANDLE(value);

        public static implicit operator HANDLE(SPPHRASERULEHANDLE value) => new HANDLE(value.Value);

        public static explicit operator SPPHRASERULEHANDLE(byte value) => new SPPHRASERULEHANDLE((nint)(value));

        public static explicit operator byte(SPPHRASERULEHANDLE value) => (byte)(value.Value);

        public static explicit operator SPPHRASERULEHANDLE(short value) => new SPPHRASERULEHANDLE((nint)(value));

        public static explicit operator short(SPPHRASERULEHANDLE value) => (short)(value.Value);

        public static explicit operator SPPHRASERULEHANDLE(int value) => new SPPHRASERULEHANDLE((nint)(value));

        public static explicit operator int(SPPHRASERULEHANDLE value) => (int)(value.Value);

        public static explicit operator SPPHRASERULEHANDLE(long value) => new SPPHRASERULEHANDLE((nint)(value));

        public static implicit operator long(SPPHRASERULEHANDLE value) => value.Value;

        public static explicit operator SPPHRASERULEHANDLE(nint value) => new SPPHRASERULEHANDLE((nint)(value));

        public static implicit operator nint(SPPHRASERULEHANDLE value) => value.Value;

        public static explicit operator SPPHRASERULEHANDLE(sbyte value) => new SPPHRASERULEHANDLE((nint)(value));

        public static explicit operator sbyte(SPPHRASERULEHANDLE value) => (sbyte)(value.Value);

        public static explicit operator SPPHRASERULEHANDLE(ushort value) => new SPPHRASERULEHANDLE((nint)(value));

        public static explicit operator ushort(SPPHRASERULEHANDLE value) => (ushort)(value.Value);

        public static explicit operator SPPHRASERULEHANDLE(uint value) => new SPPHRASERULEHANDLE((nint)(value));

        public static explicit operator uint(SPPHRASERULEHANDLE value) => (uint)(value.Value);

        public static explicit operator SPPHRASERULEHANDLE(ulong value) => new SPPHRASERULEHANDLE((nint)(value));

        public static explicit operator ulong(SPPHRASERULEHANDLE value) => (ulong)(value.Value);

        public static explicit operator SPPHRASERULEHANDLE(nuint value) => new SPPHRASERULEHANDLE((nint)(value));

        public static explicit operator nuint(SPPHRASERULEHANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is SPPHRASERULEHANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of SPPHRASERULEHANDLE.");
        }

        public int CompareTo(SPPHRASERULEHANDLE other) => Value.CompareTo(other.Value);

        public override bool Equals(object? obj) => (obj is SPPHRASERULEHANDLE other) && Equals(other);

        public bool Equals(SPPHRASERULEHANDLE other) => Value.Equals(other.Value);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => Value.ToString(format, formatProvider);
    }
}
