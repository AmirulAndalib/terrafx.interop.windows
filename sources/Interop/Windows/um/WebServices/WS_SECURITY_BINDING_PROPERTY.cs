// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct WS_SECURITY_BINDING_PROPERTY
    {
        public WS_SECURITY_BINDING_PROPERTY_ID id;

        [NativeTypeName("void *")]
        public void* value;

        [NativeTypeName("ULONG")]
        public uint valueSize;
    }
}
