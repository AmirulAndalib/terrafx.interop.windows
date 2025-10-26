// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12.h in microsoft/DirectX-Headers tag v1.618.2
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_PIPELINE_STATE_STREAM_DESC.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_STREAM_DESC"]/*' />
public unsafe partial struct D3D12_PIPELINE_STATE_STREAM_DESC
{
    /// <include file='D3D12_PIPELINE_STATE_STREAM_DESC.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_STREAM_DESC.SizeInBytes"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint SizeInBytes;

    /// <include file='D3D12_PIPELINE_STATE_STREAM_DESC.xml' path='doc/member[@name="D3D12_PIPELINE_STATE_STREAM_DESC.pPipelineStateSubobjectStream"]/*' />
    public void* pPipelineStateSubobjectStream;
}
