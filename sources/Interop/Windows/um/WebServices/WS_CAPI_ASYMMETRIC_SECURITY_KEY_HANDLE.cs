// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public partial struct WS_CAPI_ASYMMETRIC_SECURITY_KEY_HANDLE
    {
        public WS_SECURITY_KEY_HANDLE keyHandle;

        [NativeTypeName("HCRYPTPROV")]
        public nuint provider;

        [NativeTypeName("ULONG")]
        public uint keySpec;
    }
}
