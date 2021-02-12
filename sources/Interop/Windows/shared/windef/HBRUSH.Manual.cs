// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/windef.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe struct HBRUSH : IEquatable<HBRUSH>
    {
        public static readonly HBRUSH NULL = default;

        private void* _value;

        public HBRUSH(IntPtr value) : this(value.ToPointer())
        {
        }

        public HBRUSH(void* value)
        {
            _value = value;
        }

        public static bool operator ==(HBRUSH l, HBRUSH r) => l._value == r._value;

        public static bool operator !=(HBRUSH l, HBRUSH r) => !(l == r);

        public static implicit operator HBRUSH(IntPtr value) => new HBRUSH(value);

        public static implicit operator HBRUSH(void* value) => new HBRUSH(value);

        public static implicit operator IntPtr(HBRUSH value) => new IntPtr(value._value);

        public static implicit operator void*(HBRUSH value) => value._value;

        public override bool Equals(object? obj) => (obj is HBRUSH other) && Equals(other);

        public bool Equals(HBRUSH other) => this == other;

        public override int GetHashCode() => ((IntPtr)_value).GetHashCode();
    }
}
