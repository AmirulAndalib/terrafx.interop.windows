// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDWP : IEquatable<HDWP>
    {
        public readonly nint Value;

        public HDWP(nint value)
        {
            Value = value;
        }

        public static HDWP INVALID_VALUE => new HDWP(-1);

        public static HDWP NULL => new HDWP(0);

        public static bool operator ==(HDWP left, HDWP right) => left.Value == right.Value;

        public static bool operator !=(HDWP left, HDWP right) => left.Value != right.Value;

        public static explicit operator HDWP(void* value) => new HDWP((nint)(value));

        public static implicit operator void*(HDWP value) => (void*)(value.Value);

        public static explicit operator HDWP(HANDLE value) => new HDWP(value);

        public static implicit operator HANDLE(HDWP value) => new HDWP(value);

        public static explicit operator HDWP(byte value) => new HDWP((nint)(value));

        public static explicit operator byte(HDWP value) => (byte)(value.Value);

        public static explicit operator HDWP(short value) => new HDWP((nint)(value));

        public static explicit operator short(HDWP value) => (short)(value.Value);

        public static explicit operator HDWP(int value) => new HDWP((nint)(value));

        public static explicit operator int(HDWP value) => (int)(value.Value);

        public static explicit operator HDWP(long value) => new HDWP((nint)(value));

        public static implicit operator long(HDWP value) => (long)(value.Value);

        public static explicit operator HDWP(nint value) => new HDWP((nint)(value));

        public static implicit operator nint(HDWP value) => (nint)(value.Value);

        public static explicit operator HDWP(sbyte value) => new HDWP((nint)(value));

        public static explicit operator sbyte(HDWP value) => (sbyte)(value.Value);

        public static explicit operator HDWP(ushort value) => new HDWP((nint)(value));

        public static explicit operator ushort(HDWP value) => (ushort)(value.Value);

        public static explicit operator HDWP(uint value) => new HDWP((nint)(value));

        public static explicit operator uint(HDWP value) => (uint)(value.Value);

        public static explicit operator HDWP(ulong value) => new HDWP((nint)(value));

        public static implicit operator ulong(HDWP value) => (ulong)(value.Value);

        public static explicit operator HDWP(nuint value) => new HDWP((nint)(value));

        public static explicit operator nuint(HDWP value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HDWP other) && Equals(other);

        public bool Equals(HDWP other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
