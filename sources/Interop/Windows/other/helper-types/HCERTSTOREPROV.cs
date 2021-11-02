// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCERTSTOREPROV : IEquatable<HCERTSTOREPROV>
    {
        public readonly nint Value;

        public HCERTSTOREPROV(nint value)
        {
            Value = value;
        }

        public static HCERTSTOREPROV INVALID_VALUE => new HCERTSTOREPROV(-1);

        public static HCERTSTOREPROV NULL => new HCERTSTOREPROV(0);

        public static bool operator ==(HCERTSTOREPROV left, HCERTSTOREPROV right) => left.Value == right.Value;

        public static bool operator !=(HCERTSTOREPROV left, HCERTSTOREPROV right) => left.Value != right.Value;

        public static explicit operator HCERTSTOREPROV(void* value) => new HCERTSTOREPROV((nint)(value));

        public static implicit operator void*(HCERTSTOREPROV value) => (void*)(value.Value);

        public static explicit operator HCERTSTOREPROV(HANDLE value) => new HCERTSTOREPROV(value);

        public static implicit operator HANDLE(HCERTSTOREPROV value) => new HCERTSTOREPROV(value);

        public static explicit operator HCERTSTOREPROV(byte value) => new HCERTSTOREPROV((nint)(value));

        public static explicit operator byte(HCERTSTOREPROV value) => (byte)(value.Value);

        public static explicit operator HCERTSTOREPROV(short value) => new HCERTSTOREPROV((nint)(value));

        public static explicit operator short(HCERTSTOREPROV value) => (short)(value.Value);

        public static explicit operator HCERTSTOREPROV(int value) => new HCERTSTOREPROV((nint)(value));

        public static explicit operator int(HCERTSTOREPROV value) => (int)(value.Value);

        public static explicit operator HCERTSTOREPROV(long value) => new HCERTSTOREPROV((nint)(value));

        public static implicit operator long(HCERTSTOREPROV value) => (long)(value.Value);

        public static explicit operator HCERTSTOREPROV(nint value) => new HCERTSTOREPROV((nint)(value));

        public static implicit operator nint(HCERTSTOREPROV value) => (nint)(value.Value);

        public static explicit operator HCERTSTOREPROV(sbyte value) => new HCERTSTOREPROV((nint)(value));

        public static explicit operator sbyte(HCERTSTOREPROV value) => (sbyte)(value.Value);

        public static explicit operator HCERTSTOREPROV(ushort value) => new HCERTSTOREPROV((nint)(value));

        public static explicit operator ushort(HCERTSTOREPROV value) => (ushort)(value.Value);

        public static explicit operator HCERTSTOREPROV(uint value) => new HCERTSTOREPROV((nint)(value));

        public static explicit operator uint(HCERTSTOREPROV value) => (uint)(value.Value);

        public static explicit operator HCERTSTOREPROV(ulong value) => new HCERTSTOREPROV((nint)(value));

        public static implicit operator ulong(HCERTSTOREPROV value) => (ulong)(value.Value);

        public static explicit operator HCERTSTOREPROV(nuint value) => new HCERTSTOREPROV((nint)(value));

        public static explicit operator nuint(HCERTSTOREPROV value) => (nuint)(value.Value);

        public override bool Equals(object? obj) => (obj is HCERTSTOREPROV other) && Equals(other);

        public bool Equals(HCERTSTOREPROV other) => (this == other);

        public override int GetHashCode() => Value.GetHashCode();

        public override string ToString() => Value.ToString();

    }
}
