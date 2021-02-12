// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public unsafe partial struct D3D12_DRED_ALLOCATION_NODE1
    {
        [NativeTypeName("const char *")]
        public sbyte* ObjectNameA;

        [NativeTypeName("const wchar_t *")]
        public ushort* ObjectNameW;

        public D3D12_DRED_ALLOCATION_TYPE AllocationType;

        [NativeTypeName("const struct D3D12_DRED_ALLOCATION_NODE1 *")]
        public D3D12_DRED_ALLOCATION_NODE1* pNext;

        [NativeTypeName("const IUnknown *")]
        public IUnknown* pObject;
    }
}
