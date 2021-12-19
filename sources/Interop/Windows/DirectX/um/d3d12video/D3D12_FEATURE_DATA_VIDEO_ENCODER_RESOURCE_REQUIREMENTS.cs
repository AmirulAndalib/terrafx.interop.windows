// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS"]/*' />
public partial struct D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS
{
    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.NodeIndex"]/*' />
    public uint NodeIndex;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.Codec"]/*' />
    public D3D12_VIDEO_ENCODER_CODEC Codec;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.Profile"]/*' />
    public D3D12_VIDEO_ENCODER_PROFILE_DESC Profile;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.InputFormat"]/*' />
    public DXGI_FORMAT InputFormat;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.PictureTargetResolution"]/*' />
    public D3D12_VIDEO_ENCODER_PICTURE_RESOLUTION_DESC PictureTargetResolution;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.IsSupported"]/*' />
    public BOOL IsSupported;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.CompressedBitstreamBufferAccessAlignment"]/*' />
    public uint CompressedBitstreamBufferAccessAlignment;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.EncoderMetadataBufferAccessAlignment"]/*' />
    public uint EncoderMetadataBufferAccessAlignment;

    /// <include file='D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.xml' path='doc/member[@name="D3D12_FEATURE_DATA_VIDEO_ENCODER_RESOURCE_REQUIREMENTS.MaxEncoderOutputMetadataBufferSize"]/*' />
    public uint MaxEncoderOutputMetadataBufferSize;
}
