// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12_resource_helpers.h in microsoft/DirectX-Headers tag v1.611.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

using System.Runtime.InteropServices;
using static TerraFX.Interop.DirectX.D3D12_TEXTURE_LAYOUT;

namespace TerraFX.Interop.DirectX;

public static unsafe partial class DirectX
{
    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.MemcpySubresource"]/*' />
    public static void MemcpySubresource([NativeTypeName("const D3D12_MEMCPY_DEST *")] D3D12_MEMCPY_DEST* pDest, [NativeTypeName("const D3D12_SUBRESOURCE_DATA *")] D3D12_SUBRESOURCE_DATA* pSrc, [NativeTypeName("SIZE_T")] nuint RowSizeInBytes, uint NumRows, uint NumSlices)
    {
        for (uint z = 0; z < NumSlices; ++z)
        {
            byte* pDestSlice = (byte*)(pDest->pData) + pDest->SlicePitch * z;
            byte* pSrcSlice = unchecked((byte*)(pSrc->pData) + pSrc->SlicePitch * (nint)(z));

            for (uint y = 0; y < NumRows; ++y)
            {
                NativeMemory.Copy(pDestSlice + pDest->RowPitch * y, unchecked(pSrcSlice + pSrc->RowPitch * (nint)(y)), RowSizeInBytes);
            }
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.MemcpySubresource"]/*' />
    public static void MemcpySubresource([NativeTypeName("const D3D12_MEMCPY_DEST *")] D3D12_MEMCPY_DEST* pDest, [NativeTypeName("const void *")] void* pResourceData, [NativeTypeName("const D3D12_SUBRESOURCE_INFO *")] D3D12_SUBRESOURCE_INFO* pSrc, [NativeTypeName("SIZE_T")] nuint RowSizeInBytes, uint NumRows, uint NumSlices)
    {
        for (uint z = 0; z < NumSlices; ++z)
        {
            byte* pDestSlice = (byte*)(pDest->pData) + pDest->SlicePitch * z;
            byte* pSrcSlice = ((byte*)(pResourceData) + pSrc->Offset) + pSrc->DepthPitch * (nuint)(z);

            for (uint y = 0; y < NumRows; ++y)
            {
                NativeMemory.Copy(pDestSlice + pDest->RowPitch * y, pSrcSlice + pSrc->RowPitch * (nuint)(y), RowSizeInBytes);
            }
        }
    }

    /// <include file='DirectX.xml' path='doc/member[@name="DirectX.D3D12IsLayoutOpaque"]/*' />
    public static bool D3D12IsLayoutOpaque(D3D12_TEXTURE_LAYOUT Layout)
    {
        return Layout == D3D12_TEXTURE_LAYOUT_UNKNOWN || Layout == D3D12_TEXTURE_LAYOUT_64KB_UNDEFINED_SWIZZLE;
    }
}
