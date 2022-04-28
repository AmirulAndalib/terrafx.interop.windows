// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_MAX_INPUT_STREAMS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_MAX_INPUT_STREAMS"]/*' />
public partial struct D3D12_FEATURE_DATA_VIDEO_PROCESS_MAX_INPUT_STREAMS
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_MAX_INPUT_STREAMS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_MAX_INPUT_STREAMS.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_PROCESS_MAX_INPUT_STREAMS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_PROCESS_MAX_INPUT_STREAMS.MaxInputStreams"]/*' />
    public uint MaxInputStreams;
}