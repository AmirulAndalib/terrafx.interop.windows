// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct PRJ_DIR_ENTRY_BUFFER_HANDLE : IEquatable<PRJ_DIR_ENTRY_BUFFER_HANDLE>
    {
        public readonly nint Value;

        public static PRJ_DIR_ENTRY_BUFFER_HANDLE NULL => (PRJ_DIR_ENTRY_BUFFER_HANDLE)(0);

        public PRJ_DIR_ENTRY_BUFFER_HANDLE(int value)
        {
            Value = ((nint)(value));
        }

        public PRJ_DIR_ENTRY_BUFFER_HANDLE(uint value)
        {
            Value = ((nint)(value));
        }

        public PRJ_DIR_ENTRY_BUFFER_HANDLE(nint value)
        {
            Value = ((nint)(value));
        }

        public PRJ_DIR_ENTRY_BUFFER_HANDLE(nuint value)
        {
            Value = ((nint)(value));
        }

        public PRJ_DIR_ENTRY_BUFFER_HANDLE(void* value)
        {
            Value = ((nint)(value));
        }

        public PRJ_DIR_ENTRY_BUFFER_HANDLE(HANDLE value)
        {
            Value = value.Value;
        }

        public static bool operator ==(PRJ_DIR_ENTRY_BUFFER_HANDLE left, PRJ_DIR_ENTRY_BUFFER_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(PRJ_DIR_ENTRY_BUFFER_HANDLE left, PRJ_DIR_ENTRY_BUFFER_HANDLE right) => left.Value != right.Value;

        public static explicit operator PRJ_DIR_ENTRY_BUFFER_HANDLE(int value) => new PRJ_DIR_ENTRY_BUFFER_HANDLE(value);

        public static explicit operator PRJ_DIR_ENTRY_BUFFER_HANDLE(uint value) => new PRJ_DIR_ENTRY_BUFFER_HANDLE(value);

        public static explicit operator PRJ_DIR_ENTRY_BUFFER_HANDLE(nint value) => new PRJ_DIR_ENTRY_BUFFER_HANDLE(value);

        public static explicit operator PRJ_DIR_ENTRY_BUFFER_HANDLE(nuint value) => new PRJ_DIR_ENTRY_BUFFER_HANDLE(value);

        public static explicit operator PRJ_DIR_ENTRY_BUFFER_HANDLE(void* value) => new PRJ_DIR_ENTRY_BUFFER_HANDLE(value);

        public static explicit operator PRJ_DIR_ENTRY_BUFFER_HANDLE(HANDLE value) => new PRJ_DIR_ENTRY_BUFFER_HANDLE(value);

        public static explicit operator int(PRJ_DIR_ENTRY_BUFFER_HANDLE value) => (int)(value.Value);

        public static explicit operator uint(PRJ_DIR_ENTRY_BUFFER_HANDLE value) => (uint)(value.Value);

        public static implicit operator nint(PRJ_DIR_ENTRY_BUFFER_HANDLE value) => (nint)(value.Value);

        public static implicit operator nuint(PRJ_DIR_ENTRY_BUFFER_HANDLE value) => (nuint)(value.Value);

        public static implicit operator void*(PRJ_DIR_ENTRY_BUFFER_HANDLE value) => (void*)(value.Value);

        public static implicit operator HANDLE(PRJ_DIR_ENTRY_BUFFER_HANDLE value) => (HANDLE)(value.Value);

        public override bool Equals(object? obj) => (obj is PRJ_DIR_ENTRY_BUFFER_HANDLE other) && Equals(other);

        public bool Equals(PRJ_DIR_ENTRY_BUFFER_HANDLE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
