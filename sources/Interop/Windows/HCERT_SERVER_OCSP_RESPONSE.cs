// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HCERT_SERVER_OCSP_RESPONSE : IEquatable<HCERT_SERVER_OCSP_RESPONSE>
    {
        public readonly nint Value;

        public HCERT_SERVER_OCSP_RESPONSE(nint value)
        {
            Value = ((nint)(value));
        }

        public HCERT_SERVER_OCSP_RESPONSE(nuint value)
        {
            Value = ((nint)(value));
        }

        public HCERT_SERVER_OCSP_RESPONSE(void* value)
        {
            Value = ((nint)(value));
        }

        public static bool operator ==(HCERT_SERVER_OCSP_RESPONSE left, HCERT_SERVER_OCSP_RESPONSE right) => left.Value == right.Value;

        public static bool operator !=(HCERT_SERVER_OCSP_RESPONSE left, HCERT_SERVER_OCSP_RESPONSE right) => left.Value != right.Value;

        public static explicit operator HCERT_SERVER_OCSP_RESPONSE(nint value) => new HCERT_SERVER_OCSP_RESPONSE(value);

        public static explicit operator HCERT_SERVER_OCSP_RESPONSE(nuint value) => new HCERT_SERVER_OCSP_RESPONSE(value);

        public static explicit operator HCERT_SERVER_OCSP_RESPONSE(void* value) => new HCERT_SERVER_OCSP_RESPONSE(value);

        public static implicit operator nint(HCERT_SERVER_OCSP_RESPONSE value) => (nint)(value.Value);

        public static implicit operator nuint(HCERT_SERVER_OCSP_RESPONSE value) => (nuint)(value.Value);

        public static implicit operator void*(HCERT_SERVER_OCSP_RESPONSE value) => (void*)(value.Value);

        public override bool Equals(object? obj) => (obj is HCERT_SERVER_OCSP_RESPONSE other) && Equals(other);

        public bool Equals(HCERT_SERVER_OCSP_RESPONSE other) => (this == other);

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();
    }
}
