// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_FEATURE_DATA_PROTECTED_RESOURCE_SESSION_TYPES
    {
        [NativeTypeName("UINT")]
        public uint NodeIndex;

        [NativeTypeName("UINT")]
        public uint Count;

        [NativeTypeName("GUID *")]
        public Guid* pTypes;
    }
}
