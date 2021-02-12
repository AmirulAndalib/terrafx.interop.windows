// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct DML_BINDING_DESC
    {
        public DML_BINDING_TYPE Type;

        [NativeTypeName("const void *")]
        public void* Desc;
    }
}
