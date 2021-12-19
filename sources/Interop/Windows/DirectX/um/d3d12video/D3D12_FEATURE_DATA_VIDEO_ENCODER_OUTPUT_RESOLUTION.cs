// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION"]/*' />
public unsafe partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION.Codec"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC Codec;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION.ResolutionRatiosCount"]/*' />
    public uint ResolutionRatiosCount;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION.IsSupported"]/*' />
    public BOOL IsSupported;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION.MinResolutionSupported"]/*' />
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC MinResolutionSupported;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION.MaxResolutionSupported"]/*' />
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC MaxResolutionSupported;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION.ResolutionWidthMultipleRequirement"]/*' />
    public uint ResolutionWidthMultipleRequirement;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION.ResolutionHeightMultipleRequirement"]/*' />
    public uint ResolutionHeightMultipleRequirement;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_OUTPUT_RESOLUTION.pResolutionRatios"]/*' />
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_RATIO_DESC* pResolutionRatios;
}
