// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from d3d12video.h in Microsoft.Direct3D.D3D12 v1.600.10
// Original source is Copyright © Microsoft. Licensed under the MIT license

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT"]/*' />
public partial struct D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT.VideoDecodeSupport"]/*' />
    public BOOL VideoDecodeSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT.VideoProcessSupport"]/*' />
    public BOOL VideoProcessSupport;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_FEATURE_AREA_SUPPORT.VideoEncodeSupport"]/*' />
    public BOOL VideoEncodeSupport;
}
