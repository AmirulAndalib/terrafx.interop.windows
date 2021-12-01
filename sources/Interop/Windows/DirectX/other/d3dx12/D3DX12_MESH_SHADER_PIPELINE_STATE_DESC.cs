// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3dx12.h in the microsoft/DirectX-Graphics-Samples tag v10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3DX12_MESH_SHADER_PIPELINE_STATE_DESC"]/*' />
public unsafe partial struct D3DX12_MESH_SHADER_PIPELINE_STATE_DESC
{
    /// <include file='D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.pRootSignature"]/*' />
    public ID3D12RootSignature* pRootSignature;

    /// <include file='D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.AS"]/*' />
    public D3D12_SHADER_BYTECODE AS;

    /// <include file='D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.MS"]/*' />
    public D3D12_SHADER_BYTECODE MS;

    /// <include file='D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.PS"]/*' />
    public D3D12_SHADER_BYTECODE PS;

    /// <include file='D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.BlendState"]/*' />
    public D3D12_BLEND_DESC BlendState;

    /// <include file='D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.SampleMask"]/*' />
    public uint SampleMask;

    /// <include file='D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.RasterizerState"]/*' />
    public D3D12_RASTERIZER_DESC RasterizerState;

    /// <include file='D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.DepthStencilState"]/*' />
    public D3D12_DEPTH_STENCIL_DESC DepthStencilState;

    /// <include file='D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.PrimitiveTopologyType"]/*' />
    public D3D12_PRIMITIVE_TOPOLOGY_TYPE PrimitiveTopologyType;

    /// <include file='D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.NumRenderTargets"]/*' />
    public uint NumRenderTargets;

    /// <include file='D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.RTVFormats"]/*' />
    [NativeTypeName("DXGI_FORMAT [8]")]
    public _RTVFormats_e__FixedBuffer RTVFormats;

    /// <include file='D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.DSVFormat"]/*' />
    public DXGI_FORMAT DSVFormat;

    /// <include file='D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.SampleDesc"]/*' />
    public DXGI_SAMPLE_DESC SampleDesc;

    /// <include file='D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.NodeMask"]/*' />
    public uint NodeMask;

    /// <include file='D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.CachedPSO"]/*' />
    public D3D12_CACHED_PIPELINE_STATE CachedPSO;

    /// <include file='D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.xml' path='doc/member[@name="D3DX12_MESH_SHADER_PIPELINE_STATE_DESC.Flags"]/*' />
    public D3D12_PIPELINE_STATE_FLAGS Flags;

    /// <include file='_RTVFormats_e__FixedBuffer.xml' path='doc/member[@name="_RTVFormats_e__FixedBuffer"]/*' />
    public partial struct _RTVFormats_e__FixedBuffer
    {
        public DXGI_FORMAT e0;
        public DXGI_FORMAT e1;
        public DXGI_FORMAT e2;
        public DXGI_FORMAT e3;
        public DXGI_FORMAT e4;
        public DXGI_FORMAT e5;
        public DXGI_FORMAT e6;
        public DXGI_FORMAT e7;

        public ref DXGI_FORMAT this[int index]
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                return ref AsSpan()[index];
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public Span<DXGI_FORMAT> AsSpan() => MemoryMarshal.CreateSpan(ref e0, 8);
    }
}
