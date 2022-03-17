// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DRED_PAGE_FAULT_OUTPUT.xml' path='doc/member[@name="D3D12_DRED_PAGE_FAULT_OUTPUT"]/*' />
public unsafe partial struct D3D12_DRED_PAGE_FAULT_OUTPUT
{
    /// <include file='D3D12_DRED_PAGE_FAULT_OUTPUT.xml' path='doc/member[@name="D3D12_DRED_PAGE_FAULT_OUTPUT.PageFaultVA"]/*' />
    [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
    public ulong PageFaultVA;

    /// <include file='D3D12_DRED_PAGE_FAULT_OUTPUT.xml' path='doc/member[@name="D3D12_DRED_PAGE_FAULT_OUTPUT.pHeadExistingAllocationNode"]/*' />
    [NativeTypeName("const D3D12_DRED_ALLOCATION_NODE *")]
    public D3D12_DRED_ALLOCATION_NODE* pHeadExistingAllocationNode;

    /// <include file='D3D12_DRED_PAGE_FAULT_OUTPUT.xml' path='doc/member[@name="D3D12_DRED_PAGE_FAULT_OUTPUT.pHeadRecentFreedAllocationNode"]/*' />
    [NativeTypeName("const D3D12_DRED_ALLOCATION_NODE *")]
    public D3D12_DRED_ALLOCATION_NODE* pHeadRecentFreedAllocationNode;
}
