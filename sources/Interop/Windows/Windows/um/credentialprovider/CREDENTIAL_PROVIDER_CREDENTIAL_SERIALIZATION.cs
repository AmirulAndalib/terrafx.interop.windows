// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/credentialprovider.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows
{
    public unsafe partial struct CREDENTIAL_PROVIDER_CREDENTIAL_SERIALIZATION
    {
        [NativeTypeName("ULONG")]
        public uint ulAuthenticationPackage;

        public Guid clsidCredentialProvider;

        [NativeTypeName("ULONG")]
        public uint cbSerialization;

        public byte* rgbSerialization;
    }
}